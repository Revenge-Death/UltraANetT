using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using UltraANetT.Control;
using UltraANetT.Form;

namespace UltraANetT.Module
{
    public partial class Employee : XtraUserControl
    {
        private XtraUserControl ContainerEm;
        private int flag;

        private bool isInit;

        public Employee()
        {
            InitializeComponent();
        }

        private void rbDept_CheckedChanged(object sender, EventArgs e)
        {
            //switch (flag)
            //{
            //    case 0:
            //        ((EmpolyeeList) ContainerEm).gridView.Columns["Dept"].GroupIndex = 0;
            //        break;
            //    case 1:
            //        ((EmTable) ContainerEm).layoutView.Columns["Dept"].GroupIndex = 0;
            //        break;
            //}
        }

        private void rbRole_CheckedChanged(object sender, EventArgs e)
        {
            //switch (flag)
            //{
            //    case 0:
            //        ((EmpolyeeList) ContainerEm).gridView.Columns["Role"].GroupIndex = 0;
            //        break;
            //    case 1:
            //        ((EmTable) ContainerEm).layoutView.Columns["Role"].GroupIndex = 0;
            //        break;
            //}
        }

        private void rbTable_CheckedChanged(object sender, EventArgs e)
        {
            pcContainer.Controls.Clear();
            SplashScreenManager.ShowForm(typeof (wfMain), false, true);
            var em = new EmTable();
            em.Dock = DockStyle.Fill;
            pcContainer.Controls.Add(em);
            SplashScreenManager.CloseForm();
            ContainerEm = em;
            flag = 1;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            if (isInit)
            {
                pcContainer.Controls.Clear();
                SplashScreenManager.ShowForm(typeof (wfMain), false, true);
                var em = new gvEmployee();
                em.Dock = DockStyle.Fill;
                pcContainer.Controls.Add(em);
                SplashScreenManager.CloseForm();
                ContainerEm = em;
                flag = 0;
            }
            else
                isInit = true;
        }
    }
}