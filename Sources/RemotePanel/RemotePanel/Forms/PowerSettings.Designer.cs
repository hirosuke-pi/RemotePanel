namespace RemotePanel.Forms
{
    partial class PowerSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainPowerComment_Textbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mainPowerTime_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mainPowerCmd_comboBox = new System.Windows.Forms.ComboBox();
            this.mainCmdSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPowerTime_numericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mainPowerComment_Textbox);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "コメント";
            // 
            // mainPowerComment_Textbox
            // 
            this.mainPowerComment_Textbox.BackColor = System.Drawing.Color.Black;
            this.mainPowerComment_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPowerComment_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainPowerComment_Textbox.Location = new System.Drawing.Point(6, 22);
            this.mainPowerComment_Textbox.Name = "mainPowerComment_Textbox";
            this.mainPowerComment_Textbox.Size = new System.Drawing.Size(334, 23);
            this.mainPowerComment_Textbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mainPowerTime_numericUpDown);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "時間 (秒)";
            // 
            // mainPowerTime_numericUpDown
            // 
            this.mainPowerTime_numericUpDown.BackColor = System.Drawing.Color.Black;
            this.mainPowerTime_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPowerTime_numericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainPowerTime_numericUpDown.Location = new System.Drawing.Point(7, 22);
            this.mainPowerTime_numericUpDown.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.mainPowerTime_numericUpDown.Name = "mainPowerTime_numericUpDown";
            this.mainPowerTime_numericUpDown.Size = new System.Drawing.Size(73, 23);
            this.mainPowerTime_numericUpDown.TabIndex = 0;
            this.mainPowerTime_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainPowerTime_numericUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mainPowerCmd_comboBox);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Location = new System.Drawing.Point(107, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(117, 59);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "コマンド";
            // 
            // mainPowerCmd_comboBox
            // 
            this.mainPowerCmd_comboBox.BackColor = System.Drawing.Color.Black;
            this.mainPowerCmd_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainPowerCmd_comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainPowerCmd_comboBox.FormattingEnabled = true;
            this.mainPowerCmd_comboBox.Items.AddRange(new object[] {
            "シャットダウン",
            "再起動",
            "ログオフ",
            "休止状態",
            "キャンセル"});
            this.mainPowerCmd_comboBox.Location = new System.Drawing.Point(7, 22);
            this.mainPowerCmd_comboBox.Name = "mainPowerCmd_comboBox";
            this.mainPowerCmd_comboBox.Size = new System.Drawing.Size(104, 23);
            this.mainPowerCmd_comboBox.TabIndex = 0;
            this.mainPowerCmd_comboBox.Text = "シャットダウン";
            // 
            // mainCmdSend
            // 
            this.mainCmdSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainCmdSend.Location = new System.Drawing.Point(231, 87);
            this.mainCmdSend.Name = "mainCmdSend";
            this.mainCmdSend.Size = new System.Drawing.Size(128, 50);
            this.mainCmdSend.TabIndex = 3;
            this.mainCmdSend.Text = "送信";
            this.mainCmdSend.UseVisualStyleBackColor = true;
            this.mainCmdSend.Click += new System.EventHandler(this.mainCmdSend_Click);
            // 
            // PowerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(371, 149);
            this.Controls.Add(this.mainCmdSend);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PowerSettings";
            this.Text = "RemotePanel - 電源";
            this.Load += new System.EventHandler(this.PowerSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPowerTime_numericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mainPowerComment_Textbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown mainPowerTime_numericUpDown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox mainPowerCmd_comboBox;
        private System.Windows.Forms.Button mainCmdSend;
    }
}