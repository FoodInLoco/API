using DotNetCore.Objects;
using DotNetCore.Results;
using DotNetCore.Validation;
using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Repositories.Interfaces;
using FoodInLoco.Application.Factories.Interfaces;
using FoodInLoco.Application.Services.Interfaces;

namespace FoodInLoco.Application.Services
{
    public sealed class RestaurantService : IRestaurantService
    {
        private readonly IAuthService _authService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IRestaurantFactory _restaurantFactory;

        public RestaurantService
        (
            IAuthService authService,
            IUnitOfWork unitOfWork,
            IRestaurantRepository restaurantRepository,
            IRestaurantFactory restaurantFactory
        )
        {
            _authService = authService;
            _unitOfWork = unitOfWork;
            _restaurantRepository = restaurantRepository;
            _restaurantFactory = restaurantFactory;
        }

        public async Task<IResult<long>> AddAsync(RestaurantModel model)
        {
            var validation = new AddRestaurantModelValidator().Validation(model);

            if (validation.Failed)
                return validation.Fail<long>();

            var auth = await _authService.AddAsync(model.Auth);

            if (auth.Failed)
                return auth.Fail<long>();

            var restaurant = _restaurantFactory.Create(model, auth.Data);

            await _restaurantRepository.AddAsync(restaurant);

            await _unitOfWork.SaveChangesAsync();

            return restaurant.Id.Success();
        }

        public async Task<IResult> DeleteAsync(long id)
        {
            var authId = await _restaurantRepository.GetAuthIdByRestaurantIdAsync(id);

            await _restaurantRepository.DeleteAsync(id);

            await _authService.DeleteAsync(authId);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public Task<RestaurantModel> GetAsync(long id)
        {
            return _restaurantRepository.GetModelByIdAsync(id);
        }

        public Task<Grid<RestaurantModel>> GridAsync(GridParameters parameters)
        {
            return _restaurantRepository.GridAsync(parameters);
        }

        public async Task<IResult> InactivateAsync(long id)
        {
            var restaurant = new Restaurant(id);

            restaurant.Inactivate();

            await _restaurantRepository.UpdateStatusAsync(restaurant);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
        
        public async Task<IResult> ActivateAsync(long id)
        {
            var restaurant = new Restaurant(id);

            restaurant.Activate();

            await _restaurantRepository.UpdateStatusAsync(restaurant);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IEnumerable<RestaurantModel>> ListAsync()
        {
            return await _restaurantRepository.ListModelAsync();
        }

        public async Task<IResult> UpdateAsync(RestaurantModel model)
        {
            var validation = new UpdateRestaurantModelValidator().Validation(model);

            if (validation.Failed)
                return validation;

            var restaurant = await _restaurantRepository.GetAsync(model.Id);

            if (restaurant is null)
                return Result.Success();

            restaurant.Update(model.CompanyName, model.TradingName, model.Email, model.DDD, model.PhoneNumber,
                model.State, model.City, model.ZipCode, model.Street, model.Number, model.Complement);

            await _restaurantRepository.UpdateAsync(restaurant);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
    }
}
