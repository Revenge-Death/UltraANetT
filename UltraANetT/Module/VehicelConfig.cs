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
    public partial class VehicelConfig : DevExpress.XtraEditors.XtraUserControl
    {
        public VehicelConfig()
        {
            InitializeComponent();
            InitGrid();
         
        }

        private void InitGrid()
        {
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            DataTable dt = new DataTable();
            string[] colName = new string[] { "Car", "Set", "Stage", "CreatTime", "CreatPsn", "GiveSetPsn", "Depart", "GiveTime", "GiveDepart" };

            for (int i = 0; i < colName.Count(); i++)
            {
                dt.Columns.Add(new DataColumn(colName[i], typeof(object)));
            }


            dt.Rows.Add(new object[] { "AX7", "CVVT", "JD1", "2016-03-02", "张某某", "张三", "测试部 ", "2016-03-02", "2016-03-02" });
            dt.Rows.Add(new object[] { "AX7", "CVVT", "JD1", "2016-03-02", "张某某", "李四", "开发部 ", "2016-03-02", "2016-03-02" });
            dt.Rows.Add(new object[] { "AX7", "CVVT", "JD1", "2016-03-02", "张某某", "王五", "测试部 ", "2016-03-02", "2016-03-02" });
            dt.Rows.Add(new object[] { "AX7", "CVVT", "JD1", "2016-03-02", "张某某", "赵六", "测试部 ", "2016-03-02", "2016-03-02" });
            dt.Rows.Add(new object[] { "AX7", "CVVT", "JD1", "2016-03-02", "张某某", "侯七", "测试部 ", "2016-03-02", "2016-03-02" });
            dt.Rows.Add(new object[] { "AX7", "CVVT", "JD1", "2016-03-02", "张某某", "马八", "测试部 ", "2016-03-02", "2016-03-02" });

            gridControl.DataSource = dt;
        }

        private void vehicelTree_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
