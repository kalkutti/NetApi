using dotnet_rpg.Entities;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private static Dress dress = new Dress();

        [HttpGet]
        public ActionResult<Dress> Get()
        {
            return Ok(dress);
        }
    }
}
