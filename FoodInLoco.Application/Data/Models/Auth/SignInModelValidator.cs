using FluentValidation;

namespace FoodInLoco.Application.Data.Models
{
    public sealed class SignInModelValidator : AbstractValidator<SignInModel>
    {
        public SignInModelValidator()
        {
            RuleFor(_ => _.Email).NotEmpty().EmailAddress();
            RuleFor(_ => _.Password).NotEmpty();
        }
    }
}
