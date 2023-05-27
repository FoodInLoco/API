using FoodInLoco.Application.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodInLoco.Application.Data.Entities.Configuration;

public sealed class TableConfiguration : IEntityTypeConfiguration<Table>
{
    public void Configure(EntityTypeBuilder<Table> builder)
    {
        builder.ToTable(nameof(Table), nameof(Table));

        builder.HasKey(obj => obj.Id);

        builder.Property(obj => obj.Id).HasDefaultValueSql("uuid_generate_v4()").IsRequired();

        builder.Property(obj => obj.CreatedAt).HasDefaultValueSql("now()").IsRequired();

        builder.Property(obj => obj.LastUpdatedAt).IsRequired(false);

        builder.Property(obj => obj.Status).HasDefaultValue(Status.Active).IsRequired();

        builder.Property(obj => obj.Number).IsRequired();

        builder.HasMany(obj => obj.Bills).WithOne(obj => obj.Table).HasForeignKey("TableId");

        builder.HasIndex("RestaurantId");
    }
}
