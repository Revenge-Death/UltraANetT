using System;
using System.Collections.Generic;
using System.Data;

namespace DBEngine
{
    public class Store : IStore
    {

        public bool AddDepartment(List<Department> dept)
        {
            throw new NotImplementedException();
        }

        public bool AddEmpolyee(List<Empolyee> emp)
        {
            //List<VehicelAuthorization> list = new List<VehicelAuthorization>();
            //var veh = new VehicelAuthorization();
            //list.Add(veh);
            //var sql = new BaseSqlOrder();
            //sql.Add(list);
            return true;
        }

        public bool AddVehAuthorization(List<VehicelAuthorization> veh)
        {
            BaseSqlOrder.Add(veh);
            return true;
        }

        public DataTable GetTableByQuery(string[] colNames, string query)
        {
            var dt = new DataTable();
            foreach (var colName in colNames)
            {
                dt.Columns.Add(new DataColumn(colName, typeof(object)));
            }
           IList<object[]> departmentList =  BaseSqlOrder.GetQuery(query);
            foreach (var dept in departmentList)
            {
                dt.Rows.Add(dept);
            }
            return dt;
        }
    }
}
