using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using UltraANetT.Properties;

namespace UltraANetT.Module
{
   
    public partial class Vehicel : XtraUserControl
    {
        private readonly List<string> _rootNodes = new List<string>();
        private readonly List<List<string>> _secondaryNodes = new List<List<string>>();
        private readonly List<List<string>> _finalNodes = new List<List<string>>();
        public Vehicel()
        {
          
            InitializeComponent();
            DrawVehicelTree();
            LoadTreeList(GolbalVar.XmlPath);
            GetNodesList();
            InitGrid();
        }

        private void InitGrid()
        {
            ((RepositoryItemComboBox)gvVechiel.Columns["VehicelType"].ColumnEdit).SelectedValueChanged += VCCombox_SelectedIndexChanged;
            ((RepositoryItemComboBox)gvVechiel.Columns["VehicelConfig"].ColumnEdit).SelectedValueChanged += VSCombox_SelectedIndexChanged;
            var dt = new DataTable();
            string[] colNames =
            {
                "VehicelType", "VehicelConfig", "VehicelStage", "CreatTime", "CreatPerson", "AuthorizeTo",
                "FromDepartment", "AuthorizationTime", "AuthorizationDept"
            };

            for (var i = 0; i < colNames.Count(); i++)
            {
                dt.Columns.Add(new DataColumn(colNames[i], typeof (object)));
            }
            gcVechiel.DataSource = dt;
        }

        private void vehicelTree_MouseDown(object sender, MouseEventArgs e)
        {
            var node = vehicelTree.CalcHitInfo(new Point(e.X, e.Y)).Node;
            switch (e.Button)
            {
                    case MouseButtons.Left:     
                    if(node == null) return;
                    if (node.HasChildren)
                    {
                        gvVechiel.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                        return;
                    }
                    IsShowNewItemByNode(node);
                    ResetAllCombox();
                    break;
                    case MouseButtons.Right:
                    ShowCmsByNode(node);
                    break;
            }         
        }
      
        #region 新建功能
        private void tsmiCreateVehicel_Click(object sender, EventArgs e)
        {
            var node = vehicelTree.AppendNode(new object[] { "New Vehicel" }, -1);
            //node.StateImageIndex = 1;//暂时不要图片
            vehicelTree.FocusedNode = node;
            StartEdit();
            SaveTreeList(GolbalVar.XmlPath);
        }

        private void tsmiCreatTask_Click(object sender, EventArgs e)
        {
            if (vehicelTree.FocusedNode == null) return;
            var node = vehicelTree.FocusedNode.Nodes.Add(new object[] { "New Task" });//可不可以初始化时增加图标
            //node.StateImageIndex = 0;//暂时不要图片
            vehicelTree.FocusedNode = node;
            StartEdit();
            SaveTreeList(GolbalVar.XmlPath);
        }

        private void tsmiCreateStage_Click(object sender, EventArgs e)
        {
            if (vehicelTree.FocusedNode == null) return;
            var node = vehicelTree.FocusedNode.Nodes.Add(new object[] { "New Stage" });
            //node.StateImageIndex = 2;//暂时不要图片
            vehicelTree.FocusedNode = node;
            StartEdit();
            SaveTreeList(GolbalVar.XmlPath);
        }
        #endregion

        #region 编辑功能
        private void tsmiReNameVehicel_Click(object sender, EventArgs e)
        {
            StartEdit();
        }

        private void tsmiReNameTask_Click(object sender, EventArgs e)
        {
            StartEdit();
        }

        private void tsmiReNameStage_Click(object sender, EventArgs e)
        {
            StartEdit();
        }
        #endregion

        private void vehicelTree_ShownEditor(object sender, EventArgs e)
        {
            vehicelTree.OptionsBehavior.Editable = false;
        }

        #region 删除功能
        private void tsmiDelVehicel_Click(object sender, EventArgs e)
        {
        }

