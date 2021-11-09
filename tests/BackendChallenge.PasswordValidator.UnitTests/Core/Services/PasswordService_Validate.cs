using BackendChallenge.PasswordValidator.Core.Interfaces;
using BackendChallenge.PasswordValidator.Core.Services;
using System.Threading.Tasks;
using Xunit;

namespace BackendChallenge.PasswordValidator.UnitTests.Core.Services
{
    public class PasswordService_Validate
    {
        private readonly IPasswordService _passwordService;

        public PasswordService_Validate()
        {
            _passwordService = new PasswordService();
        }

        [Theory]
        [InlineData("")]
        [InlineData("aa")]
        [InlineData("ab")]
        [InlineData("AAAbbbCc")]
        [InlineData("AbTp9!foo")]
        [InlineData("AbTp9!foA")]
        [InlineData("AbTp9 fok")]
        public async Task ReturnFalseGivenInvalidContent(string content)
        {
            var validationResult = await _passwordService.Validate(content);

            Assert.False(validationResult.IsValid);
        }


        [Theory]
        [InlineData("AbTp9!fok")]       
        public async Task ReturnTrueGivenValidContent(string content)
        {
            var validationResult = await _passwordService.Validate(content);

            Assert.True(validationResult.IsValid);
        }
    }
}
