using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IMenuService
    {
        Task<IResult<Guid>> AddAsync(MenuModelRequest model);

        Task<IResult> DeleteAsync(Guid id);

        Task<IResult<MenuModelResponse?>> GetAsync(Guid id);
        
        Task<IResult<IEnumerable<MenuModelResponse>>> ListAsync();

        Task<IResult<IEnumerable<MenuModelResponse>>> ListByRestaurantAsync(Guid restaurantId);

        Task<IResult> UpdateAsync(MenuModelRequest model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);
    }
}
