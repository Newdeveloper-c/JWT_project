using Microsoft.AspNetCore.Mvc;

namespace JWT_advanced.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RegistrationController : ControllerBase
{
    [HttpPost("Registration")]
    public async Task<IActionResult> RegisterAsync()
    {
        return Ok();
    }
}
