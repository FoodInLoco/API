using FluentValidation;
using System.Text.RegularExpressions;

namespace FoodInLoco.Application.Data.Models
{
    public abstract class UserModelValidator : AbstractValidator<UserModel>
    {
        public void Id() => RuleFor(_ => _.Id).NotEmpty();

        public void FirstName() => RuleFor(_ => _.FirstName).MaximumLength(100).NotEmpty();

        public void LastName() => RuleFor(_ => _.LastName).MaximumLength(200).NotEmpty();

        public void Email() => RuleFor(_ => _.Email).MaximumLength(300).EmailAddress();

        public void Photo() => RuleFor(_ => _.Photo).MaximumLength(10000).NotEmpty();

        public void DDD() => RuleFor(_ => _.DDD)
            .Length(2).WithMessage("DDD precisa ter 2 caracteres.")
            .Matches(new Regex(@"\d{2}")).WithMessage("DDD inválido.");

        public void PhoneNumber() => RuleFor(_ => _.PhoneNumber)
            .NotNull().WithMessage("Telefone é obrigatório.")
            .NotEmpty().WithMessage("Telefone não pode estar vazio.")
            .MinimumLength(8).WithMessage("Telefone precisa ter pelo menos 8 caracteres.")
            .MaximumLength(9).WithMessage("Telefone não pode ter mais de 9 caracteres.")
            .Matches(new Regex(@"(?:[1-9]|9[1-9])[0-9]{3}\-?[0-9]{4}$")).WithMessage("Telefone inválido.");

        public void Roles() => RuleFor(_ => _.Roles).NotEmpty();

        public void Password() => RuleFor(_ => _.Password).NotEmpty();
    }
}
