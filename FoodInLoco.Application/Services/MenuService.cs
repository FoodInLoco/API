using DotNetCore.Results;
using DotNetCore.Security;
using DotNetCore.Validation;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Repositories.Interfaces;
using FoodInLoco.Application.Factories.Interfaces;
using FoodInLoco.Application.Services.Interfaces;

namespace FoodInLoco.Application.Services
{
    public sealed class MenuService : IMenuService
    {
        private readonly IMenuRepository _menuRepository;
        private readonly IMenuFactory _menuFactory;

        public MenuService
        (
            IMenuRepository menuRepository,
            IMenuFactory menuFactory
        )
        {
            _menuRepository = menuRepository;
            _menuFactory = menuFactory;
        }
    }
}
