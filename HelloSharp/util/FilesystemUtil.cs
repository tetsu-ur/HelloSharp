using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace HelloSharp.util
{
    class FilesystemUtil
    {

        /// <summary>
        /// 「%USERPROFILE%」のパスを取得
        /// </summary>
        /// <returns></returns>
        public static String getUSERPROFILEPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }

        public static String getAppSettingFolderPath()
        {
            return FilesystemUtil.getUSERPROFILEPath() + "\\AppData\\Local\\"
                 + System.IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath) + "\\";
        }

        /// <summary>
        /// 指定されたパスをエクスプローラーで開く
        /// </summary>
        /// <param name="path"></param>
        public static void openExplorer(String path)
        {
            if (File.Exists(path))
            {
                // ファイルの場合
                ProcessStartInfo psi =　new ProcessStartInfo();
                psi.FileName = path;
                Process p = Process.Start(psi);
            }
            else if (Directory.Exists(path))
            {
                // ディレクトリの場合
                Process.Start("EXPLORER.EXE", @"/select," + path);
            }
            else
            {
                throw new Exception("ファイルパスが不正です。" + path);
            }

        }
    }
}
