using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record MenuModelResponse
    {
        public Guid Id { get; init; }

        public DateTime CreatedAt { get; init; }

        public DateTime? LastUpdatedAt { get; init; }

        public Guid RestaurantId { get; init; }

        public string? RestaurantName { get; init; }

        public string Name { get; init; }

        public string Description { get; init; }

        public string? Photo { get; init; }

        public DateTime InitialDate { get; init; }

        public DateTime? ExpirationDate { get; init; }

        public bool HappyHour { get; init; }

        public string? StartAt { get; init; }

        public string? EndAt { get; init; }

        public Status Status { get; init; }

        public List<MenuItemModelResponse>? Items { get; init; }
    }
}
