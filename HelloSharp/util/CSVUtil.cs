using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSharp.util
{
    class CSVUtil
    {
        /// <summary>
        /// 指定されたCSVファイルを読み込み項目に分割された配列をリストに格納して取得する
        /// </summary>
        /// <param name="csvfileName">CSVファイル名</param>
        /// <returns></returns>
        public static List<String[]> readCsvfile2List(String csvfileName)
        {
            List<String[]> csvArray = new List<string[]>();

            TextFieldParser parser = new TextFieldParser(csvfileName);
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(","); // 区切り文字はコンマ
            while (!parser.EndOfData)
            {
                string[] cols = parser.ReadFields(); // 1行読み込み
                csvArray.Add(cols);
            }

            return csvArray;
        }
    }
}
