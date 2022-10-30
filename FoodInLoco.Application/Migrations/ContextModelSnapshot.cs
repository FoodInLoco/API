﻿// <auto-generated />
using System;
using FoodInLoco.Application.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FoodInLoco.Application.Data.Entities.Menu", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("InitialDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2022, 10, 30, 9, 10, 14, 63, DateTimeKind.Utc).AddTicks(1346));

                    b.Property<long>("RestaurantId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId")
                        .IsUnique();

                    b.ToTable("Menu", "Menu");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            InitialDate = new DateTime(2022, 10, 30, 9, 10, 14, 251, DateTimeKind.Utc).AddTicks(6241),
                            RestaurantId = 1L
                        });
                });

            modelBuilder.Entity("FoodInLoco.Application.Data.Entities.MenuItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("MenuId")
                        .HasColumnType("bigint");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<double>("Value")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("MenuId")
                        .IsUnique();

                    b.ToTable("MenuItem", "MenuItem");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            MenuId = 1L,
                            Photo = "foto qualquer",
                            Quantity = 1,
                            Status = 1,
                            Value = 11.99
                        });
                });

            modelBuilder.Entity("FoodInLoco.Application.Data.Entities.Restaurant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Restaurant", "Restaurant");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Status = 1
                        });
                });

            modelBuilder.Entity("FoodInLoco.Application.Data.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<int>("Roles")
                        .HasColumnType("integer");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("User", "User");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Password = "MgpcGfZdk9zZHEpZDFSwoNl83Jpsh8dsyF1GXo5SRbLM5Ufz2VutzdiJPpKgVwWjQsiTkcRRSMwmVJKEFAGT4iSdI7VV8cgcjwe0noDbgDsSWu0PT+3rHjQD8CGCjpw8zy61iBRJjHMkZtIqj1KQGp8Afx/2aA7+b8FpqwWfAvIuBsVlk2nsfJ/bUx5wLMm+COI2Oqa5KF7tqBVqeS4o7fxpm8MpHWTsZw8Yus5Ve8in29elbzMlEJ0ib8JfIyYiusEyz4nnUVHS0XXKa18cszcubgssNU4tLtYcrC+Q6eTxB40Ue7IbgYeKBusfFEjJgXIdvn9RK4fwfRq+BrIIHLwszLfPAf0otqgPfieJi6y3OLBJj1Z26UIDmVCv3Vvb+IXEaPz9+h2i5PCP7tf/vu7yr6sws4mBiH65P9d5oiuvzkjxheoJLzdKALmsZa3SCmZsvLA+GsJf4M5uo6kWRyCBaUxXT++wn2a8UUg7H2rQD5bUqyr/XzK/MGiTDqXrDfW4AuNdXWSM03L2Oyyv45KyLwrkFaF1R9MrSpwPjObn3X1VtM3nXF0GHyfXXkGcOW4qG7MVW0ebJ/v6cpQPUvJxyUOimp7UuZYsRKCv2KVUhZWA4N/9j//4TBg7TO+2IKOj6o/KioGjBiQiTg1D8xxyAcjYoouvaHsLabAlvBk=",
                            Roles = 3,
                            Salt = "a21e371e-7db0-4809-aa62-4d8bb33535c1",
                            Status = 1
                        },
                        new
                        {
                            Id = 2L,
                            Password = "y2EOamUBVjnb1XIERBJz/fe17z7igtjh8Y3VmOP6wZrRXxkpp2AHNj7921qxZYUMJRWQHC/XXzl0vtiTLPiCfKAOYmh+rUxfnj1R1SyXBxpl2tu4auUC659y+jlGq/H1/T6swrDGJ/ZZblBiZM6nrfvTexNGK1NWB57hPgtskCeFSz38iPyaBfOwmnSJsvqHCgKdAU423Q5eKXk24FuZUIrfAXJbdF8hvMOVvko6VPJv/xGfOWOL1l4s8SchgA9rgRG2+S8M3UNpR/T/K/4b0/TOJbGSu0fIX8wS76XXrtZZUBW8NjpQPLMCpI/tUpabUxPtHVVxrXEsppJCFVt0EaHBymuyWpLTrErTZTdcpjedNti7+CQ19UR2tGI9QbdLjEOyW5TKI2w6tJrqztc9hQ7VGmTjwp9RXXfLTBRnkdYwZooBVeKqSdFYpXESS4XxWrFBqLZF2WneO3bc2vJm0DnxlKOI5DtwBNcjR8qSmR3bGm3vLDBAQvrUiZsu7BOiH9snrVlh4xrHlO0syCldQUJKbDyxqOujaSR3N3WhCqByghjBf9qmRQyUopNx9WOun8jsHE6WqcVC5G3+8xbFwlGO7Ku03mdCkYlkV79n6dF7bxpZExe9beT9M6lzn77tt6T/exuwUGZcCCuY79QREOBoWDcgoVI0wHUm+0YqVSg=",
                            Roles = 1,
                            Salt = "1f414507-de3c-4835-9844-11de08995d7f",
                            Status = 1
                        });
                });

            modelBuilder.Entity("FoodInLoco.Application.Data.Entities.Menu", b =>
                {
                    b.HasOne("FoodInLoco.Application.Data.Entities.Restaurant", "Restaurant")
                        .WithMany("Menus")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("FoodInLoco.Application.Data.ValueObjects.NameDescription", "NameDescription", b1 =>
                        {
                            b1.Property<long>("MenuId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Description")
                                .IsRequired()
                                .HasMaxLength(300)
                                .HasColumnType("character varying(300)")
                                .HasColumnName("Description");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("Name");

                            b1.HasKey("MenuId");

                            b1.ToTable("Menu", "Menu");

                            b1.WithOwner()
                                .HasForeignKey("MenuId");

                            b1.HasData(
                                new
                                {
                                    MenuId = 1L,
                                    Description = "Cardápio de vinhos.",
                                    Name = "Wine"
                                });
                        });

                    b.OwnsOne("FoodInLoco.Application.Data.ValueObjects.HappyHour", "HappyHour", b1 =>
                        {
                            b1.Property<long>("MenuId")
                                .HasColumnType("bigint");

                            b1.Property<int?>("EndAt")
                                .HasColumnType("integer")
                                .HasColumnName("EndAt");

                            b1.Property<int?>("StartAt")
                                .HasColumnType("integer")
                                .HasColumnName("StartAt");

                            b1.Property<bool>("Value")
                                .HasColumnType("boolean")
                                .HasColumnName("HappyHour");

                            b1.HasKey("MenuId");

                            b1.ToTable("Menu", "Menu");

                            b1.WithOwner()
                                .HasForeignKey("MenuId");

                            b1.HasData(
                                new
                                {
                                    MenuId = 1L,
                                    Value = false
                                });
                        });

                    b.Navigation("HappyHour")
                        .IsRequired();

                    b.Navigation("NameDescription")
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("FoodInLoco.Application.Data.Entities.MenuItem", b =>
                {
                    b.HasOne("FoodInLoco.Application.Data.Entities.Menu", "Menu")
                        .WithMany("Items")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("FoodInLoco.Application.Data.ValueObjects.NameDescription", "NameDescription", b1 =>
                        {
                            b1.Property<long>("MenuItemId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Description")
                                .IsRequired()
                                .HasMaxLength(300)
                                .HasColumnType("character varying(300)")
                                .HasColumnName("Description");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("Name");

                            b1.HasKey("MenuItemId");

                            b1.ToTable("MenuItem", "MenuItem");

                            b1.WithOwner()
                                .HasForeignKey("MenuItemId");

                            b1.HasData(
                                new
                                {
                                    MenuItemId = 1L,
                                    Description = "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.",
                                    Name = "Hamburguer"
                                });
                        });

                    b.Navigation("Menu");

                    b.Navigation("NameDescription")
                        .IsRequired();
                });

            modelBuilder.Entity("FoodInLoco.Application.Data.Entities.Restaurant", b =>
                {
                    b.OwnsOne("FoodInLoco.Application.Data.ValueObjects.Phone", "CellPhone", b1 =>
                        {
                            b1.Property<long>("RestaurantId")
                                .HasColumnType("bigint");

                            b1.Property<string>("DDD")
                                .IsRequired()
                                .HasMaxLength(2)
                                .HasColumnType("character varying(2)")
                                .HasColumnName("DDD");

                            b1.Property<string>("PhoneNumber")
                                .IsRequired()
                                .HasMaxLength(9)
                                .HasColumnType("character varying(9)")
                                .HasColumnName("PhoneNumber");

                            b1.HasKey("RestaurantId");

                            b1.ToTable("Restaurant", "Restaurant");

                            b1.WithOwner()
                                .HasForeignKey("RestaurantId");

                            b1.HasData(
                                new
                                {
                                    RestaurantId = 1L,
                                    DDD = "85",
                                    PhoneNumber = "998888888"
                                });
                        });

                    b.OwnsOne("FoodInLoco.Application.Data.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<long>("RestaurantId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(300)
                                .HasColumnType("character varying(300)")
                                .HasColumnName("Email");

                            b1.HasKey("RestaurantId");

                            b1.HasIndex("Value")
                                .IsUnique();

                            b1.ToTable("Restaurant", "Restaurant");

                            b1.WithOwner()
                                .HasForeignKey("RestaurantId");

                            b1.HasData(
                                new
                                {
                                    RestaurantId = 1L,
                                    Value = "mcdonalds@foodinloco.com"
                                });
                        });

                    b.OwnsOne("FoodInLoco.Application.Data.ValueObjects.Address", "Address", b1 =>
                        {
                            b1.Property<long>("RestaurantId")
                                .HasColumnType("bigint");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(150)
                                .HasColumnType("character varying(150)")
                                .HasColumnName("City");

                            b1.Property<string>("Complement")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("character varying(200)")
                                .HasColumnName("Complement");

                            b1.Property<long>("Number")
                                .HasColumnType("bigint")
                                .HasColumnName("Number");

                            b1.Property<string>("State")
                                .IsRequired()
                                .HasMaxLength(150)
                                .HasColumnType("character varying(150)")
                                .HasColumnName("State");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("character varying(200)")
                                .HasColumnName("Street");

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("character varying(20)")
                                .HasColumnName("ZipCode");

                            b1.HasKey("RestaurantId");

                            b1.ToTable("Restaurant", "Restaurant");

                            b1.WithOwner()
                                .HasForeignKey("RestaurantId");

                            b1.HasData(
                                new
                                {
                                    RestaurantId = 1L,
                                    City = "Fortaleza",
                                    Complement = "Apto 004, Bloco D",
                                    Number = 150L,
                                    State = "Ceará",
                                    Street = "Travessa Elisiário Mendes",
                                    ZipCode = "60841477"
                                });
                        });

                    b.OwnsOne("FoodInLoco.Application.Data.ValueObjects.Company", "Company", b1 =>
                        {
                            b1.Property<long>("RestaurantId")
                                .HasColumnType("bigint");

                            b1.Property<string>("CompanyName")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("character varying(200)")
                                .HasColumnName("CompanyName");

                            b1.Property<string>("TradingName")
                                .IsRequired()
                                .HasMaxLength(300)
                                .HasColumnType("character varying(300)")
                                .HasColumnName("TradingName");

                            b1.HasKey("RestaurantId");

                            b1.ToTable("Restaurant", "Restaurant");

                            b1.WithOwner()
                                .HasForeignKey("RestaurantId");

                            b1.HasData(
                                new
                                {
                                    RestaurantId = 1L,
                                    CompanyName = "Mc Donalds",
                                    TradingName = "Méqui"
                                });
                        });

                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("CellPhone")
                        .IsRequired();

                    b.Navigation("Company")
                        .IsRequired();

                    b.Navigation("Email")
                        .IsRequired();
                });

            modelBuilder.Entity("FoodInLoco.Application.Data.Entities.User", b =>
                {
                    b.OwnsOne("FoodInLoco.Application.Data.ValueObjects.Phone", "CellPhone", b1 =>
                        {
                            b1.Property<long>("UserId")
                                .HasColumnType("bigint");

                            b1.Property<string>("DDD")
                                .IsRequired()
                                .HasMaxLength(2)
                                .HasColumnType("character varying(2)")
                                .HasColumnName("DDD");

                            b1.Property<string>("PhoneNumber")
                                .IsRequired()
                                .HasMaxLength(9)
                                .HasColumnType("character varying(9)")
                                .HasColumnName("PhoneNumber");

                            b1.HasKey("UserId");

                            b1.ToTable("User", "User");

                            b1.WithOwner()
                                .HasForeignKey("UserId");

                            b1.HasData(
                                new
                                {
                                    UserId = 1L,
                                    DDD = "85",
                                    PhoneNumber = "997851936"
                                },
                                new
                                {
                                    UserId = 2L,
                                    DDD = "85",
                                    PhoneNumber = "999999999"
                                });
                        });

                    b.OwnsOne("FoodInLoco.Application.Data.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<long>("UserId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(300)
                                .HasColumnType("character varying(300)")
                                .HasColumnName("Email");

                            b1.HasKey("UserId");

                            b1.HasIndex("Value")
                                .IsUnique();

                            b1.ToTable("User", "User");

                            b1.WithOwner()
                                .HasForeignKey("UserId");

                            b1.HasData(
                                new
                                {
                                    UserId = 1L,
                                    Value = "admin@foodinloco.com"
                                },
                                new
                                {
                                    UserId = 2L,
                                    Value = "letter.pedro@gmail.com"
                                });
                        });

                    b.OwnsOne("FoodInLoco.Application.Data.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<long>("UserId")
                                .HasColumnType("bigint");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("character varying(200)")
                                .HasColumnName("LastName");

                            b1.HasKey("UserId");

                            b1.ToTable("User", "User");

                            b1.WithOwner()
                                .HasForeignKey("UserId");

                            b1.HasData(
                                new
                                {
                                    UserId = 1L,
                                    FirstName = "Pedro",
                                    LastName = "Oliveira"
                                },
                                new
                                {
                                    UserId = 2L,
                                    FirstName = "Pedro",
                                    LastName = "Lopes"
                                });
                        });

                    b.Navigation("CellPhone")
                        .IsRequired();

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("Name")
                        .IsRequired();
                });

            modelBuilder.Entity("FoodInLoco.Application.Data.Entities.Menu", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("FoodInLoco.Application.Data.Entities.Restaurant", b =>
                {
                    b.Navigation("Menus");
                });
#pragma warning restore 612, 618
        }
    }
}
