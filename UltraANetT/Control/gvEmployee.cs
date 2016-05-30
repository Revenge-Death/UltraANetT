using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using ProcessEngine;
using UltraANetT.Form;

namespace UltraANetT.Control
{
    // ReSharper disable once InconsistentNaming
    public partial class gvEmployee : XtraUserControl
    {
        public gvEmployee()
        {
            InitializeComponent();
            //InitGrid();
            //InitEmpDict();
        }

        private void gridView_RowClick(object sender, RowClickEventArgs e)
        {
           
        }

        private void gridView_MouseDown(object sender, MouseEventArgs e)
        {
            var hInfo = gridView.CalcHitInfo(new Point(e.X, e.Y));
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                //判断光标是否在行范围内 
                if (hInfo.InRow)
                {
                    var contact = new Contact();
                    contact.Show();
                }
            }
        }

        #region 提交数据
        /// <summary>
        /// 提交数据
        /// </summary>
        private void Submit()
        {
        }
        #endregion

        #region 从界面控件上获得数据
        /// <summary>
        ///  从界面上获得数据集合
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, object> GetData()
        {
            return null;
        }
        #endregion

        #region 向界面控件上设置数据
        private void SetData(DataRow selectedRow)
        {
        }
        #endregion

        #region 初始化Dict
        /// <summary>
        /// 初始化Dict
        /// </summary>
        private void InitEmpDict()
        {
        }
        #endregion

        #region 初始化gridView
        /// <summary>
        /// 初始化gridView
        /// </summary>
        private void InitGrid()
        {
            
        }
        #endregion

    }
}