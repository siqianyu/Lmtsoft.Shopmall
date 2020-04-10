using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class InfoFile
    {
        public int Id { get; set; }
        public string ObjType { get; set; }
        public int? ObjId { get; set; }
        public string ObjName { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Format { get; set; }
        public double? Size { get; set; }
        public int? OperateId { get; set; }
        public string OperateName { get; set; }
        public string OperateRealName { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Vest { get; set; }
    }
}
