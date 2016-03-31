namespace UltraANetT.Control
{
    partial class VehicelTree
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicelTree));
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFolder = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colImageIndex = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colData = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageTree = new DevExpress.Utils.ImageCollection(this.components);
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.CMSCar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.创建车型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除车型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMSTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.创建任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RMTask = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.CMSCar.SuspendLayout();
            this.CMSTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RMTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList
            // 
            this.treeList.Appearance.Caption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeList.Appearance.Caption.Options.UseFont = true;
            this.treeList.Appearance.Empty.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeList.Appearance.Empty.Options.UseFont = true;
            this.treeList.Appearance.EvenRow.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeList.Appearance.EvenRow.Options.UseFont = true;
            this.treeList.Appearance.Row.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.treeList.Appearance.Row.Options.UseFont = true;
            this.treeList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colType,
            this.colFolder,
            this.colImageIndex,
            this.colData});
            this.treeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList.Font = new System.Drawing.Font("微软雅黑 Light", 10F);
            this.treeList.HtmlImages = this.imageTree;
            this.treeList.Location = new System.Drawing.Point(0, 0);
            this.treeList.LookAndFeel.SkinName = "Office 2016 Dark";
            this.treeList.Name = "treeList";
            this.treeList.BeginUnboundLoad();
            this.treeList.AppendNode(new object[] {
            "AX7",
            null,
            null,
            null,
            null}, -1, 2, 2, 0);
            this.treeList.AppendNode(new object[] {
            "CVVT",
            null,
            null,
            null,
            null}, 0, 4, 4, 1);
            this.treeList.AppendNode(new object[] {
            "JD1",
            null,
            null,
            null,
            null}, 1, 5, 5, 2);
            this.treeList.AppendNode(new object[] {
            "JD2",
            null,
            null,
            null,
            null}, 1, 3, 3, 3);
            this.treeList.AppendNode(new object[] {
            "E3",
            null,
            null,
            null,
            null}, 0, 0, 0, 4);
            this.treeList.AppendNode(new object[] {
            "AX9",
            null,
            null,
            null,
            null}, -1, 0, 0, 0);
            this.treeList.AppendNode(new object[] {
            "CVVT",
            null,
            null,
            null,
            null}, 5, 0, 0, 5);
            this.treeList.AppendNode(new object[] {
            "VT",
            null,
            null,
            null,
            null}, 5, 0, 0, 6);
            this.treeList.EndUnboundLoad();
            this.treeList.OptionsBehavior.Editable = false;
            this.treeList.OptionsBehavior.PopulateServiceColumns = true;
            this.treeList.OptionsView.ShowColumns = false;
            this.treeList.OptionsView.ShowHorzLines = false;
            this.treeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList.OptionsView.ShowIndicator = false;
            this.treeList.OptionsView.ShowVertLines = false;
            this.treeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.treeList.Size = new System.Drawing.Size(218, 468);
            this.treeList.StateImageList = this.imageTree;
            this.treeList.TabIndex = 1;
            this.treeList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeList_MouseDown);
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 88;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 88;
            // 
            // colType
            // 
            this.colType.Name = "colType";
            // 
            // colFolder
            // 
            this.colFolder.Name = "colFolder";
            // 
            // colImageIndex
            // 
            this.colImageIndex.FieldName = "ImageIndex";
            this.colImageIndex.Name = "colImageIndex";
            // 
            // colData
            // 
            this.colData.FieldName = "colData";
            this.colData.Name = "colData";
            // 
            // imageTree
            // 
            this.imageTree.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageTree.ImageStream")));
            this.imageTree.Images.SetKeyName(0, "Calendar_16x16.png");
            this.imageTree.Images.SetKeyName(1, "Drafts_16x16.png");
            this.imageTree.Images.SetKeyName(2, "Inbox_16x16.png");
            this.imageTree.Images.SetKeyName(3, "Organizer_16x16.png");
            this.imageTree.Images.SetKeyName(4, "Ribbon_Content_16x16.png");
            this.imageTree.Images.SetKeyName(5, "Ribbon_Save_16x16.png");
            this.imageTree.Images.SetKeyName(6, "Tasks_16x16.png");
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // CMSCar
            // 
            this.CMSCar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.创建车型ToolStripMenuItem,
            this.删除车型ToolStripMenuItem});
            this.CMSCar.Name = "CMSCar";
            this.CMSCar.Size = new System.Drawing.Size(125, 48);
            // 
            // 创建车型ToolStripMenuItem
            // 
            this.创建车型ToolStripMenuItem.Name = "创建车型ToolStripMenuItem";
            this.创建车型ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.创建车型ToolStripMenuItem.Text = "创建车型";
            // 
            // 删除车型ToolStripMenuItem
            // 
            this.删除车型ToolStripMenuItem.Name = "删除车型ToolStripMenuItem";
            this.删除车型ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除车型ToolStripMenuItem.Text = "删除车型";
            // 
            // CMSTask
            // 
            this.CMSTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.创建任务ToolStripMenuItem,
            this.删除任务ToolStripMenuItem});
            this.CMSTask.Name = "CMSTask";
            this.CMSTask.Size = new System.Drawing.Size(125, 48);
            // 
            // 创建任务ToolStripMenuItem
            // 
            this.创建任务ToolStripMenuItem.Name = "创建任务ToolStripMenuItem";
            this.创建任务ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.创建任务ToolStripMenuItem.Text = "创建任务";
            // 
            // 删除任务ToolStripMenuItem
            // 
            this.删除任务ToolStripMenuItem.Name = "删除任务ToolStripMenuItem";
            this.删除任务ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除任务ToolStripMenuItem.Text = "删除任务";
            // 
            // RMTask
            // 
            this.RMTask.InnerRadius = 3;
            this.RMTask.ItemAutoSize = DevExpress.XtraBars.Ribbon.RadialMenuItemAutoSize.Spring;
            this.RMTask.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.RMTask.Manager = this.barManager;
            this.RMTask.Name = "RMTask";
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.DockWindowTabFont = new System.Drawing.Font("华文中宋", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.barManager.Form = this;
            this.barManager.Images = this.imageTree;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5});
            this.barManager.MaxItemId = 9;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "创建车型";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageIndex = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "修改车型";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageIndex = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "删除车型";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageIndex = 0;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(218, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 468);
            this.barDockControlBottom.Size = new System.Drawing.Size(218, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 468);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(218, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 468);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "创建车型";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 7;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // VehicelTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.treeList);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "VehicelTree";
            this.Size = new System.Drawing.Size(218, 468);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.CMSCar.ResumeLayout(false);
            this.CMSTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RMTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFolder;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colImageIndex;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colData;
        private System.Windows.Forms.ContextMenuStrip CMSCar;
        private System.Windows.Forms.ToolStripMenuItem 创建车型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除车型ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMSTask;
        private System.Windows.Forms.ToolStripMenuItem 创建任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除任务ToolStripMenuItem;
        private DevExpress.Utils.ImageCollection imageTree;
        private DevExpress.XtraBars.Ribbon.RadialMenu RMTask;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
    }
}
