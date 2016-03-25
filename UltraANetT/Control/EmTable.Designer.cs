namespace UltraANetT.Control
{
    partial class EmTable
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.layoutView = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn4 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn4 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn5 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn5 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn6 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn6 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.layoutView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControl.Size = new System.Drawing.Size(830, 540);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView});
            this.gridControl.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // layoutView
            // 
            this.layoutView.Appearance.Card.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutView.Appearance.Card.Options.UseFont = true;
            this.layoutView.Appearance.CardCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutView.Appearance.CardCaption.Options.UseFont = true;
            this.layoutView.Appearance.FieldCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutView.Appearance.FieldCaption.Options.UseFont = true;
            this.layoutView.Appearance.FieldValue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutView.Appearance.FieldValue.Options.UseFont = true;
            this.layoutView.CardHorzInterval = 0;
            this.layoutView.CardMinSize = new System.Drawing.Size(101, 140);
            this.layoutView.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn3,
            this.layoutViewColumn2,
            this.layoutViewColumn1,
            this.layoutViewColumn4,
            this.layoutViewColumn5,
            this.layoutViewColumn6});
            this.layoutView.GridControl = this.gridControl;
            this.layoutView.Name = "layoutView";
            this.layoutView.OptionsBehavior.Editable = false;
            this.layoutView.OptionsFind.AllowFindPanel = false;
            this.layoutView.OptionsView.CardsAlignment = DevExpress.XtraGrid.Views.Layout.CardsAlignment.Far;
            this.layoutView.OptionsView.ShowCardCaption = false;
            this.layoutView.OptionsView.ShowCardExpandButton = false;
            this.layoutView.OptionsView.ShowHeaderPanel = false;
            this.layoutView.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;
            this.layoutView.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewColumn3
            // 
            this.layoutViewColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.layoutViewColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutViewColumn3.Caption = "部门";
            this.layoutViewColumn3.FieldName = "Dept";
            this.layoutViewColumn3.LayoutViewField = this.layoutViewField_layoutViewColumn3;
            this.layoutViewColumn3.Name = "layoutViewColumn3";
            // 
            // layoutViewField_layoutViewColumn3
            // 
            this.layoutViewField_layoutViewColumn3.EditorPreferredWidth = 121;
            this.layoutViewField_layoutViewColumn3.Location = new System.Drawing.Point(0, 50);
            this.layoutViewField_layoutViewColumn3.Name = "layoutViewField_layoutViewColumn3";
            this.layoutViewField_layoutViewColumn3.Size = new System.Drawing.Size(182, 20);
            this.layoutViewField_layoutViewColumn3.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutViewColumn2
            // 
            this.layoutViewColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.layoutViewColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutViewColumn2.Caption = "姓名";
            this.layoutViewColumn2.FieldName = "Name";
            this.layoutViewColumn2.LayoutViewField = this.layoutViewField_layoutViewColumn2;
            this.layoutViewColumn2.Name = "layoutViewColumn2";
            // 
            // layoutViewField_layoutViewColumn2
            // 
            this.layoutViewField_layoutViewColumn2.EditorPreferredWidth = 121;
            this.layoutViewField_layoutViewColumn2.Location = new System.Drawing.Point(0, 26);
            this.layoutViewField_layoutViewColumn2.Name = "layoutViewField_layoutViewColumn2";
            this.layoutViewField_layoutViewColumn2.Size = new System.Drawing.Size(182, 24);
            this.layoutViewField_layoutViewColumn2.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.layoutViewColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutViewColumn1.ColumnEdit = this.repositoryItemPictureEdit1;
            this.layoutViewColumn1.FieldName = "Photo";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemPictureEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemPictureEdit1.AppearanceDisabled.Options.UseTextOptions = true;
            this.repositoryItemPictureEdit1.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemPictureEdit1.AppearanceFocused.Options.UseTextOptions = true;
            this.repositoryItemPictureEdit1.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemPictureEdit1.AppearanceReadOnly.Options.UseTextOptions = true;
            this.repositoryItemPictureEdit1.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.ContentVisible = false;
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 120;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(182, 26);
            this.layoutViewField_layoutViewColumn1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(20, 14);
            this.layoutViewField_layoutViewColumn1.TextToControlDistance = 5;
            // 
            // layoutViewColumn4
            // 
            this.layoutViewColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.layoutViewColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutViewColumn4.Caption = "角色";
            this.layoutViewColumn4.FieldName = "Role";
            this.layoutViewColumn4.LayoutViewField = this.layoutViewField_layoutViewColumn4;
            this.layoutViewColumn4.Name = "layoutViewColumn4";
            // 
            // layoutViewField_layoutViewColumn4
            // 
            this.layoutViewField_layoutViewColumn4.EditorPreferredWidth = 121;
            this.layoutViewField_layoutViewColumn4.Location = new System.Drawing.Point(0, 70);
            this.layoutViewField_layoutViewColumn4.Name = "layoutViewField_layoutViewColumn4";
            this.layoutViewField_layoutViewColumn4.Size = new System.Drawing.Size(182, 24);
            this.layoutViewField_layoutViewColumn4.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutViewColumn5
            // 
            this.layoutViewColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.layoutViewColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutViewColumn5.Caption = "创建人";
            this.layoutViewColumn5.FieldName = "Creat";
            this.layoutViewColumn5.LayoutViewField = this.layoutViewField_layoutViewColumn5;
            this.layoutViewColumn5.Name = "layoutViewColumn5";
            // 
            // layoutViewField_layoutViewColumn5
            // 
            this.layoutViewField_layoutViewColumn5.EditorPreferredWidth = 121;
            this.layoutViewField_layoutViewColumn5.Location = new System.Drawing.Point(0, 94);
            this.layoutViewField_layoutViewColumn5.Name = "layoutViewField_layoutViewColumn5";
            this.layoutViewField_layoutViewColumn5.Size = new System.Drawing.Size(182, 24);
            this.layoutViewField_layoutViewColumn5.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutViewColumn6
            // 
            this.layoutViewColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.layoutViewColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutViewColumn6.Caption = "创建时间";
            this.layoutViewColumn6.FieldName = "CreatTime";
            this.layoutViewColumn6.LayoutViewField = this.layoutViewField_layoutViewColumn6;
            this.layoutViewColumn6.Name = "layoutViewColumn6";
            // 
            // layoutViewField_layoutViewColumn6
            // 
            this.layoutViewField_layoutViewColumn6.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn6.Location = new System.Drawing.Point(0, 118);
            this.layoutViewField_layoutViewColumn6.Name = "layoutViewField_layoutViewColumn6";
            this.layoutViewField_layoutViewColumn6.Size = new System.Drawing.Size(182, 24);
            this.layoutViewField_layoutViewColumn6.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.GroupBordersVisible = false;
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn1,
            this.layoutViewField_layoutViewColumn2,
            this.layoutViewField_layoutViewColumn3,
            this.layoutViewField_layoutViewColumn4,
            this.layoutViewField_layoutViewColumn5,
            this.layoutViewField_layoutViewColumn6});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // EmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Name = "EmTable";
            this.Size = new System.Drawing.Size(830, 540);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn3;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn4;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn5;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn3;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn5;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn6;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn6;
        public DevExpress.XtraGrid.GridControl gridControl;
        public DevExpress.XtraGrid.Views.Layout.LayoutView layoutView;
    }
}
