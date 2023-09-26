using Microsoft.AspNetCore.Mvc;

namespace Soldaria.TemplateSolidaria.EntryPoint.Web.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class Example : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello world");
        }
    }
}
