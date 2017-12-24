namespace RemotePanel.Forms
{
    partial class SendMsg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMsg));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Main_subtitle_tx = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Main_title_tx = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Set_bt_YesNo_rbt = new System.Windows.Forms.RadioButton();
            this.Set_bt_RetryCancel_rbt = new System.Windows.Forms.RadioButton();
            this.Set_bt_OK_rbt = new System.Windows.Forms.RadioButton();
            this.Set_bt_YesNoCancel_rbt = new System.Windows.Forms.RadioButton();
            this.Set_bt_OKCancel_rbt = new System.Windows.Forms.RadioButton();
            this.Set_bt_AbortRetryIgnore_rbt = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Set_icon_none_rbt = new System.Windows.Forms.RadioButton();
            this.Set_icon_error_rbt = new System.Windows.Forms.RadioButton();
            this.Set_icon_info_rbt = new System.Windows.Forms.RadioButton();
            this.Set_icon_warning_rbt = new System.Windows.Forms.RadioButton();
            this.Set_icon_question_rbt = new System.Windows.Forms.RadioButton();
            this.Main_test_msg_bt = new System.Windows.Forms.Button();
            this.Main_send_msg_bt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Main_subtitle_tx);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "送信メッセージ";
            // 
            // Main_subtitle_tx
            // 
            this.Main_subtitle_tx.BackColor = System.Drawing.Color.Black;
            this.Main_subtitle_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_subtitle_tx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Main_subtitle_tx.Location = new System.Drawing.Point(7, 22);
            this.Main_subtitle_tx.Multiline = true;
            this.Main_subtitle_tx.Name = "Main_subtitle_tx";
            this.Main_subtitle_tx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Main_subtitle_tx.Size = new System.Drawing.Size(277, 147);
            this.Main_subtitle_tx.TabIndex = 1;
            this.Main_subtitle_tx.WordWrap = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Main_title_tx);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "送信タイトル";
            // 
            // Main_title_tx
            // 
            this.Main_title_tx.BackColor = System.Drawing.Color.Black;
            this.Main_title_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_title_tx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Main_title_tx.Location = new System.Drawing.Point(6, 22);
            this.Main_title_tx.Name = "Main_title_tx";
            this.Main_title_tx.Size = new System.Drawing.Size(277, 23);
            this.Main_title_tx.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Location = new System.Drawing.Point(308, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 182);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "メッセージ設定";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Set_bt_YesNo_rbt);
            this.panel2.Controls.Add(this.Set_bt_RetryCancel_rbt);
            this.panel2.Controls.Add(this.Set_bt_OK_rbt);
            this.panel2.Controls.Add(this.Set_bt_YesNoCancel_rbt);
            this.panel2.Controls.Add(this.Set_bt_OKCancel_rbt);
            this.panel2.Controls.Add(this.Set_bt_AbortRetryIgnore_rbt);
            this.panel2.Location = new System.Drawing.Point(85, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 154);
            this.panel2.TabIndex = 5;
            // 
            // Set_bt_YesNo_rbt
            // 
            this.Set_bt_YesNo_rbt.AutoSize = true;
            this.Set_bt_YesNo_rbt.Location = new System.Drawing.Point(3, 103);
            this.Set_bt_YesNo_rbt.Name = "Set_bt_YesNo_rbt";
            this.Set_bt_YesNo_rbt.Size = new System.Drawing.Size(58, 19);
            this.Set_bt_YesNo_rbt.TabIndex = 5;
            this.Set_bt_YesNo_rbt.Text = "YesNo";
            this.Set_bt_YesNo_rbt.UseVisualStyleBackColor = true;
            // 
            // Set_bt_RetryCancel_rbt
            // 
            this.Set_bt_RetryCancel_rbt.AutoSize = true;
            this.Set_bt_RetryCancel_rbt.Location = new System.Drawing.Point(3, 128);
            this.Set_bt_RetryCancel_rbt.Name = "Set_bt_RetryCancel_rbt";
            this.Set_bt_RetryCancel_rbt.Size = new System.Drawing.Size(87, 19);
            this.Set_bt_RetryCancel_rbt.TabIndex = 4;
            this.Set_bt_RetryCancel_rbt.Text = "RetryCancel";
            this.Set_bt_RetryCancel_rbt.UseVisualStyleBackColor = true;
            // 
            // Set_bt_OK_rbt
            // 
            this.Set_bt_OK_rbt.AutoSize = true;
            this.Set_bt_OK_rbt.Checked = true;
            this.Set_bt_OK_rbt.Location = new System.Drawing.Point(3, 3);
            this.Set_bt_OK_rbt.Name = "Set_bt_OK_rbt";
            this.Set_bt_OK_rbt.Size = new System.Drawing.Size(41, 19);
            this.Set_bt_OK_rbt.TabIndex = 0;
            this.Set_bt_OK_rbt.TabStop = true;
            this.Set_bt_OK_rbt.Text = "OK";
            this.Set_bt_OK_rbt.UseVisualStyleBackColor = true;
            // 
            // Set_bt_YesNoCancel_rbt
            // 
            this.Set_bt_YesNoCancel_rbt.AutoSize = true;
            this.Set_bt_YesNoCancel_rbt.Location = new System.Drawing.Point(3, 78);
            this.Set_bt_YesNoCancel_rbt.Name = "Set_bt_YesNoCancel_rbt";
            this.Set_bt_YesNoCancel_rbt.Size = new System.Drawing.Size(93, 19);
            this.Set_bt_YesNoCancel_rbt.TabIndex = 3;
            this.Set_bt_YesNoCancel_rbt.Text = "YesNoCancel";
            this.Set_bt_YesNoCancel_rbt.UseVisualStyleBackColor = true;
            // 
            // Set_bt_OKCancel_rbt
            // 
            this.Set_bt_OKCancel_rbt.AutoSize = true;
            this.Set_bt_OKCancel_rbt.Location = new System.Drawing.Point(3, 28);
            this.Set_bt_OKCancel_rbt.Name = "Set_bt_OKCancel_rbt";
            this.Set_bt_OKCancel_rbt.Size = new System.Drawing.Size(76, 19);
            this.Set_bt_OKCancel_rbt.TabIndex = 1;
            this.Set_bt_OKCancel_rbt.Text = "OKCancel";
            this.Set_bt_OKCancel_rbt.UseVisualStyleBackColor = true;
            // 
            // Set_bt_AbortRetryIgnore_rbt
            // 
            this.Set_bt_AbortRetryIgnore_rbt.AutoSize = true;
            this.Set_bt_AbortRetryIgnore_rbt.Location = new System.Drawing.Point(3, 53);
            this.Set_bt_AbortRetryIgnore_rbt.Name = "Set_bt_AbortRetryIgnore_rbt";
            this.Set_bt_AbortRetryIgnore_rbt.Size = new System.Drawing.Size(116, 19);
            this.Set_bt_AbortRetryIgnore_rbt.TabIndex = 2;
            this.Set_bt_AbortRetryIgnore_rbt.Text = "AbortRetryIgnore";
            this.Set_bt_AbortRetryIgnore_rbt.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Set_icon_none_rbt);
            this.panel1.Controls.Add(this.Set_icon_error_rbt);
            this.panel1.Controls.Add(this.Set_icon_info_rbt);
            this.panel1.Controls.Add(this.Set_icon_warning_rbt);
            this.panel1.Controls.Add(this.Set_icon_question_rbt);
            this.panel1.Location = new System.Drawing.Point(6, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 122);
            this.panel1.TabIndex = 4;
            // 
            // Set_icon_none_rbt
            // 
            this.Set_icon_none_rbt.AutoSize = true;
            this.Set_icon_none_rbt.Location = new System.Drawing.Point(3, 100);
            this.Set_icon_none_rbt.Name = "Set_icon_none_rbt";
            this.Set_icon_none_rbt.Size = new System.Drawing.Size(43, 19);
            this.Set_icon_none_rbt.TabIndex = 4;
            this.Set_icon_none_rbt.Text = "なし";
            this.Set_icon_none_rbt.UseVisualStyleBackColor = true;
            // 
            // Set_icon_error_rbt
            // 
            this.Set_icon_error_rbt.AutoSize = true;
            this.Set_icon_error_rbt.Checked = true;
            this.Set_icon_error_rbt.Location = new System.Drawing.Point(3, 3);
            this.Set_icon_error_rbt.Name = "Set_icon_error_rbt";
            this.Set_icon_error_rbt.Size = new System.Drawing.Size(50, 19);
            this.Set_icon_error_rbt.TabIndex = 0;
            this.Set_icon_error_rbt.TabStop = true;
            this.Set_icon_error_rbt.Text = "エラー";
            this.Set_icon_error_rbt.UseVisualStyleBackColor = true;
            // 
            // Set_icon_info_rbt
            // 
            this.Set_icon_info_rbt.AutoSize = true;
            this.Set_icon_info_rbt.Location = new System.Drawing.Point(3, 78);
            this.Set_icon_info_rbt.Name = "Set_icon_info_rbt";
            this.Set_icon_info_rbt.Size = new System.Drawing.Size(49, 19);
            this.Set_icon_info_rbt.TabIndex = 3;
            this.Set_icon_info_rbt.Text = "情報";
            this.Set_icon_info_rbt.UseVisualStyleBackColor = true;
            // 
            // Set_icon_warning_rbt
            // 
            this.Set_icon_warning_rbt.AutoSize = true;
            this.Set_icon_warning_rbt.Location = new System.Drawing.Point(3, 28);
            this.Set_icon_warning_rbt.Name = "Set_icon_warning_rbt";
            this.Set_icon_warning_rbt.Size = new System.Drawing.Size(49, 19);
            this.Set_icon_warning_rbt.TabIndex = 1;
            this.Set_icon_warning_rbt.Text = "注意";
            this.Set_icon_warning_rbt.UseVisualStyleBackColor = true;
            // 
            // Set_icon_question_rbt
            // 
            this.Set_icon_question_rbt.AutoSize = true;
            this.Set_icon_question_rbt.Location = new System.Drawing.Point(3, 53);
            this.Set_icon_question_rbt.Name = "Set_icon_question_rbt";
            this.Set_icon_question_rbt.Size = new System.Drawing.Size(49, 19);
            this.Set_icon_question_rbt.TabIndex = 2;
            this.Set_icon_question_rbt.Text = "質問";
            this.Set_icon_question_rbt.UseVisualStyleBackColor = true;
            // 
            // Main_test_msg_bt
            // 
            this.Main_test_msg_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Main_test_msg_bt.Location = new System.Drawing.Point(308, 20);
            this.Main_test_msg_bt.Name = "Main_test_msg_bt";
            this.Main_test_msg_bt.Size = new System.Drawing.Size(75, 49);
            this.Main_test_msg_bt.TabIndex = 3;
            this.Main_test_msg_bt.Text = "テスト";
            this.Main_test_msg_bt.UseVisualStyleBackColor = true;
            this.Main_test_msg_bt.Click += new System.EventHandler(this.Main_test_msg_bt_Click);
            // 
            // Main_send_msg_bt
            // 
            this.Main_send_msg_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Main_send_msg_bt.Location = new System.Drawing.Point(389, 20);
            this.Main_send_msg_bt.Name = "Main_send_msg_bt";
            this.Main_send_msg_bt.Size = new System.Drawing.Size(136, 49);
            this.Main_send_msg_bt.TabIndex = 4;
            this.Main_send_msg_bt.Text = "送信";
            this.Main_send_msg_bt.UseVisualStyleBackColor = true;
            this.Main_send_msg_bt.Click += new System.EventHandler(this.Main_send_msg_bt_Click);
            // 
            // SendMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(537, 269);
            this.Controls.Add(this.Main_send_msg_bt);
            this.Controls.Add(this.Main_test_msg_bt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SendMsg";
            this.Text = "RemotePanel - メッセージ送信";
            this.Load += new System.EventHandler(this.SendMsg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Main_title_tx;
        private System.Windows.Forms.TextBox Main_subtitle_tx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Set_icon_info_rbt;
        private System.Windows.Forms.RadioButton Set_icon_question_rbt;
        private System.Windows.Forms.RadioButton Set_icon_warning_rbt;
        private System.Windows.Forms.RadioButton Set_icon_error_rbt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Set_bt_YesNo_rbt;
        private System.Windows.Forms.RadioButton Set_bt_RetryCancel_rbt;
        private System.Windows.Forms.RadioButton Set_bt_OK_rbt;
        private System.Windows.Forms.RadioButton Set_bt_YesNoCancel_rbt;
        private System.Windows.Forms.RadioButton Set_bt_OKCancel_rbt;
        private System.Windows.Forms.RadioButton Set_bt_AbortRetryIgnore_rbt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Set_icon_none_rbt;
        private System.Windows.Forms.Button Main_test_msg_bt;
        private System.Windows.Forms.Button Main_send_msg_bt;
    }
}