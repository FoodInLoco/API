using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class OrderExpression
    {
        public static Expression<Func<Order, OrderModelResponse>> Model => _ => new OrderModelResponse
        {
            Id = _.Id,
            CreatedAt = _.CreatedAt,
            LastUpdatedAt = _.LastUpdatedAt,
            BillId = _.BillId,
            UserId = _.UserId,
            MenuItemId = _.ItemId,
            Status = _.Status,
            Confirmed = _.Confirmed,
            ProductName = _.Item.NameDescription.Name,
            ProductDescription = _.Item.NameDescription.Description,
            ProductQuantity = _.Item.Quantity,
            ProductPhoto = _.Item.Photo,
            Quantity = _.Quantity,
            Message = _.Message,
            ValueAmount = _.Quantity * _.Item.Value
        };

        public static Expression<Func<Order, bool>> Id(Guid id)
        {
            return _ => _.Id == id;
        }

        public static Expression<Func<Order, bool>> BillId(Guid id)
        {
            return _ => _.BillId == id;
        }
    }
}
