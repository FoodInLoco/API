using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IMenuService
    {
        Task<IResult<Guid>> AddAsync(MenuModelRequest model);

        Task<IResult> DeleteAsync(Guid id);

        Task<MenuModelResponse> GetAsync(Guid id);
        
        Task<IEnumerable<MenuModelResponse>> ListAsync();

        Task<IEnumerable<MenuModelResponse>> ListByRestaurantAsync(Guid id);

        Task<IResult> UpdateAsync(MenuModelRequest model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);
    }
}
