using System;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraEditors;

namespace UltraANetT.Module
{
    public partial class Statistics : XtraUserControl
    {
        public Statistics()
        {
            InitializeComponent();
            var controlColor = CommonSkins.GetSkin(UserLookAndFeel.Default).Colors.GetColor("Control");
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