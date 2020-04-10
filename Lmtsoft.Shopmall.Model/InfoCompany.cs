using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class InfoCompany
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
        public string Shortname { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Url { get; set; }
        public string Linkman { get; set; }
        public string Linkmb { get; set; }
        public string Code { get; set; }
        public string Logo { get; set; }
        public string Slogo { get; set; }
        public string Bankno { get; set; }
        public DateTime? Bdate { get; set; }
        public DateTime? Edate { get; set; }
        public string Demo { get; set; }
        public int? OperateId { get; set; }
        public string OperateName { get; set; }
        public string OperateRealName { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int? IsLock { get; set; }
        public string Vest { get; set; }
    }
}
