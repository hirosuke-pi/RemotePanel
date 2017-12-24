namespace RemotePanel.Forms.Explorer
{
    partial class MainExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainExplorer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuGoComboboxPath_Button = new System.Windows.Forms.Button();
            this.menuDriveslist_Combobox = new System.Windows.Forms.ComboBox();
            this.menuGoNext_Button = new System.Windows.Forms.Button();
            this.menuFilePathList_Combobox = new System.Windows.Forms.ComboBox();
            this.menuGoback_Button = new System.Windows.Forms.Button();
            this.mainFileListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.一覧を更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ファイルをダウンロードToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.パスをコピーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.切り取りToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.コピーToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.貼り付けToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前変更ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.一覧更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.プログラムの実行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.引数を指定して実行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewIcon_imageList = new System.Windows.Forms.ImageList(this.components);
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ここにファイルをアップロードToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ファイルをダウンロードToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ファイルパスをコピーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.切り取りToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.コピーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼り付けToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ファイルを削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前変更ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一覧の更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.実行SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.プログラムを実行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.引数を指定して事項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainUploadFile_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainDownloadFile_saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuGoComboboxPath_Button);
            this.panel1.Controls.Add(this.menuDriveslist_Combobox);
            this.panel1.Controls.Add(this.menuGoNext_Button);
            this.panel1.Controls.Add(this.menuFilePathList_Combobox);
            this.panel1.Controls.Add(this.menuGoback_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 48);
            this.panel1.TabIndex = 0;
            // 
            // menuGoComboboxPath_Button
            // 
            this.menuGoComboboxPath_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuGoComboboxPath_Button.Location = new System.Drawing.Point(136, 12);
            this.menuGoComboboxPath_Button.Name = "menuGoComboboxPath_Button";
            this.menuGoComboboxPath_Button.Size = new System.Drawing.Size(56, 23);
            this.menuGoComboboxPath_Button.TabIndex = 5;
            this.menuGoComboboxPath_Button.Text = "更新";
            this.menuGoComboboxPath_Button.UseVisualStyleBackColor = true;
            this.menuGoComboboxPath_Button.Click += new System.EventHandler(this.menuGoComboboxPath_Button_Click);
            // 
            // menuDriveslist_Combobox
            // 
            this.menuDriveslist_Combobox.BackColor = System.Drawing.Color.Black;
            this.menuDriveslist_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuDriveslist_Combobox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.menuDriveslist_Combobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuDriveslist_Combobox.FormattingEnabled = true;
            this.menuDriveslist_Combobox.Location = new System.Drawing.Point(198, 12);
            this.menuDriveslist_Combobox.Name = "menuDriveslist_Combobox";
            this.menuDriveslist_Combobox.Size = new System.Drawing.Size(56, 23);
            this.menuDriveslist_Combobox.TabIndex = 4;
            this.menuDriveslist_Combobox.SelectedIndexChanged += new System.EventHandler(this.menuDriveslist_Combobox_SelectedIndexChanged);
            // 
            // menuGoNext_Button
            // 
            this.menuGoNext_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuGoNext_Button.Location = new System.Drawing.Point(74, 12);
            this.menuGoNext_Button.Name = "menuGoNext_Button";
            this.menuGoNext_Button.Size = new System.Drawing.Size(56, 23);
            this.menuGoNext_Button.TabIndex = 3;
            this.menuGoNext_Button.Text = "次へ→";
            this.menuGoNext_Button.UseVisualStyleBackColor = true;
            this.menuGoNext_Button.Click += new System.EventHandler(this.menuGoNext_Button_Click);
            // 
            // menuFilePathList_Combobox
            // 
            this.menuFilePathList_Combobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuFilePathList_Combobox.BackColor = System.Drawing.Color.Black;
            this.menuFilePathList_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuFilePathList_Combobox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.menuFilePathList_Combobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuFilePathList_Combobox.FormattingEnabled = true;
            this.menuFilePathList_Combobox.Location = new System.Drawing.Point(260, 12);
            this.menuFilePathList_Combobox.Name = "menuFilePathList_Combobox";
            this.menuFilePathList_Combobox.Size = new System.Drawing.Size(296, 23);
            this.menuFilePathList_Combobox.TabIndex = 2;
            // 
            // menuGoback_Button
            // 
            this.menuGoback_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuGoback_Button.Location = new System.Drawing.Point(12, 12);
            this.menuGoback_Button.Name = "menuGoback_Button";
            this.menuGoback_Button.Size = new System.Drawing.Size(56, 23);
            this.menuGoback_Button.TabIndex = 1;
            this.menuGoback_Button.Text = "←戻る";
            this.menuGoback_Button.UseVisualStyleBackColor = true;
            this.menuGoback_Button.Click += new System.EventHandler(this.menuGoback_Button_Click);
            // 
            // mainFileListView
            // 
            this.mainFileListView.AllowDrop = true;
            this.mainFileListView.BackColor = System.Drawing.Color.Black;
            this.mainFileListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainFileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.mainFileListView.ContextMenuStrip = this.contextMenuStrip1;
            this.mainFileListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFileListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainFileListView.Location = new System.Drawing.Point(0, 71);
            this.mainFileListView.Name = "mainFileListView";
            this.mainFileListView.Size = new System.Drawing.Size(568, 281);
            this.mainFileListView.SmallImageList = this.listViewIcon_imageList;
            this.mainFileListView.TabIndex = 4;
            this.mainFileListView.UseCompatibleStateImageBehavior = false;
            this.mainFileListView.View = System.Windows.Forms.View.Details;
            this.mainFileListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mainFileListView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名前";
            this.columnHeader1.Width = 231;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "更新日時";
            this.columnHeader2.Width = 122;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "種類";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "サイズ";
            this.columnHeader4.Width = 107;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一覧を更新ToolStripMenuItem,
            this.ファイルをダウンロードToolStripMenuItem1,
            this.パスをコピーToolStripMenuItem,
            this.toolStripMenuItem3,
            this.切り取りToolStripMenuItem1,
            this.コピーToolStripMenuItem1,
            this.貼り付けToolStripMenuItem1,
            this.削除ToolStripMenuItem,
            this.名前変更ToolStripMenuItem1,
            this.toolStripMenuItem4,
            this.一覧更新ToolStripMenuItem,
            this.toolStripMenuItem5,
            this.プログラムの実行ToolStripMenuItem,
            this.引数を指定して実行ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 264);
            this.contextMenuStrip1.Text = "プロパティ";
            // 
            // 一覧を更新ToolStripMenuItem
            // 
            this.一覧を更新ToolStripMenuItem.Name = "一覧を更新ToolStripMenuItem";
            this.一覧を更新ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.一覧を更新ToolStripMenuItem.Text = "ここにファイルをアップロード";
            this.一覧を更新ToolStripMenuItem.Click += new System.EventHandler(this.ここにファイルをアップロードToolStripMenuItem_Click);
            // 
            // ファイルをダウンロードToolStripMenuItem1
            // 
            this.ファイルをダウンロードToolStripMenuItem1.Name = "ファイルをダウンロードToolStripMenuItem1";
            this.ファイルをダウンロードToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.ファイルをダウンロードToolStripMenuItem1.Text = "ファイルをダウンロード";
            this.ファイルをダウンロードToolStripMenuItem1.Click += new System.EventHandler(this.ファイルをダウンロードToolStripMenuItem_Click);
            // 
            // パスをコピーToolStripMenuItem
            // 
            this.パスをコピーToolStripMenuItem.Name = "パスをコピーToolStripMenuItem";
            this.パスをコピーToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.パスをコピーToolStripMenuItem.Text = "パスをコピー";
            this.パスをコピーToolStripMenuItem.Click += new System.EventHandler(this.ファイルパスをコピーToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(190, 6);
            // 
            // 切り取りToolStripMenuItem1
            // 
            this.切り取りToolStripMenuItem1.Name = "切り取りToolStripMenuItem1";
            this.切り取りToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.切り取りToolStripMenuItem1.Text = "切り取り";
            this.切り取りToolStripMenuItem1.Click += new System.EventHandler(this.切り取りToolStripMenuItem_Click);
            // 
            // コピーToolStripMenuItem1
            // 
            this.コピーToolStripMenuItem1.Name = "コピーToolStripMenuItem1";
            this.コピーToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.コピーToolStripMenuItem1.Text = "コピー";
            this.コピーToolStripMenuItem1.Click += new System.EventHandler(this.コピーToolStripMenuItem_Click);
            // 
            // 貼り付けToolStripMenuItem1
            // 
            this.貼り付けToolStripMenuItem1.Name = "貼り付けToolStripMenuItem1";
            this.貼り付けToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.貼り付けToolStripMenuItem1.Text = "貼り付け";
            this.貼り付けToolStripMenuItem1.Click += new System.EventHandler(this.貼り付けToolStripMenuItem_Click);
            // 
            // 削除ToolStripMenuItem
            // 
            this.削除ToolStripMenuItem.Name = "削除ToolStripMenuItem";
            this.削除ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.削除ToolStripMenuItem.Text = "削除";
            this.削除ToolStripMenuItem.Click += new System.EventHandler(this.ファイルを削除ToolStripMenuItem_Click);
            // 
            // 名前変更ToolStripMenuItem1
            // 
            this.名前変更ToolStripMenuItem1.Name = "名前変更ToolStripMenuItem1";
            this.名前変更ToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.名前変更ToolStripMenuItem1.Text = "名前変更";
            this.名前変更ToolStripMenuItem1.Click += new System.EventHandler(this.名前変更ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(190, 6);
            // 
            // 一覧更新ToolStripMenuItem
            // 
            this.一覧更新ToolStripMenuItem.Name = "一覧更新ToolStripMenuItem";
            this.一覧更新ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.一覧更新ToolStripMenuItem.Text = "一覧更新";
            this.一覧更新ToolStripMenuItem.Click += new System.EventHandler(this.一覧の更新ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(190, 6);
            // 
            // プログラムの実行ToolStripMenuItem
            // 
            this.プログラムの実行ToolStripMenuItem.Name = "プログラムの実行ToolStripMenuItem";
            this.プログラムの実行ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.プログラムの実行ToolStripMenuItem.Text = "プログラムの実行";
            this.プログラムの実行ToolStripMenuItem.Click += new System.EventHandler(this.プログラムを実行ToolStripMenuItem_Click);
            // 
            // 引数を指定して実行ToolStripMenuItem
            // 
            this.引数を指定して実行ToolStripMenuItem.Name = "引数を指定して実行ToolStripMenuItem";
            this.引数を指定して実行ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.引数を指定して実行ToolStripMenuItem.Text = "引数を指定して実行";
            this.引数を指定して実行ToolStripMenuItem.Click += new System.EventHandler(this.引数を指定して事項ToolStripMenuItem_Click);
            // 
            // listViewIcon_imageList
            // 
            this.listViewIcon_imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listViewIcon_imageList.ImageStream")));
            this.listViewIcon_imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.listViewIcon_imageList.Images.SetKeyName(0, "file_icon.png");
            this.listViewIcon_imageList.Images.SetKeyName(1, "folder_icon.png");
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ここにファイルをアップロードToolStripMenuItem,
            this.ファイルをダウンロードToolStripMenuItem,
            this.toolStripMenuItem2,
            this.ファイルパスをコピーToolStripMenuItem});
            this.ファイルToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(70, 19);
            this.ファイルToolStripMenuItem.Text = "ファイル (&F)";
            // 
            // ここにファイルをアップロードToolStripMenuItem
            // 
            this.ここにファイルをアップロードToolStripMenuItem.Name = "ここにファイルをアップロードToolStripMenuItem";
            this.ここにファイルをアップロードToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ここにファイルをアップロードToolStripMenuItem.Text = "ここにファイルをアップロード (&U)";
            this.ここにファイルをアップロードToolStripMenuItem.Click += new System.EventHandler(this.ここにファイルをアップロードToolStripMenuItem_Click);
            // 
            // ファイルをダウンロードToolStripMenuItem
            // 
            this.ファイルをダウンロードToolStripMenuItem.Name = "ファイルをダウンロードToolStripMenuItem";
            this.ファイルをダウンロードToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ファイルをダウンロードToolStripMenuItem.Text = "ファイルをダウンロード (&D)";
            this.ファイルをダウンロードToolStripMenuItem.Click += new System.EventHandler(this.ファイルをダウンロードToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(209, 6);
            // 
            // ファイルパスをコピーToolStripMenuItem
            // 
            this.ファイルパスをコピーToolStripMenuItem.Name = "ファイルパスをコピーToolStripMenuItem";
            this.ファイルパスをコピーToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ファイルパスをコピーToolStripMenuItem.Text = "パスをコピー (&C)";
            this.ファイルパスをコピーToolStripMenuItem.Click += new System.EventHandler(this.ファイルパスをコピーToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.表示VToolStripMenuItem,
            this.実行SToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 23);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.切り取りToolStripMenuItem,
            this.コピーToolStripMenuItem,
            this.貼り付けToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ファイルを削除ToolStripMenuItem,
            this.名前変更ToolStripMenuItem});
            this.編集EToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.編集EToolStripMenuItem.Text = "編集 (&E)";
            // 
            // 切り取りToolStripMenuItem
            // 
            this.切り取りToolStripMenuItem.Name = "切り取りToolStripMenuItem";
            this.切り取りToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.切り取りToolStripMenuItem.Text = "切り取り (&T)";
            this.切り取りToolStripMenuItem.Click += new System.EventHandler(this.切り取りToolStripMenuItem_Click);
            // 
            // コピーToolStripMenuItem
            // 
            this.コピーToolStripMenuItem.Name = "コピーToolStripMenuItem";
            this.コピーToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.コピーToolStripMenuItem.Text = "コピー (&C)";
            this.コピーToolStripMenuItem.Click += new System.EventHandler(this.コピーToolStripMenuItem_Click);
            // 
            // 貼り付けToolStripMenuItem
            // 
            this.貼り付けToolStripMenuItem.Name = "貼り付けToolStripMenuItem";
            this.貼り付けToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.貼り付けToolStripMenuItem.Text = "貼り付け (&P)";
            this.貼り付けToolStripMenuItem.Click += new System.EventHandler(this.貼り付けToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // ファイルを削除ToolStripMenuItem
            // 
            this.ファイルを削除ToolStripMenuItem.Name = "ファイルを削除ToolStripMenuItem";
            this.ファイルを削除ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ファイルを削除ToolStripMenuItem.Text = "削除 (&D)";
            this.ファイルを削除ToolStripMenuItem.Click += new System.EventHandler(this.ファイルを削除ToolStripMenuItem_Click);
            // 
            // 名前変更ToolStripMenuItem
            // 
            this.名前変更ToolStripMenuItem.Name = "名前変更ToolStripMenuItem";
            this.名前変更ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.名前変更ToolStripMenuItem.Text = "名前変更 (&M)";
            this.名前変更ToolStripMenuItem.Click += new System.EventHandler(this.名前変更ToolStripMenuItem_Click);
            // 
            // 表示VToolStripMenuItem
            // 
            this.表示VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一覧の更新ToolStripMenuItem});
            this.表示VToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem";
            this.表示VToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.表示VToolStripMenuItem.Text = "表示 (&V)";
            // 
            // 一覧の更新ToolStripMenuItem
            // 
            this.一覧の更新ToolStripMenuItem.Name = "一覧の更新ToolStripMenuItem";
            this.一覧の更新ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.一覧の更新ToolStripMenuItem.Text = "一覧の更新 (&L)";
            this.一覧の更新ToolStripMenuItem.Click += new System.EventHandler(this.一覧の更新ToolStripMenuItem_Click);
            // 
            // 実行SToolStripMenuItem
            // 
            this.実行SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.プログラムを実行ToolStripMenuItem,
            this.引数を指定して事項ToolStripMenuItem});
            this.実行SToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.実行SToolStripMenuItem.Name = "実行SToolStripMenuItem";
            this.実行SToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.実行SToolStripMenuItem.Text = "実行 (&S)";
            // 
            // プログラムを実行ToolStripMenuItem
            // 
            this.プログラムを実行ToolStripMenuItem.Name = "プログラムを実行ToolStripMenuItem";
            this.プログラムを実行ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.プログラムを実行ToolStripMenuItem.Text = "プログラムを実行 (&S)";
            this.プログラムを実行ToolStripMenuItem.Click += new System.EventHandler(this.プログラムを実行ToolStripMenuItem_Click);
            // 
            // 引数を指定して事項ToolStripMenuItem
            // 
            this.引数を指定して事項ToolStripMenuItem.Name = "引数を指定して事項ToolStripMenuItem";
            this.引数を指定して事項ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.引数を指定して事項ToolStripMenuItem.Text = "引数を指定して実行 (&A)";
            this.引数を指定して事項ToolStripMenuItem.Click += new System.EventHandler(this.引数を指定して事項ToolStripMenuItem_Click);
            // 
            // mainUploadFile_openFileDialog
            // 
            this.mainUploadFile_openFileDialog.SupportMultiDottedExtensions = true;
            this.mainUploadFile_openFileDialog.Title = "アップロードするファイルを選択";
            // 
            // mainDownloadFile_saveFileDialog
            // 
            this.mainDownloadFile_saveFileDialog.SupportMultiDottedExtensions = true;
            this.mainDownloadFile_saveFileDialog.Title = "ダウンロード保存先を指定";
            // 
            // MainExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(568, 352);
            this.Controls.Add(this.mainFileListView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(584, 391);
            this.Name = "MainExplorer";
            this.Text = "RemotePanel - ファイルエクスプローラ (接続中...)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainExplorer_FormClosing);
            this.Load += new System.EventHandler(this.MainExplorer_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox menuFilePathList_Combobox;
        private System.Windows.Forms.Button menuGoback_Button;
        private System.Windows.Forms.ListView mainFileListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ここにファイルをアップロードToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ファイルをダウンロードToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ファイルを削除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 実行SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem プログラムを実行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 引数を指定して事項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前変更ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem コピーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 切り取りToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表示VToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 一覧の更新ToolStripMenuItem;
        private System.Windows.Forms.Button menuGoNext_Button;
        private System.Windows.Forms.ComboBox menuDriveslist_Combobox;
        private System.Windows.Forms.ImageList listViewIcon_imageList;
        private System.Windows.Forms.ToolStripMenuItem 貼り付けToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog mainUploadFile_openFileDialog;
        private System.Windows.Forms.Button menuGoComboboxPath_Button;
        private System.Windows.Forms.SaveFileDialog mainDownloadFile_saveFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ファイルパスをコピーToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 一覧を更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ファイルをダウンロードToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem パスをコピーToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 切り取りToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem コピーToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 貼り付けToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 削除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前変更ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 一覧更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem プログラムの実行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 引数を指定して実行ToolStripMenuItem;
    }
}