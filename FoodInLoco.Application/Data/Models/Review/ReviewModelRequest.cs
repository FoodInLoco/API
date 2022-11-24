using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record ReviewModelRequest
    {
        public Guid Id { get; init; }

        public Guid RestaurantId { get; init; }

        public Guid ReservationId { get; init; }

        public Guid UserId { get; init; }

        public string Name { get; init; }

        public string Description { get; init; }

        public Rate Rate { get; init; }
    }
}
