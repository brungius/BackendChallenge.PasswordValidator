using System.Collections.Generic;

namespace BackendChallenge.PasswordValidator.Core.DTOs
{
    public class ValidateResult
    {

        public bool IsValid { get; private set; }
        public List<string> ValidationError { get; private set; }

        public ValidateResult(bool isValid, List<string> validationError)
        {
            IsValid = isValid;
            ValidationError = validationError;
        }

    }
}
