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
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.CMSCar.SuspendLayout();
            this.CMSTask.SuspendLayout();
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
            this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList.Font = new System.Drawing.Font("微软雅黑 Light", 10F);
            this.treeList.HtmlImages = this.imageTree;
            this.treeList.Location = new System.Drawing.Point(0, 0);
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
            // VehicelTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList);
            this.Name = "VehicelTree";
            this.Size = new System.Drawing.Size(218, 468);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.CMSCar.ResumeLayout(false);
            this.CMSTask.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}
