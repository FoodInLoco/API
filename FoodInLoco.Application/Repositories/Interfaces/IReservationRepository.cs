using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        Task<ReservationModelResponse> GetModelByIdAsync(Guid id);

        Task<ReservationModelResponse> GetModelByIdWithRelationsAsync(Guid id);

        Task<IEnumerable<ReservationModelResponse>> ListModelAsync();

        Task<IEnumerable<ReservationModelResponse>> ListModelByDateFromRestaurantAsync(Guid restaurantId, DateTime? date);

        Task<IEnumerable<ReservationModelResponse>> ListModelByDateFromUserAsync(Guid userId, DateTime? date);

        Task<IEnumerable<ReservationModelResponse>> ListModelPendingConfirmationAsync();

        Task UpdateStatusAsync(Reservation obj);
    }
}
