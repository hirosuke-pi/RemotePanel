namespace RemoteClient.Forms
{
    partial class AccessSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainGetMessage = new System.Windows.Forms.CheckBox();
            this.mainGetImage = new System.Windows.Forms.CheckBox();
            this.mainGetPCData = new System.Windows.Forms.CheckBox();
            this.mainGetCommand = new System.Windows.Forms.CheckBox();
            this.mainKeyboardLogger = new System.Windows.Forms.CheckBox();
            this.mainTaskManeger = new System.Windows.Forms.CheckBox();
            this.mainCapture = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mainCaptureMouse = new System.Windows.Forms.CheckBox();
            this.mainCaptureKeyboard = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mainFileDontAccess = new System.Windows.Forms.RadioButton();
            this.mainFileLookOnly = new System.Windows.Forms.RadioButton();
            this.mainFileAllAccess = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Button_Decide = new System.Windows.Forms.Button();
            this.Button_CloseEnd = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mainGetMessage);
            this.groupBox1.Controls.Add(this.mainGetImage);
            this.groupBox1.Controls.Add(this.mainGetPCData);
            this.groupBox1.Controls.Add(this.mainGetCommand);
            this.groupBox1.Controls.Add(this.mainKeyboardLogger);
            this.groupBox1.Controls.Add(this.mainTaskManeger);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(151, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "機能制限";
            // 
            // mainGetMessage
            // 
            this.mainGetMessage.AutoSize = true;
            this.mainGetMessage.Checked = true;
            this.mainGetMessage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mainGetMessage.Location = new System.Drawing.Point(7, 22);
            this.mainGetMessage.Name = "mainGetMessage";
            this.mainGetMessage.Size = new System.Drawing.Size(94, 19);
            this.mainGetMessage.TabIndex = 6;
            this.mainGetMessage.Text = "メッセージ受信";
            this.toolTip2.SetToolTip(this.mainGetMessage, "相手から送られてきたメッセージを表示するかどうかです");
            this.mainGetMessage.UseVisualStyleBackColor = true;
            // 
            // mainGetImage
            // 
            this.mainGetImage.AutoSize = true;
            this.mainGetImage.Checked = true;
            this.mainGetImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mainGetImage.Location = new System.Drawing.Point(111, 72);
            this.mainGetImage.Name = "mainGetImage";
            this.mainGetImage.Size = new System.Drawing.Size(74, 19);
            this.mainGetImage.TabIndex = 5;
            this.mainGetImage.Text = "画像受信";
            this.toolTip2.SetToolTip(this.mainGetImage, "相手のPCから送信された画像を表示するかどうかです");
            this.mainGetImage.UseVisualStyleBackColor = true;
            // 
            // mainGetPCData
            // 
            this.mainGetPCData.AutoSize = true;
            this.mainGetPCData.Checked = true;
            this.mainGetPCData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mainGetPCData.Location = new System.Drawing.Point(111, 47);
            this.mainGetPCData.Name = "mainGetPCData";
            this.mainGetPCData.Size = new System.Drawing.Size(88, 19);
            this.mainGetPCData.TabIndex = 4;
            this.mainGetPCData.Text = "PC情報送信";
            this.toolTip2.SetToolTip(this.mainGetPCData, "相手のPCに、このPCの情報を送信するかどうかです。以下のデータを送信します\r\nユーザー名・PC名・メモリ容量・デバイス・ファイルパス\r\n");
            this.mainGetPCData.UseVisualStyleBackColor = true;
            // 
            // mainGetCommand
            // 
            this.mainGetCommand.AutoSize = true;
            this.mainGetCommand.Location = new System.Drawing.Point(111, 22);
            this.mainGetCommand.Name = "mainGetCommand";
            this.mainGetCommand.Size = new System.Drawing.Size(84, 19);
            this.mainGetCommand.TabIndex = 3;
            this.mainGetCommand.Text = "コマンド受信";
            this.toolTip2.SetToolTip(this.mainGetCommand, "コマンドプロンプトのコマンドを受信するかどうかです");
            this.mainGetCommand.UseVisualStyleBackColor = true;
            this.mainGetCommand.CheckedChanged += new System.EventHandler(this.mainGetCommand_CheckedChanged);
            // 
            // mainKeyboardLogger
            // 
            this.mainKeyboardLogger.AutoSize = true;
            this.mainKeyboardLogger.Location = new System.Drawing.Point(7, 72);
            this.mainKeyboardLogger.Name = "mainKeyboardLogger";
            this.mainKeyboardLogger.Size = new System.Drawing.Size(87, 19);
            this.mainKeyboardLogger.TabIndex = 2;
            this.mainKeyboardLogger.Text = "キーボードログ";
            this.toolTip2.SetToolTip(this.mainKeyboardLogger, "相手のPCに、このPCで入力された文字を送信するかどうかです");
            this.mainKeyboardLogger.UseVisualStyleBackColor = true;
            this.mainKeyboardLogger.CheckedChanged += new System.EventHandler(this.mainKeyboardLogger_CheckedChanged);
            // 
            // mainTaskManeger
            // 
            this.mainTaskManeger.AutoSize = true;
            this.mainTaskManeger.Location = new System.Drawing.Point(7, 47);
            this.mainTaskManeger.Name = "mainTaskManeger";
            this.mainTaskManeger.Size = new System.Drawing.Size(98, 19);
            this.mainTaskManeger.TabIndex = 1;
            this.mainTaskManeger.Text = "タスクマネージャ";
            this.toolTip2.SetToolTip(this.mainTaskManeger, "プロセス状態を相手のPCに送信、プロセス終了コマンドの受信をするかどうかです");
            this.mainTaskManeger.UseVisualStyleBackColor = true;
            this.mainTaskManeger.CheckedChanged += new System.EventHandler(this.mainTaskManeger_CheckedChanged);
            // 
            // mainCapture
            // 
            this.mainCapture.AutoSize = true;
            this.mainCapture.Checked = true;
            this.mainCapture.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mainCapture.Location = new System.Drawing.Point(6, 22);
            this.mainCapture.Name = "mainCapture";
            this.mainCapture.Size = new System.Drawing.Size(101, 19);
            this.mainCapture.TabIndex = 2;
            this.mainCapture.Text = "画面キャプチャー";
            this.toolTip1.SetToolTip(this.mainCapture, "このPCのデスクトップの様子を閲覧を許可するかどうかです");
            this.mainCapture.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mainCaptureMouse);
            this.groupBox2.Controls.Add(this.mainCaptureKeyboard);
            this.groupBox2.Controls.Add(this.mainCapture);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "画面制限";
            // 
            // mainCaptureMouse
            // 
            this.mainCaptureMouse.AutoSize = true;
            this.mainCaptureMouse.Location = new System.Drawing.Point(6, 72);
            this.mainCaptureMouse.Name = "mainCaptureMouse";
            this.mainCaptureMouse.Size = new System.Drawing.Size(103, 19);
            this.mainCaptureMouse.TabIndex = 4;
            this.mainCaptureMouse.Text = "マウスデータ受信";
            this.toolTip1.SetToolTip(this.mainCaptureMouse, "相手から送られたマウスデータを出力するかどうかです");
            this.mainCaptureMouse.UseVisualStyleBackColor = true;
            // 
            // mainCaptureKeyboard
            // 
            this.mainCaptureKeyboard.AutoSize = true;
            this.mainCaptureKeyboard.Location = new System.Drawing.Point(6, 47);
            this.mainCaptureKeyboard.Name = "mainCaptureKeyboard";
            this.mainCaptureKeyboard.Size = new System.Drawing.Size(93, 19);
            this.mainCaptureKeyboard.TabIndex = 3;
            this.mainCaptureKeyboard.Text = "キーデータ受信";
            this.toolTip1.SetToolTip(this.mainCaptureKeyboard, "相手から送られたキーボードデータを出力するかどうかです");
            this.mainCaptureKeyboard.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mainFileDontAccess);
            this.groupBox3.Controls.Add(this.mainFileLookOnly);
            this.groupBox3.Controls.Add(this.mainFileAllAccess);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(133, 105);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ファイルエクスプローラ";
            // 
            // mainFileDontAccess
            // 
            this.mainFileDontAccess.AutoSize = true;
            this.mainFileDontAccess.Location = new System.Drawing.Point(7, 72);
            this.mainFileDontAccess.Name = "mainFileDontAccess";
            this.mainFileDontAccess.Size = new System.Drawing.Size(86, 19);
            this.mainFileDontAccess.TabIndex = 2;
            this.mainFileDontAccess.Text = "アクセス禁止";
            this.toolTip3.SetToolTip(this.mainFileDontAccess, "ファイルへのアクセスを許可しないかどうかです");
            this.mainFileDontAccess.UseVisualStyleBackColor = true;
            // 
            // mainFileLookOnly
            // 
            this.mainFileLookOnly.AutoSize = true;
            this.mainFileLookOnly.Checked = true;
            this.mainFileLookOnly.Location = new System.Drawing.Point(6, 47);
            this.mainFileLookOnly.Name = "mainFileLookOnly";
            this.mainFileLookOnly.Size = new System.Drawing.Size(104, 19);
            this.mainFileLookOnly.TabIndex = 1;
            this.mainFileLookOnly.TabStop = true;
            this.mainFileLookOnly.Text = "ファイル閲覧のみ";
            this.toolTip3.SetToolTip(this.mainFileLookOnly, "ファイルへのアクセスのみを許可するかどうかです。ファイルの変更はできません");
            this.mainFileLookOnly.UseVisualStyleBackColor = true;
            // 
            // mainFileAllAccess
            // 
            this.mainFileAllAccess.AutoSize = true;
            this.mainFileAllAccess.Location = new System.Drawing.Point(7, 22);
            this.mainFileAllAccess.Name = "mainFileAllAccess";
            this.mainFileAllAccess.Size = new System.Drawing.Size(116, 19);
            this.mainFileAllAccess.TabIndex = 0;
            this.mainFileAllAccess.Text = "全てアクセスを許可";
            this.toolTip3.SetToolTip(this.mainFileAllAccess, "ファイルへのアクセスと、ファイルの変更を許可するかどうかです。ただし、Windowsのシステムファイルの変更は許可しません");
            this.mainFileAllAccess.UseVisualStyleBackColor = true;
            this.mainFileAllAccess.CheckedChanged += new System.EventHandler(this.mainFileAllAccess_CheckedChanged);
            // 
            // Button_Decide
            // 
            this.Button_Decide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Decide.Location = new System.Drawing.Point(151, 125);
            this.Button_Decide.Name = "Button_Decide";
            this.Button_Decide.Size = new System.Drawing.Size(101, 98);
            this.Button_Decide.TabIndex = 5;
            this.Button_Decide.Text = "決定";
            this.Button_Decide.UseVisualStyleBackColor = true;
            this.Button_Decide.Click += new System.EventHandler(this.Button_Decide_Click);
            // 
            // Button_CloseEnd
            // 
            this.Button_CloseEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_CloseEnd.Location = new System.Drawing.Point(258, 125);
            this.Button_CloseEnd.Name = "Button_CloseEnd";
            this.Button_CloseEnd.Size = new System.Drawing.Size(101, 98);
            this.Button_CloseEnd.TabIndex = 6;
            this.Button_CloseEnd.Text = "終了";
            this.Button_CloseEnd.UseVisualStyleBackColor = true;
            this.Button_CloseEnd.Click += new System.EventHandler(this.Button_CloseEnd_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "画面制限";
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipTitle = "機能制限";
            // 
            // toolTip3
            // 
            this.toolTip3.ToolTipTitle = "ファイルエクスプローラ";
            // 
            // AccessSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(374, 239);
            this.ControlBox = false;
            this.Controls.Add(this.Button_CloseEnd);
            this.Controls.Add(this.Button_Decide);
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
            this.Name = "AccessSettings";
            this.ShowInTaskbar = false;
            this.Text = "RemotePanel - アクセス制限設定";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Button_Decide;
        public System.Windows.Forms.CheckBox mainCapture;
        public System.Windows.Forms.CheckBox mainCaptureMouse;
        public System.Windows.Forms.CheckBox mainCaptureKeyboard;
        public System.Windows.Forms.CheckBox mainGetCommand;
        public System.Windows.Forms.CheckBox mainKeyboardLogger;
        public System.Windows.Forms.CheckBox mainTaskManeger;
        public System.Windows.Forms.CheckBox mainGetImage;
        public System.Windows.Forms.CheckBox mainGetPCData;
        public System.Windows.Forms.CheckBox mainGetMessage;
        public System.Windows.Forms.RadioButton mainFileDontAccess;
        public System.Windows.Forms.RadioButton mainFileLookOnly;
        public System.Windows.Forms.RadioButton mainFileAllAccess;
        private System.Windows.Forms.Button Button_CloseEnd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}