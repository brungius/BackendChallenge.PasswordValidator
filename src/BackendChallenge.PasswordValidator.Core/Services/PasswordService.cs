using BackendChallenge.PasswordValidator.Core.DTOs;
using BackendChallenge.PasswordValidator.Core.Interfaces;
using BackendChallenge.PasswordValidator.Core.Models;
using BackendChallenge.PasswordValidator.Core.Validations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendChallenge.PasswordValidator.Core.Services
{
    public class PasswordService : IPasswordService
    {
        public async Task<ValidateResult> Validate(string content)
        {
            var password = new Password(content);
            var validator = new PasswordValidation();

            var validationResult = await validator.ValidateAsync(password);

            return new ValidateResult(validationResult.IsValid,
                validationResult.Errors.Select(x => x.ErrorMessage).ToList());            
        }        
    }
}
