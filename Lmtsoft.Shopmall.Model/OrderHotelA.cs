using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class OrderHotelA
    {
        public int Id { get; set; }
        public int? HotelId { get; set; }
        public string HotelName { get; set; }
        public int? LinkmanId { get; set; }
        public string LinkmanName { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int? HotelLinkmanId { get; set; }
        public string HotelLinkmanName { get; set; }
        public string OrderNo { get; set; }
        public DateTime? DateIn { get; set; }
        public DateTime? DateOut { get; set; }
        public int? Day { get; set; }
        public DateTime? DateOrder { get; set; }
        public string GuestName { get; set; }
        public string RoomType { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public decimal? Amount { get; set; }
        public string Breakfast { get; set; }
        public string Invoice { get; set; }
        public string Detail { get; set; }
        public int? GuideId { get; set; }
        public string GuideName { get; set; }
        public string GuideTel { get; set; }
        public string GuideDemo { get; set; }
        public string Demo { get; set; }
        public decimal? Profit { get; set; }
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
        public int? NumFlag { get; set; }
    }
}
