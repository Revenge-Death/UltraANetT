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
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFolder = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colImageIndex = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colData = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
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
            this.treeList.Location = new System.Drawing.Point(0, 0);
            this.treeList.Name = "treeList";
            this.treeList.BeginUnboundLoad();
            this.treeList.AppendNode(new object[] {
            "AX7",
            null,
            null,
            null,
            null}, -1, 2, 2, -1);
            this.treeList.AppendNode(new object[] {
            "CVVT",
            null,
            null,
            null,
            null}, 0, 4, 4, -1);
            this.treeList.AppendNode(new object[] {
            "JD1",
            null,
            null,
            null,
            null}, 1, 5, 5, -1);
            this.treeList.AppendNode(new object[] {
            "JD2",
            null,
            null,
            null,
            null}, 1, 3, 3, -1);
            this.treeList.EndUnboundLoad();
            this.treeList.OptionsBehavior.Editable = false;
            this.treeList.OptionsView.ShowColumns = false;
            this.treeList.OptionsView.ShowHorzLines = false;
            this.treeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList.OptionsView.ShowIndicator = false;
            this.treeList.OptionsView.ShowVertLines = false;
            this.treeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.treeList.Size = new System.Drawing.Size(225, 450);
            this.treeList.TabIndex = 1;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 88;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 88;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
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
            // VehicelTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList);
            this.Name = "VehicelTree";
            this.Size = new System.Drawing.Size(225, 450);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
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
    }
}
