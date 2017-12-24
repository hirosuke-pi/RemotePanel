namespace RemotePanel.Forms
{
    partial class TaskManeger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManeger));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainProcessListReload_Button = new System.Windows.Forms.Button();
            this.mainProcessExit_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainSaveFile_Button = new System.Windows.Forms.Button();
            this.mainListSavePath_Textbox = new System.Windows.Forms.TextBox();
            this.mainProcessList_ListView = new System.Windows.Forms.ListView();
            this.processName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processMemory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveProcessList_saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mainProcessListReload_Button);
            this.panel1.Controls.Add(this.mainProcessExit_Button);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 75);
            this.panel1.TabIndex = 0;
            // 
            // mainProcessListReload_Button
            // 
            this.mainProcessListReload_Button.Enabled = false;
            this.mainProcessListReload_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainProcessListReload_Button.Location = new System.Drawing.Point(8, 11);
            this.mainProcessListReload_Button.Name = "mainProcessListReload_Button";
            this.mainProcessListReload_Button.Size = new System.Drawing.Size(80, 51);
            this.mainProcessListReload_Button.TabIndex = 3;
            this.mainProcessListReload_Button.Text = "更新";
            this.mainProcessListReload_Button.UseVisualStyleBackColor = true;
            this.mainProcessListReload_Button.Click += new System.EventHandler(this.mainProcessListReload_Button_Click);
            // 
            // mainProcessExit_Button
            // 
            this.mainProcessExit_Button.Enabled = false;
            this.mainProcessExit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainProcessExit_Button.Location = new System.Drawing.Point(94, 11);
            this.mainProcessExit_Button.Name = "mainProcessExit_Button";
            this.mainProcessExit_Button.Size = new System.Drawing.Size(80, 51);
            this.mainProcessExit_Button.TabIndex = 2;
            this.mainProcessExit_Button.Text = "プロセス終了";
            this.mainProcessExit_Button.UseVisualStyleBackColor = true;
            this.mainProcessExit_Button.Click += new System.EventHandler(this.mainProcessExit_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.mainListSavePath_Textbox);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(180, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "リスト保存";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mainSaveFile_Button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(234, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(61, 37);
            this.panel2.TabIndex = 1;
            // 
            // mainSaveFile_Button
            // 
            this.mainSaveFile_Button.Enabled = false;
            this.mainSaveFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainSaveFile_Button.Location = new System.Drawing.Point(0, 4);
            this.mainSaveFile_Button.Name = "mainSaveFile_Button";
            this.mainSaveFile_Button.Size = new System.Drawing.Size(58, 23);
            this.mainSaveFile_Button.TabIndex = 3;
            this.mainSaveFile_Button.Text = "保存";
            this.mainSaveFile_Button.UseVisualStyleBackColor = true;
            this.mainSaveFile_Button.Click += new System.EventHandler(this.mainSaveFile_Button_Click);
            // 
            // mainListSavePath_Textbox
            // 
            this.mainListSavePath_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainListSavePath_Textbox.BackColor = System.Drawing.Color.Black;
            this.mainListSavePath_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainListSavePath_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainListSavePath_Textbox.Location = new System.Drawing.Point(7, 23);
            this.mainListSavePath_Textbox.Name = "mainListSavePath_Textbox";
            this.mainListSavePath_Textbox.Size = new System.Drawing.Size(221, 23);
            this.mainListSavePath_Textbox.TabIndex = 0;
            // 
            // mainProcessList_ListView
            // 
            this.mainProcessList_ListView.BackColor = System.Drawing.Color.Black;
            this.mainProcessList_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainProcessList_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.processName,
            this.processMemory,
            this.processID,
            this.processFilePath});
            this.mainProcessList_ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainProcessList_ListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainProcessList_ListView.Location = new System.Drawing.Point(0, 75);
            this.mainProcessList_ListView.Name = "mainProcessList_ListView";
            this.mainProcessList_ListView.Size = new System.Drawing.Size(491, 245);
            this.mainProcessList_ListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.mainProcessList_ListView.TabIndex = 5;
            this.mainProcessList_ListView.UseCompatibleStateImageBehavior = false;
            this.mainProcessList_ListView.View = System.Windows.Forms.View.Details;
            // 
            // processName
            // 
            this.processName.Text = "名前";
            this.processName.Width = 141;
            // 
            // processMemory
            // 
            this.processMemory.Text = "メモリー";
            this.processMemory.Width = 86;
            // 
            // processID
            // 
            this.processID.Text = "PID";
            this.processID.Width = 59;
            // 
            // processFilePath
            // 
            this.processFilePath.Text = "ファイルパス";
            this.processFilePath.Width = 179;
            // 
            // saveProcessList_saveFileDialog
            // 
            this.saveProcessList_saveFileDialog.FileName = "ProcessList.txt";
            this.saveProcessList_saveFileDialog.Filter = "テキストファイル|*.txt";
            this.saveProcessList_saveFileDialog.Title = "プロセスリストの保存";
            // 
            // TaskManeger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(491, 320);
            this.Controls.Add(this.mainProcessList_ListView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(507, 359);
            this.Name = "TaskManeger";
            this.Text = "RemotePanel - タスクマネージャ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskManeger_FormClosing);
            this.Load += new System.EventHandler(this.TaskManeger_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mainProcessExit_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button mainSaveFile_Button;
        private System.Windows.Forms.TextBox mainListSavePath_Textbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView mainProcessList_ListView;
        private System.Windows.Forms.ColumnHeader processName;
        private System.Windows.Forms.ColumnHeader processMemory;
        private System.Windows.Forms.ColumnHeader processID;
        private System.Windows.Forms.ColumnHeader processFilePath;
        private System.Windows.Forms.Button mainProcessListReload_Button;
        private System.Windows.Forms.SaveFileDialog saveProcessList_saveFileDialog;
    }
}