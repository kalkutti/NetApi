using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Entities;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    public class DressController : ControllerBase
    {
        private readonly IDressService _dressService;

        public DressController(IDressService dressService)
        {
            _dressService = dressService;
        }
        
        [HttpGet("GetAll")]
        public ActionResult<List<Dress>> Get() { return Ok(_dressService.GetAllDresses()); }

        [HttpGet("{id}")]
        public ActionResult<Dress> GetSingle(int id) { return Ok(_dressService.GetDressById(id)); }

        [HttpPost]
        public ActionResult<List<Dress>> AddDress(Dress newDress) { return Ok(_dressService.AddDress(newDress)); }
    }
}