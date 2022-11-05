using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Enums;
using FoodInLoco.Application.Data.ValueObjects;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record MenuModel
    {
        public long Id { get; init; }

        public long RestaurantId { get; init; }

        public string Name { get; init; }

        public string Description { get; init; }

        public string Photo { get; init; }

        public DateTime InitialDate { get; init; }

        public DateTime? ExpirationDate { get; init; }

        public bool HappyHour { get; init; }

        public int? StartAt { get; init; }

        public int? EndAt { get; init; }

        public Status Status { get; init; }
    }
}
