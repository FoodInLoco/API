using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IReservationService
    {
        Task<IResult<Guid>> AddAsync(ReservationModelRequest model);

        Task<IResult> DeleteAsync(Guid id);

        Task<ReservationModelResponse> GetAsync(Guid id);
        
        Task<IEnumerable<ReservationModelResponse>> ListAsync();

        Task<IEnumerable<ReservationModelResponse>> ListByDateFromRestaurantAsync(Guid id, DateTime? date);

        Task<IEnumerable<ReservationModelResponse>> ListByDateFromUserAsync(Guid id, DateTime? date);

        Task<IResult> UpdateAsync(ReservationModelRequest model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);

        Task<IResult> DisconfirmAsync(Guid id);

        Task<IResult> ConfirmAsync(Guid id);
    }
}
