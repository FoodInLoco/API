using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Repositories
{
    public sealed class ReviewRepository : EFRepository<Review>, IReviewRepository
    {
        public ReviewRepository(Context context) : base(context) { }

        public async Task<ReviewModelResponse?> GetModelByIdAsync(Guid id)
        {
            return await Queryable.Where(ReviewExpression.Id(id)).Select(ReviewExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<ReviewModelResponse?> GetModelByIdWithRelationsAsync(Guid id)
        {
            return await Queryable.Where(ReviewExpression.Id(id))
                .Include(_ => _.User)
                .Include(_ => _.Restaurant)
                .Select(ReviewExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<ReviewModelResponse>> ListModelAsync()
        {
            return await Queryable.Select(ReviewExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(Review obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status, LastUpdatedAt = DateTime.UtcNow });
        }
    }
}
