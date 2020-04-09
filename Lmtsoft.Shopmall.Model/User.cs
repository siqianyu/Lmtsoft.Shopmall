using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salt { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string NickName { get; set; }
        public string Sex { get; set; }
        public DateTime? Birthday { get; set; }
        public int? ProvinceId { get; set; }
        public string Province { get; set; }
        public int? CityId { get; set; }
        public string City { get; set; }
        public int? AreaId { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public byte? Status { get; set; }
        public string WxOpenId { get; set; }
    }
}
