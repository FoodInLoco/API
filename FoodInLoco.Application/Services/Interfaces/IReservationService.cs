using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IReservationService
    {
        Task<bool> CheckUser(Guid reservationId, Guid userId);

        Task<IResult<Guid>> AddAsync(Guid userId, ReservationModelRequest model);

        Task<IResult> DeleteAsync(Guid id);

        Task<ReservationModelResponse?> GetAsync(Guid id);
        
        Task<IEnumerable<ReservationModelResponse>> ListAsync();

        Task<IEnumerable<ReservationModelResponse>> ListByDateFromRestaurantAsync(Guid restaurantId, DateTime? date);

        Task<IEnumerable<ReservationModelResponse>> ListByDateFromUserAsync(Guid userId, DateTime? date);

        Task<IEnumerable<ReservationModelResponse>> ListPendingConfirmationAsync();

        Task<IResult> UpdateAsync(ReservationModelRequest model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);

        Task<IResult> DisconfirmAsync(Guid id);

        Task<IResult> ConfirmAsync(Guid id);
    }
}
