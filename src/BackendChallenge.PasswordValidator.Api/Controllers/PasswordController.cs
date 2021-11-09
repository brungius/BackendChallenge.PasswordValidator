using BackendChallenge.PasswordValidator.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendChallenge.PasswordValidator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordController : ControllerBase
    {
        private readonly IPasswordService _passwordService;

        public PasswordController(IPasswordService passwordService)
        {
            _passwordService = passwordService;
        }

        [Route("validate")]
        [HttpPost]
        public async Task<IActionResult> Validate(string content)
        {
            var result = await _passwordService.Validate(content);

            if (!result.IsValid)
            {
                return BadRequest(result.ValidationError);
            }

            return Ok(content);
        }
    }
}
