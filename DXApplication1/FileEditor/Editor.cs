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
            //GetTemStauts(null);
            _tem = template;
            _show = new ProcDB();
            //LoadTemporaryFile();

        }



        #region 得到模板状态
        private TemStatus GetTemStauts(List<string> nodeList)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region 加载临时文件

        private void LoadTemporaryFile()
        {
            if (File.Exists(GlobalVar.TemporaryFilePath))
                _tem.LoadFile(GlobalVar.TemporaryFilePath);
            else
            {
                _show.ProDBC(ref GlobalVar.CANNameList, ref GlobalVar.NodeList, GlobalVar.CurrentNodeNameList);
            }

        }

        #endregion

        #region 加载Excel

        #endregion

        private enum TemStatus
        {
            Independence,
            Dependence
        }
    }
}