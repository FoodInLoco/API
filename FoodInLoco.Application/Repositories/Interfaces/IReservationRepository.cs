using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        Task<ReservationModel> GetModelByIdAsync(Guid id);

        Task<ReservationModel> GetModelByIdWithRelationsAsync(Guid id);

        Task<IEnumerable<ReservationModel>> ListModelAsync();

        Task<IEnumerable<ReservationModel>> ListModelByDateFromRestaurantAsync(Guid id, DateTime? date);

        Task<IEnumerable<ReservationModel>> ListModelByDateFromUserAsync(Guid id, DateTime? date);

        Task UpdateStatusAsync(Reservation obj);
    }
}
