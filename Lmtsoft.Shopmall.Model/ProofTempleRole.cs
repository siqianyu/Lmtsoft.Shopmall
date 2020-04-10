using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class ProofTempleRole
    {
        public int Id { get; set; }
        public int? TempleId { get; set; }
        public string TempleName { get; set; }
        public int? Step { get; set; }
        public int? RoleId { get; set; }
        public string RoleName { get; set; }
        public int? IsJump { get; set; }
        public string Status { get; set; }
        public int? OperateId { get; set; }
        public string OperateName { get; set; }
        public string OperateRealName { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Vest { get; set; }
        public string Limits { get; set; }
    }
}
