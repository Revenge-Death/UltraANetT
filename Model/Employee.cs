using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public virtual string No { get; set; }
        public virtual string Name { get; set; }
        public virtual string Role { get; set; }
        public virtual string Department { get; set; }
        public virtual string Sex { get; set; }
        public virtual string TelePhone { get; set; }
        public virtual string Mail { get; set; }
        public virtual string Password { get; set; }
        //public virtual object Portrait { get; set; }
        public virtual string Remark { get; set; }
    }
}
