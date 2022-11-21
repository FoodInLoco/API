using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodInLoco.Application.Data.Entities.Configuration;

public sealed class MenuConfiguration : IEntityTypeConfiguration<Menu>
{
    public void Configure(EntityTypeBuilder<Menu> builder)
    {
        builder.ToTable(nameof(Menu), nameof(Menu));

        builder.HasKey(obj => obj.Id);

        builder.Property(obj => obj.Id).ValueGeneratedOnAdd().IsRequired();

        builder.Property(obj => obj.InsertDate).ValueGeneratedOnAdd().IsRequired();

        builder.Property(obj => obj.UpdateDate).ValueGeneratedOnAddOrUpdate();

        builder.Property(obj => obj.InitialDate).HasDefaultValue(DateTime.UtcNow).IsRequired();

        builder.Property(obj => obj.ExpirationDate);

        builder.Property(obj => obj.Photo).HasMaxLength(10000).HasDefaultValue("https://menubrands.com.br/wp-content/uploads/2020/04/Menu-300x300.png").IsRequired(false);

        builder.Property(obj => obj.Status).HasDefaultValue(Status.Active).IsRequired();

        builder.OwnsOne(obj => obj.NameDescription, obj =>
        {
            obj.Property(nameDescription => nameDescription.Name).HasColumnName(nameof(NameDescription.Name)).HasMaxLength(100).IsRequired();

            obj.Property(nameDescription => nameDescription.Description).HasColumnName(nameof(NameDescription.Description)).HasMaxLength(300);
        });

        builder.OwnsOne(obj => obj.HappyHour, obj =>
        {
            obj.Property(hh => hh.Value).HasColumnName(nameof(HappyHour)).IsRequired();

            obj.Property(hh => hh.StartAt).HasColumnName(nameof(HappyHour.StartAt));

            obj.Property(hh => hh.EndAt).HasColumnName(nameof(HappyHour.EndAt));
        });

        builder.HasMany(obj => obj.Items).WithOne(obj => obj.Menu).HasForeignKey("MenuId");

        builder.HasIndex("RestaurantId");
    }
}
