using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba2.Models
{
    public class Usuarios
    {
        [Key]
        public int? UsuarioId { get; set; }
        //Ponemos mensaje de error con Data anotations
        [Required(ErrorMessage ="Se requiere ingresar el nombre")]
        public string Nombre { get; set; }

        //con este le indicamos que debe modificar el nombre a mostrar
        [Display(Name = "Primer apellido")]
        [Required(ErrorMessage = "Se requiere ingresar el Apellido")]
        public string ApellidoPater { get; set; }

        [Display(Name = "Segundo apellido")]
        [Required(ErrorMessage = "Se requiere ingresar el Apellido")]
        public string ApellidoMater { get; set; }

        [Required(ErrorMessage = "Se requiere ingresar su número de celular")]
        public string Celular { get; set; }

        [ForeignKey("Sede")]

        [Display(Name = "ID Sede")]
        public int? SedeId { get; set; }
        public Sede? Sede { get; set; }
    }
}
