using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace myShoppingAPI.Model.EF
{
    public partial class myshoppingDBAPIContext : DbContext
    {
        public myshoppingDBAPIContext()
        {
        }

        public myshoppingDBAPIContext(DbContextOptions<myshoppingDBAPIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=WIN8\\NIKHILINSTANCE;database=myshoppingDBAPI;integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK__customer__D830D477B7EB91A7");

                entity.ToTable("customers");

                entity.Property(e => e.CId)
                    .ValueGeneratedNever()
                    .HasColumnName("cId");

                entity.Property(e => e.CEmail)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cEmail");

                entity.Property(e => e.CIsActive).HasColumnName("cIsActive");

                entity.Property(e => e.CName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cName");

                entity.Property(e => e.CType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cType");

                entity.Property(e => e.CWalletBalance).HasColumnName("cWalletBalance");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.PId)
                    .HasName("PK__products__DD36D562F9E4F88D");

                entity.ToTable("products");

                entity.Property(e => e.PId)
                    .ValueGeneratedNever()
                    .HasColumnName("pId");

                entity.Property(e => e.PCategoty)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pCategoty");

                entity.Property(e => e.PIsInStock).HasColumnName("pIsInStock");

                entity.Property(e => e.PName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pName");

                entity.Property(e => e.PPrice).HasColumnName("pPrice");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
