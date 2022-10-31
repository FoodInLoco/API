using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Enums;
using FoodInLoco.Application.Data.ValueObjects;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record MenuItemModel
    {
        public long Id { get; init; }

        public long MenuId { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public string Photo { get; private set; }

        public int Quantity { get; private set; }

        public double Value { get; private set; }

        public Status Status { get; private set; }
    }
}
