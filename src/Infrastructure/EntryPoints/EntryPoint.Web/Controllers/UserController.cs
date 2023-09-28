using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Soldaria.TemplateSolidaria.Domain.Model;
using Soldaria.TemplateSolidaria.Domain.UseCase;
using Soldaria.TemplateSolidaria.EntryPoint.Web.Dtos;

namespace Soldaria.TemplateSolidaria.EntryPoint.Web.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> NewUser(
        [FromBody] UserDto user,
        [FromServices] IUseCase<Task<User>, User> useCase)
    {
        _logger.LogInformation("Creating new user {@User}", user);

        var newUser = await useCase.Execute(user.ToDomain());

        _logger.LogInformation("User created successfully  {@NewUser}", newUser);
        return CreatedAtAction(nameof(NewUser), newUser);
    }
}