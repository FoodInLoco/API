using DotNetCore.Results;
using DotNetCore.Security;
using DotNetCore.Validation;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using FoodInLoco.Application.Factories.Interfaces;
using FoodInLoco.Application.Services.Interfaces;
using FoodInLoco.Application.Data;
using DotNetCore.Objects;
using FoodInLoco.Application.Repositories;

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

        public async Task<IResult<long>> AddAsync(MenuModel model)
        {
            var validation = new AddMenuModelValidator().Validation(model);

            if (validation.Failed)
                return validation.Fail<long>();

            var restaurant = _menuFactory.Create(model);

            await _menuRepository.AddAsync(restaurant);

            await _unitOfWork.SaveChangesAsync();

            return restaurant.Id.Success();
        }

        public async Task<IResult> DeleteAsync(long id)
        {
            await _menuRepository.DeleteAsync(id);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public Task<MenuModel> GetAsync(long id)
        {
            return _menuRepository.GetModelByIdAsync(id);
        }

        public async Task<IEnumerable<MenuModel>> ListAsync()
        {
            return await _menuRepository.ListModelAsync();
        }

        public async Task<IResult> UpdateAsync(MenuModel model)
        {
            var validation = new UpdateMenuModelValidator().Validation(model);

            if (validation.Failed)
                return validation;

            var menu = await _menuRepository.GetAsync(model.Id);

            if (menu is null)
                return Result.Success();

            menu.Update(model.Name, model.Description, model.ExpirationDate, model.HappyHour, model.StartAt, model.EndAt);

            await _menuRepository.UpdateAsync(menu);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> InactivateAsync(long id)
        {
            var menu = new Menu(id);
            menu.Inactivate();

            await _menuRepository.UpdateStatusAsync(menu);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> ActivateAsync(long id)
        {
            var menu = new Menu(id);
            menu.Activate();

            await _menuRepository.UpdateStatusAsync(menu);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
    }
}
