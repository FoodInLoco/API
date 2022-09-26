using DotNetCore.Results;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Repositories.Interfaces;
using FoodInLoco.Application.Factories.Interfaces;
using FoodInLoco.Application.Helpers;
using FoodInLoco.Application.Helpers.Interfaces;
using FoodInLoco.Application.Services.Interfaces;

namespace FoodInLoco.Application.Services
{
    public sealed class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly IAuthFactory _authFactory;
        private readonly IHashService _hashService;

        public AuthService
        (
            IAuthRepository authRepository,
            IAuthFactory authFactory,
            IHashService hashService
        )
        {
            _authRepository = authRepository;
            _authFactory = authFactory;
            _hashService = hashService;
        }

        public async Task<IResult<Auth>> AddAsync(AuthModel model)
        {
            var failResult = Result<Auth>.Fail("Alguma das validações não passaram!");

            var validation = new AuthModelValidator().Validate(model);

            if (!validation.IsValid)
                return failResult;

            if (await _authRepository.AnyByLoginAsync(model.Login))
                return Result<Auth>.Fail("Login já existe!");

            var auth = _authFactory.Create(model);

            var password = _hashService.Create(auth.Password, auth.Salt);

            auth.UpdatePassword(password);

            await _authRepository.AddAsync(auth);

            return auth.Success();
        }

        public async Task DeleteAsync(long id)
        {
            await _authRepository.DeleteAsync(id);
        }

        public async Task<IResult<TokenModel>> SignInAsync(SignInModel model)
        {
            var failResult = Result<TokenModel>.Fail("Usuário ou senha inválidos!");

            var validation = new SignInModelValidator().Validate(model);

            if (!validation.IsValid)
                return failResult;

            var auth = await _authRepository.GetByLoginAsync(model.Login);

            if (auth is null)
                return failResult;

            var password = _hashService.Create(model.Password, auth.Salt);

            if (auth.Password != password)
                return failResult;

            return CreateToken(auth);
        }

        private static IResult<TokenModel> CreateToken(Auth auth)
        {
            var token = TokenService.GenerateToken(auth);

            return new TokenModel(token).Success();
        }
    }
}
