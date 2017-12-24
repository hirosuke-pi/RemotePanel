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
    public partial class SendMsg : Form
    {
        public SendMsg()
        {
            InitializeComponent();
        }

        public TCP.Server serverMain = null; 

        private void Main_test_msg_bt_Click(object sender, EventArgs e)
        {
            List<int> msg_info = convert_messagebox();
            MessageBox.Show(Main_subtitle_tx.Text, Main_title_tx.Text, (MessageBoxButtons)msg_info[0], (MessageBoxIcon)msg_info[1]);
        }

        private List<int> convert_messagebox()
        {
            List<int> return_int = new List<int>();

            if (Set_bt_AbortRetryIgnore_rbt.Checked) return_int.Add(2);
            else if (Set_bt_OKCancel_rbt.Checked) return_int.Add(1);
            else if (Set_bt_OK_rbt.Checked) return_int.Add(0);
            else if (Set_bt_RetryCancel_rbt.Checked) return_int.Add(5);
            else if (Set_bt_YesNoCancel_rbt.Checked) return_int.Add(3);
            else if (Set_bt_YesNo_rbt.Checked) return_int.Add(4);

            if (Set_icon_error_rbt.Checked) return_int.Add(16);
            else if (Set_icon_info_rbt.Checked) return_int.Add(64);
            else if (Set_icon_none_rbt.Checked) return_int.Add(0);
            else if (Set_icon_question_rbt.Checked) return_int.Add(32);
            else if (Set_icon_warning_rbt.Checked) return_int.Add(48);

            return return_int;
        }

        private string get_base64(string data)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(data));
        }

        private void SendMsg_Load(object sender, EventArgs e)
        {

        }

        private void Main_send_msg_bt_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
               try
               {
                    Text = "RemotePanel - メッセージ送信 (送信中...)";
                    List<int> msg_info = convert_messagebox();
                    serverMain.Send(
                       "+MSG " +
                       get_base64(Main_subtitle_tx.Text) + " " +
                       get_base64(Main_title_tx.Text) + " " +
                       msg_info[0].ToString() + " " + msg_info[1].ToString()
                       );
                    serverMain.RecvString();
                    Text = "RemotePanel - メッセージ送信 (送信完了)";
                }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                   Close();
               }
            });
        }
    }
}
