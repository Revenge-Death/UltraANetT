namespace UltraANetT.Module
{
    partial class mod_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mod_Employee));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.mailGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rbRole = new System.Windows.Forms.RadioButton();
            this.rbDept = new System.Windows.Forms.RadioButton();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.pcContainer = new System.Windows.Forms.Panel();
            this.empolyeeList1 = new UltraANetT.Control.EmpolyeeList();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            this.navBarControl.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.pcContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.navBarControl);
            this.layoutControl1.Controls.Add(this.pcContainer);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(595, 366, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1022, 551);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.mailGroup;
            this.navBarControl.Appearance.Background.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl.Appearance.Background.Options.UseFont = true;
            this.navBarControl.Appearance.GroupHeader.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl.Appearance.GroupHeader.Options.UseFont = true;
            this.navBarControl.Appearance.Item.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl.Appearance.Item.Options.UseFont = true;
            this.navBarControl.Appearance.NavigationPaneHeader.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.navBarControl.Appearance.NavigationPaneHeader.Options.UseFont = true;
            this.navBarControl.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.mailGroup});
            this.navBarControl.Location = new System.Drawing.Point(5, 5);
            this.navBarControl.Margin = new System.Windows.Forms.Padding(2);
            this.navBarControl.MaximumSize = new System.Drawing.Size(176, 0);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.CollapsedWidth = 10;
            this.navBarControl.OptionsNavPane.ExpandedWidth = 149;
            this.navBarControl.OptionsNavPane.ShowExpandButton = false;
            this.navBarControl.OptionsNavPane.ShowOverflowButton = false;
            this.navBarControl.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl.OptionsNavPane.ShowSplitter = false;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar;
            this.navBarControl.Size = new System.Drawing.Size(149, 539);
            this.navBarControl.SmallImages = this.imageCollection;
            this.navBarControl.TabIndex = 9;
            this.navBarControl.Text = "navBarControl1";
            this.navBarControl.View = new DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator();
            // 
            // mailGroup
            // 
            this.mailGroup.Appearance.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.mailGroup.Appearance.Options.UseFont = true;
            this.mailGroup.AppearanceBackground.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailGroup.AppearanceBackground.Options.UseFont = true;
            this.mailGroup.AppearanceHotTracked.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailGroup.AppearanceHotTracked.Options.UseFont = true;
            this.mailGroup.Caption = "查看方式";
            this.mailGroup.ControlContainer = this.navBarGroupControlContainer1;
            this.mailGroup.Expanded = true;
            this.mailGroup.GroupClientHeight = 424;
            this.mailGroup.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.mailGroup.LargeImageIndex = 2;
            this.mailGroup.Name = "mailGroup";
            this.mailGroup.NavigationPaneVisible = false;
            this.mailGroup.SmallImageIndex = 2;
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer1.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer1.Controls.Add(this.panel2);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(149, 506);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.rbRole);
            this.panel2.Controls.Add(this.rbDept);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MaximumSize = new System.Drawing.Size(150, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 506);
            this.panel2.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.labelControl1.Location = new System.Drawing.Point(6, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(138, 16);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "- - - - - - - - - - - - - - - - - ";
            // 
            // rbRole
            // 
            this.rbRole.AutoSize = true;
            this.rbRole.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbRole.Location = new System.Drawing.Point(34, 51);
            this.rbRole.Name = "rbRole";
            this.rbRole.Size = new System.Drawing.Size(86, 21);
            this.rbRole.TabIndex = 7;
            this.rbRole.Text = "按角色汇总";
            this.rbRole.UseVisualStyleBackColor = true;
            this.rbRole.CheckedChanged += new System.EventHandler(this.rbRole_CheckedChanged);
            // 
            // rbDept
            // 
            this.rbDept.AutoSize = true;
            this.rbDept.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbDept.Location = new System.Drawing.Point(34, 20);
            this.rbDept.Name = "rbDept";
            this.rbDept.Size = new System.Drawing.Size(86, 21);
            this.rbDept.TabIndex = 5;
            this.rbDept.Text = "按部门汇总";
            this.rbDept.UseVisualStyleBackColor = true;
            this.rbDept.CheckedChanged += new System.EventHandler(this.rbDept_CheckedChanged);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "Calendar_16x16.png");
            this.imageCollection.Images.SetKeyName(1, "Drafts_16x16.png");
            this.imageCollection.Images.SetKeyName(2, "Organizer_16x16.png");
            // 
            // pcContainer
            // 
            this.pcContainer.Controls.Add(this.empolyeeList1);
            this.pcContainer.Location = new System.Drawing.Point(157, 4);
            this.pcContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pcContainer.Name = "pcContainer";
            this.pcContainer.Size = new System.Drawing.Size(861, 543);
            this.pcContainer.TabIndex = 4;
            // 
            // empolyeeList1
            // 
            this.empolyeeList1.Location = new System.Drawing.Point(2, 0);
            this.empolyeeList1.Margin = new System.Windows.Forms.Padding(2);
            this.empolyeeList1.Name = "empolyeeList1";
            this.empolyeeList1.Size = new System.Drawing.Size(855, 540);
            this.empolyeeList1.TabIndex = 0;
            this.empolyeeList1.Load += new System.EventHandler(this.empolyeeList1_Load);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1022, 551);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pcContainer;
            this.layoutControlItem1.Location = new System.Drawing.Point(153, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlItem1.Size = new System.Drawing.Size(863, 545);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.navBarControl;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(180, 0);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(14, 14);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem3.Size = new System.Drawing.Size(153, 545);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // mod_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "mod_Employee";
            this.Size = new System.Drawing.Size(1022, 551);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            this.navBarControl.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.pcContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.Panel pcContainer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup mailGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbRole;
        private System.Windows.Forms.RadioButton rbDept;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Control.EmpolyeeList empolyeeList1;
    }
}
