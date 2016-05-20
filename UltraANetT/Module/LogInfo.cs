using System.Data;
using System.Linq;
using DevExpress.XtraEditors;

namespace UltraANetT.Module
{
    public partial class LogInfo : XtraUserControl
    {
        public LogInfo()
        {
            InitializeComponent();
            InitGrid();
        }

        private void InitGrid()
        {
            var dt = new DataTable();
            string[] colName = {"LogNo", "LogInName", "FromDept", "LogInTime", "LogOutTime"};

            for (var i = 0; i < colName.Count(); i++)
            {
                dt.Columns.Add(new DataColumn(colName[i], typeof (object)));
            }

            dt.Rows.Add("001", "李四", "开发部", "2015-03-27 12:40:30", "2015-03-27 16:40:30");
            dt.Rows.Add("002", "李四", "开发部", "2015-03-28 12:40:30", "2015-03-28 16:40:30");
            dt.Rows.Add("003", "李四", "开发部", "2015-03-29 12:40:30", "2015-03-29 16:40:30");
            dt.Rows.Add("004", "李四", "开发部", "2015-03-30 12:40:30", "2015-03-30 16:40:30");


            gridControl.DataSource = dt;
        }
    }
}