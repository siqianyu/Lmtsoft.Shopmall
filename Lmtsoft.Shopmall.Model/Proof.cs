using System;
using System.Collections.Generic;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class Proof
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public string TypeName { get; set; }
        public string ProofNo { get; set; }
        public DateTime? ProofDate { get; set; }
        public string Name { get; set; }
        public int? TempleId { get; set; }
        public string TempleName { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? OperateId { get; set; }
        public string OperateName { get; set; }
        public string OperateRealName { get; set; }
        public string ItemName { get; set; }
        public string ItemDetail { get; set; }
        public decimal? Amount { get; set; }
        public int? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierLinkName { get; set; }
        public string SupplierBankName { get; set; }
        public string SupplierBankAccount { get; set; }
        public string IsLock { get; set; }
        public string Status { get; set; }
        public int? LockId { get; set; }
        public string LockName { get; set; }
        public string LockRealName { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Vest { get; set; }
        public int? CurrentRoleId { get; set; }
        public string CurrentRoleName { get; set; }
        public int? CurrentUserId { get; set; }
        public string CurrentUserName { get; set; }
        public string NextRoleIds { get; set; }
        public string NextRoleNames { get; set; }
        public string PayStatus { get; set; }
        public int? PayUserId { get; set; }
        public string PayUserName { get; set; }
        public int? PayInfoId { get; set; }
        public string PayInfoDetail { get; set; }
        public decimal? PayMoney { get; set; }
        public DateTime? PayTime { get; set; }
        public string Demo { get; set; }
        public string CheckStatus { get; set; }
        public string SumitStatus { get; set; }
        public DateTime? SubmitTime { get; set; }
    }
}
