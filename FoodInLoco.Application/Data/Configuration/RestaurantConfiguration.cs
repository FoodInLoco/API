using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodInLoco.Application.Data.Configuration;

public sealed class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
{
    public void Configure(EntityTypeBuilder<Restaurant> builder)
    {
        builder.ToTable(nameof(Restaurant), nameof(Restaurant));

        builder.HasKey(restaurant => restaurant.Id);

        builder.Property(restaurant => restaurant.Id).ValueGeneratedOnAdd().IsRequired();

        builder.Property(restaurant => restaurant.Status).IsRequired();

        builder.OwnsOne(restaurant => restaurant.Company, companyName =>
        {
            companyName.Property(name => name.CompanyName).HasColumnName(nameof(Company.CompanyName)).HasMaxLength(200).IsRequired();

            companyName.Property(name => name.TradingName).HasColumnName(nameof(Company.TradingName)).HasMaxLength(300).IsRequired();
        });

        builder.OwnsOne(restaurant => restaurant.Email, restaurantEmail =>
        {
            restaurantEmail.Property(email => email.Value).HasColumnName(nameof(Email)).HasMaxLength(300).IsRequired();

            restaurantEmail.HasIndex(email => email.Value).IsUnique();
        });

        builder.OwnsOne(restaurant => restaurant.CellPhone, restaurantPhone =>
        {
            restaurantPhone.Property(phone => phone.DDD).HasColumnName(nameof(Phone.DDD)).HasMaxLength(2).IsRequired();

            restaurantPhone.Property(phone => phone.PhoneNumber).HasColumnName(nameof(Phone.PhoneNumber)).HasMaxLength(9).IsRequired();
        });

        builder.HasOne(restaurant => restaurant.Auth).WithOne().HasForeignKey<Restaurant>("AuthId").IsRequired();

        builder.HasIndex("AuthId").IsUnique();
    }
}
