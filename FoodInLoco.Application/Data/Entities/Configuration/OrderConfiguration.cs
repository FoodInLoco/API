using FoodInLoco.Application.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodInLoco.Application.Data.Entities.Configuration;

public sealed class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable(nameof(Order), nameof(Order));

        builder.HasKey(obj => obj.Id);

        builder.Property(obj => obj.Id).HasDefaultValueSql("uuid_generate_v4()").IsRequired();

        builder.Property(obj => obj.CreatedAt).HasDefaultValueSql("now()").IsRequired();

        builder.Property(obj => obj.LastUpdatedAt).IsRequired(false);

        builder.Property(obj => obj.Status).HasDefaultValue(Status.Active).IsRequired();

        builder.Property(obj => obj.Quantity).IsRequired();

        builder.Property(obj => obj.Message).HasMaxLength(500).IsRequired(false);

        builder.HasIndex("BillId");

        builder.HasIndex("UserId");

        builder.HasIndex("ItemId");
    }
}
