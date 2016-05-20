using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraNavBar;

namespace UltraANetT.Module
{
    public partial class Auto : XtraUserControl
    {
        private bool flag = true;

        public Auto()
        {
            InitializeComponent();
            InitGrid();
        }

        private void InitGrid()
        {
            var dt = new DataTable();
            string[] colName =
            {
                "testName", "testContent", "testType", "testProgress", "testTime", "testResult",
                "testImg", "testReport"
            };
            for (var i = 0; i < colName.Count(); i++)
            {
                dt.Columns.Add(new DataColumn(colName[i], typeof (object)));
            }

            dt.Rows.Add("TC001", "隐性输出电压", "隐性测试次数为1", 100, "", "Waiting", null, "");
            dt.Rows.Add("TC002", "隐性输出电压", "隐性测试次数为1", 50, "", "Waiting", null, "");
            dt.Rows.Add("TC003", "隐性输出电压", "隐性测试次数为1", 50, "", "Waiting", null, "");
            dt.Rows.Add("TC004", "隐性输出电压", "隐性测试次数为1", 50, "", "Waiting", null, "");
            dt.Rows.Add("TC005", "隐性输出电压", "隐性测试次数为1", 50, "", "Waiting", null, "");
            gcAuto.DataSource = dt;
        }


        private void SetDdv(int row)
        {
            if (gcAuto.InvokeRequired)
            {
                SetGridValue sds = SetDdv;
                Invoke(sds, row);
            }
            else
            {
                gvAuto.SetRowCellValue(row, gvAuto.Columns[5], "Running");

                if (row == 3)
                {
                    gvAuto.SetRowCellValue(row, gvAuto.Columns[4], "1分00秒");
                    gvAuto.SetRowCellValue(row, gvAuto.Columns[5], "NotOk");
                    var imgFalse = Image.FromFile(@"Images/False.png");
                    gvAuto.SetRowCellValue(row, gvAuto.Columns[6], imgFalse);
                    gvAuto.SetRowCellValue(row, gvAuto.Columns[7], "查看子报告");
                    return;
                }
                gvAuto.SetRowCellValue(row, gvAuto.Columns[3], false);
                gvAuto.SetRowCellValue(row, gvAuto.Columns[4], "1分30秒");
                gvAuto.SetRowCellValue(row, gvAuto.Columns[5], "OK");
                var imgTure = Image.FromFile(@"Images/True.png");
                gvAuto.SetRowCellValue(row, gvAuto.Columns[6], imgTure);
                gvAuto.SetRowCellValue(row, gvAuto.Columns[7], "查看子报告");
            }
        }

        private void Progress()
        {
            var row = 0;
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

        private void inboxItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            outboxItem.Appearance.ForeColor = Color.Black;
            inboxItem.Appearance.ForeColor = Color.Red;
        }

        private void outboxItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            inboxItem.Appearance.ForeColor = Color.Black;
            outboxItem.Appearance.ForeColor = Color.Red;
        }

        private void gridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var result = gvAuto.GetRowCellValue(e.RowHandle, gvAuto.Columns[5]).ToString();
                if (result == "NotOk")
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void pictureEdit_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                pictureEdit.Image = Image.FromFile(@"Images/Pause.png");
                flag = !flag;
            }
            else
            {
                pictureEdit.Image = Image.FromFile(@"Images/Run.png");
                flag = !flag;
            }
            var test = new Thread(Progress);
            test.Start();
            gvAuto.OptionsView.AnimationType = GridAnimationType.AnimateAllContent;
            gvAuto.Columns[3].ColumnEdit = ProRun;
        }

        private void gridView_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
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

        private void gridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
        }

        private void pictureEdit_EditValueChanged(object sender, EventArgs e)
        {
        }

        private delegate void SetGridValue(int row);
    }
}