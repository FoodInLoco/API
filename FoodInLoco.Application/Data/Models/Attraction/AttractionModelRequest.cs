using FoodInLoco.Application.Converters;
using FoodInLoco.Application.Enums;
using System.Text.Json.Serialization;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record AttractionModelRequest
    {
        public Guid Id { get; init; }

        public Guid RestaurantId { get; init; }

        public string Name { get; init; }

        public string Description { get; init; }

        public string? Photo { get; init; }

        public DateTime Date { get; init; }

        public double? CoverTax { get; init; }
    }
}
