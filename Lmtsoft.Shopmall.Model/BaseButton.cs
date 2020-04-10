using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class BaseButton
    {
        public int Id { get; set; }
        public string EnCode { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Icone { get; set; }
        public string JsEvent { get; set; }
        public int? Sort { get; set; }
        public int? OperateId { get; set; }
        public string OperateName { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Vest { get; set; }
    }
}
