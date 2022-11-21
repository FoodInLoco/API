using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodInLoco.Application.Data.Entities.Configuration;

public sealed class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.ToTable(nameof(Review), nameof(Review));

        builder.HasKey(obj => obj.Id);

        builder.Property(obj => obj.Id).ValueGeneratedOnAdd().IsRequired();

        builder.Property(obj => obj.CreatedAt).ValueGeneratedOnAdd().HasDefaultValueSql("GETUTCDATE()").IsRequired();

        builder.Property(obj => obj.LastUpdatedAt).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("GETUTCDATE()");

        builder.Property(obj => obj.Rate).IsRequired();

        builder.Property(obj => obj.Status).HasDefaultValue(Status.Active).IsRequired();

        builder.OwnsOne(obj => obj.NameDescription, obj =>
        {
            obj.Property(nameDescription => nameDescription.Name).HasColumnName(nameof(NameDescription.Name)).HasMaxLength(100).IsRequired();

            obj.Property(nameDescription => nameDescription.Description).HasColumnName(nameof(NameDescription.Description)).HasMaxLength(300);
        });

        builder.HasIndex("RestaurantId");

        builder.HasIndex("ReservationId").IsUnique();
    }
}
