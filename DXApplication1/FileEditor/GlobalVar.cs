using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FileEditor
{
    public class GlobalVar
    {
        public static Dictionary<string, string> CurrentNodeNameList = new Dictionary<string, string>();

        public static string TemporaryFilePath = "";

        public static List<string> CANNameList = new List<string>();

        public static List<Dictionary<string,string[]>> NodeList = new List<Dictionary<string, string[]>>();


    }
}
