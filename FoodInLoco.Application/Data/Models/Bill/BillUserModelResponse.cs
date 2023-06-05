using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record BillUserModelResponse
    {
        public Guid BillId { get; init; }

        public Guid UserId { get; init; }

        public Status Status { get; init; }

        public UserModelResponse UserModel { get; init; }

        public BillModelResponse BillModel { get; init; }
    }
}
