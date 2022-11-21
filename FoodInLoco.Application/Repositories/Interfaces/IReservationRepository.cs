using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        Task<ReservationModel> GetModelByIdAsync(Guid id);

        Task<IEnumerable<ReservationModel>> ListModelAsync();

        Task UpdateStatusAsync(Reservation obj);
    }
}
