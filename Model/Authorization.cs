using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Authorization
    {
        public virtual string VehicelType { get; set; }
        public virtual string VehicelConfig { get; set; }
        public virtual string VehicelStage { get; set; }
        public virtual DateTime CreateTime { get; set; }
        public virtual string Creater { get; set; }
        public virtual string AuthorizeTo { get; set; }
        public virtual string AuthorizedFromDept { get; set; }
        public virtual DateTime AuthorizationTime { get; set; }
        public virtual DateTime InvaildTime { get; set; }
        public virtual string Remark { get; set; }
    }
}
