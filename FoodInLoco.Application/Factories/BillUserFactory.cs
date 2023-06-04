using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Factories.Interfaces;

namespace FoodInLoco.Application.Factories
{
    public sealed class BillUserFactory : IBillUserFactory
    {
        public BillUser Create(BillUserModelRequest model, Guid userId)
        {
            return new BillUser
            (
                model.BillId,
                userId
            );
        }
    }
}
