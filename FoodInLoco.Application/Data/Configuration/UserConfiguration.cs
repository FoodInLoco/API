using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodInLoco.Application.Data.Configuration;

public sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable(nameof(User), nameof(User));

        builder.HasKey(user => user.Id);

        builder.Property(user => user.Id).ValueGeneratedOnAdd().IsRequired();

        builder.Property(user => user.Status).IsRequired();

        builder.OwnsOne(user => user.Name, userName =>
        {
            userName.Property(name => name.FirstName).HasColumnName(nameof(Name.FirstName)).HasMaxLength(100).IsRequired();

            userName.Property(name => name.LastName).HasColumnName(nameof(Name.LastName)).HasMaxLength(200).IsRequired();
        });

        builder.OwnsOne(user => user.Email, userEmail =>
        {
            userEmail.Property(email => email.Value).HasColumnName(nameof(Email)).HasMaxLength(300).IsRequired();

            userEmail.HasIndex(email => email.Value).IsUnique();
        });

        builder.OwnsOne(user => user.CellPhone, userPhone =>
        {
            userPhone.Property(phone => phone.DDD).HasColumnName(nameof(Phone.DDD)).HasMaxLength(2).IsRequired();

            userPhone.Property(phone => phone.PhoneNumber).HasColumnName(nameof(Phone.PhoneNumber)).HasMaxLength(9).IsRequired();
        });

        builder.HasOne(user => user.Auth).WithOne().HasForeignKey<User>("AuthId").IsRequired();

        builder.HasIndex("AuthId").IsUnique();
    }
}
