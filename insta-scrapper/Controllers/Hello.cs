using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace insta_scrapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Hello : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHello()
        {
            var content = new { Hello = "World" };
            return Ok(content);
        }
    }
}
