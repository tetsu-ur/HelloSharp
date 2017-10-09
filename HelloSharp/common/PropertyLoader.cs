using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloSharp.common
{
    /// <summary>
    /// プロパティファイルを読み込むクラス
    /// </summary>
    class PropertyLoader
    {
        /// <summary>
        /// プロパティファイルのパス
        /// 実行ファイルと同じディレクトリで、実行ファイルの拡張子が .ini のファイルを対象とする
        /// </summary>
        private static String propertyFilePath = 
              System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\"
            + System.IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".ini";

        /// <summary>
        /// .NET Framework クラスライブラリには、INI ファイルにアクセスするためのクラスは存在していません。
        /// INI ファイルへのアクセスを実現するためには、Win32 API を呼び出す必要があります。
        /// </summary>
        /// <param name="lpApplicationName"></param>
        /// <param name="lpKeyName"></param>
        /// <param name="lpDefault"></param>
        /// <param name="lpReturnedstring"></param>
        /// <param name="nSize"></param>
        /// <param name="lpFileName"></param>
        /// <see cref="https://msdn.microsoft.com/ja-jp/library/cc440869.aspx"/>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(
            string lpApplicationName,
            string lpKeyName,
            string lpDefault,
            StringBuilder lpReturnedstring,
            int nSize,
            string lpFileName);
   
        /// <summary>
        /// プロパティファイルから値を取得
        /// </summary>
        /// <param name="section">セクション名</param>
        /// <param name="key">属性名</param>
        /// <returns></returns>
        public static string GetValue(string section, string key)
        {
            StringBuilder sb = new StringBuilder(256);
            GetPrivateProfileString(section, key, string.Empty, sb, sb.Capacity, propertyFilePath);
            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="e"></param>
        /// <see cref="http://qiita.com/caf2for4/items/3078375bb8e79a5771b4"/>
        /// <returns></returns>
        public string GetName<T>(System.Linq.Expressions.Expression<Func<T>> e)
        {
            var member = (System.Linq.Expressions.MemberExpression)e.Body;
            return member.Member.Name;
        }
    }
}
