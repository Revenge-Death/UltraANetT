using System;
using System.Data;
using System.Linq;
using DevExpress.XtraEditors;

namespace UltraANetT.Module
{
    public partial class Manual : XtraUserControl
    {
        public Manual()
        {
            InitializeComponent();
            InitGrid();
        }

        private void InitGrid()
        {
            var dt = new DataTable();
            string[] colName = {"ManualName", "Content", "Type"};

            for (var i = 0; i < colName.Count(); i++)
            {
                dt.Columns.Add(new DataColumn(colName[i], typeof (object)));
            }

            dt.Rows.Add("TC001", "隐形输出电压", "手动测试一次");
            dt.Rows.Add("TC002", "显性输出电压", "手动测试一次");
            dt.Rows.Add("TC003", "内阻正常", "手动测试三次");
            dt.Rows.Add("TC004", "内阻断电", "手动测试两次");

            gridControl1.DataSource = dt;
        }

        private void lblNext_Click(object sender, EventArgs e)
        {
            secStep.PageEnabled = true;
            tabManual.SelectedTabPage = secStep;
            firstStep.PageEnabled = false;
        }

        private void linkBack_Click(object sender, EventArgs e)
        {
            firstStep.PageEnabled = true;
            tabManual.SelectedTabPage = firstStep;
            secStep.PageEnabled = false;
        }

        private void linkNext_Click(object sender, EventArgs e)
        {
            trdStep.PageEnabled = true;
            tabManual.SelectedTabPage = trdStep;
            secStep.PageEnabled = false;
        }

        private void lkThirdBack_Click(object sender, EventArgs e)
        {
            secStep.PageEnabled = true;
            tabManual.SelectedTabPage = secStep;
            trdStep.PageEnabled = false;
        }

        private void lkThirdNext_Click(object sender, EventArgs e)
        {
            fourStep.PageEnabled = true;
            tabManual.SelectedTabPage = fourStep;
            trdStep.PageEnabled = false;
        }

        private void lkFourBack_Click(object sender, EventArgs e)
        {
            trdStep.PageEnabled = true;
            tabManual.SelectedTabPage = trdStep;
            fourStep.PageEnabled = false;
        }

        private void lkFourNext_Click(object sender, EventArgs e)
        {
            fiveStep.PageEnabled = true;
            tabManual.SelectedTabPage = fiveStep;
            fourStep.PageEnabled = false;
        }

        private void lkFiveBack_Click(object sender, EventArgs e)
        {
            fourStep.PageEnabled = true;
            tabManual.SelectedTabPage = fourStep;
            fiveStep.PageEnabled = false;
        }
    }
}