using System;
using System.Data;
using System.Drawing;
using System.Linq;
using DevExpress.XtraEditors;

namespace UltraANetT.Control
{
    public partial class EmTable : XtraUserControl
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
            var dt = new DataTable();
            string[] colName = {"Photo", "Name", "Dept", "Role", "Creat", "CreatTime"};

            for (var i = 0; i < colName.Count(); i++)
            {
                dt.Columns.Add(new DataColumn(colName[i], typeof (object)));
            }

            dt.Rows.Add(Image.FromFile(@"Images\user.png"), "张三", "开发部", "测试员", "张某某", "2016-03-02");
            dt.Rows.Add(Image.FromFile(@"Images\user.png"), "李四", "开发部", "测试员", "张某某", "2016-03-02");

            dt.Rows.Add(Image.FromFile(@"Images\user.png"), "王五", "商务部", "配置员", "张某某", "2016-03-02");
            dt.Rows.Add(Image.FromFile(@"Images\user.png"), "赵六", "商务部", "配置员", "张某某", "2016-03-02");
            dt.Rows.Add(Image.FromFile(@"Images\user.png"), "马七", "运维部", "配置员", "张某某", "2016-03-02");
            dt.Rows.Add(Image.FromFile(@"Images\user.png"), "楚九", "运维部", "测试员", "张某某", "2016-03-02");

            dt.Rows.Add(Image.FromFile(@"Images\user.png"), "冯十", "运维部", "管理员", "张某某", "2016-03-02");
            dt.Rows.Add(Image.FromFile(@"Images\user.png"), "吴一", "管理部", "管理员", "张某某", "2016-03-02");
            gridControl.DataSource = dt;
        }
    }
}