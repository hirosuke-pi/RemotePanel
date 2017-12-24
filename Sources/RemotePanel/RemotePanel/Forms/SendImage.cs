using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace RemotePanel.Forms
{
    public partial class SendImage : Form
    {
        public SendImage()
        {
            InitializeComponent();
        }

        public TCP.Server serverMain = null;

        private void SendImage_Load(object sender, EventArgs e)
        {

        }

        private byte[] getImageBytesFormPictureBox()
        {
            Image bmp = mainSendImage_PictureBox.Image;
            ImageConverter imgconv = new ImageConverter();
            return (byte[])imgconv.ConvertTo(bmp, typeof(byte[]));
        }

        private void mainSendData_Button_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                if (mainSendImage_PictureBox.Image != null)
                {
                    try
                    {
                        Text = "RemotePanel - 画像送信 (送信中...)";
                        mainSendData_Button.Enabled = false;

                        serverMain.Send("+SEND_IMG " + mainSendTitle_Textbox.Text);
                        serverMain.RecvBytes();
                        serverMain.Send(getImageBytesFormPictureBox());
                        serverMain.RecvString();

                        mainSendData_Button.Enabled = true;
                        Text = "RemotePanel - 画像送信 (送信完了)";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "送信エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Close();
                    }
                }
            });    
        }

        private void mainSendImage_PictureBox_DoubleClick(object sender, EventArgs e)
        {
            if (mainImageOpen_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    mainSendImage_PictureBox.Image = Image.FromFile(mainImageOpen_openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "画像エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}
