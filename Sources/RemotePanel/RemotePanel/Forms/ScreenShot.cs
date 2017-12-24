using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace RemotePanel.Forms
{
    public partial class ScreenShot : Form
    {
        public ScreenShot()
        {
            InitializeComponent();
        }

        public TCP.Server serverMain = null;
        private string save_dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\ScreenShots";

        private void ScreenShot_Load(object sender, EventArgs e)
        {
            reload_image();
            Text = "RemotePanel - スクリーンショット: " + save_dir;
        }

        public void reload_image()
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    Main_reload_bt.Enabled = false;
                    serverMain.Send("+SCREENSHOT");
                    ImageConverter imgconv = new ImageConverter();
                    Main_save_pic.Image = (Image)imgconv.ConvertFrom(serverMain.RecvBytes());                
                }
                catch
                {
                    MessageBox.Show("アクセス制限されているか、スクリーンショットを取得できません", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                Main_reload_bt.Enabled = true;
            });
            DateTime dt = DateTime.Now;
            Main_info_tx.Text = "ScreenShot_"+ dt.ToString("yyyy-MM-dd_HH-mm-ss");            
        }

        private void Main_reload_bt_Click(object sender, EventArgs e)
        {
            reload_image();
        }

        private void Main_save_bt_Click(object sender, EventArgs e)
        {
            try
            {
                new DirectoryInfo(save_dir).Create();
                Main_save_pic.Image.Save(save_dir + @"\" + Main_info_tx.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "保存失敗", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
