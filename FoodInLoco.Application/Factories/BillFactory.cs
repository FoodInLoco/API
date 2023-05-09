using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Factories.Interfaces;

namespace FoodInLoco.Application.Factories
{
    public sealed class BillFactory : IBillFactory
    {
        public Bill Create(BillModelRequest model)
        {
            return new Bill
            (
                model.TableId,
                model.BillingStatus
            );
        }
    }
}
