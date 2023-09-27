using Soldaria.TemplateSolidaria.Domain.Model;
using Soldaria.TemplateSolidaria.Domain.UseCase.Ports;

namespace Soldaria.TemplateSolidaria.Domain.UseCase;

public class CreateUserUseCase : IUseCase<Task<User>, User>
{
    private readonly IUserRepository _userRepository;

    public CreateUserUseCase(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> Execute(User user)
    {
        return await _userRepository.AddAsync(user);
    }
}