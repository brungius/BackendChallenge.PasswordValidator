using BackendChallenge.PasswordValidator.Core.DTOs;
using System.Threading.Tasks;

namespace BackendChallenge.PasswordValidator.Core.Interfaces
{
    public interface IPasswordService
    {
        Task<ValidateResult> Validate(string content);
    }
}
