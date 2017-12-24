namespace RemotePanel.Forms
{
    partial class SendImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendImage));
            this.mainSendData_Button = new System.Windows.Forms.Button();
            this.mainSendTitle_Textbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainSendImage_PictureBox = new System.Windows.Forms.PictureBox();
            this.mainImageOpen_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSendImage_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSendData_Button
            // 
            this.mainSendData_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainSendData_Button.Location = new System.Drawing.Point(3, 11);
            this.mainSendData_Button.Name = "mainSendData_Button";
            this.mainSendData_Button.Size = new System.Drawing.Size(70, 23);
            this.mainSendData_Button.TabIndex = 1;
            this.mainSendData_Button.Text = "送信";
            this.mainSendData_Button.UseVisualStyleBackColor = true;
            this.mainSendData_Button.Click += new System.EventHandler(this.mainSendData_Button_Click);
            // 
            // mainSendTitle_Textbox
            // 
            this.mainSendTitle_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSendTitle_Textbox.BackColor = System.Drawing.Color.Black;
            this.mainSendTitle_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSendTitle_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainSendTitle_Textbox.Location = new System.Drawing.Point(58, 11);
            this.mainSendTitle_Textbox.Name = "mainSendTitle_Textbox";
            this.mainSendTitle_Textbox.Size = new System.Drawing.Size(247, 23);
            this.mainSendTitle_Textbox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.mainSendTitle_Textbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 47);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "タイトル: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mainSendData_Button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(311, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 45);
            this.panel2.TabIndex = 2;
            // 
            // mainSendImage_PictureBox
            // 
            this.mainSendImage_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainSendImage_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSendImage_PictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainSendImage_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSendImage_PictureBox.Location = new System.Drawing.Point(0, 47);
            this.mainSendImage_PictureBox.Name = "mainSendImage_PictureBox";
            this.mainSendImage_PictureBox.Size = new System.Drawing.Size(394, 235);
            this.mainSendImage_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainSendImage_PictureBox.TabIndex = 3;
            this.mainSendImage_PictureBox.TabStop = false;
            this.mainSendImage_PictureBox.DoubleClick += new System.EventHandler(this.mainSendImage_PictureBox_DoubleClick);
            // 
            // mainImageOpen_openFileDialog
            // 
            this.mainImageOpen_openFileDialog.Filter = "画像ファイル|*.png;*jpeg;*jpg;*.bmp;*.tiff;*.gif|PNGファイル|*.png|JPEGファイル|*.jpeg|JPGファイル|" +
    "*.jpg|BMPファイル|*.bmp|TIFFファイル|*.tiff|GIFファイル|*.gif";
            this.mainImageOpen_openFileDialog.SupportMultiDottedExtensions = true;
            // 
            // SendImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(394, 282);
            this.Controls.Add(this.mainSendImage_PictureBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SendImage";
            this.Text = "RemotePanel - 画像送信";
            this.Load += new System.EventHandler(this.SendImage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSendImage_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainSendData_Button;
        private System.Windows.Forms.TextBox mainSendTitle_Textbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox mainSendImage_PictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog mainImageOpen_openFileDialog;
    }
}