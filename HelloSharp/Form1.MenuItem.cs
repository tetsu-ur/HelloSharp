using HelloSharp.util;
using System;
using System.IO;
using System.Windows.Forms;

namespace HelloSharp
{
    /// <summary>
    /// メニュー処理用パーシャルクラス
    /// </summary>
    public partial class FormTest : Form
    {

        private void ToolStripMenuItem設定ファイルを開く_Click(object sender, EventArgs e)
        {
            FilesystemUtil.openExplorer(FilesystemUtil.getAppSettingFolderPath());
        }

        private void アプリの場所を開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilesystemUtil.openExplorer(Path.GetDirectoryName(Application.ExecutablePath));
        }

    }
}
