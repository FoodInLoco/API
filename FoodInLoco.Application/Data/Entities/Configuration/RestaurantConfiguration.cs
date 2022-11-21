using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodInLoco.Application.Data.Entities.Configuration;

public sealed class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
{
    public void Configure(EntityTypeBuilder<Restaurant> builder)
    {
        builder.ToTable(nameof(Restaurant), nameof(Restaurant));

        builder.HasKey(obj => obj.Id);

        builder.Property(obj => obj.Id).ValueGeneratedOnAdd().IsRequired();

        builder.Property(obj => obj.InsertDate).ValueGeneratedOnAdd().IsRequired();

        builder.Property(obj => obj.UpdateDate).ValueGeneratedOnAddOrUpdate();

        builder.Property(obj => obj.Status).HasDefaultValue(Status.Active).IsRequired();

        builder.Property(obj => obj.Photo).HasMaxLength(10000).HasDefaultValue("https://img.freepik.com/free-vector/restaurant-logo_23-2147506959.jpg?w=826&t=st=1668952356~exp=1668952956~hmac=49402768c6b8d28e62ceaf62db752e285911d5b9ec57bb827b2118d98f046d74").IsRequired(false);

        builder.Property(obj => obj.Kids).IsRequired();

        builder.OwnsOne(obj => obj.Company, companyName =>
        {
            companyName.Property(name => name.CompanyName).HasColumnName(nameof(Company.CompanyName)).HasMaxLength(200).IsRequired();

            companyName.Property(name => name.TradingName).HasColumnName(nameof(Company.TradingName)).HasMaxLength(300).IsRequired();
        });

        builder.OwnsOne(obj => obj.Email, objEmail =>
        {
            objEmail.Property(email => email.Value).HasColumnName(nameof(Email)).HasMaxLength(300).IsRequired();

            objEmail.HasIndex(email => email.Value).IsUnique();
        });

        builder.OwnsOne(obj => obj.CellPhone, objPhone =>
        {
            objPhone.Property(phone => phone.DDD).HasColumnName(nameof(Phone.DDD)).HasMaxLength(2).IsRequired();

            objPhone.Property(phone => phone.PhoneNumber).HasColumnName(nameof(Phone.PhoneNumber)).HasMaxLength(9).IsRequired();
        });

        builder.OwnsOne(obj => obj.Address, objAddress =>
        {
            objAddress.Property(address => address.State).HasColumnName(nameof(Address.State)).HasMaxLength(150).IsRequired();

            objAddress.Property(address => address.City).HasColumnName(nameof(Address.City)).HasMaxLength(150).IsRequired();

            objAddress.Property(address => address.ZipCode).HasColumnName(nameof(Address.ZipCode)).HasMaxLength(20).IsRequired();

            objAddress.Property(address => address.Street).HasColumnName(nameof(Address.Street)).HasMaxLength(200).IsRequired();

            objAddress.Property(address => address.Number).HasColumnName(nameof(Address.Number)).IsRequired();

            objAddress.Property(address => address.Complement).HasColumnName(nameof(Address.Complement)).HasMaxLength(200);
        });

        builder.HasMany(obj => obj.Menus).WithOne(obj => obj.Restaurant).HasForeignKey("RestaurantId");
    }
}
