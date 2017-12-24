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


namespace RemotePanel.Forms
{
    public partial class BuildSet : Form
    {
        public BuildSet()
        {
            InitializeComponent();
        }

        private void BuildSet_Load(object sender, EventArgs e)
        {

        }

        public int serverMain_Port;
        public string SetSaveText
        {
            set { mainSavePath_Textbox.Text = value; }
        }

        private byte[] getHeaderBytes
        {
            get
            {
                byte[] header = Encoding.UTF8.GetBytes(TCP.Server.GetLocalIP + "|" + serverMain_Port.ToString() + "|");
                return Enumerable.Concat(new byte[] { 0xff }, Encoding.UTF8.GetBytes(Convert.ToBase64String(header))).ToArray();
            }
        }

        private void mainBuild_Button_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                mainBuild_Button.Enabled = false;
                mainSavePath_Button.Enabled = false;

                try
                {
                    using (FileStream fs = new FileStream(mainSavePath_Textbox.Text, FileMode.Create, FileAccess.Write))
                    {
                        byte[] headerBytes = getHeaderBytes;
                        fs.Write(Properties.Resources.RemoteClient, 0, Properties.Resources.RemoteClient.Length);
                        fs.Write(headerBytes, 0, headerBytes.Length);
                    }
                    MessageBox.Show("ファイルを出力しました:\r\n" + mainSavePath_Textbox.Text, "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ファイルエラー", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                mainBuild_Button.Enabled = true;
                mainSavePath_Button.Enabled = true;
            });
        }

        private void mainSavePath_Button_Click(object sender, EventArgs e)
        {
            if (mainBuild_saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                mainSavePath_Textbox.Text = mainBuild_saveFileDialog.FileName;
            }
        }
    }
}
