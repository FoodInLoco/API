using DotNetCore.Objects;
using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IMenuItemService
    {
        Task<IResult<Guid>> AddAsync(MenuItemModelRequest model);

        Task<IResult> DeleteAsync(Guid id);

        Task<IResult<MenuItemModelResponse?>> GetAsync(Guid id);
        
        Task<IResult<Grid<MenuItemModelResponse>>> GridAsync(GridParameters parameters);

        Task<IResult<IEnumerable<MenuItemModelResponse>>> ListAsync();

        Task<IResult<IEnumerable<MenuItemModelResponse>>> ListByMenuAsync(Guid menuId);

        Task<IResult> UpdateAsync(MenuItemModelRequest model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);
    }
}
