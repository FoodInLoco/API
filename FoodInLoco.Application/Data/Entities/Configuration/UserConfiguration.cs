using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodInLoco.Application.Data.Entities.Configuration;

public sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable(nameof(User), nameof(User));

        builder.HasKey(obj => obj.Id);

        builder.Property(obj => obj.Id).ValueGeneratedOnAdd().IsRequired();

        builder.Property(obj => obj.InsertDate).ValueGeneratedOnAdd().IsRequired();

        builder.Property(obj => obj.UpdateDate).ValueGeneratedOnUpdate();

        builder.Property(obj => obj.Status).HasDefaultValue(Status.Active).IsRequired();

        builder.Property(obj => obj.Photo).HasMaxLength(10000);

        builder.Property(obj => obj.Password).HasMaxLength(1000).IsRequired();

        builder.Property(obj => obj.Salt).HasMaxLength(1000).IsRequired();

        builder.Property(obj => obj.Roles).IsRequired();

        builder.OwnsOne(obj => obj.Name, objName =>
        {
            objName.Property(name => name.FirstName).HasColumnName(nameof(Name.FirstName)).HasMaxLength(100).IsRequired();

            objName.Property(name => name.LastName).HasColumnName(nameof(Name.LastName)).HasMaxLength(200).IsRequired();
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
    }
}
