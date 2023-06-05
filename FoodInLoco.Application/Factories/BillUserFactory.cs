using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Factories.Interfaces;

namespace FoodInLoco.Application.Factories
{
    public sealed class BillUserFactory : IBillUserFactory
    {
        public BillUser Create(Guid billId, Guid userId)
        {
            return new BillUser
            (
                billId,
                userId
            );
        }
    }
}
