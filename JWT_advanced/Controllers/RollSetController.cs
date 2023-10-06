using Microsoft.AspNetCore.Mvc;

namespace JWT_advanced.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RollSetController : ControllerBase
{
    [HttpPost("RollSet")]
    public async Task<IActionResult> RollSetAsync()
    {
        return Ok();
    }
}