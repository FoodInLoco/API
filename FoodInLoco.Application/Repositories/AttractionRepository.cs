using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FoodInLoco.Application.Repositories
{
    public sealed class AttractionRepository : EFRepository<Attraction>, IAttractionRepository
    {
        private readonly Context _dbContext;

        public AttractionRepository(Context context) : base(context)
        {
            _dbContext = context;
        }

        public Task<AttractionModel> GetModelByIdAsync(Guid id)
        {
            return Queryable.Where(AttractionExpression.Id(id)).Select(AttractionExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<AttractionModel>> ListModelAsync()
        {
            return await Queryable.Select(AttractionExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(Attraction obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status });
        }
    }
}
