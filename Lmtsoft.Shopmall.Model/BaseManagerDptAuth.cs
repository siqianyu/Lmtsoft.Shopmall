using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class BaseManagerDptAuth
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string UserRealName { get; set; }
        public string Code { get; set; }
        public string DptIds { get; set; }
        public string DptNames { get; set; }
        public string Vest { get; set; }
    }
}
