using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessEngine
{
    public interface IProcXml
    {
        string ReadLocalXml(string xmlName, string nodeStr);

        bool UpdateLocalXml(string xmlName, string nodeStr, string value);

    }
}
