using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IReservationService
    {
        Task<IResult<Guid>> AddAsync(ReservationModel model);

        Task<IResult> DeleteAsync(Guid id);

        Task<ReservationModel> GetAsync(Guid id);
        
        Task<IEnumerable<ReservationModel>> ListAsync();

        Task<IResult> UpdateAsync(ReservationModel model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);

        Task<IResult> DisconfirmAsync(Guid id);

        Task<IResult> ConfirmAsync(Guid id);
    }
}
