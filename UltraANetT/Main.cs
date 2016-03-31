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
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;

namespace UltraANetT
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarBaseButtonItem barContainer;
        public Main()
        {
            InitializeComponent();

            InitSkinGallery();
            InitGrid();
            SkinSelect();


        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        BindingList<Person> gridDataList = new BindingList<Person>();
        void InitGrid()
        {
           

        }
        void SkinSelect()
        {
            SkinView.Gallery.Groups[0].Items.RemoveAt(0);
            SkinView.Gallery.Groups[0].Items.RemoveAt(0);
            for (int i = 0; i < 10; i++)
                SkinView.Gallery.Groups[0].Items.RemoveAt(3);
            for (int i = 0; i < 16; i++)
                SkinView.Gallery.Groups[1].Items.RemoveAt(0);
            for (int i = 0; i < 9; i++)
                SkinView.Gallery.Groups[1].Items.RemoveAt(1);
            SkinView.Gallery.Groups[2].Items.Clear();
        }







private void iNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            pcMain.Controls.Clear();
            SplashScreenManager.ShowForm( typeof(wfMain), false, true);
            Vehicel vc = new Vehicel();
            vc.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            vc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(vc);
            SplashScreenManager.CloseForm();
            if (barContainer != null)
                barContainer.ItemAppearance.Normal.BackColor = Color.Transparent;
            iNew.ItemAppearance.Normal.BackColor = Color.Silver;
            barContainer = iNew;
        }

        private void iHelp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            pcMain.Controls.Clear();
            SplashScreenManager.ShowForm(typeof(wfMain), false, true);
            Auto at = new Auto();
            at.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            at.Dock = DockStyle.Fill;
            pcMain.Controls.Add(at);
            SplashScreenManager.CloseForm();
            if (barContainer != null)
                barContainer.ItemAppearance.Normal.BackColor = Color.Transparent;
            iHelp.ItemAppearance.Normal.BackColor = Color.Silver;
            barContainer = iHelp;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Vehicel vc = new Vehicel();
            vc.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            pcMain.Controls.Clear();
            pcMain.Controls.Add(vc);
            iNew.ItemAppearance.Normal.BackColor = Color.Silver;
        }

        private void btEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            pcMain.Controls.Clear();
            SplashScreenManager.ShowForm(typeof(wfMain), false, true);
            Employee em = new Employee();
            em.Dock = DockStyle.Fill;
            pcMain.Controls.Add(em);
            SplashScreenManager.CloseForm();
            if (barContainer != null)
                barContainer.ItemAppearance.Normal.BackColor = Color.Transparent;
            btEmployee.ItemAppearance.Normal.BackColor = Color.Silver;
            barContainer = btEmployee;
        }

        private void Manual_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            SplashScreenManager.ShowForm(typeof(wfMain), false, true);
            Manual em = new Manual();
            em.Dock = DockStyle.Fill;
            pcMain.Controls.Add(em);
            SplashScreenManager.CloseForm();
            if (barContainer != null)
                barContainer.ItemAppearance.Normal.BackColor = Color.Transparent;
            Manual.ItemAppearance.Normal.BackColor = Color.Silver;
            barContainer = Manual;
        }

        private void btDeptMge_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            SplashScreenManager.ShowForm(typeof(wfMain), false, true);
            Department dept = new Department();
            dept.Dock = DockStyle.Fill;
            pcMain.Controls.Add(dept);
            SplashScreenManager.CloseForm();
            if (barContainer != null)
                barContainer.ItemAppearance.Normal.BackColor = Color.Transparent;
            btDeptMge.ItemAppearance.Normal.BackColor = Color.Silver;
            barContainer = btDeptMge;
        }

        private void btStatistics_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            SplashScreenManager.ShowForm(typeof(wfMain), false, true);
            Statistics Stat = new Statistics();
            Stat.Dock = DockStyle.Fill;
            pcMain.Controls.Add(Stat);
            SplashScreenManager.CloseForm();
            if (barContainer != null)
                barContainer.ItemAppearance.Normal.BackColor = Color.Transparent;
            btStatistics.ItemAppearance.Normal.BackColor = Color.Silver;
            barContainer = btStatistics;
        }

        private void btDeviceInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            SplashScreenManager.ShowForm(typeof(wfMain), false, true);
            HardwareInfo hardInfo = new HardwareInfo();
            hardInfo.Dock = DockStyle.Fill;
            pcMain.Controls.Add(hardInfo);
            SplashScreenManager.CloseForm();
            if (barContainer != null)
                barContainer.ItemAppearance.Normal.BackColor = Color.Transparent;
            btDeviceInfo.ItemAppearance.Normal.BackColor = Color.Silver;
            barContainer = btDeviceInfo;
        }

        private void btDeviceCheck_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            SplashScreenManager.ShowForm(typeof(wfMain), false, true);
            HardwareCheck hardCheck = new HardwareCheck();
            hardCheck.Dock = DockStyle.Fill;
            pcMain.Controls.Add(hardCheck);
            SplashScreenManager.CloseForm();
            if (barContainer != null)
                barContainer.ItemAppearance.Normal.BackColor = Color.Transparent;
            btDeviceInfo.ItemAppearance.Normal.BackColor = Color.Silver;
            barContainer = btDeviceInfo;
        }

        private void btTools_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            SplashScreenManager.ShowForm(typeof(wfMain), false, true);
            Tools tools = new Tools();
            tools.Dock = DockStyle.Fill;
            pcMain.Controls.Add(tools);
            SplashScreenManager.CloseForm();
            if (barContainer != null)
                barContainer.ItemAppearance.Normal.BackColor = Color.Transparent;
            btTools.ItemAppearance.Normal.BackColor = Color.Silver;
            barContainer = btTools;
        }

        private void btModifyPwd_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            SplashScreenManager.ShowForm(typeof(wfMain), false, true);
            UserPwd pwd = new UserPwd();
            pwd.Dock = DockStyle.Fill;
            pcMain.Controls.Add(pwd);
            SplashScreenManager.CloseForm();
            if (barContainer != null)
                barContainer.ItemAppearance.Normal.BackColor = Color.Transparent;
            btModifyPwd.ItemAppearance.Normal.BackColor = Color.Silver;
            barContainer = btModifyPwd;
        }

        private void btLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            SplashScreenManager.ShowForm(typeof(wfMain), false, true);
            LogInfo log = new LogInfo();
            log.Dock = DockStyle.Fill;
            pcMain.Controls.Add(log);
            SplashScreenManager.CloseForm();
            if (barContainer != null)
                barContainer.ItemAppearance.Normal.BackColor = Color.Transparent;
            btLog.ItemAppearance.Normal.BackColor = Color.Silver;
            barContainer = btLog;
        }
    }
}