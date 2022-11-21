using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record ReservationModel
    {
        public Guid Id { get; init; }

        public DateTime InsertDate { get; init; }

        public DateTime? UpdateDate { get; init; }

        public Guid RestaurantId { get; init; }

        public Guid UserId { get; init; }

        public string Description { get; init; }

        public short SeatQuantity { get; init; }

        public DateTime Date { get; init; }

        public Status Status { get; init; }

        public Status Confirmation { get; init; }
    }
}