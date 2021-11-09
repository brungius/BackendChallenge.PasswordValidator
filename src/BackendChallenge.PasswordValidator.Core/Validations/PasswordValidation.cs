using BackendChallenge.PasswordValidator.Core.Models;
using FluentValidation;
using System.Linq;

namespace BackendChallenge.PasswordValidator.Core.Validations
{
    public class PasswordValidation : AbstractValidator<Password>
    {
        const string SPECIAL_CHARS = "!@#$%^&*()-+";
        public PasswordValidation()
        {
            RuleFor(c => c.Content)                
                .MinimumLength(9).WithMessage("Nove ou mais caracteres")
                .Must(x => x.Any(c => char.IsDigit(c))).WithMessage("Ao menos 1 dígito")
                .Must(x => x.Any(c => !char.IsUpper(c))).WithMessage("Ao menos 1 letra minúscula")
                .Must(x => x.Any(c => char.IsUpper(c))).WithMessage("Ao menos 1 letra maiúscula")
                .Must(x => x.Any(c => SPECIAL_CHARS.Contains(c))).WithMessage("Ao menos 1 caractere especial")
                .Must(x => x.Distinct().ToList().Count == x.Length).WithMessage("Não possuir caracteres repetidos dentro do conjunto");
        }
    }
}
