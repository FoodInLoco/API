using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodInLoco.Application.Data.Entities.Configuration;

public sealed class AuthConfiguration : IEntityTypeConfiguration<Auth>
{
    public void Configure(EntityTypeBuilder<Auth> builder)
    {
        builder.ToTable(nameof(Auth), nameof(Auth));

        builder.HasKey(obj => obj.Id);

        builder.HasIndex(obj => obj.Login).IsUnique();

        builder.Property(obj => obj.Id).ValueGeneratedOnAdd().IsRequired();

        builder.Property(obj => obj.Login).HasMaxLength(100).IsRequired();

        builder.Property(obj => obj.Password).HasMaxLength(1000).IsRequired();

        builder.Property(obj => obj.Salt).HasMaxLength(1000).IsRequired();

        builder.Property(obj => obj.Roles).IsRequired();
    }
}
