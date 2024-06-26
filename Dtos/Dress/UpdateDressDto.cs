using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Dtos.Dress
{
    public class UpdateDressDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "sf";
        public string Color { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}