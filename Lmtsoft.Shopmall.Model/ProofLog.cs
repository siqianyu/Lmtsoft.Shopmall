using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class ProofLog
    {
        public int Id { get; set; }
        public int? ProofId { get; set; }
        public string Status { get; set; }
        public string Demo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? OperateId { get; set; }
        public string OperateName { get; set; }
        public string OperateRealName { get; set; }
        public int? OperateRoleId { get; set; }
        public string OperateRoleName { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Vest { get; set; }
    }
}
