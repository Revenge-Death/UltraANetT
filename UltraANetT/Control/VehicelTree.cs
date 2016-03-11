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

namespace UltraANetT.Control
{
    public partial class VehicelTree : DevExpress.XtraEditors.XtraUserControl
    {
        public VehicelTree()
        {
            InitializeComponent();
            Color controlColor = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("Control");
            treeList.Appearance.Empty.BackColor = controlColor;
            treeList.Appearance.Row.BackColor = controlColor;
        }
    }
}
