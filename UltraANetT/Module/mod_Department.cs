using System.Data;
using System.Linq;
using DevExpress.XtraEditors;
using DBEngine;
using DevExpress.Utils.FormShadow;
using DevExpress.XtraGrid.Views.Grid;

namespace UltraANetT.Module
{
    // ReSharper disable once InconsistentNaming
    public partial class mod_Department : XtraUserControl
    {
        private bool isEditable = false;
        private readonly IStore _store = new Store();
        public mod_Department()
        {
            InitializeComponent();
            InitGrid();
        }

        private void InitGrid()
        {
            string[] colNames = {"Name", "Master", "NumberInDept", "Remark"};
            var dt =_store.GetTableByQuery(colNames, ExcuteSqlCase.Department_Query());
            gcDepartment.DataSource = dt;
        }

        private void btEditOrSave_Click(object sender, System.EventArgs e)
        {
            if (isEditable)
            {
                gvDepartment.OptionsBehavior.ReadOnly = false;
                gvDepartment.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                isEditable = !isEditable;
            }
            else
            {
                gvDepartment.OptionsBehavior.ReadOnly = true;
                gvDepartment.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                isEditable = !isEditable;
            }
          
        }
    }
}