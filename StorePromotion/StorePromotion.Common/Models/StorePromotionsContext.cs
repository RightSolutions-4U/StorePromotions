using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StorePromotion.Common.Models
{
    public partial class StorePromotionsContext : DbContext
    {
        public StorePromotionsContext()
        {
        }

        public StorePromotionsContext(DbContextOptions<StorePromotionsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminUser> AdminUsers { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerCampaign> CustomerCampaigns { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<StoreOwner> StoreOwners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=MARS\\MARS ; Database=StorePromotions; user id= mars ; password = mars; Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AdminUser>(entity =>
            {
                entity.HasKey(e => new { e.UserId});

                entity.ToTable("AdminUser");

                entity.Property(e => e.Pwd).HasMaxLength(50);

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.HasKey(e => new { e.CampaignId, e.StoreId });

                entity.ToTable("Campaign");

                entity.Property(e => e.CampaignId).ValueGeneratedOnAdd();

                entity.Property(e => e.Cdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CDate");

                entity.Property(e => e.SentDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.CityName).HasMaxLength(50);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => new { e.CustId, e.StoreId });

                entity.ToTable("Customer");

                entity.Property(e => e.CustId).ValueGeneratedOnAdd();

                entity.Property(e => e.CellNo).HasMaxLength(50);

                entity.Property(e => e.CustFname)
                    .HasMaxLength(50)
                    .HasColumnName("CustFName");

                entity.Property(e => e.CustLname)
                    .HasMaxLength(50)
                    .HasColumnName("CustLName");

                entity.Property(e => e.Email).HasMaxLength(50);
            });

            modelBuilder.Entity<CustomerCampaign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustomerCampaign");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasKey(e => new { e.StoreId, e.OwnerId });

                entity.ToTable("Store");

                entity.Property(e => e.StoreId).ValueGeneratedOnAdd();

                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.Qrurl)
                    .HasMaxLength(50)
                    .HasColumnName("QRURL");

                entity.Property(e => e.StName).HasMaxLength(50);

                entity.Property(e => e.StateId).HasMaxLength(20);
            });

            modelBuilder.Entity<StoreOwner>(entity =>
            {
                entity.HasKey(e => e.OwnerId);

                entity.ToTable("StoreOwner");

                entity.Property(e => e.CellNo).HasMaxLength(20);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .HasColumnName("FName");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .HasColumnName("LName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
