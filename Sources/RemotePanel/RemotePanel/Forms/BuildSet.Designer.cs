namespace RemotePanel.Forms
{
    partial class BuildSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildSet));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainSavePath_Button = new System.Windows.Forms.Button();
            this.mainSavePath_Textbox = new System.Windows.Forms.TextBox();
            this.mainBuild_Button = new System.Windows.Forms.Button();
            this.mainBuild_saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mainSavePath_Button);
            this.groupBox1.Controls.Add(this.mainSavePath_Textbox);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "保存先ファイルパス";
            // 
            // mainSavePath_Button
            // 
            this.mainSavePath_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainSavePath_Button.Location = new System.Drawing.Point(273, 23);
            this.mainSavePath_Button.Name = "mainSavePath_Button";
            this.mainSavePath_Button.Size = new System.Drawing.Size(70, 23);
            this.mainSavePath_Button.TabIndex = 1;
            this.mainSavePath_Button.Text = "設定";
            this.mainSavePath_Button.UseVisualStyleBackColor = true;
            this.mainSavePath_Button.Click += new System.EventHandler(this.mainSavePath_Button_Click);
            // 
            // mainSavePath_Textbox
            // 
            this.mainSavePath_Textbox.BackColor = System.Drawing.Color.Black;
            this.mainSavePath_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSavePath_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainSavePath_Textbox.Location = new System.Drawing.Point(7, 23);
            this.mainSavePath_Textbox.Name = "mainSavePath_Textbox";
            this.mainSavePath_Textbox.ReadOnly = true;
            this.mainSavePath_Textbox.Size = new System.Drawing.Size(260, 23);
            this.mainSavePath_Textbox.TabIndex = 0;
            // 
            // mainBuild_Button
            // 
            this.mainBuild_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainBuild_Button.Location = new System.Drawing.Point(12, 84);
            this.mainBuild_Button.Name = "mainBuild_Button";
            this.mainBuild_Button.Size = new System.Drawing.Size(349, 71);
            this.mainBuild_Button.TabIndex = 3;
            this.mainBuild_Button.Text = "生成開始";
            this.mainBuild_Button.UseVisualStyleBackColor = true;
            this.mainBuild_Button.Click += new System.EventHandler(this.mainBuild_Button_Click);
            // 
            // mainBuild_saveFileDialog
            // 
            this.mainBuild_saveFileDialog.Filter = "実行ファイル|*.exe";
            this.mainBuild_saveFileDialog.SupportMultiDottedExtensions = true;
            this.mainBuild_saveFileDialog.Title = "保存先を指定";
            // 
            // BuildSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(376, 172);
            this.Controls.Add(this.mainBuild_Button);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuildSet";
            this.Text = "RemotePanel - バイナリ生成";
            this.Load += new System.EventHandler(this.BuildSet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mainSavePath_Textbox;
        private System.Windows.Forms.Button mainSavePath_Button;
        private System.Windows.Forms.Button mainBuild_Button;
        private System.Windows.Forms.SaveFileDialog mainBuild_saveFileDialog;
    }
}