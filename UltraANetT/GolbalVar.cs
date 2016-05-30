using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;

namespace UltraANetT
{
    public class GolbalVar
    {
        /// <summary>
        /// xml存放地址
        /// </summary>
        public static string VehicelXmlPath = @"xml\vehicelTree.xml";

        public static string UserName = "";

        public static string UserRole = "";
        /// <summary>
        /// 当前节点及其父节点的名称集合
        /// </summary>
        public static Dictionary<string,string> CurrentNodeNameList = new Dictionary<string, string>();
    }
}