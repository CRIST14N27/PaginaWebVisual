using System.ComponentModel.DataAnnotations;

namespace PaginaWebCSharp.Models
{
    public class Curriculum
    {
        [Required(ErrorMessage = "El campo nombre es requerido")]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres")]
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        [Required (ErrorMessage = "El campo CURP es requeriso")]
        public string CURP { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "La fecha de nacimineto es obligatorio.")]
        public DateTime FechaNacimineto { get; set; }
        public string Direccion { get; set; }
        [Range(0,100)]
        public int PorcentajeIngles { get; set; }
        public IFormFile? Foto {  get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Es necesario que ponga su correo")]
        public string Email { get; set; }
    }
}
