using DotNetCore.Objects;
using DotNetCore.Results;
using DotNetCore.Validation;
using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Factories.Interfaces;
using FoodInLoco.Application.Repositories;
using FoodInLoco.Application.Repositories.Interfaces;
using FoodInLoco.Application.Services.Interfaces;

namespace FoodInLoco.Application.Services
{
    public sealed class RestaurantService : IRestaurantService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IRestaurantFactory _restaurantFactory;

        public RestaurantService
        (
            IUnitOfWork unitOfWork,
            IRestaurantRepository restaurantRepository,
            IRestaurantFactory restaurantFactory
        )
        {
            _unitOfWork = unitOfWork;
            _restaurantRepository = restaurantRepository;
            _restaurantFactory = restaurantFactory;
        }

        public async Task<IResult<Guid>> AddAsync(RestaurantModel model)
        {
            var validation = new AddRestaurantModelValidator().Validation(model);

            if (validation.Failed)
                return validation.Fail<Guid>();

            var restaurant = _restaurantFactory.Create(model);

            await _restaurantRepository.AddAsync(restaurant);

            await _unitOfWork.SaveChangesAsync();

            return restaurant.Id.Success();
        }

        public async Task<IResult> DeleteAsync(Guid id)
        {
            await _restaurantRepository.DeleteAsync(id);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public Task<RestaurantModel> GetAsync(Guid id)
        {
            return _restaurantRepository.GetModelByIdAsync(id);
        }

        public Task<Grid<RestaurantModel>> GridAsync(GridParameters parameters)
        {
            return _restaurantRepository.GridAsync(parameters);
        }

        public async Task<IResult> InactivateAsync(Guid id)
        {
            var restaurant = new Restaurant(id);

            restaurant.Inactivate();

            await _restaurantRepository.UpdateStatusAsync(restaurant);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
        
        public async Task<IResult> ActivateAsync(Guid id)
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

            restaurant.Update(model.CompanyName, model.TradingName, model.Email, model.DDD, model.PhoneNumber, model.State, 
                model.City, model.ZipCode, model.Street, model.Number, model.Complement, model.Kids, model.Photo);

            await _restaurantRepository.UpdateAsync(restaurant);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
    }
}
