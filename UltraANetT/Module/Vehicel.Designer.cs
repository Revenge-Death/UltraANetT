using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraNavBar;
using DevExpress.XtraNavBar.ViewInfo;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using UltraANetT.Properties;

namespace UltraANetT.Module
{
    partial class Vehicel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicel));
            this.imageCollection = new DevExpress.Utils.ImageCollection();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.serachNode = new DevExpress.XtraEditors.SearchControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tabAuthorize = new DevExpress.XtraTab.XtraTabControl();
            this.pageAuthorize = new DevExpress.XtraTab.XtraTabPage();
            this.gcVechiel = new DevExpress.XtraGrid.GridControl();
            this.gvVechiel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.VehicelType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VehicelConfig = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VehicelStage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AuthorizeTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FromDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AuthorizationTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AuthorizationDept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pageSet = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.plFirst = new DevExpress.XtraEditors.PanelControl();
            this.plFour = new DevExpress.XtraEditors.PanelControl();
            this.plThird = new DevExpress.XtraEditors.PanelControl();
            this.plSecond = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.navContain = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.vehicelTree = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageTree = new DevExpress.Utils.ImageCollection();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CMSVehicel = new System.Windows.Forms.ContextMenuStrip();
            this.tsmiCreatTask = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelVehicel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReNameVehicel = new System.Windows.Forms.ToolStripMenuItem();
            this.CMSCreate = new System.Windows.Forms.ContextMenuStrip();
            this.tsmiCreateVehicel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.CMSTask = new System.Windows.Forms.ContextMenuStrip();
            this.tsmiCreateStage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelTask = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReNameTask = new System.Windows.Forms.ToolStripMenuItem();
            this.CMSStage = new System.Windows.Forms.ContextMenuStrip();
            this.tsmiDelStage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReNameStage = new System.Windows.Forms.ToolStripMenuItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serachNode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabAuthorize)).BeginInit();
            this.tabAuthorize.SuspendLayout();
            this.pageAuthorize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVechiel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVechiel)).BeginInit();
            this.pageSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            this.navBarControl.SuspendLayout();
            this.navContain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicelTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.CMSVehicel.SuspendLayout();
            this.CMSCreate.SuspendLayout();
            this.CMSTask.SuspendLayout();
            this.CMSStage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "Calendar_16x16.png");
            this.imageCollection.Images.SetKeyName(1, "Drafts_16x16.png");
            this.imageCollection.Images.SetKeyName(2, "Organizer_16x16.png");
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.serachNode);
            this.layoutControl1.Controls.Add(this.comboBoxEdit1);
            this.layoutControl1.Controls.Add(this.tabAuthorize);
            this.layoutControl1.Controls.Add(this.navBarControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(418, 307, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1168, 708);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // serachNode
            // 
            this.serachNode.Location = new System.Drawing.Point(15, 15);
            this.serachNode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.serachNode.Name = "serachNode";
            this.serachNode.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.serachNode.Properties.Appearance.Options.UseFont = true;
            this.serachNode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.SearchButton(20, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, false, true)});
            this.serachNode.Properties.ShowClearButton = false;
            this.serachNode.Size = new System.Drawing.Size(212, 28);
            this.serachNode.StyleController = this.layoutControl1;
            this.serachNode.TabIndex = 10;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(137, 15);
            this.comboBoxEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(119, 28);
            this.comboBoxEdit1.StyleController = this.layoutControl1;
            this.comboBoxEdit1.TabIndex = 8;
            // 
            // tabAuthorize
            // 
            this.tabAuthorize.Location = new System.Drawing.Point(240, 8);
            this.tabAuthorize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAuthorize.Name = "tabAuthorize";
            this.tabAuthorize.SelectedTabPage = this.pageAuthorize;
            this.tabAuthorize.Size = new System.Drawing.Size(920, 692);
            this.tabAuthorize.TabIndex = 6;
            this.tabAuthorize.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageAuthorize,
            this.pageSet});
            // 
            // pageAuthorize
            // 
            this.pageAuthorize.Appearance.Header.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageAuthorize.Appearance.Header.Options.UseFont = true;
            this.pageAuthorize.Controls.Add(this.gcVechiel);
            this.pageAuthorize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageAuthorize.Name = "pageAuthorize";
            this.pageAuthorize.Size = new System.Drawing.Size(913, 654);
            this.pageAuthorize.Text = "AX7_CVVT授权";
            // 
            // gcVechiel
            // 
            this.gcVechiel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcVechiel.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcVechiel.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gcVechiel.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.gcVechiel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcVechiel.Location = new System.Drawing.Point(2, 1);
            this.gcVechiel.MainView = this.gvVechiel;
            this.gcVechiel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.gcVechiel.Name = "gcVechiel";
            this.gcVechiel.Size = new System.Drawing.Size(917, 656);
            this.gcVechiel.TabIndex = 4;
            this.gcVechiel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVechiel});
            // 
            // gvVechiel
            // 
            this.gvVechiel.Appearance.Empty.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVechiel.Appearance.Empty.Options.UseFont = true;
            this.gvVechiel.Appearance.EvenRow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVechiel.Appearance.EvenRow.Options.UseFont = true;
            this.gvVechiel.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVechiel.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvVechiel.Appearance.Row.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVechiel.Appearance.Row.Options.UseFont = true;
            this.gvVechiel.AppearancePrint.Row.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVechiel.AppearancePrint.Row.Options.UseFont = true;
            this.gvVechiel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gvVechiel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.VehicelType,
            this.VehicelConfig,
            this.VehicelStage,
            this.CreatTime,
            this.CreatPerson,
            this.AuthorizeTo,
            this.FromDepartment,
            this.AuthorizationTime,
            this.AuthorizationDept});
            this.gvVechiel.GridControl = this.gcVechiel;
            this.gvVechiel.Name = "gvVechiel";
            this.gvVechiel.OptionsFind.AlwaysVisible = true;
            this.gvVechiel.OptionsSelection.MultiSelect = true;
            this.gvVechiel.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // VehicelType
            // 
            this.VehicelType.Caption = "车型";
            this.VehicelType.FieldName = "VehicelType";
            this.VehicelType.Name = "VehicelType";
            this.VehicelType.Visible = true;
            this.VehicelType.VisibleIndex = 1;
            // 
            // VehicelConfig
            // 
            this.VehicelConfig.Caption = "配置";
            this.VehicelConfig.FieldName = "VehicelConfig";
            this.VehicelConfig.Name = "VehicelConfig";
            this.VehicelConfig.Visible = true;
            this.VehicelConfig.VisibleIndex = 2;
            // 
            // VehicelStage
            // 
            this.VehicelStage.Caption = "阶段";
            this.VehicelStage.FieldName = "VehicelStage";
            this.VehicelStage.Name = "VehicelStage";
            this.VehicelStage.Visible = true;
            this.VehicelStage.VisibleIndex = 3;
            // 
            // CreatTime
            // 
            this.CreatTime.Caption = "创建时间";
            this.CreatTime.FieldName = "CreatTime";
            this.CreatTime.Name = "CreatTime";
            this.CreatTime.Visible = true;
            this.CreatTime.VisibleIndex = 4;
            // 
            // CreatPerson
            // 
            this.CreatPerson.Caption = "创建人";
            this.CreatPerson.FieldName = "CreatPerson";
            this.CreatPerson.Name = "CreatPerson";
            this.CreatPerson.Visible = true;
            this.CreatPerson.VisibleIndex = 5;
            // 
            // AuthorizeTo
            // 
            this.AuthorizeTo.Caption = "授权配置员";
            this.AuthorizeTo.FieldName = "AuthorizeTo";
            this.AuthorizeTo.Name = "AuthorizeTo";
            this.AuthorizeTo.Visible = true;
            this.AuthorizeTo.VisibleIndex = 6;
            // 
            // FromDepartment
            // 
            this.FromDepartment.Caption = "部门";
            this.FromDepartment.FieldName = "FromDepartment";
            this.FromDepartment.Name = "FromDepartment";
            this.FromDepartment.Visible = true;
            this.FromDepartment.VisibleIndex = 7;
            // 
            // AuthorizationTime
            // 
            this.AuthorizationTime.Caption = "授权时间";
            this.AuthorizationTime.FieldName = "AuthorizationTime";
            this.AuthorizationTime.Name = "AuthorizationTime";
            this.AuthorizationTime.Visible = true;
            this.AuthorizationTime.VisibleIndex = 8;
            // 
            // AuthorizationDept
            // 
            this.AuthorizationDept.Caption = "授权部门";
            this.AuthorizationDept.FieldName = "AuthorizationDept";
            this.AuthorizationDept.Name = "AuthorizationDept";
            this.AuthorizationDept.Visible = true;
            this.AuthorizationDept.VisibleIndex = 9;
            // 
            // pageSet
            // 
            this.pageSet.Appearance.Header.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageSet.Appearance.Header.Options.UseFont = true;
            this.pageSet.Appearance.PageClient.BackColor = System.Drawing.Color.Transparent;
            this.pageSet.Appearance.PageClient.Options.UseBackColor = true;
            this.pageSet.Controls.Add(this.layoutControl2);
            this.pageSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageSet.Name = "pageSet";
            this.pageSet.Size = new System.Drawing.Size(913, 654);
            this.pageSet.Text = "AX7_CVVT配置";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.labelControl4);
            this.layoutControl2.Controls.Add(this.plSecond);
            this.layoutControl2.Controls.Add(this.plFirst);
            this.layoutControl2.Controls.Add(this.plFour);
            this.layoutControl2.Controls.Add(this.plThird);
            this.layoutControl2.Controls.Add(this.simpleButton1);
            this.layoutControl2.Controls.Add(this.pictureEdit4);
            this.layoutControl2.Controls.Add(this.pictureEdit3);
            this.layoutControl2.Controls.Add(this.pictureEdit2);
            this.layoutControl2.Controls.Add(this.labelControl6);
            this.layoutControl2.Controls.Add(this.labelControl5);
            this.layoutControl2.Controls.Add(this.labelControl2);
            this.layoutControl2.Controls.Add(this.pictureEdit1);
            this.layoutControl2.Controls.Add(this.labelControl3);
            this.layoutControl2.Controls.Add(this.labelControl1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(662, 319, 250, 350);
            this.layoutControl2.Root = this.layoutControlGroup3;
            this.layoutControl2.Size = new System.Drawing.Size(913, 654);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 135);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(960, 18);
            this.labelControl4.StyleController = this.layoutControl2;
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-------------------------------\r\n";
            // 
            // plFirst
            // 
            this.plFirst.ContentImage = ((System.Drawing.Image)(resources.GetObject("plFirst.ContentImage")));
            this.plFirst.Location = new System.Drawing.Point(83, 236);
            this.plFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plFirst.Name = "plFirst";
            this.plFirst.Size = new System.Drawing.Size(373, 149);
            this.plFirst.TabIndex = 16;
            // 
            // plFour
            // 
            this.plFour.ContentImage = global::UltraANetT.Properties.Resources.fourth;
            this.plFour.Location = new System.Drawing.Point(516, 431);
            this.plFour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plFour.Name = "plFour";
            this.plFour.Size = new System.Drawing.Size(373, 139);
            this.plFour.TabIndex = 17;
            // 
            // plThird
            // 
            this.plThird.ContentImage = global::UltraANetT.Properties.Resources.third;
            this.plThird.Location = new System.Drawing.Point(83, 431);
            this.plThird.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plThird.Name = "plThird";
            this.plThird.Size = new System.Drawing.Size(373, 139);
            this.plThird.TabIndex = 19;
            // 
            // plSecond
            // 
            this.plSecond.ContentImage = global::UltraANetT.Properties.Resources.second;
            this.plSecond.Location = new System.Drawing.Point(516, 236);
            this.plSecond.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plSecond.Name = "plSecond";
            this.plSecond.Size = new System.Drawing.Size(373, 149);
            this.plSecond.TabIndex = 18;
            this.plSecond.Click += new System.EventHandler(this.plSecond_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(824, 64);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.MinimumSize = new System.Drawing.Size(0, 58);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(95, 58);
            this.simpleButton1.StyleController = this.layoutControl2;
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "检测配置";
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(771, 64);
            this.pictureEdit4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Size = new System.Drawing.Size(41, 58);
            this.pictureEdit4.StyleController = this.layoutControl2;
            this.pictureEdit4.TabIndex = 14;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(591, 64);
            this.pictureEdit3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(42, 58);
            this.pictureEdit3.StyleController = this.layoutControl2;
            this.pictureEdit3.TabIndex = 13;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(419, 64);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(42, 58);
            this.pictureEdit2.StyleController = this.layoutControl2;
            this.pictureEdit2.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(640, 64);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(124, 48);
            this.labelControl6.StyleController = this.layoutControl2;
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "  第四步：\r\n供应商配置";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(468, 64);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(116, 48);
            this.labelControl5.StyleController = this.layoutControl2;
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "  第三步：\r\n网络拓扑图";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(288, 64);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(124, 48);
            this.labelControl2.StyleController = this.layoutControl2;
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "    第二步：\r\n车型模板配置";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureEdit1.EditValue = global::UltraANetT.Properties.Resources.False;
            this.pictureEdit1.Location = new System.Drawing.Point(237, 64);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(44, 58);
            this.pictureEdit1.StyleController = this.layoutControl2;
            this.pictureEdit1.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(106, 64);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(124, 48);
            this.labelControl3.StyleController = this.layoutControl2;
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "     第一步：\r\n车型数据配置\r\n";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Location = new System.Drawing.Point(7, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(216, 31);
            this.labelControl1.StyleController = this.layoutControl2;
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "车辆配置信息检测：";
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.emptySpaceItem5,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem9,
            this.layoutControlItem12,
            this.layoutControlItem13,
            this.layoutControlItem14,
            this.layoutControlItem15,
            this.layoutControlItem16,
            this.layoutControlItem17,
            this.layoutControlItem18,
            this.layoutControlItem19});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "Root";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup3.Size = new System.Drawing.Size(972, 633);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(224, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(742, 51);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(926, 51);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(40, 78);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.labelControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 10, 10);
            this.layoutControlItem4.Size = new System.Drawing.Size(224, 51);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 51);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(98, 78);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.labelControl3;
            this.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem7.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem7.Location = new System.Drawing.Point(98, 51);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 10, 5);
            this.layoutControlItem7.Size = new System.Drawing.Size(134, 78);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.pictureEdit1;
            this.layoutControlItem6.Location = new System.Drawing.Point(232, 51);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10);
            this.layoutControlItem6.Size = new System.Drawing.Size(48, 78);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.labelControl2;
            this.layoutControlItem8.Location = new System.Drawing.Point(280, 51);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 10, 5);
            this.layoutControlItem8.Size = new System.Drawing.Size(134, 78);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.labelControl5;
            this.layoutControlItem10.Location = new System.Drawing.Point(460, 51);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 10, 5);
            this.layoutControlItem10.Size = new System.Drawing.Size(126, 78);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.labelControl6;
            this.layoutControlItem11.Location = new System.Drawing.Point(632, 51);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 10, 5);
            this.layoutControlItem11.Size = new System.Drawing.Size(134, 78);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.pictureEdit2;
            this.layoutControlItem9.Location = new System.Drawing.Point(414, 51);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10);
            this.layoutControlItem9.Size = new System.Drawing.Size(46, 78);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.pictureEdit3;
            this.layoutControlItem12.Location = new System.Drawing.Point(586, 51);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10);
            this.layoutControlItem12.Size = new System.Drawing.Size(46, 78);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.pictureEdit4;
            this.layoutControlItem13.Location = new System.Drawing.Point(766, 51);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10);
            this.layoutControlItem13.Size = new System.Drawing.Size(45, 78);
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.simpleButton1;
            this.layoutControlItem14.Location = new System.Drawing.Point(811, 51);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem14.Size = new System.Drawing.Size(115, 78);
            this.layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem14.TextVisible = false;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.plFirst;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 153);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Padding = new DevExpress.XtraLayout.Utils.Padding(80, 30, 80, 23);
            this.layoutControlItem15.Size = new System.Drawing.Size(483, 252);
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextVisible = false;
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.plFour;
            this.layoutControlItem16.Location = new System.Drawing.Point(483, 405);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 80, 23, 60);
            this.layoutControlItem16.Size = new System.Drawing.Size(483, 222);
            this.layoutControlItem16.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem16.TextVisible = false;
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.plSecond;
            this.layoutControlItem17.Location = new System.Drawing.Point(483, 153);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 80, 80, 23);
            this.layoutControlItem17.Size = new System.Drawing.Size(483, 252);
            this.layoutControlItem17.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem17.TextVisible = false;
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.plThird;
            this.layoutControlItem18.Location = new System.Drawing.Point(0, 405);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Padding = new DevExpress.XtraLayout.Utils.Padding(80, 30, 23, 60);
            this.layoutControlItem18.Size = new System.Drawing.Size(483, 222);
            this.layoutControlItem18.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem18.TextVisible = false;
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.labelControl4;
            this.layoutControlItem19.Location = new System.Drawing.Point(0, 129);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(966, 24);
            this.layoutControlItem19.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem19.TextVisible = false;
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.navBarGroup;
            this.navBarControl.Controls.Add(this.navContain);
            this.navBarControl.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup});
            this.navBarControl.Location = new System.Drawing.Point(15, 49);
            this.navBarControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navBarControl.MaximumSize = new System.Drawing.Size(242, 639);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 212;
            this.navBarControl.Size = new System.Drawing.Size(212, 639);
            this.navBarControl.TabIndex = 7;
            this.navBarControl.Text = "navBarControl1";
            this.navBarControl.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Office 2016 Colorful");
            // 
            // navBarGroup
            // 
            this.navBarGroup.Appearance.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.navBarGroup.Appearance.Options.UseFont = true;
            this.navBarGroup.Caption = "车型列表";
            this.navBarGroup.ControlContainer = this.navContain;
            this.navBarGroup.Expanded = true;
            this.navBarGroup.GroupClientHeight = 576;
            this.navBarGroup.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup.Name = "navBarGroup";
            // 
            // navContain
            // 
            this.navContain.Controls.Add(this.vehicelTree);
            this.navContain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navContain.Name = "navContain";
            this.navContain.Size = new System.Drawing.Size(202, 567);
            this.navContain.TabIndex = 0;
            // 
            // vehicelTree
            // 
            this.vehicelTree.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vehicelTree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName});
            this.vehicelTree.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vehicelTree.Location = new System.Drawing.Point(-5, 0);
            this.vehicelTree.LookAndFeel.SkinName = "Office 2016 Dark";
            this.vehicelTree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vehicelTree.Name = "vehicelTree";
            this.vehicelTree.OptionsBehavior.Editable = false;
            this.vehicelTree.OptionsView.ShowColumns = false;
            this.vehicelTree.OptionsView.ShowHorzLines = false;
            this.vehicelTree.OptionsView.ShowIndentAsRowStyle = true;
            this.vehicelTree.OptionsView.ShowIndicator = false;
            this.vehicelTree.OptionsView.ShowVertLines = false;
            this.vehicelTree.Size = new System.Drawing.Size(238, 570);
            this.vehicelTree.StateImageList = this.imageTree;
            this.vehicelTree.TabIndex = 0;
            this.vehicelTree.ShownEditor += new System.EventHandler(this.vehicelTree_ShownEditor);
            this.vehicelTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vehicelTree_MouseDown);
            // 
            // colName
            // 
            this.colName.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colName.AppearanceCell.Options.UseFont = true;
            this.colName.Caption = "colName";
            this.colName.FieldName = "colName";
            this.colName.MinWidth = 88;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 93;
            // 
            // imageTree
            // 
            this.imageTree.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageTree.ImageStream")));
            this.imageTree.Images.SetKeyName(0, "Config.png");
            this.imageTree.Images.SetKeyName(1, "List.png");
            this.imageTree.Images.SetKeyName(2, "节点列表.png");
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.comboBoxEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(108, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(108, 30);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1168, 708);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tabAuthorize;
            this.layoutControlItem3.Location = new System.Drawing.Point(232, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(926, 698);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup2.Size = new System.Drawing.Size(232, 698);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.navBarControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(218, 650);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.serachNode;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(218, 34);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // CMSVehicel
            // 
            this.CMSVehicel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMSVehicel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreatTask,
            this.tsmiDelVehicel,
            this.tsmiReNameVehicel});
            this.CMSVehicel.Name = "CMSTask";
            this.CMSVehicel.Size = new System.Drawing.Size(191, 100);
            // 
            // tsmiCreatTask
            // 
            this.tsmiCreatTask.Name = "tsmiCreatTask";
            this.tsmiCreatTask.Size = new System.Drawing.Size(190, 32);
            this.tsmiCreatTask.Text = "创建任务";
            // 
            // tsmiDelVehicel
            // 
            this.tsmiDelVehicel.Name = "tsmiDelVehicel";
            this.tsmiDelVehicel.Size = new System.Drawing.Size(190, 32);
            this.tsmiDelVehicel.Text = "删除车型";
            // 
            // tsmiReNameVehicel
            // 
            this.tsmiReNameVehicel.Name = "tsmiReNameVehicel";
            this.tsmiReNameVehicel.Size = new System.Drawing.Size(190, 32);
            this.tsmiReNameVehicel.Text = "重命名车型";
            // 
            // CMSCreate
            // 
            this.CMSCreate.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMSCreate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateVehicel,
            this.tsmiRefresh});
            this.CMSCreate.Name = "CMSTask";
            this.CMSCreate.Size = new System.Drawing.Size(171, 68);
            // 
            // tsmiCreateVehicel
            // 
            this.tsmiCreateVehicel.Name = "tsmiCreateVehicel";
            this.tsmiCreateVehicel.Size = new System.Drawing.Size(170, 32);
            this.tsmiCreateVehicel.Text = "创建车型";
            // 
            // tsmiRefresh
            // 
            this.tsmiRefresh.Name = "tsmiRefresh";
            this.tsmiRefresh.Size = new System.Drawing.Size(170, 32);
            this.tsmiRefresh.Text = "刷新";
            this.tsmiRefresh.Click += new System.EventHandler(this.tsmiRefresh_Click);
            // 
            // CMSTask
            // 
            this.CMSTask.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMSTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateStage,
            this.tsmiDelTask,
            this.tsmiReNameTask});
            this.CMSTask.Name = "CMSTask";
            this.CMSTask.Size = new System.Drawing.Size(191, 100);
            // 
            // tsmiCreateStage
            // 
            this.tsmiCreateStage.Name = "tsmiCreateStage";
            this.tsmiCreateStage.Size = new System.Drawing.Size(190, 32);
            this.tsmiCreateStage.Text = "创建阶段";
            // 
            // tsmiDelTask
            // 
            this.tsmiDelTask.Name = "tsmiDelTask";
            this.tsmiDelTask.Size = new System.Drawing.Size(190, 32);
            this.tsmiDelTask.Text = "删除任务";
            // 
            // tsmiReNameTask
            // 
            this.tsmiReNameTask.Name = "tsmiReNameTask";
            this.tsmiReNameTask.Size = new System.Drawing.Size(190, 32);
            this.tsmiReNameTask.Text = "重命名任务";
            // 
            // CMSStage
            // 
            this.CMSStage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMSStage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelStage,
            this.tsmiReNameStage});
            this.CMSStage.Name = "CMSTask";
            this.CMSStage.Size = new System.Drawing.Size(191, 68);
            // 
            // tsmiDelStage
            // 
            this.tsmiDelStage.Name = "tsmiDelStage";
            this.tsmiDelStage.Size = new System.Drawing.Size(190, 32);
            this.tsmiDelStage.Text = "删除阶段";
            // 
            // tsmiReNameStage
            // 
            this.tsmiReNameStage.Name = "tsmiReNameStage";
            this.tsmiReNameStage.Size = new System.Drawing.Size(190, 32);
            this.tsmiReNameStage.Text = "重命名阶段";
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 33);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(118, 451);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Vehicel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.LookAndFeel.SkinName = "Office 2016 Dark";
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Vehicel";
            this.Size = new System.Drawing.Size(1168, 708);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serachNode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabAuthorize)).EndInit();
            this.tabAuthorize.ResumeLayout(false);
            this.pageAuthorize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcVechiel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVechiel)).EndInit();
            this.pageSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            this.navBarControl.ResumeLayout(false);
            this.navContain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehicelTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.CMSVehicel.ResumeLayout(false);
            this.CMSCreate.ResumeLayout(false);
            this.CMSTask.ResumeLayout(false);
            this.CMSStage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ImageCollection imageCollection;
        private LayoutControl layoutControl1;
        private LayoutControlGroup layoutControlGroup1;
        private NavBarControl navBarControl;
        private NavBarGroup navBarGroup;
        private NavBarGroupControlContainer navContain;
        private LayoutControlItem layoutControlItem2;
        private XtraTabControl tabAuthorize;
        private XtraTabPage pageAuthorize;
        private XtraTabPage pageSet;
        private LayoutControlItem layoutControlItem3;
        private ComboBoxEdit comboBoxEdit1;
        private LayoutControlItem layoutControlItem1;
        private SearchControl serachNode;
        private LayoutControlGroup layoutControlGroup2;
        private LayoutControlItem layoutControlItem5;
        private ImageCollection imageTree;
        private ContextMenuStrip CMSVehicel;
        private ToolStripMenuItem tsmiCreatTask;
        private ToolStripMenuItem tsmiDelVehicel;
        private ContextMenuStrip CMSCreate;
        private ToolStripMenuItem tsmiCreateVehicel;
        private ToolStripMenuItem tsmiReNameVehicel;
        private TreeList vehicelTree;
        private TreeListColumn colName;
        private ContextMenuStrip CMSTask;
        private ToolStripMenuItem tsmiCreateStage;
        private ToolStripMenuItem tsmiDelTask;
        private ToolStripMenuItem tsmiReNameTask;
        private ContextMenuStrip CMSStage;
        private ToolStripMenuItem tsmiDelStage;
        private ToolStripMenuItem tsmiReNameStage;
        private ToolStripMenuItem tsmiRefresh;
        private GridControl gcVechiel;
        private GridView gvVechiel;
        private GridColumn VehicelType;
        private GridColumn VehicelConfig;
        private GridColumn VehicelStage;
        private GridColumn CreatTime;
        private GridColumn CreatPerson;
        private GridColumn AuthorizeTo;
        private GridColumn FromDepartment;
        private GridColumn AuthorizationTime;
        private GridColumn AuthorizationDept;
        private LayoutControl layoutControl2;
        private PictureEdit pictureEdit4;
        private PictureEdit pictureEdit3;
        private PictureEdit pictureEdit2;
        private LabelControl labelControl6;
        private LabelControl labelControl5;
        private LabelControl labelControl2;
        private PictureEdit pictureEdit1;
        private LabelControl labelControl3;
        private LabelControl labelControl1;
        private LayoutControlGroup layoutControlGroup3;
        private EmptySpaceItem emptySpaceItem1;
        private EmptySpaceItem emptySpaceItem2;
        private LayoutControlItem layoutControlItem4;
        private EmptySpaceItem emptySpaceItem5;
        private LayoutControlItem layoutControlItem7;
        private LayoutControlItem layoutControlItem6;
        private LayoutControlItem layoutControlItem8;
        private LayoutControlItem layoutControlItem10;
        private LayoutControlItem layoutControlItem11;
        private LayoutControlItem layoutControlItem9;
        private LayoutControlItem layoutControlItem12;
        private LayoutControlItem layoutControlItem13;
        private EmptySpaceItem emptySpaceItem3;
        private PanelControl plThird;
        private PanelControl plSecond;
        private PanelControl plFour;
        private PanelControl plFirst;
        private SimpleButton simpleButton1;
        private LayoutControlItem layoutControlItem14;
        private LayoutControlItem layoutControlItem15;
        private LayoutControlItem layoutControlItem16;
        private LayoutControlItem layoutControlItem17;
        private LayoutControlItem layoutControlItem18;
        private LabelControl labelControl4;
        private LayoutControlItem layoutControlItem19;
    }
}
