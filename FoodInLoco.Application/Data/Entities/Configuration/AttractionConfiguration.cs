using FoodInLoco.Application.Data.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodInLoco.Application.Data.Entities.Configuration;

public sealed class AttractionConfiguration : IEntityTypeConfiguration<Attraction>
{
    public void Configure(EntityTypeBuilder<Attraction> builder)
    {
        builder.ToTable(nameof(Attraction), nameof(Attraction));

        builder.HasKey(obj => obj.Id);

        builder.Property(obj => obj.Id).ValueGeneratedOnAdd().IsRequired();

        builder.Property(obj => obj.IdGuid).ValueGeneratedOnAdd().IsRequired();

        builder.Property(obj => obj.Date).IsRequired();

        builder.Property(obj => obj.Status).IsRequired();

        builder.Property(obj => obj.Photo).HasMaxLength(1000);

        builder.Property(obj => obj.CoverTax).IsRequired();

        builder.OwnsOne(obj => obj.NameDescription, obj =>
        {
            obj.Property(nameDescription => nameDescription.Name).HasColumnName(nameof(NameDescription.Name)).HasMaxLength(100).IsRequired();

            obj.Property(nameDescription => nameDescription.Description).HasColumnName(nameof(NameDescription.Description)).HasMaxLength(300);
        });

        builder.HasIndex("RestaurantId").IsUnique(); //TODO: verificar se será isso mesmo
    }
}
