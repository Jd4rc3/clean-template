using Soldaria.TemplateSolidaria.Domain.Model;

namespace Soldaria.TemplateSolidaria.EntryPoint.Web.Dtos;

public class UserDto
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string LastName { get; set; }

    public User ToDomain()
    {
        return new User { Id = Id, Name = Name, LastName = LastName };
    }
}