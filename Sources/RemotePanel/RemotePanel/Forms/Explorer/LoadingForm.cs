using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace RemotePanel.Forms.Explorer
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        public TCP.Server serverExplorer = null;
        public int serverUpload_Port;
        public int serverDownload_Port;
        public string LoadingMode = "";
        public string OpenFilePath = "";
        public string SaveFilePath = "";
        public string resultLoading = "";

        private TCP.Server serverUpload = null;
        private TCP.Server serverDownload = null;

        private void UploadForm_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                if (LoadingMode == "UPLOAD") startUpload();
                else if (LoadingMode == "DOWNLOAD") startDownload();
                else Close();
            });

            mainFileOpen_Textbox.Text = OpenFilePath;
            mainFileSave_Textbox.Text = SaveFilePath;
        }

        private void startUpload()
        {
            Text = "サーバー待機中...";
            mainFileOpen_Groupbox.Text = "アップロードするファイル";
            mainFileSave_Groupbox.Text = "アップロード先";

            try
            {
                FileInfo fi = new FileInfo(OpenFilePath);
                serverExplorer.Send("+UPLOAD |" + SaveFilePath + "|" + fi.Length.ToString() + "|" + serverUpload_Port.ToString());
                fi = null;
                serverUpload = new TCP.Server(serverUpload_Port);
                serverUpload.Start();
            }
            catch (Exception ex)
            {
                if (serverUpload != null) serverUpload.Stop();
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Text = "ファイル読み込み中...";           
            try
            {
                byte[] fileData = null;
                using (FileStream fs = new FileStream(OpenFilePath, FileMode.Open))
                {
                    fileData = new byte[fs.Length];
                    fs.Read(fileData, 0, (int)fs.Length);
                }
                Text = "アップロード中...";
                serverUpload.Send(fileData);
                fileData = null;
                GC.Collect();
                Text = "アップロード確認中...";
                resultLoading = serverUpload.RecvString(-1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "アップロードエラー", MessageBoxButtons.OK, MessageBoxIcon.Stop);               
            }
            if (serverUpload != null) serverUpload.Stop();
            Close();
        }

        private void startDownload()
        {
            Text = "サーバー待機中...";
            mainFileOpen_Groupbox.Text = "ファイル保存先";
            mainFileSave_Groupbox.Text = "ダウンロードファイル";

            try
            {
                serverExplorer.Send("+DOWNLOAD |" + SaveFilePath + "|" + serverDownload_Port.ToString());
                serverDownload = new TCP.Server(serverDownload_Port);
                serverDownload.Start();
            }
            catch (Exception ex)
            {
                if (serverDownload != null) serverDownload.Stop();
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Close();
                return;
            }

            try
            {
                Text = "ダウンロード中...";
                int downloadBuffer = int.Parse(serverDownload.RecvString());                
                serverDownload.Send("+OK");               
                byte[] fileData = serverDownload.RecvBytes(5000, downloadBuffer);

                Text = "ファイル書き込み中...";
                if (fileData.Length != 0)
                {
                    using (FileStream fs = new FileStream(OpenFilePath, FileMode.Create))
                    {
                        fs.Write(fileData, 0, fileData.Length);
                    }
                }
                else
                {
                    resultLoading = "以下が原因でダウンロードに失敗しました\r\n - アクセス権限がない\r\n - ファイルが存在しない\r\n - 送信パケット容量を超えている";
                }
                fileData = null;
                GC.Collect();
            }
            catch (Exception ex)
            {
                resultLoading = ex.Message;
            }
            if (serverDownload != null) serverDownload.Stop();
            Close();
        }
    }
}
