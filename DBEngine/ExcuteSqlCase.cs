namespace DBEngine
{
    public class ExcuteSqlCase
    {
        public static string VehicelAuthorization_Update(string colName, string updateData, string type, string config,
            string stage)
        {
            var updateStr = "update VehicelAuthorization set " + colName + " = '" + updateData +
                            "' where VehicelType = '" + type + "' and VehicelConfig = '" + config +
                            "' and VehicelStage = '" + stage + "'";
            return updateStr;
        }

        public static string VehicelAuthorization_Del(string type, string config,  string stage)
        {
            var delStr = "delete from VehicelAuthorization where VehicelType = '" + type + "' and VehicelConfig = '" + config +
                            "' and VehicelStage = '" + stage + "'";
            return delStr;
        }

        public static string VehicelAuthorization_Query()
        {
            const string queryStr = "select * from VehicelAuthorization";
            return queryStr;
        }

        public static string Department_Query()
        {
            const string queryStr = "select * from Department";
            return queryStr;
        }
    }
}