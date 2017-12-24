namespace RemotePanel.Forms
{
    partial class CommandForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandForm));
            this.mainSendCMD_Button = new System.Windows.Forms.Button();
            this.mainCMDOption_Textbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSendCMD_Button
            // 
            this.mainSendCMD_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mainSendCMD_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainSendCMD_Button.Location = new System.Drawing.Point(3, 3);
            this.mainSendCMD_Button.Name = "mainSendCMD_Button";
            this.mainSendCMD_Button.Size = new System.Drawing.Size(68, 154);
            this.mainSendCMD_Button.TabIndex = 0;
            this.mainSendCMD_Button.Text = "送信";
            this.mainSendCMD_Button.UseVisualStyleBackColor = true;
            this.mainSendCMD_Button.Click += new System.EventHandler(this.mainSendCMD_Button_Click);
            // 
            // mainCMDOption_Textbox
            // 
            this.mainCMDOption_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainCMDOption_Textbox.BackColor = System.Drawing.Color.Black;
            this.mainCMDOption_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainCMDOption_Textbox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mainCMDOption_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainCMDOption_Textbox.Location = new System.Drawing.Point(6, 22);
            this.mainCMDOption_Textbox.Multiline = true;
            this.mainCMDOption_Textbox.Name = "mainCMDOption_Textbox";
            this.mainCMDOption_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainCMDOption_Textbox.Size = new System.Drawing.Size(297, 154);
            this.mainCMDOption_Textbox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.mainCMDOption_Textbox);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "コマンド送信";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainSendCMD_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(309, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 160);
            this.panel1.TabIndex = 2;
            // 
            // CommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(408, 206);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(400, 231);
            this.Name = "CommandForm";
            this.Text = "RemotePanel - コマンドプロンプト";
            this.Load += new System.EventHandler(this.CommandForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button mainSendCMD_Button;
        private System.Windows.Forms.TextBox mainCMDOption_Textbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}