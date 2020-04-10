using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class BaseDepartment
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string EnCode { get; set; }
        public string Name { get; set; }
        public int? Sort { get; set; }
        public int? LeaderId { get; set; }
        public string LeaerName { get; set; }
        public string LeaderTel { get; set; }
        public string Demo { get; set; }
        public int? OperateId { get; set; }
        public string OperateName { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Vest { get; set; }
    }
}
