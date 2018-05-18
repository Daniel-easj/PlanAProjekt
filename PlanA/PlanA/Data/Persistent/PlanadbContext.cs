using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PlanA
{
    public partial class PlanadbContext : DbContext
    {
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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PlanADB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
