using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Entities;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    public class DressController : ControllerBase
    {
        private static Dress dress = new Dress();
        
        [HttpGet]
        public ActionResult<Dress> Get() { return Ok(dress); }
    }
}