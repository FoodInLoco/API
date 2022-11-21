using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record AttractionModel
    {
        public Guid Id { get; init; }

        public DateOnly CreatedAt { get; init; }

        public DateOnly? LastUpdatedAt { get; init; }

        public Guid RestaurantId { get; init; }

        public string Name { get; init; }

        public string Description { get; init; }

        public string Photo { get; init; }

        public DateOnly Date { get; init; }

        public TimeOnly Time { get; init; }

        public decimal CoverTax { get; init; }

        public Status Status { get; init; }
    }
}
