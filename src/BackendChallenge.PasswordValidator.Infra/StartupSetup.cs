using BackendChallenge.PasswordValidator.Core.Interfaces;
using BackendChallenge.PasswordValidator.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BackendChallenge.PasswordValidator.Infra
{
    public static class StartupSetup
    {
        public static void AddDomainServices(this IServiceCollection services) =>
           services.AddScoped<IPasswordService, PasswordService>();
    }
    }
