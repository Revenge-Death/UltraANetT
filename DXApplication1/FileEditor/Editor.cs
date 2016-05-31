using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using FileEditor.Control;
using ProcessEngine;

namespace FileEditor
{
    public partial class Editor : DevExpress.XtraEditors.XtraForm
    {
        private ITemplate _tem;
        private IProcBefShow _show;

        public Editor()
        {
            InitializeComponent();
            GetTemStauts(null);
            //_tem = template;
            _show = new ProcDB();
            LoadTemporaryFile();
            DrawLeftNav(TemplateNameList());
            

        }



        #region 得到模板状态
        private EnumLibrary.TemStatus GetTemStauts(List<string> nodeList)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region 加载临时文件

        private void LoadTemporaryFile()
        {
            if (File.Exists(GlobalVar.TemporaryFilePath))
                _tem.LoadFile(GlobalVar.TemporaryFilePath);
           

        }

        #endregion

        #region 加载模板名称列表

        private List<string> TemplateNameList()
        {
            //查询模板表，取出模板名称和模板内容，内容放进globalVar
            GlobalVar.ByteCfgTemplate = null;
            throw new NotImplementedException();
        }

        #endregion

        #region 渲染左侧导航栏

        private List<string> DrawLeftNav(List<string > temList)
        {
            //根据名称渲染左侧导航栏
            throw new NotImplementedException();
        }

        #endregion

      

        #region 解析数据库

        #endregion

       

        private void navEditor_ItemClick(object sender, DevExpress.XtraBars.Navigation.NavigationBarItemEventArgs e)
        {
            //异常处理
            var itemBar = sender as NavigationBarItem;
            if (itemBar == navCfg)
            {
            }
            else if (itemBar == navExample)
            {
            }
            else if (itemBar == navTemplete)
            {
                _show.ProDBC(ref GlobalVar.CANNameList,ref GlobalVar.GetNodeFromDBC,GlobalVar.CurrentNodeNameList);
            }
        }
    }
}