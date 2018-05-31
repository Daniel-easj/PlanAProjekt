using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PlanA.Data.Domain.ExtendedClasses;

namespace PlanA
{
    public partial class PlanadbContext : DbContext
    {
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<CompanyCustomer> CompanyCustomers { get; set; }
        public virtual DbSet<Cover> Covers { get; set; }
        public virtual DbSet<HousingAssociationCustomer> HousingAssociationCustomers { get; set; }
        public virtual DbSet<Paint> Paints { get; set; }
        public virtual DbSet<PrivateCustomer> PrivateCustomers { get; set; }
        public virtual DbSet<Putty> Putties { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Tool> Tools { get; set; }
        public virtual DbSet<Wallcover> Wallcovers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=tcp:danielbsqlserver.database.windows.net,1433;Initial Catalog=PlanADB;Persist Security Info=False;User ID=DanielB;Password=202020Design?;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().Ignore(item => item.Key);

            modelBuilder.Entity<CompanyCustomer>().Ignore(item => item.Key);
            modelBuilder.Entity<CompanyCustomer>().Ignore(item => item.CustomerType);

            modelBuilder.Entity<HousingAssociationCustomer>().Ignore(item => item.Key);
            modelBuilder.Entity<HousingAssociationCustomer>().Ignore(item => item.CustomerType);

            modelBuilder.Entity<PrivateCustomer>().Ignore(item => item.Key);
            modelBuilder.Entity<PrivateCustomer>().Ignore(item => item.CustomerType);

            modelBuilder.Entity<Cover>().Ignore(item => item.Key);
            modelBuilder.Entity<Paint>().Ignore(item => item.Key);
            modelBuilder.Entity<Paint>().Ignore(item => item.ProductType);
            modelBuilder.Entity<Paint>().Ignore(item => item.ReadableQuantity);
            modelBuilder.Entity<Putty>().Ignore(item => item.Key);
            modelBuilder.Entity<Tool>().Ignore(item => item.Key);
            modelBuilder.Entity<Tool>().Ignore(item => item.ProductType);
            modelBuilder.Entity<Tool>().Ignore(item => item.ReadableQuantity);
            modelBuilder.Entity<Wallcover>().Ignore(item => item.Key);


            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.Zip);

                entity.ToTable("City");

                entity.Property(e => e.Zip)
                    .HasColumnType("nchar(30)")
                    .ValueGeneratedNever();

                entity.Property(e => e.City1)
                    .HasColumnName("City")
                    .HasColumnType("nchar(100)");
            });

            modelBuilder.Entity<CompanyCustomer>(entity =>
            {
                entity.HasKey(e => e.CompanyCustomer1);

                entity.ToTable("CompanyCustomer");

                entity.Property(e => e.CompanyCustomer1).HasColumnName("CompanyCustomer");

                entity.Property(e => e.Address).HasColumnType("nchar(100)");

                entity.Property(e => e.Cvr)
                    .HasColumnName("CVR")
                    .HasColumnType("nchar(100)");

                entity.Property(e => e.Email).HasColumnType("nchar(100)");

                entity.Property(e => e.Name).HasColumnType("nchar(100)");

                entity.Property(e => e.Phone).HasColumnType("nchar(100)");

                entity.Property(e => e.Zip).HasColumnType("nchar(30)");

                entity.HasOne(d => d.ZipNavigation)
                    .WithMany(p => p.CompanyCustomers)
                    .HasForeignKey(d => d.Zip)
                    .HasConstraintName("FK_CC_Zip");
            });

            modelBuilder.Entity<Cover>(entity =>
            {
                entity.ToTable("Cover");

                entity.Property(e => e.CoverId).HasColumnName("Cover Id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("nchar(300)");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.SpecificType)
                    .HasColumnName("Specific Type")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HousingAssociationCustomer>(entity =>
            {
                entity.ToTable("HousingAssociationCustomer");

                entity.Property(e => e.HousingAssociationCustomerId).HasColumnName("HousingAssociationCustomer Id");

                entity.Property(e => e.Address).HasColumnType("nchar(100)");

                entity.Property(e => e.Cvr)
                    .HasColumnName("CVR")
                    .HasColumnType("nchar(100)");

                entity.Property(e => e.Email).HasColumnType("nchar(100)");

                entity.Property(e => e.Name).HasColumnType("nchar(100)");

                entity.Property(e => e.Phone).HasColumnType("nchar(100)");

                entity.Property(e => e.Zip).HasColumnType("nchar(30)");

                entity.HasOne(d => d.ZipNavigation)
                    .WithMany(p => p.HousingAssociationCustomers)
                    .HasForeignKey(d => d.Zip)
                    .HasConstraintName("FK_HAC_Zip");
            });

            modelBuilder.Entity<Paint>(entity =>
            {
                entity.ToTable("Paint");

                entity.Property(e => e.PaintId).HasColumnName("Paint Id");

                entity.Property(e => e.Description).HasColumnType("nchar(300)");

                entity.Property(e => e.InDoor).HasColumnName("In Door");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.SpecificType)
                    .HasColumnName("Specific Type")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PrivateCustomer>(entity =>
            {
                entity.ToTable("PrivateCustomer");

                entity.Property(e => e.PrivateCustomerId).HasColumnName("PrivateCustomer Id");

                entity.Property(e => e.Address).HasColumnType("nchar(100)");

                entity.Property(e => e.Email).HasColumnType("nchar(100)");

                entity.Property(e => e.Name).HasColumnType("nchar(100)");

                entity.Property(e => e.Phone).HasColumnType("nchar(100)");

                entity.Property(e => e.Zip).HasColumnType("nchar(30)");

                entity.HasOne(d => d.ZipNavigation)
                    .WithMany(p => p.PrivateCustomers)
                    .HasForeignKey(d => d.Zip)
                    .HasConstraintName("FK_PC_Zip");
            });

            modelBuilder.Entity<Putty>(entity =>
            {
                entity.ToTable("Putty");

                entity.Property(e => e.PuttyId).HasColumnName("Putty Id");

                entity.Property(e => e.Coarse)
                    .IsRequired()
                    .HasColumnType("nchar(30)");

                entity.Property(e => e.Description).HasColumnType("nchar(300)");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.SpecificType)
                    .HasColumnName("Specific Type")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasKey(e => e.RefNr);

                entity.ToTable("Task");

                entity.Property(e => e.RefNr)
                    .HasColumnName("Ref-Nr")
                    .ValueGeneratedNever();

                entity.Property(e => e.TaskDescription)
                    .HasColumnName("Task Description")
                    .HasColumnType("nchar(100)");

                entity.Property(e => e.TaskEnd)
                    .HasColumnName("Task End")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaskSource)
                    .HasColumnName("Task Source")
                    .HasColumnType("nchar(50)");

                entity.Property(e => e.TaskStart)
                    .HasColumnName("Task Start")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Tool>(entity =>
            {
                entity.ToTable("Tool");

                entity.Property(e => e.ToolId).HasColumnName("Tool Id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("nchar(300)");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.SpecificType)
                    .HasColumnName("Specific Type")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Wallcover>(entity =>
            {
                entity.ToTable("Wallcover");

                entity.Property(e => e.WallcoverId).HasColumnName("Wallcover Id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("nchar(300)");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.SpecificType)
                    .HasColumnName("Specific Type")
                    .HasDefaultValueSql("((0))");
            });
        }
    }
}
