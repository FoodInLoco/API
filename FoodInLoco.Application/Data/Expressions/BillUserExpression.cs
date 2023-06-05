using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Enums;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class BillUserExpression
    {
        public static Expression<Func<BillUser, BillUserModelResponse>> Model => _ => new BillUserModelResponse
        {
            BillId = _.BillId,
            UserId = _.UserId,
            Status = _.Status,
            UserModel = (UserModelResponse)_.User,
            BillModel = (BillModelResponse)_.Bill
        };

        public static Expression<Func<BillUser, bool>> Id(Guid billId, Guid userId)
        {
            return _ => _.BillId == billId && _.UserId == userId;
        }
    }
}
