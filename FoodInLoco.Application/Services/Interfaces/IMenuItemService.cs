using DotNetCore.Objects;
using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IMenuItemService
    {
        Task<IResult<long>> AddAsync(MenuItemModel model);

        Task<IResult> DeleteAsync(long id);

        Task<MenuItemModel> GetAsync(long id);

        Task<Grid<MenuItemModel>> GridAsync(GridParameters parameters);

        Task<IResult> InactivateAsync(long id);

        Task<IResult> ActivateAsync(long id);

        Task<IEnumerable<MenuItemModel>> ListAsync();

        Task<IResult> UpdateAsync(MenuItemModel model);
    }
}
