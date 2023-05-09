using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Factories.Interfaces;

namespace FoodInLoco.Application.Factories
{
    public sealed class OrderFactory : IOrderFactory
    {
        public Order Create(OrderModelRequest model)
        {
            return new Order
            (
                model.BillId,
                model.UserId,
                model.MenuItemId,
                model.Quantity,
                model.Message
            );
        }
    }
}
