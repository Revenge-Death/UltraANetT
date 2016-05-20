using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UltraANetT.Control
{
    public partial class NodeNav : DevExpress.XtraEditors.XtraUserControl
    {
        public NodeNav()
        {
            InitializeComponent();
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
    }
}
