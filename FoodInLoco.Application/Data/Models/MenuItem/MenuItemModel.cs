using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Enums;
using FoodInLoco.Application.Data.ValueObjects;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record MenuItemModel
    {
        public long Id { get; init; }

        public long MenuId { get; init; }

        public string Name { get; init; }

        public string Description { get; init; }

        public string Photo { get; init; }

        public int Quantity { get; init; }

        public double Value { get; init; }

        public Status Status { get; init; }
    }
}
