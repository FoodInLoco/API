using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Enums;
using FoodInLoco.Application.Data.ValueObjects;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record AttractionModel
    {
        public long Id { get; init; }

        public long RestaurantId { get; init; }

        public string Name { get; init; }

        public string Description { get; init; }

        public string Photo { get; init; }

        public DateTime Date { get; init; }

        public decimal CoverTax { get; init; }

        public Status Status { get; init; }
    }
}
