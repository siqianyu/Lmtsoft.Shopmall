using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class OrderOther
    {
        public int Id { get; set; }
        public int? OtherId { get; set; }
        public string OtherName { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int? OtherLinkmanId { get; set; }
        public string OtherLinkmanName { get; set; }
        public int? LinkmanId { get; set; }
        public string LinkmanName { get; set; }
        public string OrderNo { get; set; }
        public DateTime? DateUse { get; set; }
        public DateTime? DateOrder { get; set; }
        public string Address { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public decimal? Amount { get; set; }
        public int? GuideId { get; set; }
        public string GuideName { get; set; }
        public string GuideTel { get; set; }
        public string GuideDemo { get; set; }
        public string Demo { get; set; }
        public string Detail { get; set; }
        public decimal Profit { get; set; }
        public decimal? ProfitChcek { get; set; }
        public string Status { get; set; }
        public string Settled { get; set; }
        public string IsLock { get; set; }
        public int? LockId { get; set; }
        public string LockName { get; set; }
        public string LockRealName { get; set; }
        public int? OperateId { get; set; }
        public string OperateName { get; set; }
        public string OperateRealName { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Vest { get; set; }
        public string Invoice { get; set; }
        public int? NumFlag { get; set; }
        public string Specs { get; set; }
        public string DemoProfit { get; set; }
    }
}
