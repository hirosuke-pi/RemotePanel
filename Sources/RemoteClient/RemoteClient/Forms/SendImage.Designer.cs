namespace RemoteClient.Forms
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
            this.mainImage_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainImage_PictureBox
            // 
            this.mainImage_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainImage_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainImage_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.mainImage_PictureBox.Name = "mainImage_PictureBox";
            this.mainImage_PictureBox.Size = new System.Drawing.Size(454, 306);
            this.mainImage_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainImage_PictureBox.TabIndex = 0;
            this.mainImage_PictureBox.TabStop = false;
            // 
            // SendImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 306);
            this.Controls.Add(this.mainImage_PictureBox);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SendImage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SendImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainImage_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainImage_PictureBox;
    }
}