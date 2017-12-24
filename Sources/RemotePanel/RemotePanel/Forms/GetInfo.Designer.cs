namespace RemotePanel.Forms
{
    partial class GetInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Main_username_tx = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Main_computername_tx = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Main_system_info_tx = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Main_paths_info_tx = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Main_username_tx);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ユーザー名";
            // 
            // Main_username_tx
            // 
            this.Main_username_tx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_username_tx.BackColor = System.Drawing.Color.Black;
            this.Main_username_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_username_tx.ForeColor = System.Drawing.Color.White;
            this.Main_username_tx.Location = new System.Drawing.Point(6, 22);
            this.Main_username_tx.Name = "Main_username_tx";
            this.Main_username_tx.ReadOnly = true;
            this.Main_username_tx.Size = new System.Drawing.Size(188, 23);
            this.Main_username_tx.TabIndex = 7;
            this.Main_username_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Main_computername_tx);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(219, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "コンピューター名";
            // 
            // Main_computername_tx
            // 
            this.Main_computername_tx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_computername_tx.BackColor = System.Drawing.Color.Black;
            this.Main_computername_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_computername_tx.ForeColor = System.Drawing.Color.White;
            this.Main_computername_tx.Location = new System.Drawing.Point(6, 22);
            this.Main_computername_tx.Name = "Main_computername_tx";
            this.Main_computername_tx.ReadOnly = true;
            this.Main_computername_tx.Size = new System.Drawing.Size(188, 23);
            this.Main_computername_tx.TabIndex = 8;
            this.Main_computername_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Main_system_info_tx);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Location = new System.Drawing.Point(13, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 180);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "システム情報";
            // 
            // Main_system_info_tx
            // 
            this.Main_system_info_tx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_system_info_tx.BackColor = System.Drawing.Color.Black;
            this.Main_system_info_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_system_info_tx.ForeColor = System.Drawing.Color.White;
            this.Main_system_info_tx.Location = new System.Drawing.Point(6, 22);
            this.Main_system_info_tx.Multiline = true;
            this.Main_system_info_tx.Name = "Main_system_info_tx";
            this.Main_system_info_tx.ReadOnly = true;
            this.Main_system_info_tx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Main_system_info_tx.Size = new System.Drawing.Size(188, 152);
            this.Main_system_info_tx.TabIndex = 7;
            this.Main_system_info_tx.WordWrap = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Main_paths_info_tx);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox4.Location = new System.Drawing.Point(219, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 180);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ファイルパス情報";
            // 
            // Main_paths_info_tx
            // 
            this.Main_paths_info_tx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_paths_info_tx.BackColor = System.Drawing.Color.Black;
            this.Main_paths_info_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_paths_info_tx.ForeColor = System.Drawing.Color.White;
            this.Main_paths_info_tx.Location = new System.Drawing.Point(6, 22);
            this.Main_paths_info_tx.Multiline = true;
            this.Main_paths_info_tx.Name = "Main_paths_info_tx";
            this.Main_paths_info_tx.ReadOnly = true;
            this.Main_paths_info_tx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Main_paths_info_tx.Size = new System.Drawing.Size(188, 152);
            this.Main_paths_info_tx.TabIndex = 7;
            this.Main_paths_info_tx.WordWrap = false;
            // 
            // GetInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(430, 270);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "GetInfo";
            this.Text = "RemotePanel - PC情報取得中...";
            this.Load += new System.EventHandler(this.GetInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Main_username_tx;
        private System.Windows.Forms.TextBox Main_computername_tx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Main_system_info_tx;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Main_paths_info_tx;
    }
}