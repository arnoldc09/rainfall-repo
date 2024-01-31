using Microsoft.AspNetCore.Mvc;

namespace RainfallApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RainfallController : ControllerBase
    {
        public RainfallController()
        {
        }

        [HttpGet("id/{stationId}/readings")]
        public async Task<ActionResult<IActionResult>> GetRainfall(string stationId, [FromQuery] int count = 10)
        {
            return Ok();
        }
    }
}
