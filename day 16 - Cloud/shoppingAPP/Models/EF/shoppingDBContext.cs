using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace shoppingAPP.Models.EF
{
    public partial class shoppingDBContext : DbContext
    {
        public shoppingDBContext()
        {
        }

        public shoppingDBContext(DbContextOptions<shoppingDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cart> Carts { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Traininginfo> Traininginfos { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:nikhilshah-project-server.database.windows.net,1433;Initial Catalog=shoppingDB;Persist Security Info=False;User ID=project;Password=Cohort@1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cart");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("cost");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("itemName");

                entity.HasOne(d => d.ItemNameNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ItemName)
                    .HasConstraintName("fk_itemName");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.ItemName)
                    .HasName("pk_itemName");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("itemName");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("cost");

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.PId)
                    .HasName("PK__Products__DD36D56210D054B5");

                entity.Property(e => e.PId).HasColumnName("pId");

                entity.Property(e => e.PAvailableQty).HasColumnName("pAvailableQty");

                entity.Property(e => e.PCategory)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pCategory");

                entity.Property(e => e.PIsInStock).HasColumnName("pIsInStock");

                entity.Property(e => e.PName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pName");

                entity.Property(e => e.PPrice).HasColumnName("pPrice");
            });

            modelBuilder.Entity<Traininginfo>(entity =>
            {
                entity.HasKey(e => e.TId)
                    .HasName("PK__training__DC11576767CE9518");

                entity.ToTable("traininginfo");

                entity.Property(e => e.TId).HasColumnName("tId");

                entity.Property(e => e.MyComments)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("myComments");

                entity.Property(e => e.MyFavTechSoFar)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("myFavTechSoFar");

                entity.Property(e => e.MyFeedback).HasColumnName("myFeedback");

                entity.Property(e => e.MyName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("myName");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserNo)
                    .HasName("pk_userNo");

                entity.HasIndex(e => e.Username, "unk_userName")
                    .IsUnique();

                entity.Property(e => e.UserNo)
                    .ValueGeneratedNever()
                    .HasColumnName("userNo");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
