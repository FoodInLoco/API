using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record ReviewModel
    {
        public Guid Id { get; init; }

        public DateTime InsertDate { get; init; }

        public DateTime? UpdateDate { get; init; }

        public Guid RestaurantId { get; init; }

        public Guid ReservationId { get; init; }

        public string Name { get; init; }

        public string Description { get; init; }

        public Rate Rate { get; init; }

        public Status Status { get; init; }
    }
}
