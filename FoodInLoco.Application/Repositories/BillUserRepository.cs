using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Repositories
{
    public sealed class BillUserRepository : EFRepository<BillUser>, IBillUserRepository
    {
        public BillUserRepository(Context context) : base(context) { }

        public async Task<BillUserModelResponse?> GetFromKeys(Guid billId, Guid userId)
        {
            return await Queryable.Where(BillUserExpression.Id(billId, userId))
                .Include(_ => _.Bill).ThenInclude(_ => _.BillUsers)
                .Include(_ => _.Bill).ThenInclude(_ => _.Orders).ThenInclude(_ => _.Item)
                .Include(_ => _.Bill).ThenInclude(_ => _.Table).ThenInclude(_ => _.Restaurant)
                .Select(BillUserExpression.Model).SingleOrDefaultAsync();
        }

        public Task UpdateStatusAsync(BillUser obj)
        {
            return UpdatePartialAsync(new { obj.BillId, obj.UserId, obj.Status });
        }
    }
}
