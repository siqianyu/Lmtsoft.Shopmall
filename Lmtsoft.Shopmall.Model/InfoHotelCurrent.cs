using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class InfoHotelCurrent
    {
        public int Id { get; set; }
        public int? HotelId { get; set; }
        public string HotelName { get; set; }
        public DateTime? Currentdate { get; set; }
        public int? CurrentCount { get; set; }
        public int? OperateId { get; set; }
        public string Controled { get; set; }
        public DateTime? CreateTime { get; set; }
        public string OperateName { get; set; }
        public string OperateRealName { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Vest { get; set; }
    }
}