        private void tsmiDelTask_Click(object sender, EventArgs e)
        {
        }

        private void tsmiDelStage_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region 使树节点可以编辑

        /// <summary>
        ///     使树节点可以编辑
        /// </summary>
        private void StartEdit()
        {
            if (vehicelTree.FocusedNode == null) return;
            vehicelTree.OptionsBehavior.Editable = true;
            vehicelTree.VisibleColumns[0].OptionsColumn.AllowFocus = true;
            vehicelTree.FocusedColumn = vehicelTree.VisibleColumns[0];
            vehicelTree.ShowEditor();
        }

        #endregion

        #region 制车型树车型管理的右键菜单[暂时无用]

        /// <summary>
        ///     绘制车型树车型管理的右键菜单
        /// </summary>
        /// <param name="isUsable"></param>
        private void DrawCmsVehicel(bool isUsable)
        {
            if (!isUsable)
            {
                for (var i = 1; i < CMSCreate.Items.Count; i++)
                    CMSCreate.Items[i].Enabled = false;
            }
            else
            {
                for (var i = 1; i < CMSCreate.Items.Count; i++)
                    CMSCreate.Items[i].Enabled = true;
            }
        }

        #endregion

        #region 保存树节点
        /// <summary>
        /// 保存树节点
        /// </summary>
        /// <returns></returns>
        private bool SaveTreeList(string filePath)
        {
            if (!File.Exists(filePath)) return false;
            vehicelTree.ExportToXml(AppDomain.CurrentDomain.BaseDirectory + filePath);
            return true;
        }

        #endregion

        #region 读取树节点
        /// <summary>
        /// 读取树节点
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private bool LoadTreeList(string filePath)
        {
            if (!File.Exists(filePath)) return false;
            vehicelTree.ImportFromXml(AppDomain.CurrentDomain.BaseDirectory + filePath);
            return true;
        }
        #endregion

        #region 根据右侧树节点判断是否显示新增行按钮
        /// <summary>
        /// 根据右侧树节点判断是否显示新增行按钮
        /// </summary>
        /// <param name="node"></param>
        private void IsShowNewItemByNode(TreeListNode node)
        {
            var level = node.Level;
            switch (level)
            {
                case 2:
                    gvVechiel.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                    break;
            }
        }

        #endregion

        #region 根据条件判断显示那个下拉菜单

        private void ShowCmsByNode(TreeListNode node)
        {
            if (node == null)
            {
                vehicelTree.ContextMenuStrip = CMSCreate;
                return;
            }
            vehicelTree.FocusedNode = node;
            var level = node.Level;
            switch (level)
            {
                case 0:
                    vehicelTree.ContextMenuStrip = CMSVehicel;
                    break;
                case 1:
                    vehicelTree.ContextMenuStrip = CMSTask;
                    break;
                case 2:
                    vehicelTree.ContextMenuStrip = CMSStage;
                    break;
            }
        }

        #endregion

        #region 获得节点数组

        private void GetNodesList()//考虑递归版本是否更好
        {
            var treeList = vehicelTree.Nodes.ToList();
          
            for (var i = 0; i < treeList.Count; i++)//获得一级节点集合
            {
                _rootNodes.Add(treeList[i].GetDisplayText("colName"));
                List<string> secondaryNodesCache = new List<string>();
                for (var j = 0; j < treeList[i].Nodes.Count; j++)//获得二级节点集合
                {
                    secondaryNodesCache.Add(treeList[i].Nodes[j].GetDisplayText("colName"));
                    List <string> finalNodeCache = new List<string>();
                    for (var k = 0; k < treeList[i].Nodes[j].Nodes.Count; k++)//获得三级节点集合
                    {
                        finalNodeCache.Add(treeList[i].Nodes[j].Nodes[k].GetDisplayText("colName"));
                    }
                    _finalNodes.Add(finalNodeCache);
                }     
             _secondaryNodes.Add(secondaryNodesCache);        
            }                      
        }

