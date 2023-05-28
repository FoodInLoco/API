using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record BillUserModelRequest
    {
        public Guid BillId { get; init; }

        public Guid UserId { get; init; }
    }
}
