using DotNetCore.Objects;
using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IRestaurantService
    {
        Task<IResult<Guid>> AddAsync(RestaurantModel model);

        Task<IEnumerable<RestaurantModel>> ListAsync();

        Task<RestaurantModel> GetAsync(Guid id);
        
        Task<Grid<RestaurantModel>> GridAsync(GridParameters parameters);

        Task<IResult> UpdateAsync(RestaurantModel model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);

        Task<IResult> DeleteAsync(Guid id);
    }
}
