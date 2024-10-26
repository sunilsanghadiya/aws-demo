using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aws_demo.Controllers
{
    [Route("/")]
    [ApiController]
    public class HomeController : Controller
    {
        public HomeController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to aws demo");
        }
    }
}
