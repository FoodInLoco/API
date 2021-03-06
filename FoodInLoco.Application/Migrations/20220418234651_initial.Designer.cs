// <auto-generated />
using FoodInLoco.Application.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220418234651_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FoodInLoco.Application.Data.Entities.Auth", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

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

                    b.HasKey("Id");

                    b.HasIndex("Login")
                        .IsUnique();

                    b.ToTable("Auth", "Auth");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Login = "admin",
                            Password = "Ywh5sxyZwNhv41ttnYPNGbYtpxYY2qZa7d4sABOvHyPjmlWSQ9394NXIYLrDcoQT4qOP/+IAU1xXtRk6FRX4T2vnTyqt7Z4cPvSaeRwV6+U0D5QYsJQhoyq/MWwrheazdEkqA9u7HpEdgQZ4iiSDFRd3Q2ePoZQ1eJzDZ8FCAiURB6EbfH7sWhga+vF+ipx1ifkLQHWZ+AO9nnUJw9qIANe6opS3U8MHT7SQUteXTNDUAmPNK+MidmqBTnmnFs+gjeqOyX4hCuFjLy8hRhu/GdFJFDUKWgO+49/x9JinhRZkNRv6kgQdDjtfcfzrY1N73oc/f0kOQ0NijDHzaIDvye2JLp6O68nZjOVYRQ5U9lIuwQoaPpD3b+bePnx8jJ/dBRqeQQzn3xRyk+1R4SHiykAVZcOMRuG5DOLaF/bUC3ECu5QPUGFQSDy8qChOdFoRQSEJpMZ06EUFqpw5CZyFm5kubbejlew1tdRIIdgL/F5HXFRKXd9+ysxyVT1ktnjHljLBBZaFqK6vM/LlY0vLtZGLBCETthoiubErDUN4CJX+sUGIfnNtKCGBvo0SQ6N09OFym9MCQOsITX64GKx+uNQJ9/nNWaKozK4J/TetBPdXpM3ZL5zFWOPUY+s3RIg/zrwkxQx/tarTUwTKxJi3RQkUrHFDDxKhf1BHT03Ilho=",
                            Roles = 3,
                            Salt = "79005744-e69a-4b09-996b-08fe0b70cbb9"
                        });
                });

            modelBuilder.Entity("FoodInLoco.Application.Data.Entities.Restaurant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AuthId")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AuthId")
                        .IsUnique();

                    b.ToTable("Restaurant", "Restaurant");
                });

            modelBuilder.Entity("FoodInLoco.Application.Data.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AuthId")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AuthId")
                        .IsUnique();

                    b.ToTable("User", "User");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AuthId = 1L,
                            Status = 1
                        });
                });

            modelBuilder.Entity("FoodInLoco.Application.Data.Entities.Restaurant", b =>
                {
                    b.HasOne("FoodInLoco.Application.Data.Entities.Auth", "Auth")
                        .WithOne()
                        .HasForeignKey("FoodInLoco.Application.Data.Entities.Restaurant", "AuthId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                        });

                    b.Navigation("Auth");

                    b.Navigation("CellPhone")
                        .IsRequired();

                    b.Navigation("Company")
                        .IsRequired();

                    b.Navigation("Email")
                        .IsRequired();
                });

            modelBuilder.Entity("FoodInLoco.Application.Data.Entities.User", b =>
                {
                    b.HasOne("FoodInLoco.Application.Data.Entities.Auth", "Auth")
                        .WithOne()
                        .HasForeignKey("FoodInLoco.Application.Data.Entities.User", "AuthId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                                });
                        });

                    b.Navigation("Auth");

                    b.Navigation("CellPhone")
                        .IsRequired();

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("Name")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
