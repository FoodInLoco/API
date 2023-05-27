using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Repositories
{
    public sealed class AttractionRepository : EFRepository<Attraction>, IAttractionRepository
    {
        public AttractionRepository(Context context) : base(context) { }

        public async Task<AttractionModelResponse?> GetModelByIdAsync(Guid id)
        {
            return await Queryable.Where(AttractionExpression.Id(id))
                .Include(_ => _.Restaurant)
                .Select(AttractionExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<AttractionModelResponse>> ListModelAsync()
        {
            return await Queryable.Select(AttractionExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(Attraction obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status, LastUpdatedAt = DateTime.UtcNow });
        }
    }
}
