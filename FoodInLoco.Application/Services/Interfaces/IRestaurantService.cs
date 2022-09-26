using DotNetCore.Objects;
using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IRestaurantService
    {
        Task<IResult<long>> AddAsync(RestaurantModel model);

        Task<IResult> DeleteAsync(long id);

        Task<RestaurantModel> GetAsync(long id);

        Task<Grid<RestaurantModel>> GridAsync(GridParameters parameters);

        Task<IResult> InactivateAsync(long id);

        Task<IResult> ActivateAsync(long id);

        Task<IEnumerable<RestaurantModel>> ListAsync();

        Task<IResult> UpdateAsync(RestaurantModel model);
    }
}
