using DotNetCore.Objects;
using DotNetCore.Results;
using DotNetCore.Validation;
using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Factories.Interfaces;
using FoodInLoco.Application.Helpers;
using FoodInLoco.Application.Helpers.Interfaces;
using FoodInLoco.Application.Repositories.Interfaces;
using FoodInLoco.Application.Services.Interfaces;
using System.Security.Claims;

namespace FoodInLoco.Application.Services
{
    public sealed class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        private readonly IUserFactory _userFactory;
        private readonly IHashService _hashService;

        public UserService
        (
            IUnitOfWork unitOfWork,
            IUserRepository userRepository,
            IUserFactory userFactory,
            IHashService hashService
        )
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _userFactory = userFactory;
            _hashService = hashService;
        }

        public async Task<IResult<long>> AddAsync(UserModel model)
        {
            var validation = new AddUserModelValidator().Validation(model);

            if (validation.Failed)
                return validation.Fail<long>();

            if (await _userRepository.AnyByEmailAsync(model.Email))
                return Result<long>.Fail("Login já existe!");

            var user = _userFactory.Create(model);

            var password = _hashService.Create(model.Password, user.Salt);

            user.UpdatePassword(password);

            await _userRepository.AddAsync(user);

            await _unitOfWork.SaveChangesAsync();

            return user.Id.Success();
        }

        public async Task<IResult> DeleteAsync(long id)
        {
            await _userRepository.DeleteAsync(id);

            // adicionar deleção de restaurantes do usuário

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public Task<UserModel> GetAsync(long id)
        {
            return _userRepository.GetModelByIdAsync(id);
        }
        
        public Task<UserModel> GetByEmail(string email)
        {
            return _userRepository.GetModelByEmailAsync(email);
        }

        public Task<Grid<UserModel>> GridAsync(GridParameters parameters)
        {
            return _userRepository.GridAsync(parameters);
        }

        public async Task<IResult> InactivateAsync(long id)
        {
            var user = new User(id);

            user.Inactivate();

            await _userRepository.UpdateStatusAsync(user);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
        
        public async Task<IResult> ActivateAsync(long id)
        {
            var user = new User(id);

            user.Activate();

            await _userRepository.UpdateStatusAsync(user);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IEnumerable<UserModel>> ListAsync()
        {
            return await _userRepository.ListModelAsync();
        }

        public async Task<IResult> UpdateAsync(UserModel model)
        {
            var validation = new UpdateUserModelValidator().Validation(model);

            if (validation.Failed)
                return validation;

            var user = await _userRepository.GetAsync(model.Id);

            if (user is null)
                return Result.Success();

            user.Update(model.FirstName, model.LastName, model.Email, model.DDD, model.PhoneNumber);

            await _userRepository.UpdateAsync(user);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult<TokenModel>> SignInAsync(SignInModel model)
        {
            var failResult = Result<TokenModel>.Fail("Usuário ou senha inválidos!");

            var validation = new SignInModelValidator().Validation(model);

            if (validation.Failed)
                return failResult;

            var user = await _userRepository.GetByEmailAsync(model.Email);

            if (user is null)
                return failResult;

            var password = _hashService.Create(model.Password, user.Salt);

            if (user.Password != password)
                return failResult;

            return CreateToken(user);
        }

        private static IResult<TokenModel> CreateToken(User user)
        {
            var token = TokenService.GenerateToken(user);

            return new TokenModel(token, new UserTokenModel(user.Id, user.Name.FirstName, user.Name.LastName, user.Email.Value)).Success();
        }
    }
}
