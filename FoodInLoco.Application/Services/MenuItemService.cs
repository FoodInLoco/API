using DotNetCore.Results;
using DotNetCore.Security;
using DotNetCore.Validation;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using FoodInLoco.Application.Factories.Interfaces;
using FoodInLoco.Application.Services.Interfaces;
using DotNetCore.Objects;
using FoodInLoco.Application.Data;

namespace FoodInLoco.Application.Services
{
    public sealed class MenuItemService : IMenuItemService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMenuItemRepository _menuItemRepository;
        private readonly IMenuItemFactory _menuItemFactory;

        public MenuItemService
        (
            IUnitOfWork unitOfWork,
            IMenuItemRepository menuItemRepository,
            IMenuItemFactory menuItemFactory
        )
        {
            _unitOfWork = unitOfWork;
            _menuItemRepository = menuItemRepository;
            _menuItemFactory = menuItemFactory;
        }

        public async Task<IResult<long>> AddAsync(MenuItemModel model)
        {
            var validation = new AddMenuItemModelValidator().Validation(model);

            if (validation.Failed)
                return validation.Fail<long>();

            var restaurant = _menuItemFactory.Create(model);

            await _menuItemRepository.AddAsync(restaurant);

            await _unitOfWork.SaveChangesAsync();

            return restaurant.Id.Success();
        }

        public async Task<IResult> DeleteAsync(long id)
        {
            await _menuItemRepository.DeleteAsync(id);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public Task<MenuItemModel> GetAsync(long id)
        {
            return _menuItemRepository.GetModelByIdAsync(id);
        }

        public Task<Grid<MenuItemModel>> GridAsync(GridParameters parameters)
        {
            return _menuItemRepository.GridAsync(parameters);
        }

        public async Task<IResult> InactivateAsync(long id)
        {
            var restaurant = new MenuItem(id);

            restaurant.Inactivate();

            await _menuItemRepository.UpdateStatusAsync(restaurant);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> ActivateAsync(long id)
        {
            var restaurant = new MenuItem(id);

            restaurant.Activate();

            await _menuItemRepository.UpdateStatusAsync(restaurant);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IEnumerable<MenuItemModel>> ListAsync()
        {
            return await _menuItemRepository.ListModelAsync();
        }

        public async Task<IResult> UpdateAsync(MenuItemModel model)
        {
            var validation = new UpdateMenuItemModelValidator().Validation(model);

            if (validation.Failed)
                return validation;

            var restaurant = await _menuItemRepository.GetAsync(model.Id);

            if (restaurant is null)
                return Result.Success();

            restaurant.Update(model.Name, model.Description, model.Photo, model.Quantity, model.Value);

            await _menuItemRepository.UpdateAsync(restaurant);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
    }
}
