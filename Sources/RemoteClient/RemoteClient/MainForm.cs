using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;


namespace RemoteClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {           
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(
            IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("USER32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void SetCursorPos(int X, int Y);

        [DllImport("USER32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;

        private TCP.Client clientMain = null;
        private TCP.Client clientLogger = null;
        private TCP.Client clientPing = null;
        private bool isLoggerStarted = false;
        private bool is_connected = true;
        private bool shutdownFlag = false;
        private bool disconnectedFlag = false;
        private Task mainTask = null;
        private  KeyboardHook keyHook;
        string pathApp = Assembly.GetExecutingAssembly().Location;
        private string serverIP = "192.168.1.11";
        private int serverPort = 61927;

        private bool access_Capture;
        private bool access_CaptureKeyboard;
        private bool access_CaptureMouse;
        private bool access_GetMsg;
        private bool access_TaskMgr;
        private bool access_KeyboardLogger;
        private bool access_GetCmd;
        private bool access_GetPCInfo;
        private bool access_GetImg;
        private bool access_FileAccess;
        private bool access_FileChange;

        private void Form1_Load(object sender, EventArgs e)
        {
            int left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            DesktopBounds = new Rectangle(left, top, this.Width, this.Height);

            keyHook = new KeyboardHook();
            keyHook.KeyboardHooked += new KeyboardHookedEventHandler(keyHookProc);

            mainTask = Task.Factory.StartNew(() =>
            {
                //loadHeader();
                setAccessSettings();

                クライアントの停止SToolStripMenuItem.Enabled = true;
                クライアントToolStripMenuItem.Enabled = false;

                while (true)
                {
                    try
                    {
                        status_text.Text = "接続待機中...";
                        if (start_connection(serverIP, serverPort)) break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERROR: " + ex.ToString());
                    }
                }
                if (shutdownFlag) Application.Exit();
                disconnectedFlag = false;
                クライアントの停止SToolStripMenuItem_Click(null, EventArgs.Empty);
            });
        }

        private void loadHeader()
        {
            try
            {
                int offset = 0;
                using (FileStream fs = new FileStream(pathApp, FileMode.Open, FileAccess.Read))
                {
                    for (offset = 1; offset <= fs.Length; offset++)
                    {
                        fs.Seek(-offset, SeekOrigin.End);
                        if (255 == fs.ReadByte())
                        {
                            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                            string[] sp_data = Encoding.UTF8.GetString(Convert.FromBase64String((sr.ReadToEnd()))).Split('|');
                            serverIP = sp_data[0];
                            serverPort = int.Parse(sp_data[1]);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
        }

        private bool start_connection(string ip_addr, int port)
        {
            try
            {              
                clientMain = new TCP.Client(ip_addr, port, 1);
                status_text.Text = "接続確立中...";
                clientMain.Send("+OK", 5000);                                             
                Console.WriteLine("Connected: "+ clientMain.GetServerIP);
                is_connected = true;
            }
            catch (Exception ex)
            {
                if (clientMain != null) clientMain.Close();
                clientMain = null;
                if (disconnectedFlag) return true;
                return false;
            }

            while (is_connected)
            {
                try
                {                   
                    string raw_data = clientMain.RecvString();
                    string[] data = raw_data.Split(' ');
                    string cmd = data[0];
                    Console.WriteLine(cmd);

                    if ((cmd == "+START_CAP")) start_capture(ip_addr, int.Parse(data[1]));
                    else if (cmd == "+START_PING") start_pinging(ip_addr, int.Parse(data[1]));
                    else if (cmd == "+START_MOUSE") start_mouse_pointer(ip_addr, int.Parse(data[1]));
                    else if (cmd == "+START_KEYBOARD") start_keyboard_capture(ip_addr, int.Parse(data[1]));
                    else if (cmd == "+MSG") show_messagebox(raw_data);
                    else if ((cmd == "+SCREENSHOT") & access_Capture) clientMain.Send(get_screen_bytes());
                    else if ((cmd == "+GET_INFO") & access_GetPCInfo) CommandClasses.GetInformations.SendSystemInformations(clientMain);
                    else if (cmd == "+LOGGER") startKeyboardLogger(ip_addr, int.Parse(data[1]));
                    else if (cmd == "+CMD") startCommandShell(raw_data);
                    else if (cmd == "+START_TASKMGR") startTaskMgr(ip_addr, int.Parse(data[1]));
                    else if (cmd == "+TASK_KILL") killProcess(int.Parse(data[1]));
                    else if (cmd == "+START_EXPLORER") CommandClasses.Explorer.StartExplorerAccess(ip_addr, int.Parse(data[1]), access_FileAccess, access_FileChange, this);
                    else if (cmd == "+SEND_IMG") startSendImage(raw_data.Substring(10));
                    else if (cmd == "+SHUTDOWN")
                    {
                        shutdownFlag = true;
                        throw new Exception();
                    }
                    else if (cmd == "") throw new Exception();
                    GC.Collect();
                    Thread.Sleep(1000);
                }
                catch(Exception ex)
                {
                    if (clientPing != null) clientPing.Close();
                    if (clientMain != null) clientMain.Close();
                    clientPing = null;
                    clientMain = null;
                    Console.WriteLine(ex.ToString());
                    is_connected = false;
                    if (shutdownFlag) return true;
                }
            }           
            return false;
        }

        private void start_capture(string ip_addr, int port)
        {
            Task.Factory.StartNew(() =>
            {
                TCP.Client cl_cap = new TCP.Client(ip_addr, port);
                if (access_Capture)
                {
                    status_camera.Visible = true;
                    try
                    {
                        while (is_connected)
                        {
                            cl_cap.Send(get_screen_bytes(), 5000);
                            string[] sp_data = cl_cap.RecvString(5000).Split(',');
                            Thread.Sleep(int.Parse(sp_data[0]));
                        }
                    }
                    catch
                    {
                    }
                    status_camera.Visible = false;
                }
                cl_cap.Close();
            });
        }

        private Image get_screen()
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(bmp);

            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), bmp.Size);
            g.Dispose();

            return bmp;
        }

        private byte[] get_screen_bytes()
        {
            Image bmp = get_screen();
            ImageConverter imgconv = new ImageConverter();
            return (byte[])imgconv.ConvertTo(bmp, typeof(byte[]));
        }

        private void start_pinging(string ip_addr, int port)
        {
            Task.Factory.StartNew(() =>
            {              
                clientPing = new TCP.Client(ip_addr, port, 5);
                try
                {
                    Stopwatch sw = new Stopwatch();
                    do
                    {
                        sw.Start();
                        clientPing.Send("+OK", 5000);
                        clientPing.RecvString(5000);
                        sw.Stop();
                        status_text.Text = clientPing.GetServerIP + " - " + sw.Elapsed.TotalMilliseconds.ToString() +"ms";
                        sw.Reset();

                        Console.WriteLine("+PING");
                        Thread.Sleep(1000);
                        if (disconnectedFlag) break;
                    } while (is_connected);
                }
                catch (Exception ex) { }
                is_connected = false;
                isLoggerStarted = false;
                if (clientPing != null) clientPing.Close();
                if (clientMain != null) clientMain.Close();
                if (clientLogger != null) clientLogger.Close();
                clientMain = null;
                clientPing = null;
                clientLogger = null;
            });
        }

        private void start_mouse_pointer(string connectIP, int connectPort)
        {
            Task.Factory.StartNew(() =>
            {
                TCP.Client cl_mouse = new TCP.Client(connectIP, connectPort);
                if (access_CaptureMouse)
                {
                    try
                    {
                        status_mouse.Visible = true;
                        while (is_connected)
                        {
                            string[] mouseData = cl_mouse.RecvString().Split(' ');
                            string mouseCmd = mouseData[0];
                            string[] mousePoint = mouseData[1].Split(',');
                            SetCursorPos(int.Parse(mousePoint[0]), int.Parse(mousePoint[1]));

                            if (mouseCmd == "+MOUSE_D_LEFT") mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            else if (mouseCmd == "+MOUSE_U_LEFT") mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            else if (mouseCmd == "+MOUSE_C_RIGHT") mouseRightClick();
                            else if (mouseCmd == "+MOUSE_DC_LEFT")
                            {
                                mouseLeftClick();
                                Thread.Sleep(10);
                                mouseLeftClick();
                            }
                            else if (mouseCmd == "+MOUSE_DC_RIGHT")
                            {
                                mouseRightClick();
                                Thread.Sleep(10);
                                mouseRightClick();
                            }
                            else mouseLeftClick();
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }

                if (cl_mouse != null) cl_mouse.Close();
                cl_mouse = null;
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                status_mouse.Visible = false;
            });
        }

        private void mouseLeftClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Thread.Sleep(10);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
        private void mouseRightClick()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            Thread.Sleep(10);
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
        }

        private void start_keyboard_capture(string connectIP, int connectPort)
        {
            Task.Factory.StartNew(() =>
            {
                TCP.Client cl_keyboard = new TCP.Client(connectIP, connectPort);
                if (access_CaptureKeyboard)
                {
                    status_keyboard.Visible = true;
                    try
                    {
                        while (is_connected)
                        {
                            string keyData = cl_keyboard.RecvString();
                            if (keyData == "")
                            {
                                cl_keyboard.Close();
                                cl_keyboard = null;
                                break;
                            }
                            SendKeys.SendWait(keyData);
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                if (cl_keyboard != null) cl_keyboard.Close();
                cl_keyboard = null;
                status_keyboard.Visible = false;
            });
        }

        private void show_messagebox(string raw_data)
        {
            try
            {
                if (access_GetMsg)
                {
                    string[] data = raw_data.Split(' ');
                    Task.Factory.StartNew(() =>
                    {
                        MessageBox.Show(base64De(data[1]), base64De(data[2]), (MessageBoxButtons)int_pares_ex(data[3]), (MessageBoxIcon)int_pares_ex(data[4]), MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    });
                    clientMain.Send("+OK");
                }
                else
                {
                    clientMain.Send("+ERROR");
                }
            }
            catch
            {
            }
        }

        private string base64De(string base64)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(base64));
        }

        private int int_pares_ex(string str_data)
        {
            return int.Parse(Regex.Replace(str_data, @"[^0-9]", ""));
        }

        private void startKeyboardLogger(string connectIP, int connectPort)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    clientLogger = new TCP.Client(connectIP, connectPort);
                    if (access_KeyboardLogger)
                    {
                        isLoggerStarted = true;
                    }        
                    else
                    {
                        if (clientLogger != null) clientLogger.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            });
        }

        private string tmpKeyInput = "";
        private void keyHookProc(object sender, KeyboardHookedEventArgs e)
        {
            if (isLoggerStarted)
            {
                try
                {                    
                    string keyData = e.KeyCode.ToString();
                    if (tmpKeyInput != keyData)
                    {
                        if (keyData.Length == 1)
                            clientLogger.Send(keyData);
                        else if (keyData.Length == 2)
                            clientLogger.Send("["+ keyData +"]");
                        else
                            clientLogger.Send("["+ keyData +"]\r\n");
                    }
                    tmpKeyInput = keyData;
                }
                catch (Exception ex)
                {
                    isLoggerStarted = false;
                }
            }
        }

        private void startCommandShell(string rawCmdData)
        {
            Task.Factory.StartNew(() =>
            {
                if (access_GetCmd)
                {
                    string cmdData = rawCmdData.Remove(0, 5);

                    OperatingSystem os = System.Environment.OSVersion;

                    if (os.Version.Major == 5)
                    {
                        Process.Start(Environment.GetEnvironmentVariable("ComSpec"), cmdData);
                        clientMain.Send("+OK");
                    }
                    else
                    {
                        Process p = new Process();
                        p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
                        p.StartInfo.UseShellExecute = false;
                        p.StartInfo.RedirectStandardOutput = true;
                        p.StartInfo.RedirectStandardInput = false;
                        p.StartInfo.CreateNoWindow = true;
                        p.StartInfo.Arguments = cmdData;
                        p.Start();

                        clientMain.Send("+OK");

                        p.WaitForExit(5000);
                        p.Kill();
                        Console.WriteLine("Process Killed");
                    }
                }
            });
        }

        private void startTaskMgr(string connectIP, int connectPort)
        {
            Task.Factory.StartNew(() =>
            {
                TCP.Client clientTaskMgr = null;
                try
                {
                    clientTaskMgr = new TCP.Client(connectIP, connectPort);
                    if (access_TaskMgr)
                    {
                        while (true)
                        {
                            clientTaskMgr.Send(getProcessInfo());
                            clientTaskMgr.RecvBytes();
                        }
                    }
                    else
                    {
                        if (clientTaskMgr != null) clientTaskMgr.Close();
                    }
                }
                catch (Exception ex)
                {
                    if (clientTaskMgr != null) clientTaskMgr.Close();
                    Console.WriteLine(ex.Message);
                }
            });
        }

        private string getProcessInfo()
        {
            //ローカルコンピュータ上で実行されているすべてのプロセスを取得
            List<string> tmpProcessList = new List<string>();
            Process[] ps = Process.GetProcesses();
            foreach (Process p in ps)
            {
                try
                {
                    tmpProcessList.Add(p.ProcessName +"/"+ (p.WorkingSet64 / 1024).ToString() +" KB/" + p.Id.ToString() +"/"+ p.MainModule.FileName);
                }
                catch (Exception ex)
                {
                }
            }

            return string.Join("|", tmpProcessList);
        }

        private void killProcess(int PID)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    if (access_TaskMgr)
                    {
                        Process ps = Process.GetProcessById(PID);
                        ps.Kill();
                        clientMain.Send("+OK");
                    }
                    else
                    {
                        clientMain.Send("アクセス制限されています");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    clientMain.Send(ex.Message);
                }
            });
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        private void startSendImage(string setTitle)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    if (access_GetImg)
                    {
                        clientMain.Send("+OK");

                        Forms.SendImage sendImage = new Forms.SendImage();
                        sendImage.setTitle = setTitle;
                        ImageConverter imgconv = new ImageConverter();
                        sendImage.setImage = (Image)imgconv.ConvertFrom(clientMain.RecvBytes(-1, 1024 * 1024 * 50));
                        clientMain.Send("+OK");
                        sendImage.ShowDialog();

                        sendImage.Dispose();
                        sendImage = null;
                    }
                    GC.Collect();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            });
        }

        private void プログラムの終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void クライアントの停止SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!disconnectedFlag)
            {
                disconnectedFlag = true;
                クライアントの停止SToolStripMenuItem.Enabled = false;
                クライアントToolStripMenuItem.Enabled = true;
                status_text.Text = "停止";
            }
        }

        private void クライアントToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (disconnectedFlag)
            {
                disconnectedFlag = false;
                クライアントToolStripMenuItem.Enabled = false;
                Form1_Load(null, EventArgs.Empty);
            }
        }

        private void バージョン情報VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "製作者: betacode_\r\n" +
                "バージョン: v1.10\r\n" +
                "開発URL: https://github.com/betacode-projects/RemotePanel\r\n"+
                "製作者URL: https://twitter.com/betacode_",
                "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void setAccessSettings()
        {
            Forms.AccessSettings fas = new Forms.AccessSettings();
            fas.ShowDialog();
            access_Capture = fas.mainCapture.Checked;
            access_CaptureKeyboard = fas.mainCaptureKeyboard.Checked;
            access_CaptureMouse = fas.mainCaptureMouse.Checked;
            access_GetCmd = fas.mainGetCommand.Checked;
            access_GetImg = fas.mainGetImage.Checked;
            access_GetMsg = fas.mainGetMessage.Checked;
            access_GetPCInfo = fas.mainGetPCData.Checked;
            access_KeyboardLogger = fas.mainKeyboardLogger.Checked;
            access_TaskMgr = fas.mainTaskManeger.Checked;
            bool exit_flag = fas.close_flag;
            fas.Dispose();
            
            if (fas.mainFileAllAccess.Checked)
            {
                access_FileAccess = true;
                access_FileChange = true;
            }
            else if (fas.mainFileLookOnly.Checked)
            {
                access_FileAccess = true;
                access_FileChange = false;
            }
            else
            {
                access_FileAccess = false;
                access_FileChange = false;
            }

            if (exit_flag) Close();
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //マウスのキャプチャを解除
                ReleaseCapture();
                //タイトルバーでマウスの左ボタンが押されたことにする
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
        }
    }
}
