using Soldaria.TemplateSolidaria.Domain.Model;

namespace Soldaria.TemplateSolidaria.Domain.UseCase.Ports;

public interface IUserRepository
{
    Task<User> AddAsync(User user);
}