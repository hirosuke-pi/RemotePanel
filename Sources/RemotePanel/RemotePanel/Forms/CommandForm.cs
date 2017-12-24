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
    public partial class CommandForm : Form
    {
        public CommandForm()
        {
            InitializeComponent();
        }

        public TCP.Server serverMain = null;

        private void CommandForm_Load(object sender, EventArgs e)
        {
            
        }

        private void mainSendCMD_Button_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                Text = "RemotePanel - コマンドプロンプト (送信中...)";
                mainSendCMD_Button.Enabled = false;

                try
                {
                    serverMain.Send("+CMD /c " + mainCMDOption_Textbox.Text.Replace("\r\n", ""));
                    serverMain.RecvBytes();
                    Text = "RemotePanel - コマンドプロンプト (送信完了)";                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Text = "RemotePanel - コマンドプロンプト (送信失敗)";
                }
                mainSendCMD_Button.Enabled = true;
            });
        }
    }
}
