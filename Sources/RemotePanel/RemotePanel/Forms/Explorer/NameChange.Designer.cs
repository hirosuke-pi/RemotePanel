namespace RemotePanel.Forms.Explorer
{
    partial class NameChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameChange));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainBeforeName_Textbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mainAfterName_Textbox = new System.Windows.Forms.TextBox();
            this.mainChange_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.mainBeforeName_Textbox);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "今現在のファイル・フォルダ名";
            // 
            // mainBeforeName_Textbox
            // 
            this.mainBeforeName_Textbox.BackColor = System.Drawing.Color.Black;
            this.mainBeforeName_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainBeforeName_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBeforeName_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainBeforeName_Textbox.Location = new System.Drawing.Point(3, 19);
            this.mainBeforeName_Textbox.Name = "mainBeforeName_Textbox";
            this.mainBeforeName_Textbox.ReadOnly = true;
            this.mainBeforeName_Textbox.Size = new System.Drawing.Size(240, 16);
            this.mainBeforeName_Textbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mainAfterName_Textbox);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(13, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "変更後のファイル・フォルダ名";
            // 
            // mainAfterName_Textbox
            // 
            this.mainAfterName_Textbox.BackColor = System.Drawing.Color.Black;
            this.mainAfterName_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainAfterName_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainAfterName_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainAfterName_Textbox.Location = new System.Drawing.Point(3, 19);
            this.mainAfterName_Textbox.Name = "mainAfterName_Textbox";
            this.mainAfterName_Textbox.Size = new System.Drawing.Size(240, 16);
            this.mainAfterName_Textbox.TabIndex = 1;
            // 
            // mainChange_Button
            // 
            this.mainChange_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainChange_Button.Location = new System.Drawing.Point(266, 20);
            this.mainChange_Button.Name = "mainChange_Button";
            this.mainChange_Button.Size = new System.Drawing.Size(75, 94);
            this.mainChange_Button.TabIndex = 2;
            this.mainChange_Button.Text = "変更";
            this.mainChange_Button.UseVisualStyleBackColor = true;
            this.mainChange_Button.Click += new System.EventHandler(this.mainChange_Button_Click);
            // 
            // NameChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(355, 129);
            this.Controls.Add(this.mainChange_Button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NameChange";
            this.ShowInTaskbar = false;
            this.Text = "名前の変更";
            this.Load += new System.EventHandler(this.NameChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox mainBeforeName_Textbox;
        private System.Windows.Forms.TextBox mainAfterName_Textbox;
        private System.Windows.Forms.Button mainChange_Button;
    }
}