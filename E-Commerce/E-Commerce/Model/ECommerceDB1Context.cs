﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace E_Commerce.Model
{
    public partial class ECommerceDB1Context : DbContext
    {
        public ECommerceDB1Context()
        {
        }

        public ECommerceDB1Context(DbContextOptions<ECommerceDB1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCategory> TblCategories { get; set; }
        public virtual DbSet<TblLogin> TblLogins { get; set; }
        public virtual DbSet<TblProduct> TblProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-H13URP5;Initial Catalog=ECommerceDB1;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.ToTable("TblCategory");

                entity.Property(e => e.CatName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblLogin>(entity =>
            {
                entity.ToTable("TblLogin");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.ToTable("TblProduct");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.ProductDescription).HasMaxLength(50);

                entity.Property(e => e.ProductFinal).HasMaxLength(50);

                entity.Property(e => e.ProductImage).HasMaxLength(50);

                entity.Property(e => e.ProductMrp).HasMaxLength(50);

                entity.Property(e => e.ProductName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
