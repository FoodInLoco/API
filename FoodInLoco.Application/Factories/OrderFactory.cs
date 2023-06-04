using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Factories.Interfaces;

namespace FoodInLoco.Application.Factories
{
    public sealed class OrderFactory : IOrderFactory
    {
        public Order Create(OrderModelRequest model, Guid userId)
        {
            return new Order
            (
                model.BillId,
                userId,
                model.MenuItemId,
                model.Quantity,
                model.Message
            );
        }
    }
}
