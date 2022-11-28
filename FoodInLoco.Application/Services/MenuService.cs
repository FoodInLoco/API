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
    public sealed class MenuService : IMenuService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMenuRepository _menuRepository;
        private readonly IMenuFactory _menuFactory;

        public MenuService
        (
            IUnitOfWork unitOfWork,
            IMenuRepository menuRepository,
            IMenuFactory menuFactory
        )
        {
            _unitOfWork = unitOfWork;
            _menuRepository = menuRepository;
            _menuFactory = menuFactory;
        }

        public async Task<IResult<Guid>> AddAsync(MenuModelRequest model)
        {
            var validation = new AddMenuModelValidator().Validation(model);

            if (validation.Failed)
                return validation.Fail<Guid>();

            var restaurant = _menuFactory.Create(model);

            await _menuRepository.AddAsync(restaurant);

            await _unitOfWork.SaveChangesAsync();

            return restaurant.Id.Success();
        }

        public async Task<IResult> DeleteAsync(Guid id)
        {
            await _menuRepository.DeleteAsync(id);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public Task<MenuModelResponse?> GetAsync(Guid id)
        {
            return _menuRepository.GetModelByIdWithRelationsAsync(id);
        }
        
        public async Task<IEnumerable<MenuModelResponse>> ListAsync()
        {
            return await _menuRepository.ListModelAsync();
        }

        public async Task<IEnumerable<MenuModelResponse>> ListByRestaurantAsync(Guid restaurantId)
        {
            return await _menuRepository.ListModelByRestaurantAsync(restaurantId);
        }

        public async Task<IResult> UpdateAsync(MenuModelRequest model)
        {
            var validation = new UpdateMenuModelValidator().Validation(model);

            if (validation.Failed)
                return validation;

            var menu = await _menuRepository.GetAsync(model.Id);

            if (menu is null)
                return Result.Success();

            menu.Update(model.Name, model.Description, model.ExpirationDate, model.HappyHour, !String.IsNullOrEmpty(model.StartAt) ? TimeOnly.Parse(model.StartAt) : null, !String.IsNullOrEmpty(model.EndAt) ? TimeOnly.Parse(model.EndAt) : null);

            await _menuRepository.UpdateAsync(menu);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> InactivateAsync(Guid id)
        {
            var menu = new Menu(id);
            menu.Inactivate();

            await _menuRepository.UpdateStatusAsync(menu);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> ActivateAsync(Guid id)
        {
            var menu = new Menu(id);
            menu.Activate();

            await _menuRepository.UpdateStatusAsync(menu);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
    }
}
