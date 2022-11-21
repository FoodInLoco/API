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

        public Task<ReservationModel> GetModelByIdAsync(Guid id)
        {
            return Queryable.Where(ReservationExpression.Id(id)).Select(ReservationExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<ReservationModel>> ListModelAsync()
        {
            return await Queryable.Select(ReservationExpression.Model).ToListAsync();
        }

        public async Task<IEnumerable<ReservationModel>> ListModelByDateFromRestaurantAsync(Guid id, DateTime? date)
        {
            return await Queryable.Where(ReservationExpression.FromRestaurantByDate(id, date)).Select(ReservationExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(Reservation obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status, LastUpdatedAt = DateTime.UtcNow });
        }
    }
}
