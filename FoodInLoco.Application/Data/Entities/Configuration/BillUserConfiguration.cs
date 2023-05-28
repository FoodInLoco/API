using FoodInLoco.Application.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace FoodInLoco.Application.Data.Entities.Configuration;

public sealed class BillUserConfiguration : IEntityTypeConfiguration<BillUser>
{
    public void Configure(EntityTypeBuilder<BillUser> builder)
    {
        builder.ToTable(nameof(BillUser), nameof(BillUser));

        builder.HasKey(obj => new { obj.BillId, obj.UserId });

        builder.Property(obj => obj.BillId).IsRequired();

        builder.Property(obj => obj.UserId).IsRequired();

        builder.Property(obj => obj.Status).HasDefaultValue(Status.None).IsRequired();

        builder.HasIndex("BillId");

        builder.HasIndex("UserId");
    }
}
