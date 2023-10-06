using Microsoft.AspNetCore.Mvc;

namespace JWT_advanced.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoginController : ControllerBase
{
    [HttpGet("Login")]
    public async Task<IActionResult> LoginAsync()
    {
        return Ok();
    }
}