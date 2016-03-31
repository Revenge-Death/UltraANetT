using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UltraANetT.Control
{
    public partial class EmTable : DevExpress.XtraEditors.XtraUserControl
    {
        public EmTable()
        {
            InitializeComponent();
            InitGrid();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void InitGrid()
        {
            DataTable dt = new DataTable();
            string[] colName = new string[] {"Photo","Name", "Dept", "Role", "Creat", "CreatTime" };

            for (int i = 0; i < colName.Count(); i++)
            {
                dt.Columns.Add(new DataColumn(colName[i], typeof(object)));
            }

            dt.Rows.Add(new object[] { Image.FromFile(@"Images\user.png"), "张三", "开发部", "测试员", "张某某", "2016-03-02" });
            dt.Rows.Add(new object[] {  Image.FromFile(@"Images\user.png"), "李四", "开发部", "测试员", "张某某", "2016-03-02" });

            dt.Rows.Add(new object[] { Image.FromFile(@"Images\user.png"), "王五", "商务部", "配置员", "张某某", "2016-03-02" });
            dt.Rows.Add(new object[] { Image.FromFile(@"Images\user.png"), "赵六", "商务部", "配置员", "张某某", "2016-03-02" });
            dt.Rows.Add(new object[] { Image.FromFile(@"Images\user.png"), "马七", "运维部", "配置员", "张某某", "2016-03-02" });
            dt.Rows.Add(new object[] { Image.FromFile(@"Images\user.png"), "楚九", "运维部", "测试员", "张某某", "2016-03-02" });

            dt.Rows.Add(new object[] { Image.FromFile(@"Images\user.png"), "冯十", "运维部", "管理员", "张某某", "2016-03-02" });
            dt.Rows.Add(new object[] { Image.FromFile(@"Images\user.png"), "吴一", "管理部", "管理员", "张某某", "2016-03-02" });
            gridControl.DataSource = dt;
        }
    }
}
