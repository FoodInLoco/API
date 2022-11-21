using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record AttractionModel
    {
        public Guid Id { get; init; }

        public DateTime InsertDate { get; init; }

        public DateTime? UpdateDate { get; init; }

        public Guid RestaurantId { get; init; }

        public string Name { get; init; }

        public string Description { get; init; }

        public string Photo { get; init; }

        public DateTime Date { get; init; }

        public decimal CoverTax { get; init; }

        public Status Status { get; init; }
    }
}
