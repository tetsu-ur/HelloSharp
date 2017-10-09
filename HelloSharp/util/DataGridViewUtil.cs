using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloSharp.util
{
    /// <summary>
    /// DataGridView に関する処理群
    /// </summary>
    class DataGridViewUtil
    {

        /// <summary>
        /// 指定されたCSVファイルの内容を DataGridView に反映する
        /// </summary>
        /// <param name="dataGrid">DataGridView</param>
        /// <param name="csvfileName">CSVファイル名</param>
        /// <param name="hasTitle">１行目がタイトルか</param>
        public static void setCsvForDataGridView(
            DataGridView dataGrid, String csvfileName, Boolean hasTitle)
        {
            //列が自動的に作成されないようにする
            dataGrid.AutoGenerateColumns = true;

            // 指定されたCSVファイルを読み込み項目に分割された配列をリストに格納して取得する
            List<String[]> csvList = CSVUtil.readCsvfile2List(csvfileName);

            // CSVファイルが空なら処理終了
            if (csvList.Count == 0)
            {
                return;
            }

            // 1行目のタイトルを取得する
            String[] csvTitleLine = csvList[0];

            DataTable dataTable = new DataTable();
            DataRow dataRow;

            int i = 0;
            // DataGridView に項目ヘッダを設定
            foreach (String colTitle in csvTitleLine)
            {
                i++;
                String colTitleText = colTitle;
                if (!hasTitle)
                {
                    colTitleText = "項目" + i;
                }

                dataTable.Columns.Add(colTitleText, typeof(String));
            }

            if (hasTitle)
            {
                csvList.RemoveAt(0);
            }

            foreach (String[] cols in csvList)
            {
                dataRow = dataTable.NewRow();
                for (int j = 0; j < cols.Length; j++)
                {
                    dataRow[j] = cols[j];
                }
                dataTable.Rows.Add(dataRow);
            }
            dataGrid.DataSource = new DataView(dataTable);
        }

        /// <summary>
        /// 指定されたCSVファイルの内容を DataGridView に反映する（普通に設定）
        /// </summary>
        /// <param name="dataGrid">DataGridView</param>
        /// <param name="csvfileName">CSVファイル名</param>
        /// <param name="hasTitle">１行目がタイトルか</param>
        public static void setCsvForDataGridViewOld(
            DataGridView dataGrid, String csvfileName, Boolean hasTitle)
        {
            //列が自動的に作成されないようにする
            dataGrid.AutoGenerateColumns = false;

            // 指定されたCSVファイルを読み込み項目に分割された配列をリストに格納して取得する
            List<String[]> csvList = CSVUtil.readCsvfile2List(csvfileName);

            // CSVファイルが空なら処理終了
            if (csvList.Count == 0)
            {
                return;
            }

            // 1行目のタイトルを取得する
            String[] csvTitleLine = csvList[0];

            int i = 0;
            // DataGridView に項目ヘッダを設定
            foreach (String colTitle in csvTitleLine)
            {
                i++;
                String colTitleText = colTitle;
                if (!hasTitle)
                {
                    colTitleText = "項目" + i;
                }

                //DataGridViewTextBoxColumn列を作成する
                DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
                //名前とヘッダーを設定する
                textColumn.Name = colTitleText;
                textColumn.HeaderText = colTitleText;
                //列を追加する
                dataGrid.Columns.Add(textColumn);
            }

            if (hasTitle)
            {
                csvList.RemoveAt(0);
            }

            foreach (String[] cols in csvList)
            {
                dataGrid.Rows.Add(cols);
            }

        }

        /// <summary>
        /// タイトル文字列を取得
        /// </summary>
        /// <param name="dataGrid"></param>
        /// <returns></returns>
        public static String[] getColumnTitles(DataGridView dataGrid)
        {
            String[] headers = new String[dataGrid.Columns.Count];
            int index = 0;

            foreach (DataGridViewColumn header in dataGrid.Columns)
            {
                headers[index] = header.HeaderCell.Value.ToString();
                index++;
            }

            return headers;
        }
    }
}
