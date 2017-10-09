using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HelloSharp.util
{
    class MenuUtil
    {
        public static Hashtable menuTable = new Hashtable();

        /// <summary>
        /// 指定されたファイルを開くメニュー項目を追加する
        /// </summary>
        /// <param name="parentMenuItem">親の ToolStripMenuItem</param>
        /// <param name="title"></param>
        /// <param name="path"></param>
        public static void addFileOpenMenu(ToolStripMenuItem parentMenuItem, String title, String path)
        {
            //メニュー項目を作成する
            ToolStripMenuItem menuItem = new ToolStripMenuItem();
            menuItem.Text = title;
            menuItem.Image =
                new Bitmap(IconUtil.getSmallIconFromRelatedFile(path).ToBitmap(), new Size(18, 18));
            parentMenuItem.DropDownItems.Add(menuItem);
            menuItem.Click += openFile_Click;

            // メニューアイテム、パスをディクショナリに格納
            menuTable.Add(menuItem, path);
        }

        /// <summary>
        /// セパレータを追加する
        /// </summary>
        /// <param name="parentMenuItem">親の ToolStripMenuItem</param>
        public static void addSeparator(ToolStripMenuItem parentMenuItem)
        {
            parentMenuItem.DropDownItems.Add(new ToolStripSeparator());
        }

        /// <summary>
        /// 指定されたファイルを起動する。
        /// 指定されたパスがディレクトリならエクスプローラーで表示し、ファイルなら起動する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void openFile_Click(object sender, EventArgs e)
        {
            String path = menuTable[(ToolStripMenuItem)sender].ToString();
            FilesystemUtil.openExplorer(path);
        }

        /// <summary>
        /// メニューXMLに定義されたメニューを親ToolStripMenuItemに追加
        /// </summary>
        /// <param name="menuStrip">親の ToolStripMenuItem</param>
        /// <param name="xmlPath">メニューXMLのファイルパス</param>
        public static void addMenuFromMenuXml(MenuStrip menuStrip, String xmlPath)
        {

            // XMLファイルをロード
            var xelm = XElement.Load(xmlPath);
            var menus = (
                from p in xelm.Elements("Menu")
                select p);

            // メニューXMLの定義に従ってメニュー項目を追加
            foreach (var menu in menus)
            {
                // MenuStrip に項目を追加
                ToolStripMenuItem menuItem = new ToolStripMenuItem();
                menuItem.Text = menu.Attribute("name").Value;
                menuStrip.Items.Add(menuItem);

                // menuItem に項目を追加
                foreach (var item in menu.Elements("Item"))
                {
                    if (item.HasElements)
                    {
                        MenuUtil.addFileOpenMenu(
                            menuItem, 
                            item.Element("Title").Value, 
                            item.Element("Path").Value);
                    }
                    else
                    {
                        MenuUtil.addSeparator(menuItem);
                    }
                }
            }

        }
    }
}
