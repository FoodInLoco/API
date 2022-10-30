using FluentValidation;

namespace FoodInLoco.Application.Data.Models
{
    public sealed class SignInModelValidator : AbstractValidator<SignInModel>
    {
        public SignInModelValidator()
        {
            RuleFor(signIn => signIn.Email).NotEmpty().EmailAddress();
            RuleFor(signIn => signIn.Password).NotEmpty();
        }
    }
}
