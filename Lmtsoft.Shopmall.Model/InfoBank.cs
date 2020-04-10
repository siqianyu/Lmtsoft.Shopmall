using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class InfoBank
    {
        public int Id { get; set; }
        public string MainType { get; set; }
        public string MainTypeName { get; set; }
        public int? MainId { get; set; }
        public string MainName { get; set; }
        public string Name { get; set; }
        public string Account { get; set; }
        public string Number { get; set; }
        public string Pro { get; set; }
        public string ProName { get; set; }
        public string City { get; set; }
        public string CityName { get; set; }
        public string Area { get; set; }
        public string AreaName { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
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
