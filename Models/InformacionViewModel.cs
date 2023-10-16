namespace PaginaWebCSharp.Models
{
    public class InformacionViewModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Turno TurnoSelect { get; set; }
        public string Comentario { set; get; }

    }

    public enum Turno
    {
        Matutino,
        Vespertino
    }
}
