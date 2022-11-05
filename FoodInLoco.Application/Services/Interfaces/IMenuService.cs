using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IMenuService
    {
        Task<IResult<long>> AddAsync(MenuModel model);

        Task<IResult> DeleteAsync(long id);

        Task<MenuModel> GetAsync(long id);

        Task<IEnumerable<MenuModel>> ListAsync();

        Task<IResult> UpdateAsync(MenuModel model);

        Task<IResult> InactivateAsync(long id);

        Task<IResult> ActivateAsync(long id);
    }
}
