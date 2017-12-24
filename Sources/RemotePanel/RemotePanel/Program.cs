using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemotePanel
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string mutexName = "RemotePanel_Application_StartMutex";
            mutexName = "Global\\" + mutexName;
            System.Security.AccessControl.MutexAccessRule rule =
                new System.Security.AccessControl.MutexAccessRule(
                    new System.Security.Principal.SecurityIdentifier(
                        System.Security.Principal.WellKnownSidType.WorldSid, null),
                        System.Security.AccessControl.MutexRights.FullControl,
                        System.Security.AccessControl.AccessControlType.Allow);
            System.Security.AccessControl.MutexSecurity mutexSecurity =
                new System.Security.AccessControl.MutexSecurity();
            mutexSecurity.AddAccessRule(rule);
            bool createdNew;
            System.Threading.Mutex mutex =
                new System.Threading.Mutex(false, mutexName, out createdNew, mutexSecurity);

            if (createdNew == false)
            {
                MessageBox.Show("サーバーが混合するため、多重起動はできません", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                mutex.Close();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
