﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kozmetik.Data;

#nullable disable

namespace kozmetik.Migrations
{
    [DbContext(typeof(cosmeticsDBContext))]
    [Migration("20230501205319_bir")]
    partial class bir
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("kozmetik.Models.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartID"), 1L, 1);

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("RecordDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserrID")
                        .HasColumnType("int");

                    b.HasKey("CartID");

                    b.HasIndex("ProductID");

                    b.HasIndex("UserrID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("kozmetik.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Makyaj"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Cilt Bakımı"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Sağlık-Hijyen"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Anne-Bebek"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Ev-Yaşam"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Saç Bakım"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Parfüm-Deodorant"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Erkek Bakım"
                        });
                });

            modelBuilder.Entity("kozmetik.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"), 1L, 1);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<decimal>("OlderPrice")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("ProductPrice")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            CategoryID = 2,
                            Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 1",
                            OlderPrice = 250m,
                            ProductName = "AHA BHA SERUM",
                            ProductPrice = 250m
                        },
                        new
                        {
                            ProductID = 2,
                            CategoryID = 2,
                            Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 2",
                            OlderPrice = 150m,
                            ProductName = "ALOEAVERA JEL",
                            ProductPrice = 150m
                        },
                        new
                        {
                            ProductID = 3,
                            CategoryID = 1,
                            Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 3",
                            OlderPrice = 250m,
                            ProductName = "ANESTEZİ KREMİ",
                            ProductPrice = 250m
                        },
                        new
                        {
                            ProductID = 4,
                            CategoryID = 1,
                            Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 4",
                            OlderPrice = 200m,
                            ProductName = "ANTIAGING",
                            ProductPrice = 150m
                        },
                        new
                        {
                            ProductID = 5,
                            CategoryID = 1,
                            Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 5",
                            OlderPrice = 400m,
                            ProductName = "ANTISPOT",
                            ProductPrice = 200m
                        },
                        new
                        {
                            ProductID = 6,
                            CategoryID = 1,
                            Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 6",
                            OlderPrice = 150m,
                            ProductName = "APRICOT PEELING",
                            ProductPrice = 100m
                        },
                        new
                        {
                            ProductID = 7,
                            CategoryID = 3,
                            Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 7",
                            OlderPrice = 250m,
                            ProductName = "BAKIM KREMİ ",
                            ProductPrice = 200m
                        },
                        new
                        {
                            ProductID = 8,
                            CategoryID = 1,
                            Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 8",
                            OlderPrice = 300m,
                            ProductName = "BEYAZLATICI KREM",
                            ProductPrice = 300m
                        },
                        new
                        {
                            ProductID = 9,
                            CategoryID = 1,
                            Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 9",
                            OlderPrice = 150m,
                            ProductName = "GEL PEELING",
                            ProductPrice = 100m
                        },
                        new
                        {
                            ProductID = 10,
                            CategoryID = 2,
                            Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 10",
                            OlderPrice = 150m,
                            ProductName = "GÜNEŞ KORUYUCU",
                            ProductPrice = 150m
                        },
                        new
                        {
                            ProductID = 11,
                            CategoryID = 1,
                            Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 11",
                            OlderPrice = 150m,
                            ProductName = "KİL",
                            ProductPrice = 150m
                        },
                        new
                        {
                            ProductID = 12,
                            CategoryID = 3,
                            Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12",
                            OlderPrice = 150m,
                            ProductName = "MOSISTURE KREM",
                            ProductPrice = 150m
                        },
                        new
                        {
                            ProductID = 13,
                            CategoryID = 3,
                            Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12",
                            OlderPrice = 150m,
                            ProductName = "PİRİNÇ",
                            ProductPrice = 150m
                        },
                        new
                        {
                            ProductID = 14,
                            CategoryID = 3,
                            Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12",
                            OlderPrice = 150m,
                            ProductName = "SIKILAŞTIRICI KREM",
                            ProductPrice = 150m
                        },
                        new
                        {
                            ProductID = 15,
                            CategoryID = 3,
                            Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12",
                            OlderPrice = 150m,
                            ProductName = "TONIK",
                            ProductPrice = 150m
                        },
                        new
                        {
                            ProductID = 16,
                            CategoryID = 3,
                            Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12",
                            OlderPrice = 150m,
                            ProductName = "TROPICAL",
                            ProductPrice = 150m
                        },
                        new
                        {
                            ProductID = 17,
                            CategoryID = 3,
                            Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12",
                            OlderPrice = 150m,
                            ProductName = "VITAMIN C",
                            ProductPrice = 150m
                        },
                        new
                        {
                            ProductID = 18,
                            CategoryID = 3,
                            Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12",
                            OlderPrice = 150m,
                            ProductName = "YÜZ TEMIZLEME GEL",
                            ProductPrice = 150m
                        });
                });

            modelBuilder.Entity("kozmetik.Models.Rolee", b =>
                {
                    b.Property<int>("RoleeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleeID"), 1L, 1);

                    b.Property<string>("RoleeName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("RoleeID");

                    b.ToTable("Rolees");

                    b.HasData(
                        new
                        {
                            RoleeID = 1,
                            RoleeName = "CandidateUser"
                        },
                        new
                        {
                            RoleeID = 2,
                            RoleeName = "NormalUser"
                        },
                        new
                        {
                            RoleeID = 3,
                            RoleeName = "Admin"
                        },
                        new
                        {
                            RoleeID = 4,
                            RoleeName = "Supervisor"
                        });
                });

            modelBuilder.Entity("kozmetik.Models.Userr", b =>
                {
                    b.Property<int>("UserrID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserrID"), 1L, 1);

                    b.Property<string>("Emaill")
                        .IsRequired()
                        .HasMaxLength(52)
                        .HasColumnType("nvarchar(52)");

                    b.Property<string>("Passwordd")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("RoleeID")
                        .HasColumnType("int");

                    b.HasKey("UserrID");

                    b.HasIndex("RoleeID");

                    b.ToTable("Userrs");

                    b.HasData(
                        new
                        {
                            UserrID = 1,
                            Emaill = "candidateuser@hotmail.com",
                            Passwordd = "123456",
                            RoleeID = 1
                        },
                        new
                        {
                            UserrID = 2,
                            Emaill = "normaluser@hotmail.com",
                            Passwordd = "123456",
                            RoleeID = 2
                        },
                        new
                        {
                            UserrID = 3,
                            Emaill = "admin@hotmail.com",
                            Passwordd = "123456",
                            RoleeID = 3
                        },
                        new
                        {
                            UserrID = 4,
                            Emaill = "supervisor@hotmail.com",
                            Passwordd = "123456",
                            RoleeID = 4
                        });
                });

            modelBuilder.Entity("kozmetik.Models.Cart", b =>
                {
                    b.HasOne("kozmetik.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kozmetik.Models.Userr", "Userr")
                        .WithMany()
                        .HasForeignKey("UserrID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Userr");
                });

            modelBuilder.Entity("kozmetik.Models.Product", b =>
                {
                    b.HasOne("kozmetik.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("kozmetik.Models.Userr", b =>
                {
                    b.HasOne("kozmetik.Models.Rolee", "Rolee")
                        .WithMany()
                        .HasForeignKey("RoleeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rolee");
                });
#pragma warning restore 612, 618
        }
    }
}
