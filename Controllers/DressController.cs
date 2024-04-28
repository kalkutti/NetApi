using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Entities;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    public class DressController : ControllerBase
    {
        private static Dress dress = new Dress();

        public IActionResult Get() { return Ok(dress); }
    }
}