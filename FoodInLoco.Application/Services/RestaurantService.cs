using DotNetCore.Objects;
using DotNetCore.Results;
using DotNetCore.Validation;
using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Factories;
using FoodInLoco.Application.Factories.Interfaces;
using FoodInLoco.Application.Helpers;
using FoodInLoco.Application.Helpers.Interfaces;
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
        private readonly IHashService _hashService;

        public RestaurantService
        (
            IUnitOfWork unitOfWork,
            IRestaurantRepository restaurantRepository,
            IRestaurantFactory restaurantFactory,
            IHashService hashService
        )
        {
            _unitOfWork = unitOfWork;
            _restaurantRepository = restaurantRepository;
            _restaurantFactory = restaurantFactory;
            _hashService = hashService;
        }

        public async Task<bool> CheckUser(Guid restaurantId, Guid loggedRestaurantId)
        {
            var restaurant = await _restaurantRepository.GetAsync(restaurantId);

            return restaurant.Id == loggedRestaurantId;
        }

        public async Task<IResult<Guid>> AddAsync(RestaurantModelRequest model)
        {
            var validation = new AddRestaurantModelValidator().Validation(model);

            if (validation.Failed)
                return validation.Fail<Guid>();

            if (await _restaurantRepository.AnyByEmailAsync(model.Email))
                return Result<Guid>.Fail("Login já existe!");

            var restaurant = _restaurantFactory.Create(model);

            var password = _hashService.Create(model.Password, restaurant.Salt);

            restaurant.UpdatePassword(password);

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

        public async Task<IResult<RestaurantModelResponse?>> GetAsync(Guid id)
        {
            var response = await _restaurantRepository.GetModelByIdWithRelationsAsync(id);
            return response.Success();
        }

        public async Task<IResult> GetByEmail(string email)
        {
            var user = await _restaurantRepository.GetModelByEmailAsync(email);
            if (user != null)
                return user.Success();
            return Result.Fail("Nenhum dado encontrado");
        }

        public async Task<IResult<Grid<RestaurantModelResponse>>> GridAsync(GridParameters parameters)
        {
            var response = await _restaurantRepository.GridAsync(parameters);
            return response.Success();
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

        public async Task<IResult<IEnumerable<RestaurantModelResponse>>> ListAsync()
        {
            var response = await _restaurantRepository.ListModelAsync();
            return response.Success();
        }

        public async Task<IResult> UpdateAsync(RestaurantModelRequest model)
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

        public async Task<IResult<TokenModel<RestaurantTokenModel>>> SignInAsync(SignInModel model)
        {
            var failResult = Result<TokenModel<RestaurantTokenModel>>.Fail("Email ou senha inválidos!");

            var validation = new SignInModelValidator().Validation(model);

            if (validation.Failed)
                return failResult;

            var restaurant = await _restaurantRepository.GetByEmailAsync(model.Email);

            if (restaurant is null)
                return failResult;

            var password = _hashService.Create(model.Password, restaurant.Salt);

            if (restaurant.Password != password)
                return failResult;

            return CreateToken(restaurant);
        }

        private static IResult<TokenModel<RestaurantTokenModel>> CreateToken(Restaurant restaurant)
        {
            var token = TokenService.GenerateToken(restaurant);

            return new TokenModel<RestaurantTokenModel>(token, new RestaurantTokenModel(restaurant.Id, restaurant.Company.CompanyName, restaurant.Company.TradingName, restaurant.Email.Value)).Success();
        }
    }
}
