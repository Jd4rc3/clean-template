using Microsoft.AspNetCore.Mvc;
using Soldaria.TemplateSolidaria.Domain.Model;
using Soldaria.TemplateSolidaria.Domain.UseCase;
using Soldaria.TemplateSolidaria.EntryPoint.Web.Dtos;

namespace Soldaria.TemplateSolidaria.EntryPoint.Web.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class UserController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> NewUser(
        [FromBody] UserDto user,
        [FromServices] IUseCase<Task<User>, User> useCase)
    {
        var newUser = await useCase.Execute(user.ToDomain());

        return CreatedAtAction(nameof(NewUser), newUser);
    }
}