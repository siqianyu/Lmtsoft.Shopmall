using System;
using Lmtsoft.Shopmall.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Lmtsoft.Shopmall.Repository
{
    public partial class ShopmallContext : DbContext
    {
        public ShopmallContext()
        {
        }

        public ShopmallContext(DbContextOptions<ShopmallContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaseButton> BaseButton { get; set; }
        public virtual DbSet<BaseCity> BaseCity { get; set; }
        public virtual DbSet<BaseCompany> BaseCompany { get; set; }
        public virtual DbSet<BaseDepartment> BaseDepartment { get; set; }
        public virtual DbSet<BaseJob> BaseJob { get; set; }
        public virtual DbSet<BaseManager> BaseManager { get; set; }
        public virtual DbSet<BaseManagerDptAuth> BaseManagerDptAuth { get; set; }
        public virtual DbSet<BaseManagerLog> BaseManagerLog { get; set; }
        public virtual DbSet<BaseMenu> BaseMenu { get; set; }
        public virtual DbSet<BaseMenuButton> BaseMenuButton { get; set; }
        public virtual DbSet<FinanceInvoice> FinanceInvoice { get; set; }
        public virtual DbSet<FinanceMoney> FinanceMoney { get; set; }
        public virtual DbSet<InfoBank> InfoBank { get; set; }
        public virtual DbSet<InfoCompany> InfoCompany { get; set; }
        public virtual DbSet<InfoEat> InfoEat { get; set; }
        public virtual DbSet<InfoFile> InfoFile { get; set; }
        public virtual DbSet<InfoHotel> InfoHotel { get; set; }
        public virtual DbSet<InfoHotelCurrent> InfoHotelCurrent { get; set; }
        public virtual DbSet<InfoSupplier> InfoSupplier { get; set; }
        public virtual DbSet<OrderEat> OrderEat { get; set; }
        public virtual DbSet<OrderHotel> OrderHotel { get; set; }
        public virtual DbSet<OrderHotelA> OrderHotelA { get; set; }
        public virtual DbSet<OrderHotelCurrent> OrderHotelCurrent { get; set; }
        public virtual DbSet<OrderOther> OrderOther { get; set; }
        public virtual DbSet<Proof> Proof { get; set; }
        public virtual DbSet<ProofLog> ProofLog { get; set; }
        public virtual DbSet<ProofTemple> ProofTemple { get; set; }
        public virtual DbSet<ProofTempleRole> ProofTempleRole { get; set; }
        public virtual DbSet<ProofType> ProofType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var constr = ConfigHelper.GetConnectionValue();
                optionsBuilder.UseSqlServer(constr);
                ////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Server=.;Database=Shopmall;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaseButton>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.EnCode)
                    .HasMaxLength(100)
                    .HasComment("按钮编号 add/edit/del/show");

                entity.Property(e => e.Icone)
                    .HasMaxLength(200)
                    .HasComment("图标");

                entity.Property(e => e.JsEvent)
                    .HasMaxLength(200)
                    .HasComment("按钮事件");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.Path)
                    .HasMaxLength(200)
                    .HasComment("所属页面");

                entity.Property(e => e.Sort).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BaseCity>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CodeId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BaseCompany>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.AllButton).HasMaxLength(2000);

                entity.Property(e => e.AllMenu).HasMaxLength(2000);

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.AreaName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Bankno).HasMaxLength(100);

                entity.Property(e => e.Bdate).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CityName).HasMaxLength(200);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.Demo).HasColumnType("ntext");

                entity.Property(e => e.Edate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(100);

                entity.Property(e => e.IsLock)
                    .HasDefaultValueSql("((0))")
                    .HasComment("是否锁定，0 否1 是");

                entity.Property(e => e.IsParent)
                    .HasDefaultValueSql("((1))")
                    .HasComment("母公司 1 是 0 否");

                entity.Property(e => e.Linkman).HasMaxLength(50);

                entity.Property(e => e.Linkmb).HasMaxLength(50);

                entity.Property(e => e.Logo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'demo.jpg')");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(100);

                entity.Property(e => e.Pro).HasMaxLength(50);

                entity.Property(e => e.ProName).HasMaxLength(200);

                entity.Property(e => e.Qu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Shortname).HasMaxLength(50);

                entity.Property(e => e.Slogo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'lmt.jpg')");

                entity.Property(e => e.Tel).HasMaxLength(100);

                entity.Property(e => e.Url).HasMaxLength(100);

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BaseDepartment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.Demo).HasMaxLength(2000);

                entity.Property(e => e.EnCode)
                    .HasMaxLength(100)
                    .HasComment("按钮编号 add/edit/del/show");

                entity.Property(e => e.LeaderId).HasDefaultValueSql("((0))");

                entity.Property(e => e.LeaderTel).HasMaxLength(50);

                entity.Property(e => e.LeaerName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sort).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BaseJob>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.Demo).HasMaxLength(500);

                entity.Property(e => e.EnCode)
                    .HasMaxLength(100)
                    .HasComment("按钮编号 add/edit/del/show");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.Sort).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BaseManager>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.AllButton).HasMaxLength(2000);

                entity.Property(e => e.AllMenu).HasMaxLength(2000);

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.AreaName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CityName).HasMaxLength(200);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("添加时间");

                entity.Property(e => e.Demo).HasColumnType("ntext");

                entity.Property(e => e.DepartmentId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DepartmentName).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')")
                    .HasComment("电子邮箱");

                entity.Property(e => e.IsAdmin)
                    .HasDefaultValueSql("((0))")
                    .HasComment("是否主帐号 1 是0 否");

                entity.Property(e => e.IsLock)
                    .HasDefaultValueSql("((0))")
                    .HasComment("是否锁定 0 否 1 是");

                entity.Property(e => e.JobId).HasMaxLength(50);

                entity.Property(e => e.JobName).HasMaxLength(100);

                entity.Property(e => e.OnlineTime).HasColumnType("datetime");

                entity.Property(e => e.OperateName).HasMaxLength(100);

                entity.Property(e => e.OperateRealName).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .HasComment("登录密码");

                entity.Property(e => e.Pro).HasMaxLength(50);

                entity.Property(e => e.ProName).HasMaxLength(200);

                entity.Property(e => e.RealName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("用户昵称");

                entity.Property(e => e.RoleId).HasComment("角色ID");

                entity.Property(e => e.RoleType)
                    .HasDefaultValueSql("((2))")
                    .HasComment("管理员类型1超管2系管");

                entity.Property(e => e.Salt)
                    .HasMaxLength(20)
                    .HasComment("6位随机字符串,加密用到");

                entity.Property(e => e.Sex).HasComment("性别 1男 2女");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')")
                    .HasComment("联系电话");

                entity.Property(e => e.Token).HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .HasComment("用户名");

                entity.Property(e => e.Vest)
                    .HasMaxLength(50)
                    .HasComment("授权公司代码");
            });

            modelBuilder.Entity<BaseManagerDptAuth>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'proof')")
                    .HasComment("标识   proof 、请款");

                entity.Property(e => e.DptIds)
                    .HasMaxLength(500)
                    .HasComment("业务上 能看到哪些部门的 数据");

                entity.Property(e => e.DptNames).HasMaxLength(2000);

                entity.Property(e => e.UserName).HasMaxLength(200);

                entity.Property(e => e.UserRealName).HasMaxLength(200);

                entity.Property(e => e.Vest).HasMaxLength(50);
            });

            modelBuilder.Entity<BaseManagerLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(100)
                    .HasComment("操作类型");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("操作时间");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasComment("备注");

                entity.Property(e => e.Token).HasMaxLength(200);

                entity.Property(e => e.UserId).HasComment("用户ID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(30)
                    .HasComment("用户IP");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .HasComment("用户名");

                entity.Property(e => e.Vest).HasMaxLength(50);
            });

            modelBuilder.Entity<BaseMenu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ButtonIds).HasMaxLength(500);

                entity.Property(e => e.ButtonNames).HasMaxLength(500);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.DeleteMark).HasComment("是否删除");

                entity.Property(e => e.EnCode)
                    .HasMaxLength(50)
                    .HasComment("菜单编号");

                entity.Property(e => e.Icon)
                    .HasMaxLength(200)
                    .HasComment("图标路径");

                entity.Property(e => e.Levels)
                    .HasDefaultValueSql("((0))")
                    .HasComment("菜单等级 0一级 其他");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasComment("菜单名称");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.ParentId)
                    .HasDefaultValueSql("((0))")
                    .HasComment("父级菜单");

                entity.Property(e => e.Path)
                    .HasMaxLength(100)
                    .HasComment("页面路径");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.Sort).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BaseMenuButton>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ButtonName).HasMaxLength(100);

                entity.Property(e => e.ButtonTitle).HasMaxLength(100);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.MenuName).HasMaxLength(100);

                entity.Property(e => e.MenuTitle).HasMaxLength(100);

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FinanceInvoice>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Demo).HasColumnType("ntext");

                entity.Property(e => e.Drawer)
                    .HasMaxLength(200)
                    .HasComment("开票人");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("datetime")
                    .HasComment("开票日期");

                entity.Property(e => e.Item)
                    .HasMaxLength(200)
                    .HasComment("开票项目 住宿");

                entity.Property(e => e.Money)
                    .HasColumnType("money")
                    .HasComment("开票金额");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasComment("开票名称");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasComment("收款状态 已收/未收");

                entity.Property(e => e.TargetId).HasComment("酒店ID");

                entity.Property(e => e.TargetName)
                    .HasMaxLength(200)
                    .HasComment("酒店名称");

                entity.Property(e => e.TaxMoney)
                    .HasColumnType("money")
                    .HasComment("税额");

                entity.Property(e => e.TaxPoint)
                    .HasColumnType("money")
                    .HasComment("税点");

                entity.Property(e => e.Taxpayer)
                    .HasMaxLength(100)
                    .HasComment("纳税人识别号");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasComment("开票类型 普票 专票");

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FinanceMoney>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BankDemo).HasMaxLength(200);

                entity.Property(e => e.BankId)
                    .HasColumnName("BankID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Demo)
                    .HasMaxLength(1000)
                    .HasComment("备注");

                entity.Property(e => e.Direction)
                    .HasDefaultValueSql("((0))")
                    .HasComment("收支方向  0 收 1 支");

                entity.Property(e => e.Money)
                    .HasColumnType("money")
                    .HasComment("金额");

                entity.Property(e => e.MoneyDate)
                    .HasColumnType("date")
                    .HasComment("发生日期");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasComment("帐目名称");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(100);

                entity.Property(e => e.Target)
                    .HasMaxLength(200)
                    .HasComment("帐目对象");

                entity.Property(e => e.Type)
                    .HasDefaultValueSql("((0))")
                    .HasComment("帐目类别  0 、现金 1、银行");

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InfoBank>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Account)
                    .HasMaxLength(100)
                    .HasComment("帐户");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CityName).HasMaxLength(100);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Demo).HasColumnType("ntext");

                entity.Property(e => e.IsLock)
                    .HasDefaultValueSql("((0))")
                    .HasComment("是否锁定，0 否1 是");

                entity.Property(e => e.MainId).HasComment("主体ID");

                entity.Property(e => e.MainName)
                    .HasMaxLength(100)
                    .HasComment("主体名称");

                entity.Property(e => e.MainType)
                    .HasMaxLength(50)
                    .HasComment("主体类型base公司、 hotel酒店、company客户、manager 个人");

                entity.Property(e => e.MainTypeName)
                    .HasMaxLength(50)
                    .HasComment("公司、酒店、客户、客户、个人");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasComment("银行名称");

                entity.Property(e => e.Number)
                    .HasMaxLength(100)
                    .HasComment("帐户号码");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(50);

                entity.Property(e => e.Pro).HasMaxLength(50);

                entity.Property(e => e.ProName).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'y')")
                    .HasComment("y正常 / n 停用");

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InfoCompany>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.Bankno).HasMaxLength(100);

                entity.Property(e => e.Bdate).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CityName).HasMaxLength(100);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Demo).HasColumnType("ntext");

                entity.Property(e => e.Edate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(100);

                entity.Property(e => e.IsLock)
                    .HasDefaultValueSql("((0))")
                    .HasComment("是否锁定，0 否1 是");

                entity.Property(e => e.Linkman).HasMaxLength(50);

                entity.Property(e => e.Linkmb).HasMaxLength(50);

                entity.Property(e => e.Logo).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(50);

                entity.Property(e => e.Pro).HasMaxLength(50);

                entity.Property(e => e.ProName).HasMaxLength(100);

                entity.Property(e => e.Qu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Shortname).HasMaxLength(50);

                entity.Property(e => e.Slogo).HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(100);

                entity.Property(e => e.Url).HasMaxLength(100);

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InfoEat>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Accopay).HasColumnType("money");

                entity.Property(e => e.Accopayw)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Amount).HasMaxLength(50);

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CityName).HasMaxLength(100);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.Controled)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'n')")
                    .HasComment("是否加入 酒店控房操作 y/n");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cutpay)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cutpayw)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Demo).HasColumnType("ntext");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Floor).HasComment("酒店楼层");

                entity.Property(e => e.Linkman).HasMaxLength(50);

                entity.Property(e => e.Linkmb).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OperateId).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(50);

                entity.Property(e => e.Outpay)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pic)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'nopic.jpg')");

                entity.Property(e => e.Pro)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProName).HasMaxLength(100);

                entity.Property(e => e.Qu).HasMaxLength(50);

                entity.Property(e => e.Skpay)
                    .HasColumnName("SKPay")
                    .HasColumnType("money")
                    .HasComment("散客房价");

                entity.Property(e => e.Star)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(50);

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InfoFile>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .HasComment("文件格式");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasComment("文件名称");

                entity.Property(e => e.ObjId).HasComment("对象id");

                entity.Property(e => e.ObjName)
                    .HasMaxLength(500)
                    .HasComment("对象名称");

                entity.Property(e => e.ObjType)
                    .HasMaxLength(50)
                    .HasComment("对象类型 dhotel酒店资料");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(100);

                entity.Property(e => e.Path)
                    .HasMaxLength(500)
                    .HasComment("文件路径");

                entity.Property(e => e.Size).HasComment("文件大小");

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InfoHotel>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Accopay).HasColumnType("money");

                entity.Property(e => e.Accopayw)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Amount).HasMaxLength(50);

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CityName).HasMaxLength(100);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.Controled)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'n')")
                    .HasComment("是否加入 酒店控房操作 y/n");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cutpay)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cutpayw)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Demo).HasColumnType("ntext");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Floor).HasComment("酒店楼层");

                entity.Property(e => e.Linkman).HasMaxLength(50);

                entity.Property(e => e.Linkmb).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OperateId).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(50);

                entity.Property(e => e.Outpay)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pic)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'nopic.jpg')");

                entity.Property(e => e.Pro)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProName).HasMaxLength(100);

                entity.Property(e => e.Qu).HasMaxLength(50);

                entity.Property(e => e.Skpay)
                    .HasColumnName("SKPay")
                    .HasColumnType("money")
                    .HasComment("散客房价");

                entity.Property(e => e.Star)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(50);

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InfoHotelCurrent>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.Controled)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'y')");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Currentdate)
                    .HasColumnType("date")
                    .HasComment("日期");

                entity.Property(e => e.HotelId).HasComment("酒店名称");

                entity.Property(e => e.HotelName).HasMaxLength(100);

                entity.Property(e => e.OperateId).HasComment("操作人");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(50);

                entity.Property(e => e.Vest).HasMaxLength(50);
            });

            modelBuilder.Entity<InfoSupplier>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Accopay).HasColumnType("money");

                entity.Property(e => e.Accopayw)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Amount).HasMaxLength(50);

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.BankAccount).HasMaxLength(100);

                entity.Property(e => e.BankLinkman).HasMaxLength(100);

                entity.Property(e => e.BankName).HasMaxLength(500);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CityName).HasMaxLength(100);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.Controled)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'n')")
                    .HasComment("是否加入 酒店控房操作 y/n");

                entity.Property(e => e.CrSuppliereTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Cutpay)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cutpayw)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Demo).HasColumnType("ntext");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Floor).HasComment("酒店楼层");

                entity.Property(e => e.Linkman).HasMaxLength(50);

                entity.Property(e => e.Linkmb).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OperateId).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(50);

                entity.Property(e => e.Outpay)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pic)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'nopic.jpg')");

                entity.Property(e => e.Pro)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProName).HasMaxLength(100);

                entity.Property(e => e.Qu).HasMaxLength(50);

                entity.Property(e => e.Skpay)
                    .HasColumnName("SKPay")
                    .HasColumnType("money")
                    .HasComment("散客房价");

                entity.Property(e => e.Star)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(50);

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OrderEat>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasComment("消费金额");

                entity.Property(e => e.CompanyId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(200)
                    .HasComment("使用人/单位");

                entity.Property(e => e.DateOrder)
                    .HasColumnType("datetime")
                    .HasComment("下单日期");

                entity.Property(e => e.DateUse)
                    .HasColumnType("datetime")
                    .HasComment("使用日期");

                entity.Property(e => e.Deduct)
                    .HasMaxLength(500)
                    .HasComment("餐扣 待定 10% 4/桌");

                entity.Property(e => e.Demo).HasColumnType("ntext");

                entity.Property(e => e.DemoProfit).HasColumnType("ntext");

                entity.Property(e => e.Detail).HasColumnType("ntext");

                entity.Property(e => e.EatId).HasDefaultValueSql("((0))");

                entity.Property(e => e.EatLinkmanId)
                    .HasDefaultValueSql("((0))")
                    .HasComment("下单人信息");

                entity.Property(e => e.EatLinkmanName)
                    .HasMaxLength(100)
                    .HasComment("预订 人");

                entity.Property(e => e.EatName)
                    .HasMaxLength(100)
                    .HasComment("餐厅名称");

                entity.Property(e => e.GuestName).HasMaxLength(200);

                entity.Property(e => e.GuideDemo).HasMaxLength(200);

                entity.Property(e => e.GuideId).HasComment("导游信息");

                entity.Property(e => e.GuideName).HasMaxLength(100);

                entity.Property(e => e.GuideTel)
                    .HasMaxLength(50)
                    .HasComment("导游电话");

                entity.Property(e => e.Invoice).HasMaxLength(50);

                entity.Property(e => e.IsLock)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('n')")
                    .HasComment("是否已上锁");

                entity.Property(e => e.LinkmanId)
                    .HasDefaultValueSql("((0))")
                    .HasComment("下单人信息");

                entity.Property(e => e.LinkmanName)
                    .HasMaxLength(100)
                    .HasComment("预订 人");

                entity.Property(e => e.LockName).HasMaxLength(50);

                entity.Property(e => e.LockRealName).HasMaxLength(50);

                entity.Property(e => e.MealFlag)
                    .HasMaxLength(50)
                    .HasComment("早餐 中餐 晚餐 待定");

                entity.Property(e => e.MealSign)
                    .HasMaxLength(500)
                    .HasComment("餐标 100/桌 10/人");

                entity.Property(e => e.NumFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperateId).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(50);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("OrderNO")
                    .HasMaxLength(500)
                    .HasComment("订单编号 ");

                entity.Property(e => e.Profit)
                    .HasColumnType("money")
                    .HasComment("净利润");

                entity.Property(e => e.ProfitChcek).HasColumnType("money");

                entity.Property(e => e.Quantity).HasMaxLength(500);

                entity.Property(e => e.Settled)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'n')")
                    .HasComment("y 已结算 n 未结 k 留存 (keep)");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'a')")
                    .HasComment("订单状态 n正常  c 取消  d删除");

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OrderHotel>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Breakfast)
                    .HasMaxLength(200)
                    .HasComment("早餐情况 自助早");

                entity.Property(e => e.CompanyId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId)
                    .HasDefaultValueSql("((0))")
                    .HasComment("旅行社信息");

                entity.Property(e => e.CustomerName).HasMaxLength(100);

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasComment("入住日期");

                entity.Property(e => e.DateOut)
                    .HasColumnType("datetime")
                    .HasComment("离店日期");

                entity.Property(e => e.Day)
                    .HasDefaultValueSql("((1))")
                    .HasComment("入住天数");

                entity.Property(e => e.Demo).HasColumnType("ntext");

                entity.Property(e => e.DemoProfit).HasColumnType("ntext");

                entity.Property(e => e.GuideDemo).HasMaxLength(200);

                entity.Property(e => e.GuideId).HasComment("导游信息");

                entity.Property(e => e.GuideName).HasMaxLength(100);

                entity.Property(e => e.GuideTel)
                    .HasMaxLength(50)
                    .HasComment("导游电话");

                entity.Property(e => e.HotelId).HasDefaultValueSql("((0))");

                entity.Property(e => e.HotelName).HasMaxLength(100);

                entity.Property(e => e.IsCleaned)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'n')")
                    .HasComment("同行旅行社是否清算 y/n");

                entity.Property(e => e.IsLock)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('n')")
                    .HasComment("是否已上锁");

                entity.Property(e => e.IsPayedA)
                    .HasMaxLength(50)
                    .HasComment("酒店是否结算");

                entity.Property(e => e.IsPayedB).HasMaxLength(50);

                entity.Property(e => e.LinkmanId)
                    .HasDefaultValueSql("((0))")
                    .HasComment("下单人信息");

                entity.Property(e => e.LinkmanName).HasMaxLength(100);

                entity.Property(e => e.LockName).HasMaxLength(50);

                entity.Property(e => e.LockRealName).HasMaxLength(50);

                entity.Property(e => e.MoneyBack)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MoneyBackDemo).HasMaxLength(500);

                entity.Property(e => e.MoneyCollect)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasComment("同行旅行社代收金额");

                entity.Property(e => e.MoneyCost)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MoneySale)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasComment("挂帐金额");

                entity.Property(e => e.OperateId).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(50);

                entity.Property(e => e.OrderType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'a')")
                    .HasComment("订单类型 a 酒店 b 会议");

                entity.Property(e => e.PayTypeA)
                    .HasMaxLength(50)
                    .HasComment("支付方式 预付 现付 挂账(和酒店)");

                entity.Property(e => e.PayTypeB)
                    .HasMaxLength(50)
                    .HasComment("支付方式 预付 现付 挂账(和客户)");

                entity.Property(e => e.PriceBack)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasComment("返佣单价");

                entity.Property(e => e.PriceCollect)
                    .HasColumnType("money")
                    .HasComment("代收单价");

                entity.Property(e => e.PriceCost)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasComment("成本价");

                entity.Property(e => e.PriceSale)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasComment("销售价");

                entity.Property(e => e.ProfitA)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasComment("毛利润");

                entity.Property(e => e.ProfitB)
                    .HasColumnType("money")
                    .HasComment("净利润");

                entity.Property(e => e.RoomActual)
                    .HasDefaultValueSql("((0))")
                    .HasComment("实际 间数");

                entity.Property(e => e.RoomSale)
                    .HasDefaultValueSql("((0))")
                    .HasComment("预期客人+司陪");

                entity.Property(e => e.RoomSaleDemo).HasMaxLength(500);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'a')")
                    .HasComment("订单状态 n正常  c 取消  d删除");

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OrderHotelA>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasComment("消费金额");

                entity.Property(e => e.Breakfast).HasMaxLength(200);

                entity.Property(e => e.CompanyId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(200)
                    .HasComment("使用人/单位");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasComment("使用日期");

                entity.Property(e => e.DateOrder)
                    .HasColumnType("datetime")
                    .HasComment("下单日期");

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.Day).HasDefaultValueSql("((0))");

                entity.Property(e => e.Demo).HasColumnType("ntext");

                entity.Property(e => e.Detail)
                    .HasColumnType("ntext")
                    .HasComment("订单要求");

                entity.Property(e => e.GuestName)
                    .HasMaxLength(200)
                    .HasComment("入住人/公司");

                entity.Property(e => e.GuideDemo)
                    .HasMaxLength(200)
                    .HasComment("司陪政策");

                entity.Property(e => e.GuideId).HasComment("导游信息");

                entity.Property(e => e.GuideName).HasMaxLength(100);

                entity.Property(e => e.GuideTel)
                    .HasMaxLength(50)
                    .HasComment("导游电话");

                entity.Property(e => e.HotelId).HasDefaultValueSql("((0))");

                entity.Property(e => e.HotelLinkmanId)
                    .HasDefaultValueSql("((0))")
                    .HasComment("下单人信息");

                entity.Property(e => e.HotelLinkmanName)
                    .HasMaxLength(100)
                    .HasComment("预订 人");

                entity.Property(e => e.HotelName)
                    .HasMaxLength(100)
                    .HasComment("餐厅名称");

                entity.Property(e => e.Invoice).HasMaxLength(50);

                entity.Property(e => e.IsLock)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('n')")
                    .HasComment("是否已上锁");

                entity.Property(e => e.LinkmanId)
                    .HasDefaultValueSql("((0))")
                    .HasComment("下单人信息");

                entity.Property(e => e.LinkmanName)
                    .HasMaxLength(100)
                    .HasComment("预订 人");

                entity.Property(e => e.LockName).HasMaxLength(50);

                entity.Property(e => e.LockRealName).HasMaxLength(50);

                entity.Property(e => e.NumFlag)
                    .HasDefaultValueSql("((0))")
                    .HasComment("订单计数 用于生成订单编号 ");

                entity.Property(e => e.OperateId).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(50);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("OrderNO")
                    .HasMaxLength(500)
                    .HasComment("订单编号 ");

                entity.Property(e => e.Price).HasMaxLength(100);

                entity.Property(e => e.Profit).HasColumnType("money");

                entity.Property(e => e.ProfitChcek).HasColumnType("money");

                entity.Property(e => e.Quantity).HasMaxLength(200);

                entity.Property(e => e.RoomType)
                    .HasMaxLength(50)
                    .HasComment("房型");

                entity.Property(e => e.Settled)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'n')")
                    .HasComment("y 已结算 n 未结 k 留存 (keep)");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'a')")
                    .HasComment("订单状态 n正常  c 取消  d删除");

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OrderHotelCurrent>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Currentdate)
                    .HasColumnType("date")
                    .HasComment("日期");

                entity.Property(e => e.HotelId).HasComment("酒店名称");

                entity.Property(e => e.HotelName).HasMaxLength(100);

                entity.Property(e => e.OperateId).HasComment("操作人");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(50);

                entity.Property(e => e.Vest).HasMaxLength(50);
            });

            modelBuilder.Entity<OrderOther>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasColumnType("ntext");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasComment("消费金额");

                entity.Property(e => e.CompanyId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(200)
                    .HasComment("使用人/单位");

                entity.Property(e => e.DateOrder)
                    .HasColumnType("datetime")
                    .HasComment("下单日期");

                entity.Property(e => e.DateUse)
                    .HasColumnType("datetime")
                    .HasComment("使用日期");

                entity.Property(e => e.Demo).HasColumnType("ntext");

                entity.Property(e => e.DemoProfit).HasMaxLength(500);

                entity.Property(e => e.Detail)
                    .HasColumnType("ntext")
                    .HasComment("要求及细节");

                entity.Property(e => e.GuideDemo).HasMaxLength(200);

                entity.Property(e => e.GuideId).HasComment("导游信息");

                entity.Property(e => e.GuideName).HasMaxLength(100);

                entity.Property(e => e.GuideTel)
                    .HasMaxLength(50)
                    .HasComment("导游电话");

                entity.Property(e => e.Invoice).HasMaxLength(50);

                entity.Property(e => e.IsLock)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('n')")
                    .HasComment("是否已上锁");

                entity.Property(e => e.ItemName).HasMaxLength(1000);

                entity.Property(e => e.ItemType)
                    .HasMaxLength(50)
                    .HasComment("导游   门票 车队 其他");

                entity.Property(e => e.LinkmanId)
                    .HasDefaultValueSql("((0))")
                    .HasComment("下单人信息");

                entity.Property(e => e.LinkmanName)
                    .HasMaxLength(100)
                    .HasComment("预订 人");

                entity.Property(e => e.LockName).HasMaxLength(50);

                entity.Property(e => e.LockRealName).HasMaxLength(50);

                entity.Property(e => e.NumFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperateId).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(50);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("OrderNO")
                    .HasMaxLength(500)
                    .HasComment("订单编号 ");

                entity.Property(e => e.OtherLinkmanId)
                    .HasDefaultValueSql("((0))")
                    .HasComment("下单人信息");

                entity.Property(e => e.OtherLinkmanName)
                    .HasMaxLength(100)
                    .HasComment("预订 人");

                entity.Property(e => e.OtherName).HasMaxLength(500);

                entity.Property(e => e.Price).HasMaxLength(500);

                entity.Property(e => e.Profit)
                    .HasColumnType("money")
                    .HasComment("净利润");

                entity.Property(e => e.ProfitChcek).HasColumnType("money");

                entity.Property(e => e.Quantity).HasMaxLength(500);

                entity.Property(e => e.Settled)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'n')")
                    .HasComment("y 已结算 n 未结 k 留存 (keep)");

                entity.Property(e => e.Specs)
                    .HasMaxLength(500)
                    .HasComment("规格");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'a')")
                    .HasComment("订单状态 n正常  c 取消  d删除");

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Proof>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasComment("支付金额");

                entity.Property(e => e.CheckStatus)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'n')")
                    .HasComment("n 待审核 y 审核中 s审核完成 ");

                entity.Property(e => e.CompanyId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentRoleId).HasComment("当前操作角色");

                entity.Property(e => e.CurrentRoleName).HasMaxLength(50);

                entity.Property(e => e.CurrentUserName).HasMaxLength(50);

                entity.Property(e => e.Demo)
                    .HasMaxLength(2000)
                    .HasComment("申请单备注");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(100)
                    .HasComment("部门");

                entity.Property(e => e.IsLock)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('n')")
                    .HasComment("是否已上锁");

                entity.Property(e => e.ItemDetail)
                    .HasMaxLength(2000)
                    .HasComment("项目明细");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(500)
                    .HasComment("支付项目");

                entity.Property(e => e.LockName).HasMaxLength(50);

                entity.Property(e => e.LockRealName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NextRoleIds).HasMaxLength(100);

                entity.Property(e => e.NextRoleNames).HasMaxLength(100);

                entity.Property(e => e.OperateId)
                    .HasDefaultValueSql("((0))")
                    .HasComment("申请人");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(50);

                entity.Property(e => e.PayInfoDetail).HasMaxLength(500);

                entity.Property(e => e.PayInfoId).HasComment("支付帐户ID  InfoBankId");

                entity.Property(e => e.PayMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'n')")
                    .HasComment("n无需支付 w 待支付 y支付完成 ");

                entity.Property(e => e.PayTime)
                    .HasColumnType("datetime")
                    .HasComment("支付日期");

                entity.Property(e => e.PayUserName).HasMaxLength(100);

                entity.Property(e => e.ProofDate)
                    .HasColumnType("datetime")
                    .HasComment("申请日期");

                entity.Property(e => e.ProofNo)
                    .HasColumnName("ProofNO")
                    .HasMaxLength(100)
                    .HasComment("凭证编号");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'y')")
                    .HasComment("状态 y正常 a初审  b 终审  c 财务  d付款 ");

                entity.Property(e => e.SubmitTime)
                    .HasColumnType("datetime")
                    .HasComment("提交时间");

                entity.Property(e => e.SumitStatus)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'n')")
                    .HasComment("提交状态 n未提交 y已提交");

                entity.Property(e => e.SupplierBankAccount)
                    .HasMaxLength(200)
                    .HasComment("收款帐号");

                entity.Property(e => e.SupplierBankName)
                    .HasMaxLength(200)
                    .HasComment("开户行");

                entity.Property(e => e.SupplierId)
                    .HasDefaultValueSql("((0))")
                    .HasComment("收款 ID");

                entity.Property(e => e.SupplierLinkName).HasMaxLength(200);

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(200)
                    .HasComment("收款 人");

                entity.Property(e => e.TempleName).HasMaxLength(100);

                entity.Property(e => e.TypeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.TypeName).HasMaxLength(100);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasComment("最近修改时间");

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProofLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Demo)
                    .HasMaxLength(1000)
                    .HasComment("审核意见");

                entity.Property(e => e.OperateId)
                    .HasDefaultValueSql("((0))")
                    .HasComment("申请人");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(50);

                entity.Property(e => e.OperateRoleId).HasComment("当前操作角色");

                entity.Property(e => e.OperateRoleName).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'y')")
                    .HasComment("y 审核通过   n审核不通过 ");

                entity.Property(e => e.Vest).HasMaxLength(50);
            });

            modelBuilder.Entity<ProofTemple>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Demo).HasMaxLength(500);

                entity.Property(e => e.OperateId).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(50);

                entity.Property(e => e.RoleIds)
                    .HasMaxLength(200)
                    .HasComment("所选择的角色");

                entity.Property(e => e.RoleNames).HasMaxLength(500);

                entity.Property(e => e.Sort).HasComment("排序");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasComment("状态  是否可用");

                entity.Property(e => e.TempleName)
                    .HasMaxLength(100)
                    .HasComment("模板名称");

                entity.Property(e => e.Vest).HasMaxLength(50);
            });

            modelBuilder.Entity<ProofTempleRole>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsJump).HasComment("是否可以跳过此流程");

                entity.Property(e => e.Limits)
                    .HasMaxLength(100)
                    .HasComment("权限 初审a  终审b  财务c 付款d");

                entity.Property(e => e.OperateId).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(50);

                entity.Property(e => e.RoleName).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'y')")
                    .HasComment("状态  该流程是否可用");

                entity.Property(e => e.Step).HasComment("审核流程  1 2 3 4 步骤");

                entity.Property(e => e.TempleName).HasMaxLength(100);

                entity.Property(e => e.Vest).HasMaxLength(50);
            });

            modelBuilder.Entity<ProofType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Demo).HasMaxLength(2000);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasComment("类目 名称");

                entity.Property(e => e.OperateName).HasMaxLength(50);

                entity.Property(e => e.OperateRealName).HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .HasDefaultValueSql("((0))")
                    .HasComment("父类目 ");

                entity.Property(e => e.ParentName).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Vest)
                    .IsRequired()
                    .HasMaxLength(50);
            });

           
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
