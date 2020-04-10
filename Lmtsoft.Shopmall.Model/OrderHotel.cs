using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class OrderHotel
    {
        public int Id { get; set; }
        public string OrderType { get; set; }
        public int? HotelId { get; set; }
        public string HotelName { get; set; }
        public double? RoomSale { get; set; }
        public string RoomSaleDemo { get; set; }
        public DateTime? DateIn { get; set; }
        public DateTime? DateOut { get; set; }
        public int? Day { get; set; }
        public string Breakfast { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int? LinkmanId { get; set; }
        public string LinkmanName { get; set; }
        public int? GuideId { get; set; }
        public string GuideName { get; set; }
        public string GuideTel { get; set; }
        public string GuideDemo { get; set; }
        public string PayTypeA { get; set; }
        public string IsPayedA { get; set; }
        public string IsPayedB { get; set; }
        public decimal? PriceSale { get; set; }
        public decimal? MoneySale { get; set; }
        public string PayTypeB { get; set; }
        public decimal? PriceCost { get; set; }
        public decimal? MoneyCost { get; set; }
        public decimal? PriceBack { get; set; }
        public decimal? MoneyBack { get; set; }
        public double? RoomActual { get; set; }
        public decimal? ProfitA { get; set; }
        public string MoneyBackDemo { get; set; }
        public decimal? PriceCollect { get; set; }
        public decimal? MoneyCollect { get; set; }
        public string IsCleaned { get; set; }
        public decimal ProfitB { get; set; }
        public string Status { get; set; }
        public string IsLock { get; set; }
        public int? LockId { get; set; }
        public string LockName { get; set; }
        public string LockRealName { get; set; }
        public string Demo { get; set; }
        public string DemoProfit { get; set; }
        public int? OperateId { get; set; }
        public string OperateName { get; set; }
        public string OperateRealName { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Vest { get; set; }
    }
}
