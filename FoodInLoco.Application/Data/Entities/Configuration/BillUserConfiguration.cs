using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodInLoco.Application.Data.Entities.Configuration;

public sealed class BillUserConfiguration : IEntityTypeConfiguration<BillUser>
{
    public void Configure(EntityTypeBuilder<BillUser> builder)
    {
        builder.ToTable(nameof(BillUser), nameof(BillUser));

        builder.HasKey(obj => obj.BillId);

        builder.HasKey(obj => obj.UserId);

        builder.Property(obj => obj.BillId).IsRequired();

        builder.Property(obj => obj.UserId).IsRequired();

        builder.HasIndex("BillId");

        builder.HasIndex("UserId");
    }
}
