using Microsoft.AspNetCore.Mvc;
using PaginaWebCSharp.Models;

namespace PaginaWebCSharp.Controllers
{
    public class EjemploController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contacto()
        {
            Persona persona = new Persona();
            persona.Nombre = "Christian";
            persona.Apellidos = "Cauich";
            persona.FechaNacimiento = new DateTime(2003, 09, 15);

            return View(persona);
        }
    }
}
