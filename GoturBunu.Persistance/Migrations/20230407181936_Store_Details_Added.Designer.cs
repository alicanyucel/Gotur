﻿// <auto-generated />
using System;
using GoturBunu.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;

#nullable disable

namespace GoturBunu.Persistance.Migrations
{
    [DbContext(typeof(GoturBunuContext))]
    [Migration("20230407181936_Store_Details_Added")]
    partial class Store_Details_Added
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GoturBunu.Domain.Entities.Carrier.CarrierRegistryRequest", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DistrictId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalIdentityNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("CarrierRegistryRequests");
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.District", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvinceId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Identity.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "9cf20d1a-9a51-4918-bd1b-29b972057fbf",
                            ConcurrencyStamp = "c795b65b-5a02-4365-960c-7330c9626c2e",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "0bd95914-44ff-4f4d-bf02-e083d77b75fa",
                            ConcurrencyStamp = "4579862a-75c6-4974-afa3-370fa827b876",
                            Name = "Store",
                            NormalizedName = "STORE"
                        },
                        new
                        {
                            Id = "fb7ac2d9-b240-4d91-a2c9-d70072cefc64",
                            ConcurrencyStamp = "5e4dccab-eedd-4800-a750-f27d2093282b",
                            Name = "Carrier",
                            NormalizedName = "CARRIER"
                        });
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Identity.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "https://goturbunu.com/identity/claims/permission",
                            ClaimValue = "CarrierRegistryRequestNavigationPermission",
                            RoleId = "9cf20d1a-9a51-4918-bd1b-29b972057fbf"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "https://goturbunu.com/identity/claims/permission",
                            ClaimValue = "GetCurrentLocationListQueryPermission",
                            RoleId = "9cf20d1a-9a51-4918-bd1b-29b972057fbf"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "https://goturbunu.com/identity/claims/permission",
                            ClaimValue = "GetTestDataListQueryPermission",
                            RoleId = "9cf20d1a-9a51-4918-bd1b-29b972057fbf"
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "https://goturbunu.com/identity/claims/permission",
                            ClaimValue = "LiveMapNavigationPermission",
                            RoleId = "9cf20d1a-9a51-4918-bd1b-29b972057fbf"
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "https://goturbunu.com/identity/claims/permission",
                            ClaimValue = "SetCurrentLocationCommandPermission",
                            RoleId = "9cf20d1a-9a51-4918-bd1b-29b972057fbf"
                        },
                        new
                        {
                            Id = 6,
                            ClaimType = "https://goturbunu.com/identity/claims/permission",
                            ClaimValue = "StoreRegistryRequestNavigationPermission",
                            RoleId = "9cf20d1a-9a51-4918-bd1b-29b972057fbf"
                        },
                        new
                        {
                            Id = 7,
                            ClaimType = "https://goturbunu.com/identity/claims/permission",
                            ClaimValue = "SetCurrentLocationCommandPermission",
                            RoleId = "fb7ac2d9-b240-4d91-a2c9-d70072cefc64"
                        });
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "0ffadff6-2bf5-4edf-be29-12cfe656edf3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
                            Email = "admin@goturbunu.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@GOTURBUNU.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "36125b81-d8c6-4665-9c2f-ec95db4e8eac",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
                            Email = "store@goturbunu.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "STORE@GOTURBUNU.COM",
                            NormalizedUserName = "STORE",
                            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
                            TwoFactorEnabled = false,
                            UserName = "store"
                        },
                        new
                        {
                            Id = "05132bcb-2752-4c5b-87f7-3d884e420df4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
                            Email = "carrier@goturbunu.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "CARRIER@GOTURBUNU.COM",
                            NormalizedUserName = "CARRIER",
                            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
                            TwoFactorEnabled = false,
                            UserName = "carrier"
                        },
                        new
                        {
                            Id = "238160d0-8a4b-4553-85e6-110290ff6878",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
                            Email = "carrier1@goturbunu.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "CARRIER1@GOTURBUNU.COM",
                            NormalizedUserName = "CARRIER1",
                            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
                            TwoFactorEnabled = false,
                            UserName = "carrier1"
                        },
                        new
                        {
                            Id = "0b290621-72de-4825-9f31-c510664d4ca9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
                            Email = "carrier2@goturbunu.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "CARRIER2@GOTURBUNU.COM",
                            NormalizedUserName = "CARRIER2",
                            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
                            TwoFactorEnabled = false,
                            UserName = "carrier2"
                        },
                        new
                        {
                            Id = "541afee1-ccf5-426b-9ed7-cc8087a3d00b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
                            Email = "carrier3@goturbunu.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "CARRIER3@GOTURBUNU.COM",
                            NormalizedUserName = "CARRIER3",
                            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
                            TwoFactorEnabled = false,
                            UserName = "carrier3"
                        },
                        new
                        {
                            Id = "64c40294-ef97-4354-aa2c-c95d4ca61267",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
                            Email = "carrier4@goturbunu.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "CARRIER4@GOTURBUNU.COM",
                            NormalizedUserName = "CARRIER4",
                            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
                            TwoFactorEnabled = false,
                            UserName = "carrier4"
                        },
                        new
                        {
                            Id = "bf67c7fc-2e77-4e96-a08f-a930345c2150",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
                            Email = "carrier5@goturbunu.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "CARRIER5@GOTURBUNU.COM",
                            NormalizedUserName = "CARRIER5",
                            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
                            TwoFactorEnabled = false,
                            UserName = "carrier5"
                        },
                        new
                        {
                            Id = "95defd0e-26a7-4c60-b5ab-79ba66a7f788",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
                            Email = "carrier6@goturbunu.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "CARRIER6@GOTURBUNU.COM",
                            NormalizedUserName = "CARRIER6",
                            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
                            TwoFactorEnabled = false,
                            UserName = "carrier6"
                        },
                        new
                        {
                            Id = "adeb25b4-4fd7-41cf-9cae-f6698febbbea",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
                            Email = "carrier7@goturbunu.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "CARRIER7@GOTURBUNU.COM",
                            NormalizedUserName = "CARRIER7",
                            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
                            TwoFactorEnabled = false,
                            UserName = "carrier7"
                        },
                        new
                        {
                            Id = "9905504a-d071-440f-96ad-3d3ddf38c248",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
                            Email = "carrier8@goturbunu.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "CARRIER8@GOTURBUNU.COM",
                            NormalizedUserName = "CARRIER8",
                            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
                            TwoFactorEnabled = false,
                            UserName = "carrier8"
                        },
                        new
                        {
                            Id = "66d9e051-4961-4aad-9408-eef68716411b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
                            Email = "carrier9@goturbunu.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "CARRIER9@GOTURBUNU.COM",
                            NormalizedUserName = "CARRIER9",
                            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
                            TwoFactorEnabled = false,
                            UserName = "carrier9"
                        },
                        new
                        {
                            Id = "f50590d5-1f85-4f6c-93c8-ec17aebe31b0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
                            Email = "carrier10@goturbunu.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "CARRIER10@GOTURBUNU.COM",
                            NormalizedUserName = "CARRIER10",
                            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
                            TwoFactorEnabled = false,
                            UserName = "carrier10"
                        });
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Identity.UserClaim", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Identity.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Identity.UserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "0ffadff6-2bf5-4edf-be29-12cfe656edf3",
                            RoleId = "9cf20d1a-9a51-4918-bd1b-29b972057fbf"
                        },
                        new
                        {
                            UserId = "36125b81-d8c6-4665-9c2f-ec95db4e8eac",
                            RoleId = "0bd95914-44ff-4f4d-bf02-e083d77b75fa"
                        },
                        new
                        {
                            UserId = "05132bcb-2752-4c5b-87f7-3d884e420df4",
                            RoleId = "fb7ac2d9-b240-4d91-a2c9-d70072cefc64"
                        },
                        new
                        {
                            UserId = "238160d0-8a4b-4553-85e6-110290ff6878",
                            RoleId = "fb7ac2d9-b240-4d91-a2c9-d70072cefc64"
                        },
                        new
                        {
                            UserId = "0b290621-72de-4825-9f31-c510664d4ca9",
                            RoleId = "fb7ac2d9-b240-4d91-a2c9-d70072cefc64"
                        },
                        new
                        {
                            UserId = "541afee1-ccf5-426b-9ed7-cc8087a3d00b",
                            RoleId = "fb7ac2d9-b240-4d91-a2c9-d70072cefc64"
                        },
                        new
                        {
                            UserId = "64c40294-ef97-4354-aa2c-c95d4ca61267",
                            RoleId = "fb7ac2d9-b240-4d91-a2c9-d70072cefc64"
                        },
                        new
                        {
                            UserId = "bf67c7fc-2e77-4e96-a08f-a930345c2150",
                            RoleId = "fb7ac2d9-b240-4d91-a2c9-d70072cefc64"
                        },
                        new
                        {
                            UserId = "95defd0e-26a7-4c60-b5ab-79ba66a7f788",
                            RoleId = "fb7ac2d9-b240-4d91-a2c9-d70072cefc64"
                        },
                        new
                        {
                            UserId = "adeb25b4-4fd7-41cf-9cae-f6698febbbea",
                            RoleId = "fb7ac2d9-b240-4d91-a2c9-d70072cefc64"
                        },
                        new
                        {
                            UserId = "9905504a-d071-440f-96ad-3d3ddf38c248",
                            RoleId = "fb7ac2d9-b240-4d91-a2c9-d70072cefc64"
                        },
                        new
                        {
                            UserId = "66d9e051-4961-4aad-9408-eef68716411b",
                            RoleId = "fb7ac2d9-b240-4d91-a2c9-d70072cefc64"
                        },
                        new
                        {
                            UserId = "f50590d5-1f85-4f6c-93c8-ec17aebe31b0",
                            RoleId = "fb7ac2d9-b240-4d91-a2c9-d70072cefc64"
                        });
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Identity.UserToken", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Province", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Store.StoreDetails", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Point>("Location")
                        .IsRequired()
                        .HasColumnType("geography");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("StoreDetails");
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Store.StoreRegistryRequest", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DistrictId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalIdentityNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("StoreRegistryRequests");
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Test", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Data")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Carrier.CarrierRegistryRequest", b =>
                {
                    b.HasOne("GoturBunu.Domain.Entities.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.District", b =>
                {
                    b.HasOne("GoturBunu.Domain.Entities.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceId");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Identity.RoleClaim", b =>
                {
                    b.HasOne("GoturBunu.Domain.Entities.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Identity.UserClaim", b =>
                {
                    b.HasOne("GoturBunu.Domain.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Identity.UserLogin", b =>
                {
                    b.HasOne("GoturBunu.Domain.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Identity.UserRole", b =>
                {
                    b.HasOne("GoturBunu.Domain.Entities.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoturBunu.Domain.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Identity.UserToken", b =>
                {
                    b.HasOne("GoturBunu.Domain.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Store.StoreDetails", b =>
                {
                    b.HasOne("GoturBunu.Domain.Entities.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("GoturBunu.Domain.Entities.Store.StoreRegistryRequest", b =>
                {
                    b.HasOne("GoturBunu.Domain.Entities.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });
#pragma warning restore 612, 618
        }
    }
}
