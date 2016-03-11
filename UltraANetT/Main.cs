using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraSplashScreen;
using System.Threading;
using DevExpress.XtraTreeList.Nodes;
using UltraANetT.Module;

namespace UltraANetT
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
            //SplashScreenManager.ShowForm(GetType(LoadScreen));
            //Thread.Sleep(3000);
            //SplashScreenManager.CloseForm();

            InitSkinGallery();
            InitGrid();
          

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        BindingList<Person> gridDataList = new BindingList<Person>();
        void InitGrid()
        {
           

        }




        


        private void iNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm( typeof(wfMain), false, true);
            VehicelConfig vc = new VehicelConfig();
            pcMain.Controls.Clear();
            pcMain.Controls.Add(vc);
            SplashScreenManager.CloseForm();
        }

        private void iHelp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(wfMain), false, true);
            AutoTest at = new AutoTest();
            pcMain.Controls.Clear();
            pcMain.Controls.Add(at);
            SplashScreenManager.CloseForm();
        }
    }
}