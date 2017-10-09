using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloSharp.util
{
    class FormUtil
    {

        /// <summary>
        /// フォームサイズを取得する。
        /// 最大化・最小化時は元のフォームサイズを取得する。
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        public static Rectangle getBounds(Form  form)
        {
            Rectangle rectangle = form.Bounds;

            if (form.WindowState != FormWindowState.Normal)
            {
                //フォームが最大化か最小化状態の時は通常状態に戻った時の位置と大きさを表示
                rectangle = form.RestoreBounds;
            }

            return rectangle;
        }
    }
}
