using FoodInLoco.Application.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodInLoco.Application.Data.Entities.Configuration;

public sealed class BillConfiguration : IEntityTypeConfiguration<Bill>
{
    public void Configure(EntityTypeBuilder<Bill> builder)
    {
        builder.ToTable(nameof(Bill), nameof(Bill));

        builder.HasKey(obj => obj.Id);

        builder.Property(obj => obj.Id).HasDefaultValueSql("uuid_generate_v4()").IsRequired();

        builder.Property(obj => obj.CreatedAt).HasDefaultValueSql("now()").IsRequired();

        builder.Property(obj => obj.LastUpdatedAt).IsRequired(false);

        builder.Property(obj => obj.Status).HasDefaultValue(Status.Active).IsRequired();

        builder.Property(obj => obj.BillingStatus).HasDefaultValue(BillingStatus.Pending).IsRequired();

        builder.HasMany(obj => obj.BillUsers).WithOne(obj => obj.Bill).HasForeignKey("BillId");

        builder.HasMany(obj => obj.Orders).WithOne(obj => obj.Bill).HasForeignKey("BillId");

        builder.HasIndex("TableId");
    }
}
