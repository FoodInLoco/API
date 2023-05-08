using FoodInLoco.Application.Converters;
using FoodInLoco.Application.Enums;
using System.Text.Json.Serialization;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record TableModelRequest
    {
        public Guid Id { get; init; }

        public Guid RestaurantId { get; init; }

        public int Number { get; init; }
    }
}
