using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using UltraANetT.Control;

namespace UltraANetT.Module
{
    public partial class Employee : DevExpress.XtraEditors.XtraUserControl
    {
        XtraUserControl ContainerEm;
        int flag = 0;

        bool isInit = false;
        public Employee()
        {
            InitializeComponent();
            rbList.Checked = true;
            ContainerEm = emList1;
        }

        private void rbDept_CheckedChanged(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 0:
                    ((EmList)ContainerEm).gridView.Columns["Dept"].GroupIndex = 0;
                    break;
                case 1:
                    ((EmTable)ContainerEm).layoutView.Columns["Dept"].GroupIndex = 0;
                    break;
            }
        }

        private void rbRole_CheckedChanged(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 0:
                    ((EmList)ContainerEm).gridView.Columns["Role"].GroupIndex = 0;
                    break;
                case 1:
                    ((EmTable)ContainerEm).layoutView.Columns["Role"].GroupIndex = 0;
                    break;
            }
        }

        private void rbTable_CheckedChanged(object sender, EventArgs e)
        {
            pcContainer.Controls.Clear();
            SplashScreenManager.ShowForm(typeof(wfMain), false, true);
            EmTable em = new EmTable();
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
                SplashScreenManager.ShowForm(typeof(wfMain), false, true);
                EmList em = new EmList();
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
