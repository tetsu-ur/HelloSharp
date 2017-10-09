using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloSharp.util
{
    class ListControlUtil
    {
        /// <summary>
        /// ListControl に設定する項目の要素を表すオブジェクト
        /// </summary>
        public class ItemSet
        {
            // DisplayMemberとValueMemberにはプロパティで指定する仕組み
            public String ItemDisp { get; set; }
            public int ItemValue { get; set; }

            // プロパティをコンストラクタでセット
            public ItemSet(int v, String s)
            {
                ItemDisp = s;
                ItemValue = v;
            }
        }

        /// <summary>
        /// ItemSet のリストを ListControl に設定する
        /// </summary>
        /// <param name="listControl"></param>
        /// <param name="itemList"></param>
        public static void setItemsToListControl(ListControl listControl, List<ItemSet> itemList)
        {
            // ComboBoxに表示と値をセット
            listControl.DataSource = itemList;
            listControl.DisplayMember = "ItemDisp";
            listControl.ValueMember = "ItemValue";

            // 初期値セット
            listControl.SelectedIndex = 0;
        }
    }
}
