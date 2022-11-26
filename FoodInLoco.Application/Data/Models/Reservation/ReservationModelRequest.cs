using FoodInLoco.Application.Converters;
using FoodInLoco.Application.Enums;
using System.Text.Json.Serialization;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record ReservationModelRequest
    {
        public Guid Id { get; init; }

        public Guid RestaurantId { get; init; }

        public string Description { get; init; }

        public short SeatQuantity { get; init; }

        public DateTime Date { get; init; }
    }
}
