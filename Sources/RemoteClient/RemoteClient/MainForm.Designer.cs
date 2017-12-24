namespace RemoteClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.status_text = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.status_camera = new System.Windows.Forms.ToolStripButton();
            this.status_keyboard = new System.Windows.Forms.ToolStripButton();
            this.status_mouse = new System.Windows.Forms.ToolStripButton();
            this.status_file = new System.Windows.Forms.ToolStripButton();
            this.クライアントの停止SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.クライアントToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.プログラムの終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "クライアント起動";
            this.notifyIcon1.BalloonTipTitle = "クライアントを起動しました。サーバーに接続中です...";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RemoteClient";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.クライアントの停止SToolStripMenuItem,
            this.クライアントToolStripMenuItem,
            this.toolStripMenuItem2,
            this.プログラムの終了ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.バージョン情報VToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 110);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(175, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(175, 6);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_camera,
            this.status_keyboard,
            this.status_mouse,
            this.toolStripSeparator1,
            this.status_text,
            this.toolStripSeparator2,
            this.status_file});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(316, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // status_text
            // 
            this.status_text.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.status_text.BackColor = System.Drawing.Color.Black;
            this.status_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.status_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.status_text.Name = "status_text";
            this.status_text.ReadOnly = true;
            this.status_text.Size = new System.Drawing.Size(160, 28);
            this.status_text.Text = "停止";
            this.status_text.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // status_camera
            // 
            this.status_camera.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.status_camera.Image = global::RemoteClient.Properties.Resources.image_icon;
            this.status_camera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.status_camera.Name = "status_camera";
            this.status_camera.Size = new System.Drawing.Size(23, 25);
            this.status_camera.Text = "画面キャプチャー中";
            this.status_camera.Visible = false;
            // 
            // status_keyboard
            // 
            this.status_keyboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.status_keyboard.Image = global::RemoteClient.Properties.Resources.keyboard_icon;
            this.status_keyboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.status_keyboard.Name = "status_keyboard";
            this.status_keyboard.Size = new System.Drawing.Size(23, 25);
            this.status_keyboard.Text = "キーボード入力中";
            this.status_keyboard.Visible = false;
            // 
            // status_mouse
            // 
            this.status_mouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.status_mouse.Image = global::RemoteClient.Properties.Resources.mouse_icon;
            this.status_mouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.status_mouse.Name = "status_mouse";
            this.status_mouse.Size = new System.Drawing.Size(23, 25);
            this.status_mouse.Text = "マウス操作中";
            this.status_mouse.Visible = false;
            // 
            // status_file
            // 
            this.status_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.status_file.Image = global::RemoteClient.Properties.Resources.folder_icon;
            this.status_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.status_file.Name = "status_file";
            this.status_file.Size = new System.Drawing.Size(23, 25);
            this.status_file.Text = "ファイル操作中";
            this.status_file.Visible = false;
            // 
            // クライアントの停止SToolStripMenuItem
            // 
            this.クライアントの停止SToolStripMenuItem.Enabled = false;
            this.クライアントの停止SToolStripMenuItem.Image = global::RemoteClient.Properties.Resources.stop_icon;
            this.クライアントの停止SToolStripMenuItem.Name = "クライアントの停止SToolStripMenuItem";
            this.クライアントの停止SToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.クライアントの停止SToolStripMenuItem.Text = "クライアントの停止 (&S)";
            this.クライアントの停止SToolStripMenuItem.Click += new System.EventHandler(this.クライアントの停止SToolStripMenuItem_Click);
            // 
            // クライアントToolStripMenuItem
            // 
            this.クライアントToolStripMenuItem.Enabled = false;
            this.クライアントToolStripMenuItem.Image = global::RemoteClient.Properties.Resources.refresh_icon;
            this.クライアントToolStripMenuItem.Name = "クライアントToolStripMenuItem";
            this.クライアントToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.クライアントToolStripMenuItem.Text = "クライアントの再開 (&R)";
            this.クライアントToolStripMenuItem.Click += new System.EventHandler(this.クライアントToolStripMenuItem_Click);
            // 
            // プログラムの終了ToolStripMenuItem
            // 
            this.プログラムの終了ToolStripMenuItem.Image = global::RemoteClient.Properties.Resources.delete_icon;
            this.プログラムの終了ToolStripMenuItem.Name = "プログラムの終了ToolStripMenuItem";
            this.プログラムの終了ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.プログラムの終了ToolStripMenuItem.Text = "プログラムの終了 (&E)";
            this.プログラムの終了ToolStripMenuItem.Click += new System.EventHandler(this.プログラムの終了ToolStripMenuItem_Click);
            // 
            // バージョン情報VToolStripMenuItem
            // 
            this.バージョン情報VToolStripMenuItem.Image = global::RemoteClient.Properties.Resources.user_icon;
            this.バージョン情報VToolStripMenuItem.Name = "バージョン情報VToolStripMenuItem";
            this.バージョン情報VToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.バージョン情報VToolStripMenuItem.Text = "バージョン情報 (&V)";
            this.バージョン情報VToolStripMenuItem.Click += new System.EventHandler(this.バージョン情報VToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(316, 28);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem プログラムの終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem クライアントの停止SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem クライアントToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報VToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripButton status_camera;
        private System.Windows.Forms.ToolStripButton status_keyboard;
        private System.Windows.Forms.ToolStripButton status_mouse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox status_text;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton status_file;
    }
}

