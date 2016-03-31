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
    public partial class Department : DevExpress.XtraEditors.XtraUserControl
    {
        public Department()
        {
            InitializeComponent();
            InitGrid();
        }

        private void InitGrid()
        {
            DataTable dt = new DataTable();
            string[] colName = new string[] { "DeptName", "DeptMaster", "DeptNum", "DeptDetail" };

            for (int i = 0; i < colName.Count(); i++)
            {
                dt.Columns.Add(new DataColumn(colName[i], typeof(object)));
            }

            dt.Rows.Add(new object[] { "开发部", "张三", "15", "负责开发工作" });
            dt.Rows.Add(new object[] { "管理部", "李四", "3", "负责管理工作" });
            dt.Rows.Add(new object[] { "人事部", "王五", "8", "负责人事工作" });
            dt.Rows.Add(new object[] { "商务部", "赵六", "20", "负责商务工作" });

            gridDepartment.DataSource = dt;
        }
    }
}
