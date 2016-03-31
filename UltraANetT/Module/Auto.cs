using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;

namespace UltraANetT.Module
{
    public partial class Auto : DevExpress.XtraEditors.XtraUserControl
    {
        public Auto()
        {
            InitializeComponent();
            InitGrid();
        }
        private delegate void SetGridValue(int row);
        private bool flag = true;
        void InitGrid()
        {

            DataTable dt = new DataTable();
            string[] colName = new string[] { "testName", "testContent", "testType", "testProgress", "testTime", "testResult", "testImg", "testReport" };
            for (int i = 0; i < colName.Count(); i++)
            {
                dt.Columns.Add(new DataColumn(colName[i], typeof(object)));
            }

            dt.Rows.Add(new object[] { "TC001", "隐性输出电压", "隐性测试次数为1", 100, "", "Waiting", null, "" });
            dt.Rows.Add(new object[] { "TC002", "隐性输出电压", "隐性测试次数为1", 50, "", "Waiting", null, "" });
            dt.Rows.Add(new object[] { "TC003", "隐性输出电压", "隐性测试次数为1", 50, "", "Waiting", null, "" });
            dt.Rows.Add(new object[] { "TC004", "隐性输出电压", "隐性测试次数为1", 50, "", "Waiting", null, "" });
            dt.Rows.Add(new object[] { "TC005", "隐性输出电压", "隐性测试次数为1", 50, "", "Waiting", null, "" });
            gridControl.DataSource = dt;
        }


        private void SetDdv( int row)
        {
            if (gridControl.InvokeRequired)
            {
                SetGridValue sds = SetDdv;
                Invoke(sds, row);
            }
            else
            {
                gridView.SetRowCellValue(row, gridView.Columns[5], "Running");
                
                if (row == 3)
                {
                    gridView.SetRowCellValue(row, gridView.Columns[4], "1分00秒");
                    gridView.SetRowCellValue(row, gridView.Columns[5], "NotOk");
                    Image imgFalse = Image.FromFile(@"Images/False.png");
                    gridView.SetRowCellValue(row, gridView.Columns[6], imgFalse);
                    gridView.SetRowCellValue(row, gridView.Columns[7], "查看子报告");
                    return;
                }
                gridView.SetRowCellValue(row, gridView.Columns[3], false);
                gridView.SetRowCellValue(row, gridView.Columns[4], "1分30秒");
                gridView.SetRowCellValue(row, gridView.Columns[5], "OK");
                Image imgTure = Image.FromFile(@"Images/True.png");
                gridView.SetRowCellValue(row, gridView.Columns[6], imgTure);
                gridView.SetRowCellValue(row, gridView.Columns[7], "查看子报告");
            }

        }

        private void Progress()
        {
            int row = 0;
            SetDdv(row);
            Thread.Sleep(3000);
            row += 1;
            SetDdv(row);
            Thread.Sleep(3000);
            row += 1;
            SetDdv(row);
            Thread.Sleep(3000);
            row += 1;
            SetDdv(row);
            Thread.Sleep(3000);
            row += 1;
            SetDdv(row);
            Thread.Sleep(3000);

        }

        private void inboxItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            outboxItem.Appearance.ForeColor = Color.Black;
            inboxItem.Appearance.ForeColor = Color.Red;
        }

        private void outboxItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            inboxItem.Appearance.ForeColor = Color.Black;
            outboxItem.Appearance.ForeColor = Color.Red;
        }

        private void gridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                string result = gridView.GetRowCellValue(e.RowHandle, gridView.Columns[5]).ToString();
                if (result == "NotOk")
                {
                    e.Appearance.ForeColor = Color.Red;

                }
            }
        }

        private void pictureEdit_Click(object sender, EventArgs e)
        {
            if (flag)
            { pictureEdit.Image = Image.FromFile(@"Images/Pause.png"); flag = !flag; }
            else
            { pictureEdit.Image = Image.FromFile(@"Images/Run.png"); flag = !flag; }
            Thread test = new Thread(Progress);
            test.Start();
            gridView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            gridView.Columns[3].ColumnEdit = ProRun;
        }

        private void gridView_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            //if (e.RowHandle == 0)
            //{
            //    e.RepositoryItem = ProRun;
            //}
            //else if (e.Column.FieldName.Equals("fileTransferInProcess"))
            //{
            //    e.RepositoryItem = this.progressBarStopped;
            //}
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void pictureEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
