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
    public partial class GetInfo : Form
    {
        public GetInfo()
        {
            InitializeComponent();
        }

        public TCP.Server serverMain = null;

        private void GetInfo_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    serverMain.Send("+GET_INFO");
                    string[] system_info = serverMain.RecvString().Split('|');
                    serverMain.Send("+OK");
                    string[] paths_info = serverMain.RecvString().Split('|');

                    Main_computername_tx.Text = system_info[0];
                    Main_username_tx.Text = system_info[1];
                    Main_system_info_tx.Text = string.Join("\r\n", system_info);
                    Main_paths_info_tx.Text = string.Join("\r\n", paths_info);
                    Text = "RemotePanel - PC情報";
                }
                catch (Exception ex)
                {
                    Text = "RemotePanel - PC情報 (取得失敗)";
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            });
        }
    }
}
