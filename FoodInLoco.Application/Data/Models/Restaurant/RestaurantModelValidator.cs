using FluentValidation;
using System.Text.RegularExpressions;

namespace FoodInLoco.Application.Data.Models
{
    public abstract class RestaurantModelValidator : AbstractValidator<RestaurantModelRequest>
    {
        public void Id() => RuleFor(_ => _.Id).NotEmpty();

        public void CompanyName() => RuleFor(_ => _.CompanyName)
            .MaximumLength(200).WithMessage("Raz�o Social n�o pode ter mais do que 200 caracteres.")
            .NotEmpty().WithMessage("� obrigat�rio preencher Raz�o Social.");

        public void TradingName() => RuleFor(_ => _.TradingName)
            .MaximumLength(300).WithMessage("Nome Fantasia n�o pode ter mais do que 300 caracteres.")
            .NotEmpty().WithMessage("� obrigat�rio preencher Nome Fantasia.");

        public void Email() => RuleFor(_ => _.Email)
            .MaximumLength(300).WithMessage("E-mail n�o pode ter mais do que 300 caracteres.")
            .EmailAddress().WithMessage("Formato de e-mail inv�lido.");

        public void Photo() => When(_ => !String.IsNullOrEmpty(_.Photo), () =>
        {
            RuleFor(_ => _.Photo)
                .MaximumLength(10000).WithMessage("Foto n�o pode ter mais do que 10000 caracteres.")
                .NotEmpty().WithMessage("� obrigat�rio preencher Foto.");
        });

        public void DDD() => RuleFor(_ => _.DDD)
            .Length(2).WithMessage("DDD precisa ter 2 caracteres.")
            .Matches(new Regex(@"\d{2}")).WithMessage("DDD inv�lido.");

        public void PhoneNumber() => RuleFor(_ => _.PhoneNumber)
            .NotNull().WithMessage("Telefone � obrigat�rio.")
            .NotEmpty().WithMessage("Telefone n�o pode estar vazio.")
            .MinimumLength(8).WithMessage("Telefone precisa ter pelo menos 8 caracteres.")
            .MaximumLength(9).WithMessage("Telefone n�o pode ter mais de 9 caracteres.")
            .Matches(new Regex(@"(?:[1-9]|9[1-9])[0-9]{3}\-?[0-9]{4}$")).WithMessage("Telefone inv�lido.");

        public void Kids() => RuleFor(_ => _.Kids)
            .NotNull().WithMessage("� obrigat�rio preencher espa�o para crian�a.");

        public void Password() => RuleFor(_ => _.Password).NotEmpty();
    }
}
