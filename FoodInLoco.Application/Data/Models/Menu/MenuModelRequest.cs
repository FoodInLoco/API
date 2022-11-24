using FoodInLoco.Application.Converters;
using FoodInLoco.Application.Enums;
using System.Text.Json.Serialization;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record MenuModelRequest
    {
        public Guid Id { get; init; }

        public Guid RestaurantId { get; init; }

        public string Name { get; init; }

        public string Description { get; init; }

        public string? Photo { get; init; }

        public DateTime InitialDate { get; init; }

        public DateTime? ExpirationDate { get; init; }

        public bool HappyHour { get; init; }

        public string? StartAt { get; init; }

        public string? EndAt { get; init; }
    }
}
