using Soldaria.TemplateSolidaria.Domain.Model;
using Soldaria.TemplateSolidaria.Domain.UseCase;
using Soldaria.TemplateSolidaria.Domain.UseCase.Ports;
using Soldaria.TemplateSolidaria.DrivenAdapter.SqlServer;

namespace Soldaria.TemplateSolidaria.Application.Host.Extensions;

public static class Services
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IUseCase<Task<User>, User>, CreateUserUseCase>();
        services.AddScoped<IUserRepository, UserAdapter>();

        return services;
    }
}