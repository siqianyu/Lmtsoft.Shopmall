using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class BaseCity
    {
        public string CodeId { get; set; }
        public string ParentId { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
