using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class InfoEat
    {
        public int Id { get; set; }
        public string Pro { get; set; }
        public string ProName { get; set; }
        public string City { get; set; }
        public string CityName { get; set; }
        public string Area { get; set; }
        public string AreaName { get; set; }
        public string Qu { get; set; }
        public string Name { get; set; }
        public string Pic { get; set; }
        public string Linkman { get; set; }
        public string Linkmb { get; set; }
        public string Star { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Url { get; set; }
        public decimal? Outpay { get; set; }
        public decimal? Cutpay { get; set; }
        public decimal? Skpay { get; set; }
        public int? Floor { get; set; }
        public decimal? Accopay { get; set; }
        public decimal? Cutpayw { get; set; }
        public decimal? Accopayw { get; set; }
        public string Amount { get; set; }
        public string Address { get; set; }
        public string Controled { get; set; }
        public int? OperateId { get; set; }
        public string OperateName { get; set; }
        public string OperateRealName { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Demo { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Vest { get; set; }
    }
}
