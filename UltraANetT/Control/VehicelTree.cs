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
using DevExpress.XtraTreeList.Nodes;

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

        private void treeList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //treeList.ContextMenuStrip = null;

                DevExpress.XtraTreeList.TreeListHitInfo hInfo = treeList.CalcHitInfo(new Point(e.X, e.Y));
                TreeListNode node = hInfo.Node;
                treeList.FocusedNode = node;
                if (node.HasChildren)
                    treeList.ContextMenuStrip = CMSTask;
                else
                    treeList.ContextMenuStrip = CMSCar;
                //if (node != null)
                //{
                //    
                //}
            }
        }
    }
}
