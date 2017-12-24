using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace RemotePanel.Forms.Explorer
{
    public partial class StartProgram : Form
    {
        public StartProgram()
        {
            InitializeComponent();
        }

        public TCP.Server serverMain = null;
        public string SendPath = "";
        private void StartProgram_Load(object sender, EventArgs e)
        {

        }

        private void mainArgv_Button_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                Text = "引数を指定して実行 (送信中...)";
                mainArgv_Button.Enabled = false;

                try
                {
                    serverMain.Send("+CMD /c \"" + SendPath +"\" "+ mainArgv_TextBox.Text.Replace("\r\n", ""));
                    serverMain.RecvBytes();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Text = "引数を指定して実行 (送信失敗)";
                }
                mainArgv_Button.Enabled = true;
            });
        }
    }
}
