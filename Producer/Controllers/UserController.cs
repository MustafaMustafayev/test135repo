using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Producer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Add()
        {
            return Ok();
        }
    }
}
