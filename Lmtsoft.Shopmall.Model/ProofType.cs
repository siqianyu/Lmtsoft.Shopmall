using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class ProofType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Demo { get; set; }
        public string Status { get; set; }
        public int? Sort { get; set; }
        public int? ParentId { get; set; }
        public string ParentName { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? OperateId { get; set; }
        public string OperateName { get; set; }
        public string OperateRealName { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Vest { get; set; }
    }
}
