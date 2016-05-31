using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ProcessEngine
{
    public class ProcFile:IProcXml
    {
        private static readonly XmlDocument Doc = new XmlDocument();
        #region 读取本地xml指定节点的值

        /// <summary>
        ///     读取本地xml指定节点的值(返回为空时,读取失败)
        /// </summary>
        /// <param name="xmlName">xml文件名称</param>
        /// <param name="nodeStr">指点节点</param>
        /// <returns>返回节点值</returns>
        public string ReadLocalXml(string xmlName, string nodeStr)
        {

            try
            {
                Doc.Load(AppDomain.CurrentDomain.BaseDirectory + xmlName); //加载本地文件
                //分析文件
                var nodeValue = Doc.SelectSingleNode(nodeStr);
                if (nodeValue == null) return string.Empty;
                var value = nodeValue.InnerText.Trim();
                return value;
            }
            catch
            {
                return string.Empty;
            }
        }

        #endregion

        #region 更改本地XML指定节点的值
        /// <summary>
        ///     更改本地XML指定节点的值
        /// </summary>
        /// <param name="xmlName">xml文档的名称</param>
        /// <param name="nodeStr">指定节点</param>
        /// <param name="value">节点的值</param>
        /// <returns>返回更改成功与否</returns>
        public bool UpdateLocalXml(string xmlName, string nodeStr, string value)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(AppDomain.CurrentDomain.BaseDirectory + xmlName);
                XmlNode xnuser = doc.SelectSingleNode(nodeStr);
                if (xnuser != null) xnuser.FirstChild.InnerText = value;
                doc.Save(AppDomain.CurrentDomain.BaseDirectory + xmlName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}
