using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record BillModelRequest
    {
        public Guid Id { get; init; }

        public Guid TableId { get; init; }

        public BillingStatus BillingStatus { get; init; }
    }
}
