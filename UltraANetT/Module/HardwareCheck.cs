using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;

namespace UltraANetT.Module
{
    public partial class HardwareCheck : DevExpress.XtraEditors.XtraUserControl
    {
        private delegate void SetResultValue();
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
            Thread th = new Thread(ShowResult);
            th.Start();
         

       
        }

        void ShowResult()
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


    }
}
