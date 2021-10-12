using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CQRSDemo.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CQRSDemo.DataContext
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContactInfo> ContactInfo { get; set; }
        public virtual DbSet<CourierOrderStatus> CourierOrderStatus { get; set; }
        public virtual DbSet<CourierOrders> CourierOrders { get; set; }
        public virtual DbSet<CourierUsers> CourierUsers { get; set; }
        public virtual DbSet<Couriers> Couriers { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<Divisions> Divisions { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<OrderDetailsLog> OrderDetailsLog { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductDetails> ProductDetails { get; set; }
        public virtual DbSet<Slider> Slider { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<Tbl1> Tbl1 { get; set; }
        public virtual DbSet<Tbl1Audit> Tbl1Audit { get; set; }
        public virtual DbSet<TestTable> TestTable { get; set; }
        public virtual DbSet<Unions> Unions { get; set; }
        public virtual DbSet<Upazilas> Upazilas { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UspLoadOrders> UspLoadOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactInfo>(entity =>
            {
                entity.Property(e => e.Facebook).HasMaxLength(400);

                entity.Property(e => e.FooterAddress).HasMaxLength(500);

                entity.Property(e => e.FooterEmail).HasMaxLength(30);

                entity.Property(e => e.FooterMobileOne)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FooterMobileTwo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FooterWebUrl).HasMaxLength(100);

                entity.Property(e => e.HeaderEmail).HasMaxLength(30);

                entity.Property(e => e.HeaderMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Linkedin).HasMaxLength(400);

                entity.Property(e => e.Twitter).HasMaxLength(400);
            });

            modelBuilder.Entity<CourierOrderStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CourierOrderStatus", "DT");

                entity.Property(e => e.CustomerEmail).HasDefaultValueSql("('')");

                entity.Property(e => e.CustomerMessage)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DashboardStatusGroup)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email).HasDefaultValueSql("('')");

                entity.Property(e => e.FulfillmentStatusGroup)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderTrackStatusGroup)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderTrackStatusPublicGroup)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostedOn).HasColumnType("datetime");

                entity.Property(e => e.StatusGroup)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusNameBng).HasMaxLength(255);

                entity.Property(e => e.StatusNameEng)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StatusType)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CourierOrders>(entity =>
            {
                entity.ToTable("CourierOrders", "DT");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AreaId).HasDefaultValueSql("((0))");

                entity.Property(e => e.BreakableCharge)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodCharge)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CollectAddress)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CollectionAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CollectionCharge)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CollectionName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ConfirmationDate).HasColumnType("datetime");

                entity.Property(e => e.CourierCharge)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CourierId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CourierOrdersId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasComputedColumnSql("('DT-'+CONVERT([varchar](10),[Id]))");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryCharge)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DistrictId).HasDefaultValueSql("((0))");

                entity.Property(e => e.HubName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsAutoProcess).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsConfirmedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsDownloaded).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOpenBox).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTakaCollectionFromCourier)
                    .HasColumnName("isTakaCollectionFromCourier")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MerchantId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderFrom)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OtherMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PackagingCharge)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PackagingName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PodNumber)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostedOn).HasColumnType("datetime");

                entity.Property(e => e.ReturnCharge)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ThanaId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ThirdPartyCourierInfo)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Weight)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CourierUsers>(entity =>
            {
                entity.HasKey(e => e.CourierUserId);

                entity.ToTable("CourierUsers", "DT");

                entity.HasIndex(e => e.Mobile)
                    .HasName("UC_CourierUsers")
                    .IsUnique();

                entity.Property(e => e.AcquisitionUserId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AlterMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BkashNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CollectionCharge).HasColumnType("money");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsAutoProcess).HasDefaultValueSql("((0))");

                entity.Property(e => e.JoinDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[getlocaldate]())");

                entity.Property(e => e.MailCharge).HasColumnType("money");

                entity.Property(e => e.MaxCodCharge)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Refreshtoken)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RetentionUserId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnCharge).HasColumnType("money");

                entity.Property(e => e.SmsCharge).HasColumnType("money");

                entity.Property(e => e.SourceType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<Couriers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Couriers", "Deal");

                entity.Property(e => e.CodchargeInDhaka).HasColumnName("CODChargeInDhaka");

                entity.Property(e => e.CodchargeOutDhaka).HasColumnName("CODChargeOutDhaka");

                entity.Property(e => e.CodperiferiCharge).HasColumnName("CODPeriferiCharge");

                entity.Property(e => e.ContactAddress)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.CourierName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsProvidePod).HasColumnName("IsProvidePOD");

                entity.Property(e => e.LastPullDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.RefreshToken).HasMaxLength(100);

                entity.Property(e => e.Token).HasMaxLength(300);
            });

            modelBuilder.Entity<Districts>(entity =>
            {
                entity.HasKey(e => e.DistrictId);

                entity.Property(e => e.DistrictId).ValueGeneratedNever();

                entity.Property(e => e.BnName).HasMaxLength(25);

                entity.Property(e => e.Lat)
                    .HasColumnName("lat")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Lon)
                    .HasColumnName("lon")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Divisions>(entity =>
            {
                entity.HasKey(e => e.DivisionId);

                entity.Property(e => e.DivisionId).ValueGeneratedNever();

                entity.Property(e => e.BnName).HasMaxLength(25);

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Show).HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(150);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.DeliveryAddress).HasMaxLength(400);

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Size).HasMaxLength(50);

                entity.Property(e => e.StatusChangeDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_OrderDetails_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_OrderDetails_Product");
            });

            modelBuilder.Entity<OrderDetailsLog>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Size).HasMaxLength(50);

                entity.Property(e => e.StatusChangeDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.Msrp).HasColumnType("money");

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.ShortDescription).HasMaxLength(500);

                entity.Property(e => e.Show).HasMaxLength(50);

                entity.Property(e => e.Sku).HasMaxLength(100);

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.Property(e => e.UnitSize).HasMaxLength(50);

                entity.Property(e => e.UnitWeight).HasColumnType("money");
            });

            modelBuilder.Entity<ProductDetails>(entity =>
            {
                entity.HasKey(e => e.ProductDetaild);

                entity.Property(e => e.Color).HasMaxLength(20);

                entity.Property(e => e.Size).HasMaxLength(20);
            });

            modelBuilder.Entity<Slider>(entity =>
            {
                entity.Property(e => e.ButtonName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TextName1).HasMaxLength(200);

                entity.Property(e => e.TextName2)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<Suppliers>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(20);
            });

            modelBuilder.Entity<Tbl1>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Val1).HasColumnName("val1");

                entity.Property(e => e.Val2).HasColumnName("val2");
            });

            modelBuilder.Entity<Tbl1Audit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl1_audit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ins)
                    .HasColumnName("ins")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Val1).HasColumnName("val1");

                entity.Property(e => e.Val11).HasColumnName("val11");

                entity.Property(e => e.Val2).HasColumnName("val2");

                entity.Property(e => e.Val22).HasColumnName("val22");
            });

            modelBuilder.Entity<TestTable>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.NetPayableAmount).HasColumnType("money");
            });

            modelBuilder.Entity<Unions>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BnName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Upazilas>(entity =>
            {
                entity.HasKey(e => e.UpazilaId);

                entity.Property(e => e.UpazilaId).ValueGeneratedNever();

                entity.Property(e => e.BnName).HasMaxLength(25);

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.RefreshToken).HasMaxLength(100);

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Token).HasMaxLength(300);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<UspLoadOrders>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("USP_LoadOrders", "DT");

                entity.Property(e => e.CourierOrdersId)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
