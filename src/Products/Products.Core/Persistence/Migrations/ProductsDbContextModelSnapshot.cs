﻿// <auto-generated />
using System;
using IGroceryStore.Products.Core.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IGroceryStore.Products.Core.Persistence.Migrations
{
    [DbContext(typeof(ProductsDbContext))]
    partial class ProductsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("IGroceryStore.Products")
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("IGroceryStore.Products.Core.Entities.Allergen", b =>
                {
                    b.Property<ulong>("Id")
                        .HasColumnType("numeric(20,0)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Allergens", "IGroceryStore.Products");
                });

            modelBuilder.Entity("IGroceryStore.Products.Core.Entities.Brand", b =>
                {
                    b.Property<ulong>("Id")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Brands", "IGroceryStore.Products");
                });

            modelBuilder.Entity("IGroceryStore.Products.Core.Entities.Category", b =>
                {
                    b.Property<ulong>("Id")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Category", "IGroceryStore.Products");
                });

            modelBuilder.Entity("IGroceryStore.Products.Core.Entities.Country", b =>
                {
                    b.Property<ulong>("Id")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Countries", "IGroceryStore.Products");
                });

            modelBuilder.Entity("IGroceryStore.Products.Core.Entities.Product", b =>
                {
                    b.Property<ulong>("Id")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Allergens")
                        .HasColumnType("text");

                    b.Property<string>("BarCode")
                        .HasColumnType("text");

                    b.Property<ulong>("BrandId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<ulong>("CategoryId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<ulong>("CountryId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<bool>("IsObsolete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CountryId");

                    b.ToTable("Products", "IGroceryStore.Products");
                });

            modelBuilder.Entity("IGroceryStore.Products.Core.Entities.Product", b =>
                {
                    b.HasOne("IGroceryStore.Products.Core.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IGroceryStore.Products.Core.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IGroceryStore.Products.Core.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Country");
                });
#pragma warning restore 612, 618
        }
    }
}