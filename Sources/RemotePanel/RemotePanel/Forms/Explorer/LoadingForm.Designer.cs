namespace RemotePanel.Forms.Explorer
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.mainFileOpen_Groupbox = new System.Windows.Forms.GroupBox();
            this.mainFileOpen_Textbox = new System.Windows.Forms.TextBox();
            this.mainFileSave_Groupbox = new System.Windows.Forms.GroupBox();
            this.mainFileSave_Textbox = new System.Windows.Forms.TextBox();
            this.mainFileOpen_Groupbox.SuspendLayout();
            this.mainFileSave_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(5, 134);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(331, 31);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            // 
            // mainFileOpen_Groupbox
            // 
            this.mainFileOpen_Groupbox.Controls.Add(this.mainFileOpen_Textbox);
            this.mainFileOpen_Groupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainFileOpen_Groupbox.Location = new System.Drawing.Point(5, 12);
            this.mainFileOpen_Groupbox.Name = "mainFileOpen_Groupbox";
            this.mainFileOpen_Groupbox.Size = new System.Drawing.Size(331, 55);
            this.mainFileOpen_Groupbox.TabIndex = 1;
            this.mainFileOpen_Groupbox.TabStop = false;
            // 
            // mainFileOpen_Textbox
            // 
            this.mainFileOpen_Textbox.BackColor = System.Drawing.Color.Black;
            this.mainFileOpen_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainFileOpen_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFileOpen_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainFileOpen_Textbox.Location = new System.Drawing.Point(3, 19);
            this.mainFileOpen_Textbox.Name = "mainFileOpen_Textbox";
            this.mainFileOpen_Textbox.ReadOnly = true;
            this.mainFileOpen_Textbox.Size = new System.Drawing.Size(325, 16);
            this.mainFileOpen_Textbox.TabIndex = 0;
            // 
            // mainFileSave_Groupbox
            // 
            this.mainFileSave_Groupbox.Controls.Add(this.mainFileSave_Textbox);
            this.mainFileSave_Groupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainFileSave_Groupbox.Location = new System.Drawing.Point(5, 73);
            this.mainFileSave_Groupbox.Name = "mainFileSave_Groupbox";
            this.mainFileSave_Groupbox.Size = new System.Drawing.Size(331, 55);
            this.mainFileSave_Groupbox.TabIndex = 2;
            this.mainFileSave_Groupbox.TabStop = false;
            // 
            // mainFileSave_Textbox
            // 
            this.mainFileSave_Textbox.BackColor = System.Drawing.Color.Black;
            this.mainFileSave_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainFileSave_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFileSave_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainFileSave_Textbox.Location = new System.Drawing.Point(3, 19);
            this.mainFileSave_Textbox.Name = "mainFileSave_Textbox";
            this.mainFileSave_Textbox.ReadOnly = true;
            this.mainFileSave_Textbox.Size = new System.Drawing.Size(325, 16);
            this.mainFileSave_Textbox.TabIndex = 0;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(344, 176);
            this.Controls.Add(this.mainFileSave_Groupbox);
            this.Controls.Add(this.mainFileOpen_Groupbox);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingForm";
            this.ShowInTaskbar = false;
            this.Text = "Remote Panel - 読み込み中...";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UploadForm_Load);
            this.mainFileOpen_Groupbox.ResumeLayout(false);
            this.mainFileOpen_Groupbox.PerformLayout();
            this.mainFileSave_Groupbox.ResumeLayout(false);
            this.mainFileSave_Groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox mainFileOpen_Groupbox;
        private System.Windows.Forms.TextBox mainFileOpen_Textbox;
        private System.Windows.Forms.GroupBox mainFileSave_Groupbox;
        private System.Windows.Forms.TextBox mainFileSave_Textbox;
    }
}