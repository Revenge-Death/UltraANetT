using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;

namespace FileEditor.Control
{
    public partial class Template : XtraUserControl,ITemplate
    {
        public Template()
        {
            InitializeComponent();
          
        }

        int ITemplate.GetColCountFromCANConfig()
        {
            //只取值，不做计算，同意放在Proc类中
            throw new NotImplementedException();
        }

        List<int> ITemplate.GetGrpNumByNode()
        {
            throw new NotImplementedException();
        }

        void ITemplate.LoadFile(string filePath)
        {
            spreadsheetControl1.LoadDocument(@"D:\新平台CAN相关配置表.xlsx");

            IWorkbook doc = spreadsheetControl1.Document;
            Worksheet ws = doc.Worksheets[0];
            Range r = ws.Range["A1:BX"];//数据库中读出来的CAN数
        }

        string ITemplate.SerBaudToJson(Range r)
        {
            throw new NotImplementedException();
        }

        string ITemplate.SerConfigToJson(Range r, List<int> rowList)
        {
            throw new NotImplementedException();
        }
    }
}
