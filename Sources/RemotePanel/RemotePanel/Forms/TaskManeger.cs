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
    public partial class TaskManeger : Form
    {
        public TaskManeger()
        {
            InitializeComponent();
        }

        private TCP.Server serverTaskMgr = null;
        public TCP.Server serverMain = null;
        public int serverTaskManeger_Port;

        private void TaskManeger_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    serverMain.Send("+START_TASKMGR " + serverTaskManeger_Port.ToString());
                    serverTaskMgr = new TCP.Server(serverTaskManeger_Port);
                    serverTaskMgr.Start();

                    mainProcessListReload_Button_Click(null, EventArgs.Empty);
                    mainProcessListReload_Button.Enabled = true;
                    mainProcessExit_Button.Enabled = true;
                    mainSaveFile_Button.Enabled = true;
                }
                catch (Exception ex)
                {
                    if (serverTaskMgr != null) serverTaskMgr.Stop();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Close();
                }
            });
        }

        private void showProcessDataFromRecv(string rawData)
        {
            mainProcessList_ListView.Items.Clear();
            mainProcessList_ListView.BeginUpdate();
            foreach (string processData in rawData.Split('|'))
            {
                string[] processInfo = processData.Split('/');

                ListViewItem lvi = mainProcessList_ListView.Items.Add(processInfo[0]);
                lvi.SubItems.Add(processInfo[1]);
                lvi.SubItems.Add(processInfo[2]);
                lvi.SubItems.Add(processInfo[3]);
            }
            mainProcessList_ListView.EndUpdate();
        }

        private void mainProcessExit_Button_Click(object sender, EventArgs e)
        {
            if (mainProcessList_ListView.SelectedItems.Count != 0)
            {

                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        mainProcessListReload_Button.Enabled = false;
                        mainProcessExit_Button.Enabled = false;
                        mainSaveFile_Button.Enabled = false;

                        ListViewItem itemx = mainProcessList_ListView.SelectedItems[0];

                        serverMain.Send("+TASK_KILL " + itemx.SubItems[2].Text);
                        string result = serverMain.RecvString();
                        if (!result.StartsWith("+OK"))
                        {
                            MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }

                        showProcessDataFromRecv(serverTaskMgr.RecvString());
                    }
                    catch (Exception ex)
                    {
                        if (serverTaskMgr != null) serverTaskMgr.Stop();
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    mainProcessListReload_Button.Enabled = true;
                    mainProcessExit_Button.Enabled = true;
                    mainSaveFile_Button.Enabled = true;
                });
            }
        }

        private void mainProcessListReload_Button_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    mainProcessListReload_Button.Enabled = false;
                    mainProcessExit_Button.Enabled = false;
                    mainSaveFile_Button.Enabled = false;

                    serverTaskMgr.Send("+GET_PROCESS");
                    showProcessDataFromRecv(serverTaskMgr.RecvString());
                }
                catch (Exception ex)
                {
                    if (serverTaskMgr != null) serverTaskMgr.Stop();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                mainProcessListReload_Button.Enabled = true;
                mainProcessExit_Button.Enabled = true;
                mainSaveFile_Button.Enabled = true;
            });
        }

        private void TaskManeger_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serverTaskMgr != null) serverTaskMgr.Stop();
        }

        private void mainSaveFile_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(mainListSavePath_Textbox.Text))
                    if (saveProcessList_saveFileDialog.ShowDialog() == DialogResult.OK)
                        mainListSavePath_Textbox.Text = saveProcessList_saveFileDialog.FileName;

                using (StreamWriter sw = new StreamWriter(mainListSavePath_Textbox.Text))
                {
                    foreach (ListViewItem processItem in mainProcessList_ListView.Items)
                    {
                        sw.WriteLine(processItem.Text + " - " + processItem.SubItems[1].Text + " - " + processItem.SubItems[2].Text + " - " + processItem.SubItems[3].Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
