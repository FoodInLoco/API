using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Repositories
{
    public sealed class BillRepository : EFRepository<Bill>, IBillRepository
    {
        public BillRepository(Context context) : base(context) { }

        public async Task<BillModelResponse?> GetModelByIdAsync(Guid id)
        {
            return await Queryable.Where(BillExpression.Id(id)).Select(BillExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<BillModelResponse?> GetModelByIdWithRelationsAsync(Guid id)
        {
            return await Queryable.Where(BillExpression.Id(id))
                .Include(_ => _.Table).ThenInclude(_ => _.Restaurant)
                .Include(_ => _.Orders).ThenInclude(_ => _.Item)
                .Include(_ => _.Orders).ThenInclude(_ => _.User)
                .Select(BillExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<BillModelResponse?> GetActiveBillByTableAsync(Guid id)
        {
            return await Queryable.Where(BillExpression.ActiveByTableId(id))
                .Include(_ => _.Table).ThenInclude(_ => _.Restaurant)
                .Include(_ => _.Orders).ThenInclude(_ => _.Item)
                .Include(_ => _.Orders).ThenInclude(_ => _.User)
                .Select(BillExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<BillModelResponse>> GetActiveBillsByUserAsync(Guid id)
        {
            return await Queryable.Where(BillExpression.ActiveByUserId(id))
                .Include(_ => _.Table).ThenInclude(_ => _.Restaurant)
                .Include(_ => _.Orders).ThenInclude(_ => _.Item)
                .Include(_ => _.Orders).ThenInclude(_ => _.User)
                .Select(BillExpression.Model).ToListAsync();
        }

        public async Task<IEnumerable<UserModelResponse>?> GetUserModelPendingAsync(Guid id)
        {
            return await Queryable.Where(BillExpression.Id(id)).Select(BillExpression.UserModelPending).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<BillModelResponse>> ListModelAsync()
        {
            return await Queryable
                .Include(_ => _.Table).ThenInclude(_ => _.Restaurant)
                .Include(_ => _.Orders).ThenInclude(_ => _.Item)
                .Include(_ => _.Orders).ThenInclude(_ => _.User)
                .Select(BillExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(Bill obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status, LastUpdatedAt = DateTime.UtcNow });
        }

        public Task UpdateWaiterAsync(Bill obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.WaiterRequested, LastUpdatedAt = DateTime.UtcNow });
        }
    }
}
