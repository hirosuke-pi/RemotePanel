using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RemoteClient.Forms
{
    public partial class AccessSettings : Form
    {
        public AccessSettings()
        {
            InitializeComponent();
        }

        public bool close_flag = false;
        private void Button_Decide_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("この設定で遠隔操作できるようにしますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Close();
        }

        private void Button_CloseEnd_Click(object sender, EventArgs e)
        {
            close_flag = true;
            Close();
        }

        private void mainTaskManeger_CheckedChanged(object sender, EventArgs e)
        {
            if (mainTaskManeger.Checked)
            {
                var result = MessageBox.Show("タスクマネージャを許可すると、自由にプロセスの閲覧・停止させられます。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result != DialogResult.Yes) mainTaskManeger.Checked = false;
            }
        }

        private void mainKeyboardLogger_CheckedChanged(object sender, EventArgs e)
        {
            if (mainKeyboardLogger.Checked)
            {
                var result = MessageBox.Show("キーボードログを許可すると、キーボードの入力内容が送信されます。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result != DialogResult.Yes) mainKeyboardLogger.Checked = false;
            }
        }

        private void mainGetCommand_CheckedChanged(object sender, EventArgs e)
        {
            if (mainGetCommand.Checked)
            {
                var result = MessageBox.Show("コマンドプロンプトを許可すると、送信されたコマンドを実行させられます。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result != DialogResult.Yes) mainGetCommand.Checked = false;
            }
        }

        private void mainFileAllAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (mainFileAllAccess.Checked)
            {
                var result = MessageBox.Show("ファイル全アクセスを許可すると、自由にファイルの削除・移動・名前変更、アップロード・ダウンロードされます。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result != DialogResult.Yes) mainFileLookOnly.Checked = true;
            }
        }
    }
}