        #endregion

        #region 获得当前节点及其父节点
        /// <summary>
        /// 获得当前节点及其父节点
        /// </summary>
        /// <param name="node">当前节点</param>
        /// <returns></returns>
        private static List<string> GetParentNodes(TreeListNode node)
        {
            List<string> nodes = new List<string>
            {
                node.ParentNode.ParentNode.GetDisplayText("colName"),
                node.ParentNode.GetDisplayText("colName"),
                node.GetDisplayText("colName")
            };
            return nodes;
        }

        #endregion

        #region 获得二级节点名称数组

        private List<string> GetSecondaryNodesName(IEnumerable<List<string>> secondaryNodesList)
        {
            List<string> secondaryNodesName = new List<string>();
            foreach (var nodes in secondaryNodesList)
            {
                secondaryNodesName.AddRange(nodes);
            }
            return secondaryNodesName;
        }

        #endregion

        #region 获得三级节点名称数组

        private List<string> GetFinalNodesName(IEnumerable<List<string>> finalNodesList)
        {
            List<string> secondaryNodesName = new List<string>();
            foreach (var nodes in finalNodesList)
            {
                secondaryNodesName.AddRange(nodes);
            }
            return secondaryNodesName;
        }

        #endregion

        #region 绘制车型树
        /// <summary>
        ///     绘制车型树，变更颜色
        /// </summary>
        private void DrawVehicelTree()
        {
            var controlColor = CommonSkins.GetSkin(UserLookAndFeel.Default).Colors.GetColor("Control");
            vehicelTree.Appearance.Empty.BackColor = controlColor;
            vehicelTree.Appearance.Row.BackColor = controlColor;
        }
        #endregion


        private void btSubmit_Click(object sender, EventArgs e)
        {
           
        }


        private void VCCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = ((ComboBoxEdit)sender).SelectedIndex;
            UpdateVcComboxByIndex(selectedIndex);//Vc = vehicel config
        }

        private void VSCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = ((ComboBoxEdit)sender).SelectedIndex;
            UpdateVsComboxByIndex(selectedIndex);//Vs = vehicel stage
        }

        private void tsmiRefresh_Click(object sender, EventArgs e)
        {

        }
        #region 重置所有combox集合
        /// <summary>
        /// 重置所有combox集合
        /// </summary>
        private void ResetAllCombox()
        {
            //清空原有数据集合
            cbVehicelConfig.Items.Clear();
            cbVehicelType.Items.Clear();
            cbVehicelStage.Items.Clear();
            //重新得到数据集合
            cbVehicelConfig.Items.AddRange(GetSecondaryNodesName(_secondaryNodes));
            cbVehicelType.Items.AddRange(_rootNodes);
            cbVehicelStage.Items.AddRange(GetFinalNodesName(_finalNodes));

            cbVehicelConfig.Enabled = false;
            cbVehicelStage.Enabled = false;
        }
        #endregion

        #region 根据索引更新车型配置集合

        private void UpdateVcComboxByIndex(int index)
        {
            if (cbVehicelStage.Enabled)
                cbVehicelStage.Enabled = false;
            List<List<string>> copySecondaryNodes = new List<List<string>> {_secondaryNodes[index]};
            cbVehicelConfig.Items.Clear();
            //重新得到数据集合
            cbVehicelConfig.Items.AddRange(GetSecondaryNodesName(copySecondaryNodes));
        }

        #endregion

        #region 根据索引更新车型阶段集合
        private void UpdateVsComboxByIndex(int index)
        {
            List<List<string>> copyFinalNodes = new List<List<string>> { _finalNodes[index] };
            cbVehicelConfig.Items.Clear();
            //重新得到数据集合
            cbVehicelStage.Items.AddRange(GetFinalNodesName(copyFinalNodes));
        }
        #endregion

    }
}