using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class BaseManager
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? RoleType { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string RealName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int? Sex { get; set; }
        public int? IsLock { get; set; }
        public string Pro { get; set; }
        public string ProName { get; set; }
        public string City { get; set; }
        public string CityName { get; set; }
        public string Area { get; set; }
        public string AreaName { get; set; }
        public string Address { get; set; }
        public string Demo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? OperateId { get; set; }
        public string OperateName { get; set; }
        public string OperateRealName { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Vest { get; set; }
        public string Token { get; set; }
        public DateTime? OnlineTime { get; set; }
        public string AllMenu { get; set; }
        public string AllButton { get; set; }
        public int? IsAdmin { get; set; }
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string JobId { get; set; }
        public string JobName { get; set; }
    }
}
