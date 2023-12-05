using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Posuda.db;

public partial class PosudaContext : DbContext
{
    public PosudaContext()
    {
    }

    public PosudaContext(DbContextOptions<PosudaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DeliveryPoint> DeliveryPoints { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=C:\\Users\\student\\Downloads\\пм05_мельников\\Posuda\\Posuda\\bin\\Debug\\net7.0-windows\\Posuda.db;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DeliveryPoint>(entity =>
        {
            entity.HasKey(e => e.PointNumber);

            entity.ToTable("DeliveryPoint");

            entity.Property(e => e.PointNumber).ValueGeneratedNever();
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderNumber);

            entity.ToTable("Order");

            entity.Property(e => e.OrderNumber).ValueGeneratedNever();
            entity.Property(e => e.DeliveryPoint).HasColumnType("NUMERIC");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Article);

            entity.ToTable("Product");

            entity.Property(e => e.Article).ValueGeneratedNever();
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Name);

            entity.ToTable("User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
