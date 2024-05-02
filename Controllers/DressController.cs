using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Entities;
using dotnet_rpg.Dtos.Dress;

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
        public async Task<ActionResult<ServiceResponse<List<GetDressDto>>>> Get() {
            return Ok(await _dressService.GetAllDresses()); 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetDressDto>>> GetSingle(int id) {
            return Ok(await _dressService.GetDressById(id)); 
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetDressDto>>>> AddDress(AddDressDto newDress) {
            return Ok(await _dressService.AddDress(newDress)); 
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<GetDressDto>>>> Updateress(UpdateDressDto updatedDress) {
            var response = await _dressService.UpdateDress(updatedDress);
            if (response.Data is null)
                return NotFound(response);
            return Ok(response); 
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<GetDressDto>>> DeleteDress(int id) {
            var response = await _dressService.DeleteDress(id);
            if (response.Data is null)
                return NotFound(response);
            return Ok(response);
        }
    }
}