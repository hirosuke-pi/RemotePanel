namespace RemotePanel.Forms.Explorer
{
    partial class StartProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartProgram));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainArgv_TextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainArgv_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.mainArgv_TextBox);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "引数";
            // 
            // mainArgv_TextBox
            // 
            this.mainArgv_TextBox.BackColor = System.Drawing.Color.Black;
            this.mainArgv_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainArgv_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainArgv_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainArgv_TextBox.Location = new System.Drawing.Point(3, 19);
            this.mainArgv_TextBox.Multiline = true;
            this.mainArgv_TextBox.Name = "mainArgv_TextBox";
            this.mainArgv_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainArgv_TextBox.Size = new System.Drawing.Size(284, 154);
            this.mainArgv_TextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainArgv_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(307, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 201);
            this.panel1.TabIndex = 1;
            // 
            // mainArgv_Button
            // 
            this.mainArgv_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mainArgv_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainArgv_Button.Location = new System.Drawing.Point(2, 21);
            this.mainArgv_Button.Name = "mainArgv_Button";
            this.mainArgv_Button.Size = new System.Drawing.Size(75, 168);
            this.mainArgv_Button.TabIndex = 0;
            this.mainArgv_Button.Text = "実行";
            this.mainArgv_Button.UseVisualStyleBackColor = true;
            this.mainArgv_Button.Click += new System.EventHandler(this.mainArgv_Button_Click);
            // 
            // StartProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(397, 201);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(413, 240);
            this.Name = "StartProgram";
            this.ShowInTaskbar = false;
            this.Text = "引数を指定して実行";
            this.Load += new System.EventHandler(this.StartProgram_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mainArgv_TextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mainArgv_Button;
    }
}