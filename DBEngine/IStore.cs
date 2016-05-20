using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DBEngine
{
    public interface IStore
    {
        bool AddVehAuthorization(List<VehicelAuthorization> veh);

        bool AddEmpolyee(List<Empolyee> emp);

        bool AddDepartment(List<Department> dept);

        DataTable GetTableByQuery(string[] colNames,string query);
    }
}
