using System.Drawing;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraEditors;

namespace UltraANetT.Control
{
    public partial class VehicelTree : XtraUserControl
    {
        public VehicelTree()
        {
            InitializeComponent();
            var controlColor = CommonSkins.GetSkin(UserLookAndFeel.Default).Colors.GetColor("Control");
            treeList.Appearance.Empty.BackColor = controlColor;
            treeList.Appearance.Row.BackColor = controlColor;
        }

        private void treeList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeList.ContextMenuStrip = null;

                var hInfo = treeList.CalcHitInfo(new Point(e.X, e.Y));
                var node = hInfo.Node;
                treeList.FocusedNode = node;
                var level = node.Level;
                if (level == 0)
                    treeList.ContextMenuStrip = CMSCar;
                else if (level == 1)
                    treeList.ContextMenuStrip = CMSTask;
            }
        }
    }
}