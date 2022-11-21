using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record MenuModel
    {
        public Guid Id { get; init; }

        public DateOnly CreatedAt { get; init; }

        public DateOnly? LastUpdatedAt { get; init; }

        public Guid RestaurantId { get; init; }

        public string Name { get; init; }

        public string Description { get; init; }

        public string Photo { get; init; }

        public DateOnly InitialDate { get; init; }

        public DateOnly? ExpirationDate { get; init; }

        public bool HappyHour { get; init; }

        public TimeOnly? StartAt { get; init; }

        public TimeOnly? EndAt { get; init; }

        public Status Status { get; init; }
    }
}
