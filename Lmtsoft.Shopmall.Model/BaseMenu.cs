using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class BaseMenu
    {
        public int Id { get; set; }
        public string EnCode { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Path { get; set; }
        public int? Levels { get; set; }
        public int? ParentId { get; set; }
        public string ButtonIds { get; set; }
        public string ButtonNames { get; set; }
        public int? DeleteMark { get; set; }
        public string Remark { get; set; }
        public int? Sort { get; set; }
        public int? Status { get; set; }
        public int? OperateId { get; set; }
        public string OperateName { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Vest { get; set; }
    }
}
