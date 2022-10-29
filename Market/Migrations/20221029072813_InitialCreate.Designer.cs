﻿// <auto-generated />
using System;
using Market.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Market.Migrations
{
    [DbContext(typeof(ExampleDBContext))]
    [Migration("20221029072813_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Market.Entity.CancelledSalesInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnearnedMoney")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CancelledSalesInfo");
                });

            modelBuilder.Entity("Market.Entity.ConfirmedSalesInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MoneyEarned")
                        .HasColumnType("int");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ConfirmedSalesInfo");
                });

            modelBuilder.Entity("Market.Entity.Products", b =>
                {
                    b.Property<int>("Barkod")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Barkod");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Barkod = 1,
                            Name = "Apple",
                            Price = 2,
                            Stock = 10
                        },
                        new
                        {
                            Barkod = 2,
                            Name = "Orange",
                            Price = 3,
                            Stock = 10
                        },
                        new
                        {
                            Barkod = 3,
                            Name = "Banana",
                            Price = 4,
                            Stock = 10
                        },
                        new
                        {
                            Barkod = 4,
                            Name = "Pineapple",
                            Price = 5,
                            Stock = 10
                        },
                        new
                        {
                            Barkod = 5,
                            Name = "Watermelon",
                            Price = 6,
                            Stock = 10
                        },
                        new
                        {
                            Barkod = 6,
                            Name = "Strawberry",
                            Price = 7,
                            Stock = 10
                        },
                        new
                        {
                            Barkod = 7,
                            Name = "Peach",
                            Price = 8,
                            Stock = 10
                        },
                        new
                        {
                            Barkod = 8,
                            Name = "Pear",
                            Price = 9,
                            Stock = 10
                        },
                        new
                        {
                            Barkod = 9,
                            Name = "Grape",
                            Price = 10,
                            Stock = 10
                        },
                        new
                        {
                            Barkod = 10,
                            Name = "Cherry",
                            Price = 1,
                            Stock = 10
                        },
                        new
                        {
                            Barkod = 11,
                            Name = "Mango",
                            Price = 2,
                            Stock = 10
                        },
                        new
                        {
                            Barkod = 12,
                            Name = "Pomegranate",
                            Price = 13,
                            Stock = 10
                        },
                        new
                        {
                            Barkod = 13,
                            Name = "Kiwi",
                            Price = 14,
                            Stock = 10
                        },
                        new
                        {
                            Barkod = 14,
                            Name = "Lemon",
                            Price = 15,
                            Stock = 10
                        },
                        new
                        {
                            Barkod = 15,
                            Name = "Lime",
                            Price = 16,
                            Stock = 10
                        },
                        new
                        {
                            Barkod = 16,
                            Name = "Raspberry",
                            Price = 17,
                            Stock = 10
                        },
                        new
                        {
                            Barkod = 17,
                            Name = "Blueberry",
                            Price = 18,
                            Stock = 10
                        });
                });

            modelBuilder.Entity("Market.Entity.QuickSaleCommonProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ProductBarkod")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("QuickSaleCommonProducts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductBarkod = 1
                        },
                        new
                        {
                            Id = 2,
                            ProductBarkod = 2
                        },
                        new
                        {
                            Id = 3,
                            ProductBarkod = 3
                        },
                        new
                        {
                            Id = 4,
                            ProductBarkod = 4
                        },
                        new
                        {
                            Id = 5,
                            ProductBarkod = 5
                        },
                        new
                        {
                            Id = 6,
                            ProductBarkod = 6
                        },
                        new
                        {
                            Id = 7,
                            ProductBarkod = 7
                        },
                        new
                        {
                            Id = 8,
                            ProductBarkod = 8
                        },
                        new
                        {
                            Id = 9,
                            ProductBarkod = 9
                        },
                        new
                        {
                            Id = 10,
                            ProductBarkod = 10
                        },
                        new
                        {
                            Id = 11,
                            ProductBarkod = 11
                        },
                        new
                        {
                            Id = 12,
                            ProductBarkod = 12
                        },
                        new
                        {
                            Id = 13,
                            ProductBarkod = 13
                        },
                        new
                        {
                            Id = 14,
                            ProductBarkod = 14
                        },
                        new
                        {
                            Id = 15,
                            ProductBarkod = 15
                        });
                });

            modelBuilder.Entity("Market.Entity.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Barkod")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("Market.Entity.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Permission")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
