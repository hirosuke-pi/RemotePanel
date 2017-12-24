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
    public partial class PowerSettings : Form
    {
        public PowerSettings()
        {
            InitializeComponent();
        }

        public TCP.Server serverMain = null;

        private void PowerSettings_Load(object sender, EventArgs e)
        {

        }

        private void mainCmdSend_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    Text = "RemotePanel - 電源 (送信中...)";
                    mainCmdSend.Enabled = false;
                    string powerCmd = "";
                    if (mainPowerCmd_comboBox.SelectedIndex == 0) powerCmd = "-s -f";
                    else if (mainPowerCmd_comboBox.SelectedIndex == 1) powerCmd = "-r -f";
                    else if (mainPowerCmd_comboBox.SelectedIndex == 2) powerCmd = "-l -f";
                    else if (mainPowerCmd_comboBox.SelectedIndex == 3) powerCmd = "-h -f";
                    else if (mainPowerCmd_comboBox.SelectedIndex == 4) powerCmd = "-a";

                    string powerCommands = "";
                    if (powerCmd == "-a")
                        powerCommands = "/c shutdown -a";
                    else
                        powerCommands = "/c shutdown " + powerCmd +" -t "+ mainPowerTime_numericUpDown.Value.ToString() +" -c \""+ mainPowerComment_Textbox.Text +" \"";
                    serverMain.Send("+CMD "+ powerCommands);
                    serverMain.RecvBytes();
                    Text = "RemotePanel - 電源 (送信完了)";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Text = "RemotePanel - 電源 (送信失敗)";
                }
                mainCmdSend.Enabled = true;
            });
        }

    }
}
