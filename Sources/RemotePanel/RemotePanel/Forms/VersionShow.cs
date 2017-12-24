using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RemotePanel.Forms
{
    public partial class VersionShow : Form
    {
        public VersionShow()
        {
            InitializeComponent();
        }

        private void VersionShow_Load(object sender, EventArgs e)
        {

        }

        private int buttonClicksNumber = 0;
        private bool userClickEvent = true;
        private void mainUser_Button_Click(object sender, EventArgs e)
        {
            if (userClickEvent)
            {
                if (buttonClicksNumber >= 10)
                {
                    MessageBox.Show("(=^･ω･^=)ﾆｬｰ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userClickEvent = false;
                }
                else
                    buttonClicksNumber++;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/betacode_");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/betacode-projects/RemotePanel");
        }
    }
}
