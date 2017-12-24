using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace RemotePanel.Forms.Explorer
{
    public partial class NameChange : Form
    {
        public NameChange()
        {
            InitializeComponent();
        }

        public string SetBeforeName
        {
            set
            {
                mainBeforeName_Textbox.Text = Path.GetFileName(value);
                mainAfterName_Textbox.Text = mainBeforeName_Textbox.Text;

                beforePath = value;
                afterPath = Path.GetDirectoryName(value);
            }
        }

        private string beforePath = "";
        private string afterPath = "";

        public TCP.Server serverExplorer = null;       

        private void mainChange_Button_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    if (mainAfterName_Textbox.Text != "")
                    {
                        mainChange_Button.Enabled = false;
                        serverExplorer.Send("+COPY |True|" + beforePath + "|" + afterPath + @"\" + mainAfterName_Textbox.Text + "|");
                        string result = serverExplorer.RecvString();

                        if (result.StartsWith("+"))
                        {
                            MessageBox.Show("名前を変更しました", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(result, "名前変更エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("名前を指定してください", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    mainChange_Button.Enabled = true;
                    mainAfterName_Textbox.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Close();
                }
            });
        }

        private void NameChange_Load(object sender, EventArgs e)
        {
            mainAfterName_Textbox.Focus();
        }
    }
}
