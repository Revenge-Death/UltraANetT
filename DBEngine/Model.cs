
using System;
using System.Net.Mime;

namespace DBEngine
{
    /// <summary>
    /// 车辆授权表
    /// </summary>
    public class VehicelAuthorization
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
    /// <summary>
    /// 员工表
    /// </summary>
    public class Empolyee
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

    /// <summary>
    /// 部门表
    /// </summary>
    public class Department
    {
        public virtual string  Name { get; set; }
        public virtual string Master { get; set; }
        public virtual int NumberInDept { get; set; }
        public virtual string Remark { get; set; }
    }
}
