using FluentValidation;
using System.Text.RegularExpressions;

namespace FoodInLoco.Application.Data.Models
{
    public abstract class UserModelValidator : AbstractValidator<UserModel>
    {
        public void Id() => RuleFor(user => user.Id).NotEmpty();

        public void FirstName() => RuleFor(user => user.FirstName).NotEmpty();

        public void LastName() => RuleFor(user => user.LastName).NotEmpty();

        public void Email() => RuleFor(user => user.Email).EmailAddress();

        public void DDD() => RuleFor(user => user.DDD)
            .Length(2).WithMessage("DDD precisa ter 2 caracteres.")
            .Matches(new Regex(@"\d{2}")).WithMessage("DDD inv�lido.");

        public void PhoneNumber() => RuleFor(user => user.PhoneNumber)
            .NotNull().WithMessage("Telefone � obrigat�rio.")
            .NotEmpty().WithMessage("Telefone n�o pode estar vazio.")
            .MinimumLength(8).WithMessage("Telefone precisa ter pelo menos 8 caracteres.")
            .MaximumLength(9).WithMessage("Telefone n�o pode ter mais de 9 caracteres.")
            .Matches(new Regex(@"(?:[1-9]|9[1-9])[0-9]{3}\-?[0-9]{4}$")).WithMessage("Telefone inv�lido.");

        public void Roles() => RuleFor(auth => auth.Roles).NotEmpty();

        public void Password() => RuleFor(auth => auth.Password).NotEmpty();
    }
}