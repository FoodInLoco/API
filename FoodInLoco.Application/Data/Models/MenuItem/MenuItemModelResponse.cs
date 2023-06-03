using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record MenuItemModelResponse
    {
        public Guid Id { get; init; }

        public DateTime CreatedAt { get; init; }

        public DateTime? LastUpdatedAt { get; init; }

        public Guid MenuId { get; init; }

        public string? MenuName { get; set; }

        public string Name { get; init; }

        public string Description { get; init; }

        public string? Photo { get; init; }

        public int Quantity { get; init; }

        public double Value { get; init; }

        public Status Status { get; init; }
    }
}
