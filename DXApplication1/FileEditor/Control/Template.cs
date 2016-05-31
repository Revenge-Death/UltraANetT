using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Model;
using ProcessEngine;
using Worksheet = DevExpress.Spreadsheet.Worksheet;

namespace FileEditor.Control
{
    public partial class Template : XtraUserControl
    {
        private IWorkbook _book;
        private Worksheet _sheet;
        private IProcBefStore _store;
        int _initRow = 2;//initRow = X 其中X可能需要自定义
        int _initCol = 0;//同上
        public Template()
        {
            InitializeComponent();
            _store = new ProcDB();
            
        }

        private void NameItem_Click(object sender, EventArgs e)
        {
            LoadBaseContent("");
            FillCANRoad();
        }

        private static int GetColCountFromCANConfig()
        {
            //从配置模板中读取，如果过程复杂，则先在Proc类中处理
            return 13;
        }

        private static List<int> GetGrpNumByNode()
        {
            return GlobalVar.CANNameList.Select(canName => GlobalVar.NodeList[canName].Count).ToList();
        }

        private void LoadFile(string filePath)
        {
            ctlExcelConfig.LoadDocument(@"D:\新平台CAN相关配置表.xlsx");

            _book = ctlExcelConfig.Document;
            _sheet = _book.Worksheets[0];
            
        }

        private string GetDictBaudFromTem(Range r)
        {
            int row = 0;
            int col = 0;
            Dictionary<string,string> dictBaud = new Dictionary<string, string>();
            foreach (var canName in GlobalVar.CANNameList)
            {
                dictBaud.Add(canName,r[row][col].Value.TextValue);
                row++;
            }
           return _store.SerBaudToJson(dictBaud);
        }

        private string SerConfigToJson(Range r, List<int> rowList)
        {
            string currentNode = "";
              List<Dictionary<string, List<Dictionary<string, string>>>> nodeList =
                new List<Dictionary<string, List<Dictionary<string, string>>>>();
            Dictionary<string, List<Dictionary<string, string>>> dictNode = new Dictionary<string, List<Dictionary<string, string>>>(); 
            
            for (int row = 0; row < r.RowCount; row++)
            {
                int col = 0;
                Dictionary<string,string> dictItem = new Dictionary<string, string>();
                if (currentNode == "" || currentNode == r[row][col].Value.TextValue)
                {       
                    if(currentNode == "")
                        dictNode = new Dictionary<string, List<Dictionary<string, string>>> {{currentNode, null}};
                    currentNode = r[row][col].Value.TextValue;
                }
                else if (currentNode != r[row][col].Value.TextValue)
                {
                    if (dictNode.Count != 0)
                        nodeList.Add(dictNode);
                    dictNode = new Dictionary<string, List<Dictionary<string, string>>> { { currentNode, null } };
                }

                foreach (var item in dictItem.Keys)
                {
                    dictItem[item] = r[row][col + 1].Value.TextValue;
                    col++;
                }
                dictNode[currentNode].Add(dictItem);
            }

            return _store.SerConfigToJson(nodeList);
        }

        #region 加载Excel基本内容

        private void LoadBaseContent(string temName)
        {
            //取得模板表的内容
        }

        #endregion

        private void btnSubmit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Range rBaud = _sheet.Range["A"+_initRow + ":" + "B" + _initRow + GlobalVar.CANNameList.Count];//数据库中读出来的CAN数
            GetDictBaudFromTem(rBaud);
            int configRow = _sheet.GetDataRange().RowCount - _initRow + GlobalVar.CANNameList.Count - 1;
            GetColCountFromCANConfig(); //得到第X列
            Range rConfig = _sheet.Range["A" + _initRow + GlobalVar.CANNameList.Count +2 + ":" + "M" + _initRow + GlobalVar.CANNameList.Count + 2 + configRow];

            SerConfigToJson(rConfig, GetGrpNumByNode());
        }

        private void FillCANRoad()
        {
            //插入X行
            _sheet.Rows.Insert(2,GlobalVar.CANNameList.Count);

            foreach (var name in GlobalVar.CANNameList)
            {
                _sheet.Rows[_initRow][_initCol].SetValue(name);
            }
        }

        private void FillConfigByCANRoad(string canRoad)
        {
           Range r = _sheet.GetDataRange();
            int initRow = r.RowCount;
            foreach (var dict in GlobalVar.NodeList[canRoad])// 后期关于CAN路的顺序可能需要处理
            {
                //填充内容
            }
        }

        private Dictionary<string, string> InitDict(Dictionary<string,string> dict)
        {
            dict.Add("DUTname", "");
            dict.Add("SlaveboxID", "");
            dict.Add("TerminalR", "");
            dict.Add("NodeType", "");
            dict.Add("OSEKMsgID", "");
            dict.Add("baseNMID", "");
            dict.Add("IsLocalEvent", "");
            dict.Add("LocalEventIO", "");
            dict.Add(".EnableLevel", "");
            dict.Add("LocalEventName", "");
            return dict;
        }
    }
}
