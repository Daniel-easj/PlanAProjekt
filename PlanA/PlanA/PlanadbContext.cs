using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PlanA
{
    public partial class PlanadbContext : DbContext
    {
        public virtual DbSet<Cover> Covers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Paint> Paints { get; set; }
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

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("nchar(30)");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("nchar(50)");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("Customer Name")
                    .HasColumnType("nchar(50)");

                entity.Property(e => e.Mail).HasColumnType("nchar(50)");

                entity.Property(e => e.PhoneNumber).HasColumnName("Phone Number");

                entity.Property(e => e.ZipCode).HasColumnName("Zip  Code");
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
