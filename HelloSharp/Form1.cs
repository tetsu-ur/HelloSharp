using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using HelloSharp.util;
using HelloSharp.common;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace HelloSharp
{
    public partial class FormTest : Form
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public FormTest()
        {
            InitializeComponent();
        }   

        private void FormTest_Load(object sender, EventArgs e)
        {
            logger.Info(MethodBase.GetCurrentMethod().Name + " [Start]");

            // クライアントサイズを復元
            //   Loadイベントでsizeを復元させると、内容されたコントロールの位置が追随する。
            //   ただし、この場合にはこのプロパティをApplicationSettingsでバインドしないこと！
            this.Size = Properties.Settings.Default.FormTestClientSize;

            // メニューXMLで定義された項目をメニューストリップに追加
            try
            {
                MenuUtil.addMenuFromMenuXml(this.menuStrip1, @"Menu.xml");
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("メニューXMLが不正です。" + Environment.NewLine + ex.Message);
                logger.Error(ex.Message);
            }
            logger.Info(MethodBase.GetCurrentMethod().Name + " [End]");
        }

        public void clearDataGridView()
        {
            this.dataGridView1.DataSource = null;
            //this.dataGridView1.Rows.Clear();
            //this.dataGridView1.Columns.Clear();
        }

        private void FormTest_Shown(object sender, EventArgs e)
        {
            logger.Info(MethodBase.GetCurrentMethod().Name + " [Start]");

            this.textBox1.Text = PropertyLoader.GetValue("default", "message")
                                    + Environment.NewLine;

            logger.Info(MethodBase.GetCurrentMethod().Name + " [End]");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logger.Info(MethodBase.GetCurrentMethod().Name + " [Start]");

            this.textBox1.Text += DateTime.Now.ToString() + Environment.NewLine;

            logger.Info(MethodBase.GetCurrentMethod().Name + " [End]");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            logger.Info(MethodBase.GetCurrentMethod().Name + " [Start]");

            this.textBox1.Text = String.Empty;

            logger.Info(MethodBase.GetCurrentMethod().Name + " [End]");
        }

        /// <summary>
        /// 「ウィンドウ」→「閉じる」メニュークリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemCloseWindow_Click(object sender, EventArgs e)
        {

            // ウィンドウクローズ
            this.Close(); 
        }

        private void FormTest_FormClosing(object sender, FormClosingEventArgs e)
        {

            //アプリケーションの設定を保存する
            Properties.Settings.Default.FormTestLocation = FormUtil.getBounds(this).Location;
            Properties.Settings.Default.FormTestClientSize = FormUtil.getBounds(this).Size;
            Properties.Settings.Default.Save();

        }

        /// <summary>
        /// テキストボックスへのドラッグエンター処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_DragEnter(object sender, DragEventArgs e)
        {
            //コントロール内にドラッグされたとき実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.Copy;
            else
                //ファイル以外は受け付けない
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// テキストボックスへのドラッグドロップ処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_DragDrop(object sender, DragEventArgs e)
        {
            //コントロール内にドロップされたとき実行される
            //ドロップされたすべてのファイル名を取得する
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            //ListBoxに追加する
            this.textFilename.Text = fileName.First();
        }

        /// <summary>
        /// フォームサイズ変更イベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTest_ClientSizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Minimized)
            {
                // フォームが最小化の状態であればフォームを非表示にする
                this.Hide();
                // トレイリストのアイコンを表示する
                notifyIcon1.Visible = true;

                this.notifyIcon1.ShowBalloonTip(10);
            }

        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            // フォームを表示する
            this.Visible = true;
            // 現在の状態が最小化の状態であれば通常の状態に戻す
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            // フォームをアクティブにする
            this.Activate();

        }

        /// <summary>
        /// 「ファイル読み込み」ボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFileRead_Click(object sender, EventArgs e)
        {
            logger.Info(MethodBase.GetCurrentMethod().Name + " [Start]");

            // CSVファイルの内容を DataGridView に反映する
            DataGridViewUtil.setCsvForDataGridView(
                dataGridView1, textFilename.Text, checkHasTitle.Checked);

            // DataGridView のヘッダテキストのリストをコンボボックスの選択肢として設定
            String[] gridTitles = DataGridViewUtil.getColumnTitles(dataGridView1);
            List<ListControlUtil.ItemSet> itemList = new List<ListControlUtil.ItemSet>();
            
            for (int i=0; i < gridTitles.Length; i++)
            {
                itemList.Add(new ListControlUtil.ItemSet(i, gridTitles[i]));
            }

            ListControlUtil.setItemsToListControl(comboFilterItem, itemList);

            logger.Info(MethodBase.GetCurrentMethod().Name + " [End]");
        }

        /// <summary>
        /// 「クリア」ボタン押下イベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearDataGridView_Click(object sender, EventArgs e)
        {
            this.clearDataGridView();
        }

        private void comboFilterItem_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 「絞り込み」テキストボックス変更イベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textFilter_TextChanged(object sender, EventArgs e)
        {
            // 「絞り込み」で入力された文字列で DataGridView を絞り込み
            this.filterDataGridView();
        }

        /// <summary>
        /// 「絞り込み」プルダウン変更イベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboFilterItem_TextChanged(object sender, EventArgs e)
        {
            // 「絞り込み」で入力された文字列で DataGridView を絞り込み
            this.filterDataGridView();
        }

        /// <summary>
        /// 「絞り込み」で入力された文字列で DataGridView を絞り込み
        /// </summary>
        private void filterDataGridView()
        {
            // 現在の「絞り込み」コンボボックスで選択されている要素を取得
            ListControlUtil.ItemSet selectedItem =
                ((ListControlUtil.ItemSet)comboFilterItem.SelectedItem);
            int columnIndex = selectedItem.ItemValue;

            // DataView を利用して項目をフィルタリング
            DataView dataView = (DataView)dataGridView1.DataSource;
            dataView.RowFilter =
                String.Format("{0} LIKE '%{1}%'", selectedItem.ItemDisp, textFilter.Text.Trim());
        }

    }
}
