using Microsoft.AspNetCore.Mvc;

namespace JWT_advanced.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RefreshController : ControllerBase
{
    [HttpPost("Refresh")]
    public async Task<IActionResult> RefreshAsync()
    {
        return Ok();
    }
}