using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace dotnet_rpg.Entities
{
    public class Dress
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = "sf";
        public string Color { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
