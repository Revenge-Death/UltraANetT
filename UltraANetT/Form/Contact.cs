using System;
using System.Data;
using System.Drawing;
using System.Linq;
using DevExpress.XtraEditors;

namespace UltraANetT.Form
{
    public partial class Contact : XtraForm
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
        }

        private void Contact_Load(object sender, EventArgs e)
        {
            pictEm.Image = Image.FromFile(@"Images\8.jpg");
            var dt = new DataTable();
            string[] colName = {"taskState", "taskNo", "CreatTime", "Creat"};

            for (var i = 0; i < colName.Count(); i++)
            {
                dt.Columns.Add(new DataColumn(colName[i], typeof (object)));
            }

            dt.Rows.Add("已完成任务", "AX7-CVVT-JD1-第二轮-CAN单节点", "2016-03-02", "张某某");
            dt.Rows.Add("待测试任务", "AX7-CVVT-JD1-第二轮-CAN集成", "2016-03-01", "张某某");
            gridControl.DataSource = dt;
        }
    }
}