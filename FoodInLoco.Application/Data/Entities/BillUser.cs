using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Enums;
using System.Drawing.Drawing2D;

namespace FoodInLoco.Application.Data.Entities
{
    public class BillUser
    {
        public BillUser(Guid billId, Guid userId)
        {
            BillId = billId;
            UserId = userId;
        }

        public Guid BillId { get; private set; }

        public Guid UserId { get; private set; }

        public Status Status { get; private set; }

        public Bill Bill { get; private set; }

        public User User { get; private set; }

        public void Activate()
        {
            Status = Status.Active;
        }

        public void Inactivate()
        {
            Status = Status.Inactive;
        }

        public static implicit operator BillUserModelResponse(BillUser billUser)
        {
            if (billUser is null)
                return null;

            return new BillUserModelResponse
            {
                BillId = billUser.BillId,
                UserId = billUser.UserId,
                Status = billUser.Status,
                UserModel = (UserModelResponse)billUser.User,
                BillModel = (BillModelResponse)billUser.Bill
            };
        }
    }
}
