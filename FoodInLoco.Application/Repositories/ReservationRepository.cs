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
        public ReservationRepository(Context context) : base(context) { }

        public async Task<ReservationModelResponse?> GetModelByIdAsync(Guid id)
        {
            return await Queryable.Where(ReservationExpression.Id(id)).Select(ReservationExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<ReservationModelResponse?> GetModelByIdWithRelationsAsync(Guid id)
        {
            return await Queryable.Where(ReservationExpression.Id(id))
                .Include(_ => _.User)
                .Include(_ => _.Restaurant)
                .Select(ReservationExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<ReservationModelResponse>> ListModelAsync()
        {
            return await Queryable
                .Include(_ => _.User)
                .Include(_ => _.Restaurant)
                .Select(ReservationExpression.Model).ToListAsync();
        }

        public async Task<IEnumerable<ReservationModelResponse>> ListModelByDateFromRestaurantAsync(Guid restaurantId, DateTime? date)
        {
            return await Queryable.Where(ReservationExpression.FromRestaurantByDate(restaurantId, date))
                .Include(_ => _.User)
                .Include(_ => _.Restaurant)
                .Select(ReservationExpression.Model).ToListAsync();
        }

        public async Task<IEnumerable<ReservationModelResponse>> ListModelByDateFromUserAsync(Guid userId, DateTime? date)
        {
            return await Queryable.Where(ReservationExpression.FromUserByDate(userId, date))
                .Include(_ => _.User)
                .Include(_ => _.Restaurant)
                .Select(ReservationExpression.Model).ToListAsync();
        }

        public async Task<IEnumerable<ReservationModelResponse>> ListModelPendingConfirmationAsync()
        {
            return await Queryable.Where(ReservationExpression.PendingConfirmation())
                .Include(_ => _.User)
                .Include(_ => _.Restaurant)
                .Select(ReservationExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(Reservation obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status, LastUpdatedAt = DateTime.UtcNow });
        }

        public Task UpdateConfirmationAsync(Reservation obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Confirmation, LastUpdatedAt = DateTime.UtcNow });
        }
    }
}
