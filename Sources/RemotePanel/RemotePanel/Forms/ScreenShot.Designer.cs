namespace RemotePanel.Forms
{
    partial class ScreenShot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenShot));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Main_info_tx = new System.Windows.Forms.TextBox();
            this.Main_save_bt = new System.Windows.Forms.Button();
            this.Main_reload_bt = new System.Windows.Forms.Button();
            this.Main_save_pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_save_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Main_info_tx);
            this.panel1.Controls.Add(this.Main_save_bt);
            this.panel1.Controls.Add(this.Main_reload_bt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 40);
            this.panel1.TabIndex = 0;
            // 
            // Main_info_tx
            // 
            this.Main_info_tx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_info_tx.BackColor = System.Drawing.Color.Black;
            this.Main_info_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_info_tx.ForeColor = System.Drawing.Color.White;
            this.Main_info_tx.Location = new System.Drawing.Point(169, 8);
            this.Main_info_tx.Name = "Main_info_tx";
            this.Main_info_tx.ReadOnly = true;
            this.Main_info_tx.Size = new System.Drawing.Size(214, 23);
            this.Main_info_tx.TabIndex = 6;
            this.Main_info_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main_save_bt
            // 
            this.Main_save_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Main_save_bt.Location = new System.Drawing.Point(90, 8);
            this.Main_save_bt.Name = "Main_save_bt";
            this.Main_save_bt.Size = new System.Drawing.Size(73, 23);
            this.Main_save_bt.TabIndex = 1;
            this.Main_save_bt.Text = "保存";
            this.Main_save_bt.UseVisualStyleBackColor = true;
            this.Main_save_bt.Click += new System.EventHandler(this.Main_save_bt_Click);
            // 
            // Main_reload_bt
            // 
            this.Main_reload_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Main_reload_bt.Location = new System.Drawing.Point(11, 8);
            this.Main_reload_bt.Name = "Main_reload_bt";
            this.Main_reload_bt.Size = new System.Drawing.Size(73, 23);
            this.Main_reload_bt.TabIndex = 0;
            this.Main_reload_bt.Text = "更新";
            this.Main_reload_bt.UseVisualStyleBackColor = true;
            this.Main_reload_bt.Click += new System.EventHandler(this.Main_reload_bt_Click);
            // 
            // Main_save_pic
            // 
            this.Main_save_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_save_pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_save_pic.Location = new System.Drawing.Point(0, 40);
            this.Main_save_pic.Name = "Main_save_pic";
            this.Main_save_pic.Size = new System.Drawing.Size(396, 240);
            this.Main_save_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Main_save_pic.TabIndex = 1;
            this.Main_save_pic.TabStop = false;
            // 
            // ScreenShot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(396, 280);
            this.Controls.Add(this.Main_save_pic);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(412, 319);
            this.Name = "ScreenShot";
            this.Text = "RemotePanel - スクリーンショット";
            this.Load += new System.EventHandler(this.ScreenShot_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_save_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Main_save_pic;
        private System.Windows.Forms.Button Main_reload_bt;
        private System.Windows.Forms.Button Main_save_bt;
        private System.Windows.Forms.TextBox Main_info_tx;
    }
}