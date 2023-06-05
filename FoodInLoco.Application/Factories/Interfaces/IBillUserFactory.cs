using FoodInLoco.Application.Data.Entities;

namespace FoodInLoco.Application.Factories.Interfaces
{
    public interface IBillUserFactory
    {
        BillUser Create(Guid billId, Guid userId);
    }
}
