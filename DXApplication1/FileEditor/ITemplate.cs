using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess.Native.Excel;
using DevExpress.Spreadsheet;

namespace FileEditor
{
    public interface ITemplate
    {
        /// <summary>
        /// 得到配置表的列数（不包括波特率部分）
        /// </summary>
        /// <returns></returns>
        int GetColCountFromCANConfig();
        /// <summary>
        /// 按照节点获得分组数
        /// </summary>
        /// <returns></returns>
        List<int> GetGrpNumByNode(); 
        /// <summary>
        /// 将波特率部分转化成Json
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        string SerBaudToJson(Range r);
        /// <summary>
        /// 将配置表内容部分转化成Json 
        /// </summary>
        /// <param name="r"></param>
        /// <param name="rowList"></param>
        /// <returns></returns>
        string SerConfigToJson(Range r, List<int> rowList);

        void LoadFile(string filePath);

    }
}
