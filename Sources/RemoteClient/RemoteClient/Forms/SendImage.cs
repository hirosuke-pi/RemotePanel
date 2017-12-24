using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RemoteClient.Forms
{
    public partial class SendImage : Form
    {
        public SendImage()
        {
            InitializeComponent();
        }

        public string setTitle
        {
            set { Text = value; }
        }

        public Image setImage
        {
            set
            {
                mainImage_PictureBox.Image = value;
                Size = mainImage_PictureBox.Image.Size;
            }
        }

        private void SendImage_Load(object sender, EventArgs e)
        {

        }
    }
}
