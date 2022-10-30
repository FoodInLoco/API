using DotNetCore.Results;
using DotNetCore.Security;
using DotNetCore.Validation;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using FoodInLoco.Application.Factories.Interfaces;
using FoodInLoco.Application.Services.Interfaces;

namespace FoodInLoco.Application.Services
{
    public sealed class MenuItemService : IMenuItemService
    {
        private readonly IMenuItemRepository _menuItemRepository;
        private readonly IMenuItemFactory _menuItemFactory;

        public MenuItemService
        (
            IMenuItemRepository menuItemRepository,
            IMenuItemFactory menuItemFactory
        )
        {
            _menuItemRepository = menuItemRepository;
            _menuItemFactory = menuItemFactory;
        }
    }
}
