using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class BaseMenuButton
    {
        public int Id { get; set; }
        public int? MenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuTitle { get; set; }
        public int? ButtonId { get; set; }
        public string ButtonName { get; set; }
        public string ButtonTitle { get; set; }
        public int? OperateId { get; set; }
        public string OperateName { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Vest { get; set; }
        public int? Sort { get; set; }
    }
}
