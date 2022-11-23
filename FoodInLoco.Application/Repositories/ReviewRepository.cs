using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FoodInLoco.Application.Repositories
{
    public sealed class ReviewRepository : EFRepository<Review>, IReviewRepository
    {
        private readonly Context _dbContext;

        public ReviewRepository(Context context) : base(context)
        {
            _dbContext = context;
        }

        public Task<ReviewModel> GetModelByIdAsync(Guid id)
        {
            return Queryable.Where(ReviewExpression.Id(id)).Select(ReviewExpression.Model).SingleOrDefaultAsync();
        }

        public Task<ReviewModel> GetModelByIdWithRelationsAsync(Guid id)
        {
            return Queryable.Where(ReviewExpression.Id(id))
                .Include(_ => _.User)
                .Select(ReviewExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<ReviewModel>> ListModelAsync()
        {
            return await Queryable.Select(ReviewExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(Review obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status, LastUpdatedAt = DateTime.UtcNow });
        }
    }
}
