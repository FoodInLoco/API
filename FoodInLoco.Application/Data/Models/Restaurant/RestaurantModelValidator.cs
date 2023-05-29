using FluentValidation;
using System.Text.RegularExpressions;

namespace FoodInLoco.Application.Data.Models
{
    public abstract class RestaurantModelValidator : AbstractValidator<RestaurantModelRequest>
    {
        public void Id() => RuleFor(_ => _.Id).NotEmpty();

        public void CompanyName() => RuleFor(_ => _.CompanyName)
            .MaximumLength(200).WithMessage("Razão Social não pode ter mais do que 200 caracteres.")
            .NotEmpty().WithMessage("É obrigatório preencher Razão Social.");

        public void TradingName() => RuleFor(_ => _.TradingName)
            .MaximumLength(300).WithMessage("Nome Fantasia não pode ter mais do que 300 caracteres.")
            .NotEmpty().WithMessage("É obrigatório preencher Nome Fantasia.");

        public void Email() => RuleFor(_ => _.Email)
            .MaximumLength(300).WithMessage("E-mail não pode ter mais do que 300 caracteres.")
            .EmailAddress().WithMessage("Formato de e-mail inválido.");

        public void Photo() => When(_ => !String.IsNullOrEmpty(_.Photo), () =>
        {
            RuleFor(_ => _.Photo)
                .MaximumLength(10000).WithMessage("Foto não pode ter mais do que 10000 caracteres.")
                .NotEmpty().WithMessage("É obrigatório preencher Foto.");
        });

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

        public void Password() => RuleFor(_ => _.Password).NotEmpty();
    }
}
