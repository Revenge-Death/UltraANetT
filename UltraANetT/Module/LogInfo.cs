using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UltraANetT.Module
{
    public partial class LogInfo : DevExpress.XtraEditors.XtraUserControl
    {
        public LogInfo()
        {
            InitializeComponent();
            InitGrid();
        }

        private void InitGrid()
        {
            DataTable dt = new DataTable();
            string[] colName = new string[] { "LogNo", "LogInName", "FromDept", "LogInTime", "LogOutTime" };

            for (int i = 0; i < colName.Count(); i++)
            {
                dt.Columns.Add(new DataColumn(colName[i], typeof(object)));
            }

            dt.Rows.Add(new object[] { "001", "李四", "开发部", "2015-03-27 12:40:30", "2015-03-27 16:40:30" });
            dt.Rows.Add(new object[] { "002", "李四", "开发部", "2015-03-28 12:40:30", "2015-03-28 16:40:30" });
            dt.Rows.Add(new object[] { "003", "李四", "开发部", "2015-03-29 12:40:30", "2015-03-29 16:40:30" });
            dt.Rows.Add(new object[] { "004", "李四", "开发部", "2015-03-30 12:40:30", "2015-03-30 16:40:30" });


            gridControl.DataSource = dt;
        }
    }
}
