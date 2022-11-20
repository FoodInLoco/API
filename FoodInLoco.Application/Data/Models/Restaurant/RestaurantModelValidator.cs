using FluentValidation;
using System.Text.RegularExpressions;

namespace FoodInLoco.Application.Data.Models
{
    public abstract class RestaurantModelValidator : AbstractValidator<RestaurantModel>
    {
        public void Id() => RuleFor(_ => _.Id).NotEmpty();

        public void CompanyName() => RuleFor(_ => _.CompanyName).NotEmpty();

        public void TradingName() => RuleFor(_ => _.TradingName).NotEmpty();

        public void Email() => RuleFor(_ => _.Email).EmailAddress();

        public void Photo() => RuleFor(_ => _.Photo).NotEmpty().MaximumLength(1000);

        public void DDD() => RuleFor(_ => _.DDD)
            .Length(2).WithMessage("DDD precisa ter 2 caracteres.")
            .Matches(new Regex(@"\d{2}")).WithMessage("DDD inválido.");

        public void PhoneNumber() => RuleFor(_ => _.PhoneNumber)
            .NotNull().WithMessage("Telefone é obrigatório.")
            .NotEmpty().WithMessage("Telefone não pode estar vazio.")
            .MinimumLength(8).WithMessage("Telefone precisa ter pelo menos 8 caracteres.")
            .MaximumLength(9).WithMessage("Telefone não pode ter mais de 9 caracteres.")
            .Matches(new Regex(@"(?:[1-9]|9[1-9])[0-9]{3}\-?[0-9]{4}$")).WithMessage("Telefone inválido.");

        public void Kids() => RuleFor(_ => _.Kids)
            .NotNull().WithMessage("É obrigatório preencher espaço para criança.");
    }
}
