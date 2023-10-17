using Microsoft.AspNetCore.Mvc;
using PaginaWebCSharp.Models;

namespace PaginaWebCSharp.Controllers
{
    public class ValidacionesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EnviarInformacion(Curriculum model) 
        {
            string mensaje = "";

            if(ModelState.IsValid)
            {
                mensaje = "Datos Validos";
                TempData["msj"] = mensaje;
                return RedirectToAction("Index");
            }
            else
            {
                mensaje = "Dantos Incorrecto";
                TempData["msj"] = mensaje;

                return View("Index", model);
            }
        }
    }
}
