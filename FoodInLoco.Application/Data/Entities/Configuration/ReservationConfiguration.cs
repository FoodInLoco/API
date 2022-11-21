using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodInLoco.Application.Data.Entities.Configuration;

public sealed class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        builder.ToTable(nameof(Reservation), nameof(Reservation));

        builder.HasKey(obj => obj.Id);

        builder.Property(obj => obj.Id).HasDefaultValueSql("NEWID()").IsRequired();

        builder.Property(obj => obj.CreatedAt).HasDefaultValueSql("GETUTCDATE()").IsRequired();

        builder.Property(obj => obj.LastUpdatedAt).IsRequired(false);

        builder.Property(obj => obj.Description).HasMaxLength(300).IsRequired();

        builder.Property(obj => obj.SeatQuantity).IsRequired();

        builder.Property(obj => obj.Date).IsRequired();

        builder.Property(obj => obj.Status).HasDefaultValue(Status.Active).IsRequired();

        builder.Property(obj => obj.Confirmation).HasDefaultValue(Status.None).IsRequired();

        builder.HasIndex("RestaurantId");

        builder.HasIndex("UserId");
    }
}
