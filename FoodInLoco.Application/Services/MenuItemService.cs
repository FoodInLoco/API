using DotNetCore.Objects;
using DotNetCore.Results;
using DotNetCore.Validation;
using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Factories.Interfaces;
using FoodInLoco.Application.Repositories.Interfaces;
using FoodInLoco.Application.Services.Interfaces;

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

        public async Task<IResult<Guid>> AddAsync(MenuItemModelRequest model)
        {
            var validation = new AddMenuItemModelValidator().Validation(model);

            if (validation.Failed)
                return validation.Fail<Guid>();

            var restaurant = _menuItemFactory.Create(model);

            await _menuItemRepository.AddAsync(restaurant);

            await _unitOfWork.SaveChangesAsync();

            return restaurant.Id.Success();
        }

        public async Task<IResult> DeleteAsync(Guid id)
        {
            await _menuItemRepository.DeleteAsync(id);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult<MenuItemModelResponse?>> GetAsync(Guid id)
        {
            var response = await _menuItemRepository.GetModelByIdAsync(id);
            return response.Success();
        }
        
        public async Task<IResult<Grid<MenuItemModelResponse>>> GridAsync(GridParameters parameters)
        {
            var response = await _menuItemRepository.GridAsync(parameters);
            return response.Success();
        }

        public async Task<IResult<IEnumerable<MenuItemModelResponse>>> ListAsync()
        {
            var response = await _menuItemRepository.ListModelAsync();
            return response.Success();
         }
        
        public async Task<IResult<IEnumerable<MenuItemModelResponse>>> ListByMenuAsync(Guid menuId)
        {
            var response = await _menuItemRepository.ListModelByMenuAsync(menuId);
            return response.Success();
        }

        public async Task<IResult> UpdateAsync(MenuItemModelRequest model)
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

        public async Task<IResult> InactivateAsync(Guid id)
        {
            var menuItem = new MenuItem(id);

            menuItem.Inactivate();

            await _menuItemRepository.UpdateStatusAsync(menuItem);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> ActivateAsync(Guid id)
        {
            var menuItem = new MenuItem(id);

            menuItem.Activate();

            await _menuItemRepository.UpdateStatusAsync(menuItem);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
    }
}
