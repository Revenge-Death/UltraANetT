using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using UltraANetT.Form;

namespace UltraANetT.Control
{
    public partial class EmpolyeeList : XtraUserControl
    {
        public EmpolyeeList()
        {
            InitializeComponent();
            InitGrid();
        }

        private void EmTable_Load(object sender, EventArgs e)
        {

        }

        private void InitGrid()
        {
            var dt = new DataTable();
            string[] colName = {"Name", "Dept", "Role", "Creat", "CreatTime"};

            for (var i = 0; i < colName.Count(); i++)
            {
                dt.Columns.Add(new DataColumn(colName[i], typeof (object)));
            }
            gridControl.DataSource = dt;
        }

        private void gridView_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                if (gridView.GetRowCellValue(e.RowHandle, gridView.Columns[0]) == null)
                    return;
                var Name = gridView.GetRowCellValue(e.RowHandle, gridView.Columns[0]).ToString();
                var Dept = gridView.GetRowCellValue(e.RowHandle, gridView.Columns[1]).ToString();
                var Role = gridView.GetRowCellValue(e.RowHandle, gridView.Columns[2]).ToString();
                lblName.Text = Name;
                txtDept.Text = Dept;
                txtRole.Text = Role;
                switch (Name)
                {
                    case "吴一":
                        pictEm.Image = System.Drawing.Image.FromFile(@"Images\1.jpg");
                        break;
                    case "张三":
                        pictEm.Image = System.Drawing.Image.FromFile(@"Images\2.jpeg");
                        break;
                    case "李四":
                        pictEm.Image = System.Drawing.Image.FromFile(@"Images\3.jpg");
                        break;
                    case "王五":
                        pictEm.Image = System.Drawing.Image.FromFile(@"Images\4.jpg");
                        break;
                    case "赵六":
                        pictEm.Image = System.Drawing.Image.FromFile(@"Images\5.jpg");
                        break;
                    case "马七":
                        pictEm.Image = System.Drawing.Image.FromFile(@"Images\6.jpg");
                        break;
                    case "楚九":
                        pictEm.Image = System.Drawing.Image.FromFile(@"Images\7.jpg");
                        break;
                    case "冯十":
                        pictEm.Image = System.Drawing.Image.FromFile(@"Images\8.jpg");
                        break;
                }
            }
            catch
            {
                XtraMessageBox.Show("出现测试问题，请重置列表...");
            }
        }

        private void gridView_MouseDown(object sender, MouseEventArgs e)
        {
            var hInfo = gridView.CalcHitInfo(new Point(e.X, e.Y));
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                //判断光标是否在行范围内 
                if (hInfo.InRow)
                {
                    var contact = new Contact();
                    contact.Show();
                }
            }
        }
    }
}