using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class FinanceMoney
    {
        public int Id { get; set; }
        public int? Type { get; set; }
        public int? Direction { get; set; }
        public string Target { get; set; }
        public string Name { get; set; }
        public decimal? Money { get; set; }
        public DateTime? MoneyDate { get; set; }
        public string Demo { get; set; }
        public int? BankId { get; set; }
        public string BankDemo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? OperateId { get; set; }
        public string OperateName { get; set; }
        public string OperateRealName { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Vest { get; set; }
    }
}
