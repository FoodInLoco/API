using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Repositories.Interfaces;

namespace FoodInLoco.Application.Repositories
{
    public sealed class BillUserRepository : EFRepository<BillUser>, IBillUserRepository
    {
        public BillUserRepository(Context context) : base(context) { }

        public Task UpdateStatusAsync(BillUser obj)
        {
            return UpdatePartialAsync(new { obj.BillId, obj.UserId, obj.Status });
        }
    }
}
