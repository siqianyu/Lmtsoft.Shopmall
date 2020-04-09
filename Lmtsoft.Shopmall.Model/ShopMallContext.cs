using System;
using System.IO;
using Lmtsoft.Shopmall.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Lmtsoft.Shopmall.Models
{
    public partial class ShopMallContext : DbContext
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>


        public ShopMallContext()
        {

        }

        public ShopMallContext(DbContextOptions<ShopMallContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserCode> UserCode { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                var constr = ConfigHelper.GetConnectionValue();
                optionsBuilder.UseSqlServer(constr);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.Area).HasMaxLength(255);

                entity.Property(e => e.Avatar).HasMaxLength(255);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NickName).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.Province).HasMaxLength(500);

                entity.Property(e => e.Salt).HasMaxLength(20);

                entity.Property(e => e.Sex).HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("帐户状态 0 正常 1 待验证 2 待审核 3锁定 ");

                entity.Property(e => e.WxOpenId).HasMaxLength(100);
            });

            modelBuilder.Entity<UserCode>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasComment("生成时间");

                entity.Property(e => e.Count).HasComment("使用次数");

                entity.Property(e => e.EffTime)
                    .HasColumnType("datetime")
                    .HasComment("有效时间");

                entity.Property(e => e.Status).HasComment("状态0未使用 1已使用");

                entity.Property(e => e.StrCode)
                    .HasMaxLength(255)
                    .HasComment("生成的字符串");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasComment("生成码类别 password取回密码 register 邀请注册");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasColumnName("UserIP")
                    .HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
