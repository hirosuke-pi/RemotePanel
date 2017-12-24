namespace RemotePanel.Forms
{
    partial class KeyboardLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyboardLogs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainClearText_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainSaveFile_Button = new System.Windows.Forms.Button();
            this.mainSavePath_Textbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainLog_Textbox = new System.Windows.Forms.TextBox();
            this.mainLogSave_saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mainClearText_Button);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 74);
            this.panel1.TabIndex = 0;
            // 
            // mainClearText_Button
            // 
            this.mainClearText_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainClearText_Button.Location = new System.Drawing.Point(11, 11);
            this.mainClearText_Button.Name = "mainClearText_Button";
            this.mainClearText_Button.Size = new System.Drawing.Size(92, 49);
            this.mainClearText_Button.TabIndex = 2;
            this.mainClearText_Button.Text = "クリア";
            this.mainClearText_Button.UseVisualStyleBackColor = true;
            this.mainClearText_Button.Click += new System.EventHandler(this.mainClearText_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.mainSavePath_Textbox);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(109, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "テキスト保存";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mainSaveFile_Button);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(276, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(99, 35);
            this.panel3.TabIndex = 7;
            // 
            // mainSaveFile_Button
            // 
            this.mainSaveFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainSaveFile_Button.Location = new System.Drawing.Point(3, 3);
            this.mainSaveFile_Button.Name = "mainSaveFile_Button";
            this.mainSaveFile_Button.Size = new System.Drawing.Size(92, 23);
            this.mainSaveFile_Button.TabIndex = 0;
            this.mainSaveFile_Button.Text = "保存";
            this.mainSaveFile_Button.UseVisualStyleBackColor = true;
            this.mainSaveFile_Button.Click += new System.EventHandler(this.mainSaveFile_Button_Click);
            // 
            // mainSavePath_Textbox
            // 
            this.mainSavePath_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSavePath_Textbox.BackColor = System.Drawing.Color.Black;
            this.mainSavePath_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSavePath_Textbox.ForeColor = System.Drawing.Color.White;
            this.mainSavePath_Textbox.Location = new System.Drawing.Point(6, 22);
            this.mainSavePath_Textbox.Name = "mainSavePath_Textbox";
            this.mainSavePath_Textbox.Size = new System.Drawing.Size(267, 23);
            this.mainSavePath_Textbox.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.mainLog_Textbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 201);
            this.panel2.TabIndex = 1;
            // 
            // mainLog_Textbox
            // 
            this.mainLog_Textbox.BackColor = System.Drawing.Color.Black;
            this.mainLog_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainLog_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLog_Textbox.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mainLog_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainLog_Textbox.Location = new System.Drawing.Point(0, 0);
            this.mainLog_Textbox.Multiline = true;
            this.mainLog_Textbox.Name = "mainLog_Textbox";
            this.mainLog_Textbox.ReadOnly = true;
            this.mainLog_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainLog_Textbox.Size = new System.Drawing.Size(496, 197);
            this.mainLog_Textbox.TabIndex = 0;
            // 
            // mainLogSave_saveFileDialog
            // 
            this.mainLogSave_saveFileDialog.FileName = "KeyboardLogs.txt";
            this.mainLogSave_saveFileDialog.Filter = "*.txt|テキストファイル";
            this.mainLogSave_saveFileDialog.SupportMultiDottedExtensions = true;
            this.mainLogSave_saveFileDialog.Title = "ログの保存";
            // 
            // KeyboardLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 275);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(516, 314);
            this.Name = "KeyboardLogs";
            this.Text = "RemotePanel - キーボードログ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KeyboardLogs_FormClosing);
            this.Load += new System.EventHandler(this.KeyboardLogs_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox mainLog_Textbox;
        private System.Windows.Forms.Button mainSaveFile_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mainSavePath_Textbox;
        private System.Windows.Forms.Button mainClearText_Button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SaveFileDialog mainLogSave_saveFileDialog;
    }
}