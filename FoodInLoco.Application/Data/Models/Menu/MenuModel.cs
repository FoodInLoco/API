using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record MenuModel
    {
        public Guid Id { get; init; }

        public DateTime InsertDate { get; init; }

        public DateTime? UpdateDate { get; init; }

        public long RestaurantId { get; init; }

        public string Name { get; init; }

        public string Description { get; init; }

        public string Photo { get; init; }

        public DateTime InitialDate { get; init; }

        public DateTime? ExpirationDate { get; init; }

        public bool HappyHour { get; init; }

        public string? StartAt { get; init; }

        public string? EndAt { get; init; }

        public Status Status { get; init; }
    }
}
