using System;
using System.Drawing;
using System.Threading;
using DevExpress.XtraEditors;

namespace UltraANetT.Module
{
    public partial class HardwareCheck : XtraUserControl
    {
        public HardwareCheck()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            var th = new Thread(ShowResult);
            th.Start();
        }

        private void ShowResult()
        {
            Thread.Sleep(3000);
            lbl_1.Appearance.ForeColor = Color.Blue;
            lbl_2.Appearance.ForeColor = Color.Red;
            lbl_3.Appearance.ForeColor = Color.Blue;
            lbl_4.Appearance.ForeColor = Color.Red;
            lbl_5.Appearance.ForeColor = Color.Blue;

            lbl_1.Text = "自检通过";
            lbl_2.Text = "自检未通过";
            lbl_3.Text = "自检通过";
            lbl_4.Text = "自检未通过";
            lbl_5.Text = "自检通过";

            tog_1.IsOn = true;
            tog_2.IsOn = false;
            tog_3.IsOn = true;
            tog_4.IsOn = false;
            tog_5.IsOn = true;

            txtResult.Text = "未通过";
        }

        private delegate void SetResultValue();
    }
}