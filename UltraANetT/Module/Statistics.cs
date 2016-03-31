using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;

namespace UltraANetT.Module
{
    public partial class Statistics : DevExpress.XtraEditors.XtraUserControl
    {
        public Statistics()
        {
            InitializeComponent();
            Color controlColor = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("Control");
            treeList.Appearance.Empty.BackColor = controlColor;
            treeList.Appearance.Row.BackColor = controlColor;
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {

        }
    }
}
