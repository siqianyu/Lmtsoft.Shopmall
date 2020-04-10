using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class FinanceInvoice
    {
        public int Id { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string Name { get; set; }
        public string Item { get; set; }
        public decimal? Money { get; set; }
        public int? TargetId { get; set; }
        public string TargetName { get; set; }
        public string Type { get; set; }
        public decimal? TaxPoint { get; set; }
        public decimal? TaxMoney { get; set; }
        public string Drawer { get; set; }
        public string Taxpayer { get; set; }
        public string Status { get; set; }
        public string Demo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? OperateId { get; set; }
        public string OperateName { get; set; }
        public string OperateRealName { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Vest { get; set; }
    }
}
