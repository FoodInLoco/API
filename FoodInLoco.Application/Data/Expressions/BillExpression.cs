using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Enums;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class BillExpression
    {
        public static Expression<Func<Bill, BillModelResponse>> Model => _ => new BillModelResponse
        {
            Id = _.Id,
            CreatedAt = _.CreatedAt,
            LastUpdatedAt = _.LastUpdatedAt,
            TableId = _.TableId,
            BillingStatus = _.BillingStatus,
            Status = _.Status,
            ValueAmount = _.Orders.Sum(_ => _.Quantity * _.Item.Value)
        };

        public static Expression<Func<Bill, bool>> Id(Guid id)
        {
            return _ => _.Id == id;
        }

        public static Expression<Func<Bill, bool>> ActiveByTableId(Guid id)
        {
            return _ => _.TableId == id && _.BillingStatus == BillingStatus.Pending;
        }

        public static Expression<Func<Bill, bool>> ActiveByUserId(Guid id)
        {
            return _ => _.BillUsers.Any(_ => _.UserId == id) && _.BillingStatus == BillingStatus.Pending;
        }
    }
}
