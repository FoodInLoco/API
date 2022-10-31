using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Enums;
using FoodInLoco.Application.Data.ValueObjects;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record MenuModel
    {
        public long Id { get; init; }

        public long RestaurantId { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public DateTime InitialDate { get; private set; }

        public DateTime? ExpirationDate { get; private set; }

        public bool HappyHour { get; private set; }

        public int? StartAt { get; private set; }

        public int? EndAt { get; private set; }
    }
}
