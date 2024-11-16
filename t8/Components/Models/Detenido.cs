using System.ComponentModel.DataAnnotations;

namespace t8.Models
{
    public class Detenido
    {
        public int Id { get; set; }
        [Required]
        public DateTime FechaDetencion { get; set; }
        [Required]
        public string NombreApellido { get; set; } = "";
        [Required]
        public string NumeroPasaporte { get; set; } = "";
        [Required]
        public DateTime FechaNacimiento { get; set; } 
        public string Coordenadas { get; set; } = "";
    }
}
