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
            RestaurantId = _.Table.RestaurantId,
            RestaurantName = _.Table.Restaurant.Company.TradingName,
            TableNumber = _.Table.Number,
            BillingStatus = _.BillingStatus,
            Status = _.Status,
            WaiterRequested = _.WaiterRequested,
            ValueAmount = _.Orders.Sum(_ => _.Quantity * _.Item.Value),
            Orders = _.Orders.Where(_ => _.Status == Status.Active).Select(_ => (OrderModelResponse)_).ToList(),
            Users = _.BillUsers.Where(_ => _.Status == Status.Active).Select(_ => (UserModelResponse)_.User).ToList(),
            PendingUsers = _.BillUsers.Where(_ => _.Status == Status.None).Select(_ => (UserModelResponse)_.User).ToList()
        };

        public static Expression<Func<Bill, IEnumerable<UserModelResponse>>> UserModelPending => _ => _.BillUsers.Where(_ => _.Status == Status.None).Select(_ => (UserModelResponse)_.User);

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
            return _ => _.BillUsers.Any(_ => _.UserId == id && _.Status == Status.Active) && _.BillingStatus == BillingStatus.Pending;
        }
    }
}
