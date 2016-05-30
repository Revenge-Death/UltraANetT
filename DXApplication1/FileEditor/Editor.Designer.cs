namespace FileEditor
{
    partial class Editor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.officeNavigationBar1 = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navCfg = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navTemplete = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navExample = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.DLAF = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.template = new FileEditor.Control.Template();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // officeNavigationBar1
            // 
            this.officeNavigationBar1.AppearanceItem.Normal.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.officeNavigationBar1.AppearanceItem.Normal.Options.UseFont = true;
            this.officeNavigationBar1.AutoSize = false;
            this.officeNavigationBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.officeNavigationBar1.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            this.navCfg,
            this.navTemplete,
            this.navExample});
            this.officeNavigationBar1.Location = new System.Drawing.Point(0, 635);
            this.officeNavigationBar1.Name = "officeNavigationBar1";
            this.officeNavigationBar1.Size = new System.Drawing.Size(1006, 45);
            this.officeNavigationBar1.TabIndex = 0;
            this.officeNavigationBar1.Text = "officeNavigationBar1";
            // 
            // navCfg
            // 
            this.navCfg.Name = "navCfg";
            this.navCfg.Text = "工程文件管理";
            // 
            // navTemplete
            // 
            this.navTemplete.Name = "navTemplete";
            this.navTemplete.Text = "配置模板管理";
            // 
            // navExample
            // 
            this.navExample.Name = "navExample";
            this.navExample.Text = "用例管理";
            // 
            // DLAF
            // 
            this.DLAF.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.template);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1006, 635);
            this.panelControl1.TabIndex = 1;
            // 
            // template
            // 
            this.template.Dock = System.Windows.Forms.DockStyle.Fill;
            this.template.Location = new System.Drawing.Point(2, 2);
            this.template.Name = "template";
            this.template.Size = new System.Drawing.Size(1002, 631);
            this.template.TabIndex = 0;
            // 
            // Editor
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 680);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.officeNavigationBar1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Editor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件配置编辑器";
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar1;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navCfg;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navTemplete;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navExample;
        private DevExpress.LookAndFeel.DefaultLookAndFeel DLAF;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Control.Template template;
    }
}