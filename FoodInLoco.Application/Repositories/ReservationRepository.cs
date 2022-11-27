using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Repositories
{
    public sealed class ReservationRepository : EFRepository<Reservation>, IReservationRepository
    {
        private readonly Context _dbContext;

        public ReservationRepository(Context context) : base(context)
        {
            _dbContext = context;
        }

        public Task<ReservationModelResponse> GetModelByIdAsync(Guid id)
        {
            return Queryable.Where(ReservationExpression.Id(id)).Select(ReservationExpression.Model).SingleOrDefaultAsync();
        }

        public Task<ReservationModelResponse> GetModelByIdWithRelationsAsync(Guid id)
        {
            return Queryable.Where(ReservationExpression.Id(id))
                .Include(_ => _.User)
                .Select(ReservationExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<ReservationModelResponse>> ListModelAsync()
        {
            return await Queryable.Select(ReservationExpression.Model).ToListAsync();
        }

        public async Task<IEnumerable<ReservationModelResponse>> ListModelByDateFromRestaurantAsync(Guid restaurantId, DateTime? date)
        {
            return await Queryable.Where(ReservationExpression.FromRestaurantByDate(restaurantId, date)).Select(ReservationExpression.Model).ToListAsync();
        }

        public async Task<IEnumerable<ReservationModelResponse>> ListModelByDateFromUserAsync(Guid userId, DateTime? date)
        {
            return await Queryable.Where(ReservationExpression.FromUserByDate(userId, date)).Select(ReservationExpression.Model).ToListAsync();
        }

        public async Task<IEnumerable<ReservationModelResponse>> ListModelPendingConfirmationAsync()
        {
            return await Queryable.Where(ReservationExpression.PendingConfirmation()).Select(ReservationExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(Reservation obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status, LastUpdatedAt = DateTime.UtcNow });
        }
    }
}
