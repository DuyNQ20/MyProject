﻿// <auto-generated />
using System;
using CatalogService.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MyProject.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MyProject.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTimeOffset?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset?>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("MyProject.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTimeOffset?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset?>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("MyProject.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTimeOffset?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Info");

                    b.Property<string>("Logo");

                    b.Property<DateTimeOffset?>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Manufacturer");
                });

            modelBuilder.Entity("MyProject.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTimeOffset?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Decriptions");

                    b.Property<bool>("Deleted");

                    b.Property<int>("Inventory");

                    b.Property<bool>("IsNew");

                    b.Property<int>("ManufacturerId");

                    b.Property<DateTimeOffset?>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("Specifications");

                    b.Property<int>("VendorId");

                    b.Property<int>("View");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("VendorId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("MyProject.Models.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Address");

                    b.Property<DateTimeOffset?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Email");

                    b.Property<DateTimeOffset?>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("MyProject.Models.Comment", b =>
                {
                    b.HasOne("MyProject.Models.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyProject.Models.Image", b =>
                {
                    b.HasOne("MyProject.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyProject.Models.Product", b =>
                {
                    b.HasOne("MyProject.Models.Manufacturer", "Manufacturer")
                        .WithMany("Products")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyProject.Models.Vendor", "Vendor")
                        .WithMany("Products")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
