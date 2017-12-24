namespace RemotePanel
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Panel();
            this.Main_screen_pic = new System.Windows.Forms.PictureBox();
            this.Cap_panel = new System.Windows.Forms.Panel();
            this.Cap_versionShow_linklabel = new System.Windows.Forms.LinkLabel();
            this.Cap_developer_linklabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cap_mouse_Y_tx = new System.Windows.Forms.TextBox();
            this.Cap_mouse_X_tx = new System.Windows.Forms.TextBox();
            this.Cap_auto_restart_server_chb = new System.Windows.Forms.CheckBox();
            this.Cap_always_show_top_chb = new System.Windows.Forms.CheckBox();
            this.Main_tmp_chkbox = new System.Windows.Forms.CheckBox();
            this.Cap_keyinput_send_chb = new System.Windows.Forms.CheckBox();
            this.Cap_stop_capture_bt = new System.Windows.Forms.Button();
            this.Cap_start_capture_bt = new System.Windows.Forms.Button();
            this.Cap_set_all_screen_chb = new System.Windows.Forms.CheckBox();
            this.Cap_send_mouse_ckb = new System.Windows.Forms.CheckBox();
            this.Cap_set_ms_gb = new System.Windows.Forms.GroupBox();
            this.Cap_fps_num_tr = new System.Windows.Forms.TrackBar();
            this.Cmd = new System.Windows.Forms.Panel();
            this.Cmd_panel = new System.Windows.Forms.Panel();
            this.Cmd_keyboardinput_bt = new System.Windows.Forms.Button();
            this.Cmd_connection_shutdown_bt = new System.Windows.Forms.Button();
            this.Cmd_task_mgr_bt = new System.Windows.Forms.Button();
            this.Cmd_keyboard_log_bt = new System.Windows.Forms.Button();
            this.Cmd_power_send_bt = new System.Windows.Forms.Button();
            this.Cmd_start_shell = new System.Windows.Forms.Button();
            this.Cmd_explore_file_bt = new System.Windows.Forms.Button();
            this.Cmd_save_screenshot_bt = new System.Windows.Forms.Button();
            this.Cmd_send_msg_bt = new System.Windows.Forms.Button();
            this.Cmd_get_info_bt = new System.Windows.Forms.Button();
            this.Set_panel = new System.Windows.Forms.Panel();
            this.Cmd_stop_server_bt = new System.Windows.Forms.Button();
            this.Cmd_build_bin_bt = new System.Windows.Forms.Button();
            this.Cmd_start_server_bt = new System.Windows.Forms.Button();
            this.Info_panel = new System.Windows.Forms.Panel();
            this.Cap_raw_tx = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_screen_pic)).BeginInit();
            this.Cap_panel.SuspendLayout();
            this.Cap_set_ms_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cap_fps_num_tr)).BeginInit();
            this.Cmd.SuspendLayout();
            this.Cmd_panel.SuspendLayout();
            this.Set_panel.SuspendLayout();
            this.Info_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Main);
            this.panel3.Controls.Add(this.Cap_panel);
            this.panel3.Controls.Add(this.Cmd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(620, 376);
            this.panel3.TabIndex = 3;
            // 
            // Main
            // 
            this.Main.AutoScroll = true;
            this.Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main.Controls.Add(this.Main_screen_pic);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 102);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(474, 272);
            this.Main.TabIndex = 4;
            // 
            // Main_screen_pic
            // 
            this.Main_screen_pic.Cursor = System.Windows.Forms.Cursors.Default;
            this.Main_screen_pic.Location = new System.Drawing.Point(0, 0);
            this.Main_screen_pic.Name = "Main_screen_pic";
            this.Main_screen_pic.Size = new System.Drawing.Size(368, 209);
            this.Main_screen_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Main_screen_pic.TabIndex = 0;
            this.Main_screen_pic.TabStop = false;
            this.Main_screen_pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_screen_pic_MouseClick);
            this.Main_screen_pic.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Main_screen_pic_MouseDoubleClick);
            this.Main_screen_pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_screen_pic_MouseMove);
            // 
            // Cap_panel
            // 
            this.Cap_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cap_panel.Controls.Add(this.Cap_versionShow_linklabel);
            this.Cap_panel.Controls.Add(this.Cap_developer_linklabel);
            this.Cap_panel.Controls.Add(this.label2);
            this.Cap_panel.Controls.Add(this.label1);
            this.Cap_panel.Controls.Add(this.Cap_mouse_Y_tx);
            this.Cap_panel.Controls.Add(this.Cap_mouse_X_tx);
            this.Cap_panel.Controls.Add(this.Cap_auto_restart_server_chb);
            this.Cap_panel.Controls.Add(this.Cap_always_show_top_chb);
            this.Cap_panel.Controls.Add(this.Main_tmp_chkbox);
            this.Cap_panel.Controls.Add(this.Cap_keyinput_send_chb);
            this.Cap_panel.Controls.Add(this.Cap_stop_capture_bt);
            this.Cap_panel.Controls.Add(this.Cap_start_capture_bt);
            this.Cap_panel.Controls.Add(this.Cap_set_all_screen_chb);
            this.Cap_panel.Controls.Add(this.Cap_send_mouse_ckb);
            this.Cap_panel.Controls.Add(this.Cap_set_ms_gb);
            this.Cap_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cap_panel.Location = new System.Drawing.Point(0, 0);
            this.Cap_panel.Name = "Cap_panel";
            this.Cap_panel.Size = new System.Drawing.Size(474, 102);
            this.Cap_panel.TabIndex = 3;
            // 
            // Cap_versionShow_linklabel
            // 
            this.Cap_versionShow_linklabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cap_versionShow_linklabel.AutoSize = true;
            this.Cap_versionShow_linklabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Cap_versionShow_linklabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Cap_versionShow_linklabel.Location = new System.Drawing.Point(664, 74);
            this.Cap_versionShow_linklabel.Name = "Cap_versionShow_linklabel";
            this.Cap_versionShow_linklabel.Size = new System.Drawing.Size(50, 15);
            this.Cap_versionShow_linklabel.TabIndex = 21;
            this.Cap_versionShow_linklabel.TabStop = true;
            this.Cap_versionShow_linklabel.Text = "Versions";
            this.Cap_versionShow_linklabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cap_versionShow_linklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Cap_versionShow_linklabel_LinkClicked);
            // 
            // Cap_developer_linklabel
            // 
            this.Cap_developer_linklabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cap_developer_linklabel.AutoSize = true;
            this.Cap_developer_linklabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Cap_developer_linklabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Cap_developer_linklabel.Location = new System.Drawing.Point(720, 74);
            this.Cap_developer_linklabel.Name = "Cap_developer_linklabel";
            this.Cap_developer_linklabel.Size = new System.Drawing.Size(72, 15);
            this.Cap_developer_linklabel.TabIndex = 20;
            this.Cap_developer_linklabel.TabStop = true;
            this.Cap_developer_linklabel.Text = "@betacode_";
            this.Cap_developer_linklabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cap_developer_linklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Cap_developer_linklabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // Cap_mouse_Y_tx
            // 
            this.Cap_mouse_Y_tx.BackColor = System.Drawing.Color.Black;
            this.Cap_mouse_Y_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cap_mouse_Y_tx.ForeColor = System.Drawing.Color.White;
            this.Cap_mouse_Y_tx.Location = new System.Drawing.Point(586, 66);
            this.Cap_mouse_Y_tx.Name = "Cap_mouse_Y_tx";
            this.Cap_mouse_Y_tx.ReadOnly = true;
            this.Cap_mouse_Y_tx.Size = new System.Drawing.Size(55, 23);
            this.Cap_mouse_Y_tx.TabIndex = 17;
            this.Cap_mouse_Y_tx.Text = "0";
            this.Cap_mouse_Y_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cap_mouse_X_tx
            // 
            this.Cap_mouse_X_tx.BackColor = System.Drawing.Color.Black;
            this.Cap_mouse_X_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cap_mouse_X_tx.ForeColor = System.Drawing.Color.White;
            this.Cap_mouse_X_tx.Location = new System.Drawing.Point(503, 66);
            this.Cap_mouse_X_tx.Name = "Cap_mouse_X_tx";
            this.Cap_mouse_X_tx.ReadOnly = true;
            this.Cap_mouse_X_tx.Size = new System.Drawing.Size(55, 23);
            this.Cap_mouse_X_tx.TabIndex = 16;
            this.Cap_mouse_X_tx.Text = "0";
            this.Cap_mouse_X_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cap_auto_restart_server_chb
            // 
            this.Cap_auto_restart_server_chb.AutoSize = true;
            this.Cap_auto_restart_server_chb.Checked = true;
            this.Cap_auto_restart_server_chb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cap_auto_restart_server_chb.Location = new System.Drawing.Point(483, 16);
            this.Cap_auto_restart_server_chb.Name = "Cap_auto_restart_server_chb";
            this.Cap_auto_restart_server_chb.Size = new System.Drawing.Size(171, 19);
            this.Cap_auto_restart_server_chb.TabIndex = 15;
            this.Cap_auto_restart_server_chb.Text = "自動的にサーバーを再起動する";
            this.Cap_auto_restart_server_chb.UseVisualStyleBackColor = true;
            this.Cap_auto_restart_server_chb.CheckedChanged += new System.EventHandler(this.Cap_auto_restart_server_chb_CheckedChanged);
            // 
            // Cap_always_show_top_chb
            // 
            this.Cap_always_show_top_chb.AutoSize = true;
            this.Cap_always_show_top_chb.Location = new System.Drawing.Point(483, 41);
            this.Cap_always_show_top_chb.Name = "Cap_always_show_top_chb";
            this.Cap_always_show_top_chb.Size = new System.Drawing.Size(114, 19);
            this.Cap_always_show_top_chb.TabIndex = 14;
            this.Cap_always_show_top_chb.Text = "最前面に表示する";
            this.Cap_always_show_top_chb.UseVisualStyleBackColor = true;
            this.Cap_always_show_top_chb.CheckedChanged += new System.EventHandler(this.Cap_always_show_top_chb_CheckedChanged);
            // 
            // Main_tmp_chkbox
            // 
            this.Main_tmp_chkbox.AutoSize = true;
            this.Main_tmp_chkbox.Location = new System.Drawing.Point(323, 101);
            this.Main_tmp_chkbox.Name = "Main_tmp_chkbox";
            this.Main_tmp_chkbox.Size = new System.Drawing.Size(15, 14);
            this.Main_tmp_chkbox.TabIndex = 13;
            this.Main_tmp_chkbox.UseVisualStyleBackColor = true;
            // 
            // Cap_keyinput_send_chb
            // 
            this.Cap_keyinput_send_chb.AutoSize = true;
            this.Cap_keyinput_send_chb.Location = new System.Drawing.Point(326, 67);
            this.Cap_keyinput_send_chb.Name = "Cap_keyinput_send_chb";
            this.Cap_keyinput_send_chb.Size = new System.Drawing.Size(145, 19);
            this.Cap_keyinput_send_chb.TabIndex = 12;
            this.Cap_keyinput_send_chb.Text = "キーボード入力を送信する";
            this.Cap_keyinput_send_chb.UseVisualStyleBackColor = true;
            this.Cap_keyinput_send_chb.CheckedChanged += new System.EventHandler(this.Cap_keyinput_send_chb_CheckedChanged);
            // 
            // Cap_stop_capture_bt
            // 
            this.Cap_stop_capture_bt.Enabled = false;
            this.Cap_stop_capture_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cap_stop_capture_bt.Location = new System.Drawing.Point(266, 54);
            this.Cap_stop_capture_bt.Name = "Cap_stop_capture_bt";
            this.Cap_stop_capture_bt.Size = new System.Drawing.Size(51, 32);
            this.Cap_stop_capture_bt.TabIndex = 11;
            this.Cap_stop_capture_bt.Text = "停止";
            this.Cap_stop_capture_bt.UseVisualStyleBackColor = true;
            this.Cap_stop_capture_bt.Click += new System.EventHandler(this.Cap_stop_capture_bt_Click);
            // 
            // Cap_start_capture_bt
            // 
            this.Cap_start_capture_bt.Enabled = false;
            this.Cap_start_capture_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cap_start_capture_bt.Location = new System.Drawing.Point(266, 16);
            this.Cap_start_capture_bt.Name = "Cap_start_capture_bt";
            this.Cap_start_capture_bt.Size = new System.Drawing.Size(51, 32);
            this.Cap_start_capture_bt.TabIndex = 10;
            this.Cap_start_capture_bt.Text = "開始";
            this.Cap_start_capture_bt.UseVisualStyleBackColor = true;
            this.Cap_start_capture_bt.Click += new System.EventHandler(this.Cap_start_capture_bt_Click);
            // 
            // Cap_set_all_screen_chb
            // 
            this.Cap_set_all_screen_chb.AutoSize = true;
            this.Cap_set_all_screen_chb.Location = new System.Drawing.Point(326, 16);
            this.Cap_set_all_screen_chb.Name = "Cap_set_all_screen_chb";
            this.Cap_set_all_screen_chb.Size = new System.Drawing.Size(126, 19);
            this.Cap_set_all_screen_chb.TabIndex = 9;
            this.Cap_set_all_screen_chb.Text = "画面全体を表示する";
            this.Cap_set_all_screen_chb.UseVisualStyleBackColor = true;
            this.Cap_set_all_screen_chb.CheckedChanged += new System.EventHandler(this.Cap_set_all_screen_chb_CheckedChanged);
            // 
            // Cap_send_mouse_ckb
            // 
            this.Cap_send_mouse_ckb.AutoSize = true;
            this.Cap_send_mouse_ckb.Location = new System.Drawing.Point(326, 41);
            this.Cap_send_mouse_ckb.Name = "Cap_send_mouse_ckb";
            this.Cap_send_mouse_ckb.Size = new System.Drawing.Size(129, 19);
            this.Cap_send_mouse_ckb.TabIndex = 3;
            this.Cap_send_mouse_ckb.Text = "マウス情報を送信する";
            this.Cap_send_mouse_ckb.UseVisualStyleBackColor = true;
            this.Cap_send_mouse_ckb.CheckedChanged += new System.EventHandler(this.Cap_send_mouse_ckb_CheckedChanged);
            // 
            // Cap_set_ms_gb
            // 
            this.Cap_set_ms_gb.Controls.Add(this.Cap_fps_num_tr);
            this.Cap_set_ms_gb.ForeColor = System.Drawing.Color.White;
            this.Cap_set_ms_gb.Location = new System.Drawing.Point(11, 9);
            this.Cap_set_ms_gb.Name = "Cap_set_ms_gb";
            this.Cap_set_ms_gb.Size = new System.Drawing.Size(249, 77);
            this.Cap_set_ms_gb.TabIndex = 1;
            this.Cap_set_ms_gb.TabStop = false;
            this.Cap_set_ms_gb.Text = "キャプチャーミリ秒: 500ms";
            // 
            // Cap_fps_num_tr
            // 
            this.Cap_fps_num_tr.Location = new System.Drawing.Point(8, 22);
            this.Cap_fps_num_tr.Maximum = 3000;
            this.Cap_fps_num_tr.Minimum = 1;
            this.Cap_fps_num_tr.Name = "Cap_fps_num_tr";
            this.Cap_fps_num_tr.Size = new System.Drawing.Size(236, 45);
            this.Cap_fps_num_tr.TabIndex = 0;
            this.Cap_fps_num_tr.TickFrequency = 100;
            this.Cap_fps_num_tr.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Cap_fps_num_tr.Value = 500;
            this.Cap_fps_num_tr.Scroll += new System.EventHandler(this.Cap_fps_num_tr_Scroll);
            // 
            // Cmd
            // 
            this.Cmd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cmd.Controls.Add(this.Cmd_panel);
            this.Cmd.Controls.Add(this.Set_panel);
            this.Cmd.Controls.Add(this.Info_panel);
            this.Cmd.Dock = System.Windows.Forms.DockStyle.Right;
            this.Cmd.Location = new System.Drawing.Point(474, 0);
            this.Cmd.Name = "Cmd";
            this.Cmd.Size = new System.Drawing.Size(144, 374);
            this.Cmd.TabIndex = 2;
            // 
            // Cmd_panel
            // 
            this.Cmd_panel.AutoScroll = true;
            this.Cmd_panel.Controls.Add(this.Cmd_keyboardinput_bt);
            this.Cmd_panel.Controls.Add(this.Cmd_connection_shutdown_bt);
            this.Cmd_panel.Controls.Add(this.Cmd_task_mgr_bt);
            this.Cmd_panel.Controls.Add(this.Cmd_keyboard_log_bt);
            this.Cmd_panel.Controls.Add(this.Cmd_power_send_bt);
            this.Cmd_panel.Controls.Add(this.Cmd_start_shell);
            this.Cmd_panel.Controls.Add(this.Cmd_explore_file_bt);
            this.Cmd_panel.Controls.Add(this.Cmd_save_screenshot_bt);
            this.Cmd_panel.Controls.Add(this.Cmd_send_msg_bt);
            this.Cmd_panel.Controls.Add(this.Cmd_get_info_bt);
            this.Cmd_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cmd_panel.Enabled = false;
            this.Cmd_panel.Location = new System.Drawing.Point(0, 101);
            this.Cmd_panel.Name = "Cmd_panel";
            this.Cmd_panel.Size = new System.Drawing.Size(142, 247);
            this.Cmd_panel.TabIndex = 12;
            // 
            // Cmd_keyboardinput_bt
            // 
            this.Cmd_keyboardinput_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_keyboardinput_bt.Location = new System.Drawing.Point(3, 290);
            this.Cmd_keyboardinput_bt.Name = "Cmd_keyboardinput_bt";
            this.Cmd_keyboardinput_bt.Size = new System.Drawing.Size(117, 35);
            this.Cmd_keyboardinput_bt.TabIndex = 12;
            this.Cmd_keyboardinput_bt.Text = "画像送信";
            this.Cmd_keyboardinput_bt.UseVisualStyleBackColor = true;
            this.Cmd_keyboardinput_bt.Click += new System.EventHandler(this.Cmd_keyboardinput_bt_Click);
            // 
            // Cmd_connection_shutdown_bt
            // 
            this.Cmd_connection_shutdown_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_connection_shutdown_bt.Location = new System.Drawing.Point(3, 372);
            this.Cmd_connection_shutdown_bt.Name = "Cmd_connection_shutdown_bt";
            this.Cmd_connection_shutdown_bt.Size = new System.Drawing.Size(117, 35);
            this.Cmd_connection_shutdown_bt.TabIndex = 11;
            this.Cmd_connection_shutdown_bt.Text = "接続の切断";
            this.Cmd_connection_shutdown_bt.UseVisualStyleBackColor = true;
            this.Cmd_connection_shutdown_bt.Click += new System.EventHandler(this.Cmd_connection_shutdown_bt_Click);
            // 
            // Cmd_task_mgr_bt
            // 
            this.Cmd_task_mgr_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_task_mgr_bt.Location = new System.Drawing.Point(3, 167);
            this.Cmd_task_mgr_bt.Name = "Cmd_task_mgr_bt";
            this.Cmd_task_mgr_bt.Size = new System.Drawing.Size(117, 35);
            this.Cmd_task_mgr_bt.TabIndex = 10;
            this.Cmd_task_mgr_bt.Text = "タスクマネージャー";
            this.Cmd_task_mgr_bt.UseVisualStyleBackColor = true;
            this.Cmd_task_mgr_bt.Click += new System.EventHandler(this.Cmd_task_mgr_bt_Click);
            // 
            // Cmd_keyboard_log_bt
            // 
            this.Cmd_keyboard_log_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_keyboard_log_bt.Location = new System.Drawing.Point(3, 126);
            this.Cmd_keyboard_log_bt.Name = "Cmd_keyboard_log_bt";
            this.Cmd_keyboard_log_bt.Size = new System.Drawing.Size(117, 35);
            this.Cmd_keyboard_log_bt.TabIndex = 9;
            this.Cmd_keyboard_log_bt.Text = "キーボードログ";
            this.Cmd_keyboard_log_bt.UseVisualStyleBackColor = true;
            this.Cmd_keyboard_log_bt.Click += new System.EventHandler(this.Cmd_keyboard_log_bt_Click);
            // 
            // Cmd_power_send_bt
            // 
            this.Cmd_power_send_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_power_send_bt.Location = new System.Drawing.Point(3, 331);
            this.Cmd_power_send_bt.Name = "Cmd_power_send_bt";
            this.Cmd_power_send_bt.Size = new System.Drawing.Size(117, 35);
            this.Cmd_power_send_bt.TabIndex = 8;
            this.Cmd_power_send_bt.Text = "電源";
            this.Cmd_power_send_bt.UseVisualStyleBackColor = true;
            this.Cmd_power_send_bt.Click += new System.EventHandler(this.Cmd_power_send_bt_Click);
            // 
            // Cmd_start_shell
            // 
            this.Cmd_start_shell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_start_shell.Location = new System.Drawing.Point(3, 3);
            this.Cmd_start_shell.Name = "Cmd_start_shell";
            this.Cmd_start_shell.Size = new System.Drawing.Size(117, 35);
            this.Cmd_start_shell.TabIndex = 1;
            this.Cmd_start_shell.Text = "コマンドプロンプト";
            this.Cmd_start_shell.UseVisualStyleBackColor = true;
            this.Cmd_start_shell.Click += new System.EventHandler(this.Cmd_start_shell_Click);
            // 
            // Cmd_explore_file_bt
            // 
            this.Cmd_explore_file_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_explore_file_bt.Location = new System.Drawing.Point(3, 85);
            this.Cmd_explore_file_bt.Name = "Cmd_explore_file_bt";
            this.Cmd_explore_file_bt.Size = new System.Drawing.Size(117, 35);
            this.Cmd_explore_file_bt.TabIndex = 3;
            this.Cmd_explore_file_bt.Text = "ファイルエクスプローラ";
            this.Cmd_explore_file_bt.UseVisualStyleBackColor = true;
            this.Cmd_explore_file_bt.Click += new System.EventHandler(this.Cmd_send_file_bt_Click);
            // 
            // Cmd_save_screenshot_bt
            // 
            this.Cmd_save_screenshot_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_save_screenshot_bt.Location = new System.Drawing.Point(3, 208);
            this.Cmd_save_screenshot_bt.Name = "Cmd_save_screenshot_bt";
            this.Cmd_save_screenshot_bt.Size = new System.Drawing.Size(117, 35);
            this.Cmd_save_screenshot_bt.TabIndex = 5;
            this.Cmd_save_screenshot_bt.Text = "スクリーンショット";
            this.Cmd_save_screenshot_bt.UseVisualStyleBackColor = true;
            this.Cmd_save_screenshot_bt.Click += new System.EventHandler(this.Cmd_save_screenshot_bt_Click);
            // 
            // Cmd_send_msg_bt
            // 
            this.Cmd_send_msg_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_send_msg_bt.Location = new System.Drawing.Point(3, 44);
            this.Cmd_send_msg_bt.Name = "Cmd_send_msg_bt";
            this.Cmd_send_msg_bt.Size = new System.Drawing.Size(117, 35);
            this.Cmd_send_msg_bt.TabIndex = 2;
            this.Cmd_send_msg_bt.Text = "メッセージ送信";
            this.Cmd_send_msg_bt.UseVisualStyleBackColor = true;
            this.Cmd_send_msg_bt.Click += new System.EventHandler(this.Cmd_send_msg_bt_Click);
            // 
            // Cmd_get_info_bt
            // 
            this.Cmd_get_info_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_get_info_bt.Location = new System.Drawing.Point(3, 249);
            this.Cmd_get_info_bt.Name = "Cmd_get_info_bt";
            this.Cmd_get_info_bt.Size = new System.Drawing.Size(117, 35);
            this.Cmd_get_info_bt.TabIndex = 6;
            this.Cmd_get_info_bt.Text = "PC情報取得";
            this.Cmd_get_info_bt.UseVisualStyleBackColor = true;
            this.Cmd_get_info_bt.Click += new System.EventHandler(this.Cmd_get_info_bt_Click);
            // 
            // Set_panel
            // 
            this.Set_panel.Controls.Add(this.Cmd_stop_server_bt);
            this.Set_panel.Controls.Add(this.Cmd_build_bin_bt);
            this.Set_panel.Controls.Add(this.Cmd_start_server_bt);
            this.Set_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Set_panel.Location = new System.Drawing.Point(0, 0);
            this.Set_panel.Name = "Set_panel";
            this.Set_panel.Size = new System.Drawing.Size(142, 101);
            this.Set_panel.TabIndex = 11;
            // 
            // Cmd_stop_server_bt
            // 
            this.Cmd_stop_server_bt.Enabled = false;
            this.Cmd_stop_server_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_stop_server_bt.Location = new System.Drawing.Point(73, 3);
            this.Cmd_stop_server_bt.Name = "Cmd_stop_server_bt";
            this.Cmd_stop_server_bt.Size = new System.Drawing.Size(67, 43);
            this.Cmd_stop_server_bt.TabIndex = 8;
            this.Cmd_stop_server_bt.Text = "停止";
            this.Cmd_stop_server_bt.UseVisualStyleBackColor = true;
            this.Cmd_stop_server_bt.Click += new System.EventHandler(this.Cmd_stop_server_bt_Click);
            // 
            // Cmd_build_bin_bt
            // 
            this.Cmd_build_bin_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_build_bin_bt.Location = new System.Drawing.Point(2, 51);
            this.Cmd_build_bin_bt.Name = "Cmd_build_bin_bt";
            this.Cmd_build_bin_bt.Size = new System.Drawing.Size(137, 43);
            this.Cmd_build_bin_bt.TabIndex = 0;
            this.Cmd_build_bin_bt.Text = "バイナリ生成";
            this.Cmd_build_bin_bt.UseVisualStyleBackColor = true;
            this.Cmd_build_bin_bt.Click += new System.EventHandler(this.Cmd_build_bin_bt_Click);
            // 
            // Cmd_start_server_bt
            // 
            this.Cmd_start_server_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_start_server_bt.Location = new System.Drawing.Point(2, 3);
            this.Cmd_start_server_bt.Name = "Cmd_start_server_bt";
            this.Cmd_start_server_bt.Size = new System.Drawing.Size(67, 43);
            this.Cmd_start_server_bt.TabIndex = 7;
            this.Cmd_start_server_bt.Text = "起動";
            this.Cmd_start_server_bt.UseVisualStyleBackColor = true;
            this.Cmd_start_server_bt.Click += new System.EventHandler(this.Cmd_start_server_bt_Click);
            // 
            // Info_panel
            // 
            this.Info_panel.Controls.Add(this.Cap_raw_tx);
            this.Info_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Info_panel.Location = new System.Drawing.Point(0, 348);
            this.Info_panel.Name = "Info_panel";
            this.Info_panel.Size = new System.Drawing.Size(142, 24);
            this.Info_panel.TabIndex = 10;
            // 
            // Cap_raw_tx
            // 
            this.Cap_raw_tx.BackColor = System.Drawing.Color.Black;
            this.Cap_raw_tx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cap_raw_tx.ForeColor = System.Drawing.Color.White;
            this.Cap_raw_tx.Location = new System.Drawing.Point(0, 5);
            this.Cap_raw_tx.Name = "Cap_raw_tx";
            this.Cap_raw_tx.ReadOnly = true;
            this.Cap_raw_tx.Size = new System.Drawing.Size(144, 16);
            this.Cap_raw_tx.TabIndex = 5;
            this.Cap_raw_tx.Text = "停止";
            this.Cap_raw_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(620, 376);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(636, 415);
            this.Name = "MainForm";
            this.Text = "RemotePanel - v1.20-RP";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.panel3.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_screen_pic)).EndInit();
            this.Cap_panel.ResumeLayout(false);
            this.Cap_panel.PerformLayout();
            this.Cap_set_ms_gb.ResumeLayout(false);
            this.Cap_set_ms_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cap_fps_num_tr)).EndInit();
            this.Cmd.ResumeLayout(false);
            this.Cmd_panel.ResumeLayout(false);
            this.Set_panel.ResumeLayout(false);
            this.Info_panel.ResumeLayout(false);
            this.Info_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel Cap_panel;
        private System.Windows.Forms.GroupBox Cap_set_ms_gb;
        private System.Windows.Forms.TrackBar Cap_fps_num_tr;
        private System.Windows.Forms.Panel Cmd;
        private System.Windows.Forms.CheckBox Cap_send_mouse_ckb;
        private System.Windows.Forms.TextBox Cap_raw_tx;
        private System.Windows.Forms.Button Cmd_send_msg_bt;
        private System.Windows.Forms.Button Cmd_explore_file_bt;
        private System.Windows.Forms.Button Cmd_save_screenshot_bt;
        private System.Windows.Forms.Button Cmd_get_info_bt;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.PictureBox Main_screen_pic;
        private System.Windows.Forms.Panel Info_panel;
        private System.Windows.Forms.Panel Cmd_panel;
        private System.Windows.Forms.Button Cmd_start_shell;
        private System.Windows.Forms.Panel Set_panel;
        private System.Windows.Forms.Button Cmd_start_server_bt;
        private System.Windows.Forms.Button Cmd_build_bin_bt;
        private System.Windows.Forms.Button Cmd_power_send_bt;
        private System.Windows.Forms.CheckBox Cap_set_all_screen_chb;
        private System.Windows.Forms.Button Cmd_keyboard_log_bt;
        private System.Windows.Forms.Button Cmd_stop_server_bt;
        private System.Windows.Forms.Button Cmd_task_mgr_bt;
        private System.Windows.Forms.Button Cmd_connection_shutdown_bt;
        private System.Windows.Forms.Button Cap_stop_capture_bt;
        private System.Windows.Forms.Button Cap_start_capture_bt;
        private System.Windows.Forms.Button Cmd_keyboardinput_bt;
        private System.Windows.Forms.CheckBox Cap_keyinput_send_chb;
        private System.Windows.Forms.CheckBox Main_tmp_chkbox;
        private System.Windows.Forms.CheckBox Cap_auto_restart_server_chb;
        private System.Windows.Forms.CheckBox Cap_always_show_top_chb;
        private System.Windows.Forms.TextBox Cap_mouse_X_tx;
        private System.Windows.Forms.TextBox Cap_mouse_Y_tx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Cap_versionShow_linklabel;
        private System.Windows.Forms.LinkLabel Cap_developer_linklabel;
    }
}

