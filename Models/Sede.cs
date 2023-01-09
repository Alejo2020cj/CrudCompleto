using System.ComponentModel.DataAnnotations;

namespace Prueba2.Models
{
    public class Sede
    {
        [Key]
        public int? SedeId { get; set; }

        [Required(ErrorMessage = "Se requiere ingresar el nombre")]
        public string? Nombre { get; set;}
        public List<Usuarios>? Usuarios { get; set; }
    }
}
