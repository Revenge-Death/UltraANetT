using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using ProcessEngine;
using UltraANetT.Properties;

namespace UltraANetT.Module
{
   
    public partial class Vehicel : XtraUserControl
    {
        private readonly List<string> _rootNodes = new List<string>();
        private readonly List<List<string>> _secondaryNodes = new List<List<string>>();
        private readonly List<List<string>> _finalNodes = new List<List<string>>();
        private readonly IProcBefShow _show = new ProcDB();
        private IProcBefStore _store = new ProcDB();
        public Vehicel()
        {
          
            InitializeComponent();
            BingEvent();
            DrawVehicelTree();
            LoadTreeListFromXml(GolbalVar.VehicelXmlPath);
            //GetAllNodesByRank();
            //InitGrid();
            
        }

        private void InitGrid()
        {
            //((RepositoryItemComboBox)gvVechiel.Columns["VehicelType"].ColumnEdit).SelectedValueChanged += VCCombox_SelectedIndexChanged;
            //((RepositoryItemComboBox)gvVechiel.Columns["VehicelConfig"].ColumnEdit).SelectedValueChanged += VSCombox_SelectedIndexChanged;
            var coList = new List<string>();
            foreach (GridColumn col in gvVechiel.Columns)
                coList.Add(col.FieldName);
            var dt = _show.GetDataTable(coList.ToArray(), EnumLibrary.EnumTable.Authorization);
            gcVechiel.DataSource = dt;
        }

        private void vehicelTree_MouseDown(object sender, MouseEventArgs e)
        {
            var node = vehicelTree.CalcHitInfo(new Point(e.X, e.Y)).Node;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (node == null) return;
                    if (!node.HasChildren)
                    {
                        //GolbalVar.CurrentNodeNameList = GetCurrentAndParentNode(node);
                        return;
                    }
                    ResetAllCombox();
                    break;
                case MouseButtons.Right:
                    ShowCmsByNode(node);
                    break;
            }
        }

        
        private void vehicelTree_ShownEditor(object sender, EventArgs e)
        {
            vehicelTree.OptionsBehavior.Editable = false;
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

        private void PanelMouse_Hover(object sender, EventArgs e)
        {
            var pl = sender as PanelControl;
            if (pl == null) return;
            if (pl == plFirst)
                plFirst.ContentImage = Resources.first_hover;
            else if (pl == plSecond)
                plSecond.ContentImage = Resources.second_hover;
            else if (pl == plThird)
                plThird.ContentImage = Resources.third_hover;
            else if (pl == plFour)
                plFour.ContentImage = Resources.fourth_hover;
        }
        private void PanelMouse_Leave(object sender, EventArgs e)
        {
            var pl = sender as PanelControl;
            if (pl == null) return;
            if (pl == plFirst)
                plFirst.ContentImage = Resources.first;
            else if (pl == plSecond)
                plSecond.ContentImage = Resources.second;
            else if (pl == plThird)
                plThird.ContentImage = Resources.third;
            else if (pl == plFour)
                plFour.ContentImage = Resources.fourth;
        }

        #region 新建事件

        private void Create_Click(object sender, EventArgs e)
        {
            var tsmi = sender as ToolStripMenuItem;
            TreeListNode node = null;
            if (tsmi == tsmiCreateVehicel)
            {
                node = vehicelTree.FocusedNode.Nodes.Add(new object[] { "New Vehicel" });
            }
            else if (tsmi == tsmiCreatTask)
            {
                if (vehicelTree.FocusedNode == null) return;
                node = vehicelTree.FocusedNode.Nodes.Add(new object[] { "New Task" });
            }
            else if (tsmi == tsmiCreateStage)
            {
                if (vehicelTree.FocusedNode == null) return;
                node = vehicelTree.FocusedNode.Nodes.Add(new object[] { "New Stage" });
            }
            vehicelTree.FocusedNode = node;
            StartEdit();
            SaveTreeList(GolbalVar.VehicelXmlPath);
        }

        #endregion

        #region 编辑事件
        private void ReName_Click(object sender, EventArgs e)
        {
            StartEdit();
        }
        #endregion

        #region 删除事件

        private void Del_Click(object sender, EventArgs e)
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
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        private bool LoadTreeListFromXml(string xmlPath)
        {
            if (!File.Exists(xmlPath)) return false;
            vehicelTree.ImportFromXml(AppDomain.CurrentDomain.BaseDirectory + xmlPath);
            return true;
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

        #region 绘制车型树颜色
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

        #region 重置所有combox集合
        /// <summary>
        /// 重置所有combox集合
        /// </summary>
        private void ResetAllCombox()
        {
         
        }
        #endregion

        #region 根据索引更新车型配置集合

        private void UpdateVcComboxByIndex(int index)
        {
            //if (cbVehicelStage.Enabled)
            //    cbVehicelStage.Enabled = false;
            //List<List<string>> copySecondaryNodes = new List<List<string>> {_secondaryNodes[index]};
            //cbVehicelConfig.Items.Clear();
            ////重新得到数据集合
            //cbVehicelConfig.Items.AddRange(GetSecondaryNodesName(copySecondaryNodes));
        }

        #endregion

        #region 根据索引更新车型阶段集合
        private void UpdateVsComboxByIndex(int index)
        {
            //List<List<string>> copyFinalNodes = new List<List<string>> { _finalNodes[index] };
            //cbVehicelConfig.Items.Clear();
            ////重新得到数据集合
            //cbVehicelStage.Items.AddRange(GetFinalNodesName(copyFinalNodes));
        }

        #endregion

        #region 获得节点数组
        /// <summary>
        /// 
        /// </summary>
        private void GetAllNodesByRank()//考虑递归版本是否更好
        {
            var treeList = vehicelTree.Nodes.ToList();

            for (var i = 0; i < treeList.Count; i++)//获得一级节点集合
            {
                _rootNodes.Add(treeList[i].GetDisplayText("colName"));
                var secondaryNodesCache = new List<string>();
                for (var j = 0; j < treeList[i].Nodes.Count; j++)//获得二级节点集合
                {
                    secondaryNodesCache.Add(treeList[i].Nodes[j].GetDisplayText("colName"));
                    var finalNodeCache = new List<string>();
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
        private static List<string> GetCurrentAndParentNode(TreeListNode node)
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

        #region 绑定事件
        private void BingEvent()
        {
            plFirst.MouseHover += PanelMouse_Hover; ;
            plSecond.MouseHover += PanelMouse_Hover;
            plThird.MouseHover += PanelMouse_Hover;
            plFour.MouseHover += PanelMouse_Hover;

            plFirst.MouseLeave += PanelMouse_Leave;
            plSecond.MouseLeave += PanelMouse_Leave;
            plThird.MouseLeave += PanelMouse_Leave;
            plFour.MouseLeave += PanelMouse_Leave;

            tsmiReNameStage.Click += ReName_Click;
            tsmiReNameTask.Click += ReName_Click;
            tsmiReNameVehicel.Click += ReName_Click;

            tsmiDelStage.Click += Del_Click;
            tsmiDelTask.Click += Del_Click;
            tsmiDelVehicel.Click += Del_Click;

            tsmiCreateVehicel.Click += Create_Click;
            tsmiCreatTask.Click += Create_Click;
            tsmiCreateStage.Click += Create_Click;

        }

        #endregion


        private void plSecond_Click(object sender, EventArgs e)
        {
            var process = new Process
            {
                StartInfo =
                    {
                        FileName = AppDomain.CurrentDomain.BaseDirectory + "FileEditor.exe",
                        UseShellExecute = true
                    }
            };
            process.Start();
        }
    }
}