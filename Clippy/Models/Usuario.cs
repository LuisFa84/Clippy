using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Clippy.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es obligatorio")]
        public string? Apellido { get; set; }
        
        [Required(ErrorMessage = "El Contacto es obligatorio")]
        public string? Contacto { get; set; }
        
        [Required(ErrorMessage = "El Email es obligatorio")]
        public string? Email { get; set; }
        
    }
}
