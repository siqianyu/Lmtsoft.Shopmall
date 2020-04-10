using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class ProofTemple
    {
        public int Id { get; set; }
        public string TempleName { get; set; }
        public int? Sort { get; set; }
        public string Status { get; set; }
        public int? OperateId { get; set; }
        public string OperateName { get; set; }
        public string OperateRealName { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Vest { get; set; }
        public string Demo { get; set; }
        public string RoleIds { get; set; }
        public string RoleNames { get; set; }
    }
}
