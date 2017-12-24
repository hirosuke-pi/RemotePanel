using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteClient.CommandClasses
{
    class Explorer
    {
        public static TCP.Client clientExplorer = null;
        private static TCP.Client clientUpload = null;
        private static TCP.Client clientDownload = null;

        private static MainForm main = null;
        private static bool change_file;

        public static void StartExplorerAccess(string connectIP, int connectPort, bool accessFile, bool changeFile, MainForm mainForm)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    clientExplorer = new TCP.Client(connectIP, connectPort);
                    change_file = changeFile;
                    main = mainForm;

                    if (accessFile)
                    {
                        main.status_file.Visible = true;
                        while (true)
                        {
                            string rawCmd = clientExplorer.RecvString();
                            string[] info = rawCmd.Split(' ');
                            string cmd = info[0];

                            if (cmd == "+GET_DRIVES") clientExplorer.Send(string.Join("|", Directory.GetLogicalDrives()));
                            else if (cmd == "+GET_DIR_LIST") explorerGetDirList(rawCmd.Split('|')[1]);
                            else if (cmd == "+GET_MAIN_DRIVE") clientExplorer.Send(Path.GetPathRoot(System.Environment.GetFolderPath(Environment.SpecialFolder.System)));
                            else if (cmd == "+UPLOAD") explorerUpload(connectIP, rawCmd.Split('|'));
                            else if (cmd == "+DOWNLOAD") explorerDownload(connectIP, rawCmd.Split('|'));
                            else if (cmd == "+COPY") explorerCopy(rawCmd.Split('|'));
                            else if (cmd == "+DELETE") explorerDelete(rawCmd.Split('|')[1]);
                            else if (cmd == "") throw new Exception();
                            GC.Collect();
                        }
                    } else { throw new Exception(); }
                }
                catch
                {
                    if (clientExplorer != null) clientExplorer.Close();
                    clientExplorer = null;
                    main.status_file.Visible = false;
                }
            });
        }

        private static void explorerGetDirList(string getPath)
        {
            string fileData = "";
            string dirData = "";

            List<Task> taskList = new List<Task>();

            try
            {
                DirectoryInfo dirPrograms = new DirectoryInfo(getPath);
                taskList.Add(Task.Factory.StartNew(() =>
                {
                    // ファイル情報
                    List<string> fileList = new List<string>();
                    foreach (FileInfo file in dirPrograms.EnumerateFiles("*", SearchOption.TopDirectoryOnly))
                    {
                        try
                        {
                            fileList.Add(file.Name + "^" + file.LastWriteTime + "^File^" + file.Length.ToString() + " B");
                        }
                        catch { }
                    }
                    fileList.Sort();
                    fileData = string.Join("|", fileList.ToArray());
                }));

                taskList.Add(Task.Factory.StartNew(() =>
                {
                    // フォルダ情報
                    List<string> dirList = new List<string>();
                    foreach (DirectoryInfo dir in dirPrograms.EnumerateDirectories("*", SearchOption.TopDirectoryOnly))
                    {
                        try
                        {
                            dirList.Add(dir.Name + "^ ^Folder^ ");
                        }
                        catch { }
                    }
                    dirList.Sort();
                    dirData = string.Join("|", dirList.ToArray());
                }));

                Task.WaitAll(taskList.ToArray());
                GC.Collect();
                clientExplorer.Send(dirData + "|" + fileData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                try
                {
                    clientExplorer.Send("/" + ex.Message);
                }
                catch { }
            }
        }

        private static void explorerUpload(string connectIP, string[] uploadInfo)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    string savePath = uploadInfo[1];
                    int fileSize = int.Parse(uploadInfo[2]);
                    int serverPort = int.Parse(uploadInfo[3]);
                    clientUpload = new TCP.Client(connectIP, serverPort);

                    if (change_file)
                    {
                        byte[] fileData = clientUpload.RecvBytes(-1, fileSize);
                        using (FileStream fs = new FileStream(savePath, FileMode.Create))
                        {
                            fs.Write(fileData, 0, fileData.Length);
                        }
                        fileData = null;
                        clientUpload.Send("+OK");
                    }                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    clientUpload.Send(ex.Message);                    
                }
                if (clientUpload != null) clientUpload.Close();
                clientUpload = null;
            });
        }

        private static void explorerDownload(string connectIP, string[] downloadInfo)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    string savePath = downloadInfo[1];
                    int serverPort = int.Parse(downloadInfo[2]);

                    clientDownload = new TCP.Client(connectIP, serverPort);

                    if (change_file)
                    {
                        byte[] fileData = null;
                        FileInfo fi = new FileInfo(savePath);
                        clientDownload.Send(fi.Length.ToString());
                        clientDownload.RecvString();

                        using (FileStream fs = new FileStream(savePath, FileMode.Open))
                        {
                            fileData = new byte[fs.Length];
                            fs.Read(fileData, 0, (int)fs.Length);
                        }
                        clientDownload.Send(fileData);
                        fileData = null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                
                if (clientDownload != null) clientDownload.Close();
                clientDownload = null;
            });
        }

        private static void explorerCopy(string[] copyInfo)
        {
            Task.Factory.StartNew(() =>
            {
                bool deleteFlag = bool.Parse(copyInfo[1]);
                string distPath = copyInfo[2];
                string copyPath = copyInfo[3];

                try
                {
                    if (change_file)
                    {
                        if (File.Exists(distPath))
                        {
                            if (deleteFlag) File.Move(distPath, copyPath);
                            else File.Copy(distPath, copyPath);
                        }
                        else
                        {
                            if (deleteFlag) Directory.Move(distPath, copyPath);
                            else CopyDirectory(distPath, copyPath);
                        }
                        clientExplorer.Send("+OK");
                    }
                    else
                    {
                        clientExplorer.Send("クライアントがアクセス制限しています");
                    }
                }
                catch (Exception ex)
                {
                    clientExplorer.Send(ex.Message);
                }
            });
        }

        private static void CopyDirectory(string sourceDirName, string destDirName)
        {
            //コピー先のディレクトリがないときは作る
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
                File.SetAttributes(destDirName, File.GetAttributes(sourceDirName));
            }

            //コピー先のディレクトリ名の末尾に"\"をつける
            if (destDirName[destDirName.Length - 1] != Path.DirectorySeparatorChar)
                destDirName = destDirName + Path.DirectorySeparatorChar;

            //コピー元のディレクトリにあるファイルをコピー
            string[] files = Directory.GetFiles(sourceDirName);
            foreach (string file in files)
                File.Copy(file,destDirName + Path.GetFileName(file), true);

            //コピー元のディレクトリにあるディレクトリについて、再帰的に呼び出す
            string[] dirs = Directory.GetDirectories(sourceDirName);
            foreach (string dir in dirs)
                CopyDirectory(dir, destDirName + Path.GetFileName(dir));
        }

        private static void explorerDelete(string pathInfo)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    if (change_file)
                    {
                        if (!pathInfo.StartsWith(Environment.GetFolderPath(Environment.SpecialFolder.Windows)))
                        {
                            if (File.Exists(pathInfo)) File.Delete(pathInfo);
                            else Directory.Delete(pathInfo, true);
                            clientExplorer.Send("+OK");
                        }
                        else
                        {
                            clientExplorer.Send("Windowsのシステムファイルの削除は禁止されています");
                        }
                    }
                    else
                    {
                        clientExplorer.Send("クライアントがアクセス制限しています");
                    }
                }
                catch (Exception ex)
                {
                    clientExplorer.Send(ex.Message);
                }
            });
        }
    }
}
