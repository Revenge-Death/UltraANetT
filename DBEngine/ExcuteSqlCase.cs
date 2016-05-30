using System.Collections.Generic;

namespace DBEngine
{
    public class ExcuteSqlCase
    {
        public static string VehicelAuthorization_Update(string colName, string updateData, string type, string config,
            string stage)
        {
            var updateStr = "update Authorization set " + colName + " = '" + updateData +
                            "' where VehicelType = '" + type + "' and VehicelConfig = '" + config +
                            "' and VehicelStage = '" + stage + "'";
            return updateStr;
        }

        public static string VehicelAuthorization_Del(string type, string config,  string stage)
        {
            var delStr = "delete from Authorization where VehicelType = '" + type + "' and VehicelConfig = '" + config +
                            "' and VehicelStage = '" + stage + "'";
            return delStr;
        }

        public static string VehicelAuthorization_Query()
        {
            const string queryStr = "select * from Authorization";
            return queryStr;
        }

        public static string Department_Query()
        {
            const string queryStr = "select * from Department";
            return queryStr;
        }
        public static string Department_Update(Dictionary<string, object> dept)
        {
            var updateStr = "update Authorization set Name= '" + dept["Name"] +
                "',Master='"+ dept["Master"] + 
                "',NumForDept='"+ dept["NumForDept"] +
                "',Remark='"+dept["Remark"]+
                "' where Name = '" + dept["Name"] + "' ";
                        
            return updateStr;
        }
        public static string Department_Del(string keyName)
        {
            var delStr = "delete from Department where Name = '" + keyName + "'";
            return delStr;
        }

        public static string DBC_Select(Dictionary<string, string> dbc)
        {
            var selStr = "select * from DBC where VehicelType = '" + dbc["VehicelType"] + "'" +
                         "VehicelConfig = '" + dbc["VehicelConfig"] + "'" +
                         "VehicelStage = '" + dbc["VehicelStage"] + "'";
            return selStr;
        }
    }
}