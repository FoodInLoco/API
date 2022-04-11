using FluentValidation;

namespace FoodInLoco.Application.Contracts.Models
{
    public sealed class SignInModelValidator : AbstractValidator<SignInModel>
    {
        public SignInModelValidator()
        {
            RuleFor(signIn => signIn.Login).NotEmpty();
            RuleFor(signIn => signIn.Password).NotEmpty();
        }
    }
}
