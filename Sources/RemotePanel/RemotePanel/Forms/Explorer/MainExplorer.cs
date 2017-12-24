using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace RemotePanel.Forms.Explorer
{
    public partial class MainExplorer : Form
    {
        public MainExplorer()
        {
            InitializeComponent();
        }

        public TCP.Server serverMain = null;
        public int serverExplorer_Port;
        public int serverUpload_Port;
        public int serverDownload_Port;

        private string mainDrive = "";
        private string copyFilePath = "";
        private bool deleteFileFlag = false;
        private TCP.Server serverExplorer = null;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string getSelectedDirName
        {
            get
            {
                try
                {
                    ListViewItem tmpFileList = mainFileListView.SelectedItems[0];
                    if (tmpFileList.SubItems[2].Text == "Folder")
                        return menuFilePathList_Combobox.Text + @"\" + tmpFileList.Text;
                    else
                        return null;
                }
                catch
                {
                    return null;
                }
            }
        }

        private string getSelectedFileName
        {
            get
            {
                try
                {
                    ListViewItem tmpFileList = mainFileListView.SelectedItems[0];
                    if (tmpFileList.SubItems[2].Text == "File")
                        return menuFilePathList_Combobox.Text + @"\" + tmpFileList.Text;
                    else
                        return null;
                }
                catch
                {
                    return null;
                }
            }
        }

        private string getSelectedItemPath
        {
            get
            {
                string filePath = getSelectedFileName;
                string dirPath = getSelectedDirName;
                if (filePath != null) return filePath.Replace(@"\\", @"\");
                else if (dirPath != null) return dirPath.Replace(@"\\", @"\");
                else return menuFilePathList_Combobox.Text;
            }
        }

        private bool isSelectedFile
        {
            get
            {
                if (getSelectedFileName != null) return true;
                else return false;
            }
        }

        private void MainExplorer_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    serverMain.Send("+START_EXPLORER " + serverExplorer_Port.ToString());
                    serverExplorer = new TCP.Server(serverExplorer_Port);
                    serverExplorer.Start();

                    serverExplorer.Send("+GET_DRIVES");
                    menuDriveslist_Combobox.Items.AddRange(serverExplorer.RecvString().Split('|'));
                    serverExplorer.Send("+GET_MAIN_DRIVE");
                    mainDrive = serverExplorer.RecvString();
                    menuDriveslist_Combobox.Text = mainDrive;

                    serverExplorer.Send("+GET_DIR_LIST |" + mainDrive + "|");
                    loadFilePathInformations(menuDriveslist_Combobox.Text);
                }
                catch (Exception ex)
                {
                    if (serverExplorer != null) serverExplorer.Stop();
                    Close();
                    MessageBox.Show(ex.Message, "サーバーエラー", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            });
        }

        private void loadFilePathInformations(string dirName, bool addFile = true)
        {
            try
            {
                Text = "RemotePanel - ファイルエクスプローラ (接続中...)";
                menuGoback_Button.Enabled = false;
                menuGoNext_Button.Enabled = false;
                menuGoComboboxPath_Button.Enabled = false;
                dirName = dirName.Replace(@"\\", @"\");
                string rawRecvData = serverExplorer.RecvString(15000);
                if (rawRecvData.StartsWith("/"))
                {
                    MessageBox.Show(rawRecvData.Substring(1), "ファイルエラー", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    menuGoback_Button.Enabled = true;
                    menuGoNext_Button.Enabled = true;
                    menuGoComboboxPath_Button.Enabled = true;
                    Text = "RemotePanel - ファイルエクスプローラ";
                    return;
                }             

                string[] filesData = rawRecvData.Split('|');

                if (addFile)
                {
                    menuFilePathList_Combobox.Items.Add(dirName);
                    menuFilePathList_Combobox.Text = dirName;
                }
                mainFileListView.Items.Clear();

                mainFileListView.BeginUpdate();
                foreach (string fileData in filesData)
                {
                    if (fileData != "")
                    {
                        string[] fileInfo = fileData.Split('^');
                        ListViewItem lvi = mainFileListView.Items.Add(fileInfo[0]);
                        lvi.SubItems.Add(fileInfo[1]);
                        lvi.SubItems.Add(fileInfo[2]);
                        lvi.SubItems.Add(fileInfo[3]);

                        if (fileInfo[2] == "Folder") lvi.ImageIndex = 1;
                        else lvi.ImageIndex = 0;
                    }
                }
                mainFileListView.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "リストエラー", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            menuGoback_Button.Enabled = true;
            menuGoNext_Button.Enabled = true;
            menuGoComboboxPath_Button.Enabled = true;
            Text = "RemotePanel - ファイルエクスプローラ";
        }

        private void mainFileListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    string selectedDirName = getSelectedDirName;
                    if (selectedDirName != null)
                    {                     
                        serverExplorer.Send("+GET_DIR_LIST |" + selectedDirName+"|");
                        loadFilePathInformations(selectedDirName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            });           
        }

        private void MainExplorer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serverExplorer != null) serverExplorer.Stop();
            serverExplorer = null;
        }

        private void menuGoandNext_Function(int nextIndex)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    menuFilePathList_Combobox.SelectedIndex = menuFilePathList_Combobox.SelectedIndex + nextIndex;
                    string dirName = menuFilePathList_Combobox.Text;
                    if (dirName != "")
                    {
                        serverExplorer.Send("+GET_DIR_LIST |" + dirName + "|");
                        loadFilePathInformations(dirName, (dirName.Length == 3));
                    }
                    else
                        menuFilePathList_Combobox.SelectedIndex = menuFilePathList_Combobox.SelectedIndex - nextIndex;
                }
                catch { }
            });
        }

        private void menuGoback_Button_Click(object sender, EventArgs e)
        {
            menuGoandNext_Function(-1);
        }

        private void menuGoNext_Button_Click(object sender, EventArgs e)
        {
            menuGoandNext_Function(1);
        }

        private void ここにファイルをアップロードToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((mainUploadFile_openFileDialog.ShowDialog() == DialogResult.OK))
            {
                startDownloadForm();
            }
        }

        private void startDownloadForm()
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    string saveFilePath = menuFilePathList_Combobox.Text + @"\" + Path.GetFileName(mainUploadFile_openFileDialog.FileName);
                    LoadingForm loadingForm = new LoadingForm();
                    loadingForm.SaveFilePath = saveFilePath;
                    loadingForm.OpenFilePath = mainUploadFile_openFileDialog.FileName;
                    loadingForm.LoadingMode = "UPLOAD";
                    loadingForm.serverUpload_Port = serverUpload_Port;
                    loadingForm.serverExplorer = serverExplorer;
                    loadingForm.ShowDialog();
                    string result = loadingForm.resultLoading;
                    loadingForm.Dispose();
                    loadingForm = null;
                    GC.Collect();

                    if (result.StartsWith("+"))
                    {
                        一覧の更新ToolStripMenuItem_Click(null, EventArgs.Empty);
                        MessageBox.Show("ファイル: " + mainUploadFile_openFileDialog.FileName + "\r\n保存先: " + saveFilePath, "アップロード完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("ファイル: " + mainUploadFile_openFileDialog.FileName + "\r\n保存先: " + saveFilePath + "\r\n\r\n" + result, "アップロード失敗", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void ファイルをダウンロードToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string saveFilePath = getSelectedFileName;
                mainDownloadFile_saveFileDialog.FileName = Path.GetFileName(saveFilePath);
                if (mainDownloadFile_saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (saveFilePath != null)
                    {
                         Task.Factory.StartNew(() =>
                         {
                             LoadingForm loadingForm = new LoadingForm();
                             loadingForm.SaveFilePath = saveFilePath;
                             loadingForm.OpenFilePath = mainDownloadFile_saveFileDialog.FileName;
                             loadingForm.LoadingMode = "DOWNLOAD";
                             loadingForm.serverDownload_Port = serverDownload_Port;
                             loadingForm.serverExplorer = serverExplorer;
                             loadingForm.ShowDialog();
                             string result = loadingForm.resultLoading;
                             loadingForm.Dispose();
                             loadingForm = null;
                             GC.Collect();

                             if (result.Length == 0)
                                 MessageBox.Show("ファイル: " + mainDownloadFile_saveFileDialog.FileName + "\r\n保存先: " + saveFilePath, "ダウンロード完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             else
                                 MessageBox.Show(result, "ダウンロードエラー", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                         });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void 切り取りToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                copyFilePath = getSelectedItemPath;
                deleteFileFlag = true;
                if ((copyFilePath == mainDrive) | copyFilePath.StartsWith(mainDrive + @"Windows") | copyFilePath.StartsWith(mainDrive + @"WINDOWS"))
                {
                    copyFilePath = "";
                    deleteFileFlag = false;
                    MessageBox.Show("Windowsのシステムファイルの移動は禁止されています", "アクセス禁止", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }                             
            }
            catch { }
        }

        private void コピーToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                copyFilePath = getSelectedItemPath;
                deleteFileFlag = false;
            }
            catch { }
        }

        private void 貼り付けToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    serverExplorer.Send("+COPY |" + deleteFileFlag.ToString() + "|" + copyFilePath + "|" + menuFilePathList_Combobox.Text + @"\" + Path.GetFileName(copyFilePath));
                    string result = serverExplorer.RecvString();

                    if (result.StartsWith("+"))
                        一覧の更新ToolStripMenuItem_Click(null, EventArgs.Empty);
                    else
                        MessageBox.Show(result, "コピーエラー", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            });
        }

        private void ファイルを削除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                string deletePath = getSelectedItemPath;

                try
                {
                    if ((deletePath == mainDrive) | deletePath.StartsWith(mainDrive + @"Windows") | deletePath.StartsWith(mainDrive + @"WINDOWS"))
                    {
                        MessageBox.Show("Windowsのシステムファイルの削除は禁止されています", "アクセス禁止", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        var result = MessageBox.Show("削除されると復元はできません。\r\n" + deletePath + " を、本当に削除しますか？", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (result == DialogResult.OK)
                        {
                            serverExplorer.Send("+DELETE |" + deletePath + "|");
                            string resultRecv = serverExplorer.RecvString();

                            if (resultRecv.StartsWith("+"))
                            {
                                一覧の更新ToolStripMenuItem_Click(null, EventArgs.Empty);
                            }
                            else
                                MessageBox.Show(resultRecv, "削除エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            });
        }

        private void 名前変更ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((menuFilePathList_Combobox.Text == mainDrive) | menuFilePathList_Combobox.Text.StartsWith(mainDrive + @"Windows") | menuFilePathList_Combobox.Text.StartsWith(mainDrive + @"WINDOWS"))
            {
                MessageBox.Show("Windowsのシステムファイルの名前変更は禁止されています", "アクセス禁止", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                NameChange nameChange = new NameChange();
                nameChange.SetBeforeName = getSelectedItemPath;
                nameChange.serverExplorer = serverExplorer;
                nameChange.ShowDialog();
                一覧の更新ToolStripMenuItem_Click(null, EventArgs.Empty);
            }
        }

        private void 一覧の更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    serverExplorer.Send("+GET_DIR_LIST |" + menuFilePathList_Combobox.Text + "|");
                    loadFilePathInformations(menuFilePathList_Combobox.Text, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "更新エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            });
        }

        private void プログラムを実行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    serverMain.Send("+CMD /c \""+ getSelectedItemPath +"\"");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            });
        }

        private void 引数を指定して事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                StartProgram startProgram = new StartProgram();
                startProgram.serverMain = serverMain;
                startProgram.SendPath = getSelectedItemPath;
                startProgram.ShowDialog();
                startProgram.Dispose();
                startProgram = null;
                GC.Collect();
            });
        }

        private void menuDriveslist_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    if (menuDriveslist_Combobox.Text != Path.GetPathRoot(menuFilePathList_Combobox.Text))
                    {
                        serverExplorer.Send("+GET_DIR_LIST |" + menuDriveslist_Combobox.Text + "|");
                        loadFilePathInformations(menuDriveslist_Combobox.Text);
                    }
                }
                catch (Exception ex)
                {
                }
            });
        }

        private void menuGoComboboxPath_Button_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    serverExplorer.Send("+GET_DRIVES");
                    menuDriveslist_Combobox.Items.Clear();
                    menuDriveslist_Combobox.Items.AddRange(serverExplorer.RecvString().Split('|'));
                    serverExplorer.Send("+GET_DIR_LIST |" + menuFilePathList_Combobox.Text + "|");
                    loadFilePathInformations(menuFilePathList_Combobox.Text, false);
                    menuDriveslist_Combobox.Text = Path.GetPathRoot(menuFilePathList_Combobox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            });
        }

        private void ファイルパスをコピーToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(getSelectedItemPath);
        }

        private void mainFileListView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
    }
}
