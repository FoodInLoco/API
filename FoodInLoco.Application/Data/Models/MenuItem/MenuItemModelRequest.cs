using FoodInLoco.Application.Converters;
using FoodInLoco.Application.Enums;
using System.Text.Json.Serialization;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record MenuItemModelRequest
    {
        public Guid Id { get; init; }

        public Guid MenuId { get; init; }

        public string Name { get; init; }

        public string Description { get; init; }

        public string? Photo { get; init; }

        public int Quantity { get; init; }

        public double Value { get; init; }
    }
}
