using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RealmDomain.Models;

#nullable disable

namespace RealmDomain
{
    public partial class TCGStoreContext : DbContext
    {
        public TCGStoreContext()
        {
        }

        public TCGStoreContext(DbContextOptions<TCGStoreContext> options)
            : base(options)
        {
        }

        private readonly IConfiguration config;

        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Orderitem> Orderitems { get; set; }
        public virtual DbSet<Orderstatus> Orderstatuses { get; set; }
        public virtual DbSet<Quality> Qualities { get; set; }
        public virtual DbSet<Sealedproduct> Sealedproducts { get; set; }
        public virtual DbSet<Set> Sets { get; set; }
        public virtual DbSet<Shippingoption> Shippingoptions { get; set; }

        public static void SetConnectionString(string connectionString)
        {
            if (ConnectionString == null)

            {
                ConnectionString = connectionString;
            }
            else
            {
                throw new Exception();
            }
        }

        private static string ConnectionString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(ConnectionString, ServerVersion.Parse("8.0.25-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_0900_ai_ci");

            modelBuilder.Entity<Card>(entity =>
            {
                entity.ToTable("card");

                entity.HasIndex(e => e.SetId, "SetID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.ApiimageId)
                    .HasMaxLength(15)
                    .HasColumnName("APIImageID");

                entity.Property(e => e.CardCodeInSet)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CardName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.ElementalType).HasMaxLength(25);

                entity.Property(e => e.PictureLink).HasMaxLength(250);

                entity.Property(e => e.PictureSmallLink).HasMaxLength(250);

                entity.Property(e => e.Price).HasPrecision(15, 2);

                entity.Property(e => e.Rarity)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.Property(e => e.SubType).HasMaxLength(25);

                entity.Property(e => e.SuperType).HasMaxLength(25);

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.Cards)
                    .HasForeignKey(d => d.SetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("card_ibfk_1");
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.ToTable("game");

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.Property(e => e.GameName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.ToTable("inventory");

                entity.HasIndex(e => e.CardId, "CardID");

                entity.HasIndex(e => e.QualityId, "QualityID");

                entity.Property(e => e.InventoryId).HasColumnName("InventoryID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.FirstEdition).HasColumnType("bit(1)");

                entity.Property(e => e.QualityId).HasColumnName("QualityID");

                entity.Property(e => e.SealedProductId).HasColumnName("SealedProductID");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.Inventories)
                    .HasForeignKey(d => d.CardId)
                    .HasConstraintName("inventory_ibfk_1");

                entity.HasOne(d => d.Quality)
                    .WithMany(p => p.Inventories)
                    .HasForeignKey(d => d.QualityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("inventory_ibfk_2");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.HasIndex(e => e.ShippingId, "ShippingID");

                entity.HasIndex(e => e.StatusId, "StatusID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.City).HasMaxLength(40);

                entity.Property(e => e.Gst)
                    .HasPrecision(15, 2)
                    .HasColumnName("GST");

                entity.Property(e => e.Hst)
                    .HasPrecision(15, 2)
                    .HasColumnName("HST");

                entity.Property(e => e.PostalCode).HasMaxLength(7);

                entity.Property(e => e.Province).HasMaxLength(25);

                entity.Property(e => e.Pst)
                    .HasPrecision(15, 2)
                    .HasColumnName("PST");

                entity.Property(e => e.SaleDate).HasColumnType("date");

                entity.Property(e => e.ShippingAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShippingId).HasColumnName("ShippingID");

                entity.Property(e => e.ShippingPrice).HasPrecision(15, 2);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubTotal).HasPrecision(15, 2);

                entity.Property(e => e.Total).HasPrecision(15, 2);

                entity.Property(e => e.UpdatedBy).HasMaxLength(20);

                entity.HasOne(d => d.Shipping)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ShippingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_ibfk_1");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_ibfk_2");
            });

            modelBuilder.Entity<Orderitem>(entity =>
            {
                entity.ToTable("orderitems");

                entity.HasIndex(e => e.InventoryId, "InventoryID");

                entity.HasIndex(e => e.OrderId, "OrderID");

                entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");

                entity.Property(e => e.InventoryId).HasColumnName("InventoryID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderItemPrice).HasPrecision(15, 2);

                entity.HasOne(d => d.Inventory)
                    .WithMany(p => p.Orderitems)
                    .HasForeignKey(d => d.InventoryId)
                    .HasConstraintName("orderitems_ibfk_2");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Orderitems)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderitems_ibfk_1");
            });

            modelBuilder.Entity<Orderstatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PRIMARY");

                entity.ToTable("orderstatus");

                entity.Property(e => e.StatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("StatusID");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Quality>(entity =>
            {
                entity.ToTable("quality");

                entity.Property(e => e.QualityId).HasColumnName("QualityID");

                entity.Property(e => e.PercentageDiscount).HasPrecision(5, 2);

                entity.Property(e => e.QualityName)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.QualityShortName)
                    .IsRequired()
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<Sealedproduct>(entity =>
            {
                entity.ToTable("sealedproduct");

                entity.HasIndex(e => e.SetId, "SetID");

                entity.Property(e => e.SealedProductId).HasColumnName("SealedProductID");

                entity.Property(e => e.Price).HasPrecision(15, 2);

                entity.Property(e => e.SealedProductName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.Sealedproducts)
                    .HasForeignKey(d => d.SetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sealedproduct_ibfk_1");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.ToTable("set");

                entity.HasIndex(e => e.GameId, "GameID");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.Property(e => e.ReleaseDate).HasColumnType("date");

                entity.Property(e => e.SetCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SetName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.Sets)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("set_ibfk_1");
            });

            modelBuilder.Entity<Shippingoption>(entity =>
            {
                entity.HasKey(e => e.ShippingId)
                    .HasName("PRIMARY");

                entity.ToTable("shippingoptions");

                entity.Property(e => e.ShippingId)
                    .ValueGeneratedNever()
                    .HasColumnName("ShippingID");

                entity.Property(e => e.ShippingName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
