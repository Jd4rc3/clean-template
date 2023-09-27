using Soldaria.TemplateSolidaria.Domain.Model;
using Soldaria.TemplateSolidaria.Domain.UseCase.Ports;

namespace Soldaria.TemplateSolidaria.DrivenAdapter.SqlServer;

public class UserAdapter : IUserRepository
{
    private readonly Context _context;

    public UserAdapter(Context context)
    {
        _context = context;
    }

    public async Task<User> AddAsync(User user)
    {
        var newUser = await _context.User.AddAsync(user);

        await _context.SaveChangesAsync();

        return newUser.Entity;
    }
}