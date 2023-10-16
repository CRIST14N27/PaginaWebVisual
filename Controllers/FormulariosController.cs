using Microsoft.AspNetCore.Mvc;
using PaginaWebCSharp.Models;
using System.Net;
using System.Net.Mail;

namespace PaginaWebCSharp.Controllers
{
    public class FormulariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            InformacionViewModel vista = new InformacionViewModel();
            return View(vista);
        }


        [HttpPost]
        public IActionResult EnviarCorreo(string email, string Comentario)
        {
            TempData["Email"] = email;
            TempData["Comentario"] = Comentario;

            return View("Contacto");
        }

        [HttpPost]
        public IActionResult EnviarInformacion(InformacionViewModel model)
        {
            TempData["Nombre"] = model.Nombre;
            TempData["Apellido"] = model.Apellido;
            TempData["Email"] = model.Email;
            TempData["FechaNacimiento"] = model.FechaNacimiento;
            TempData["TurnoSelect"] = model.TurnoSelect;
            TempData["Comentario"] = model.Comentario;

            SendEmail(model);
            return View("Contacto", model);
        }

        public bool SendEmail(InformacionViewModel model)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient("mail.shapp.mx", 587);

            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("moises.puc@shapp.mx", "Dhaserck_999");

            mail.From = new MailAddress("moises.puc@shapp.mx", "Administrador");
            mail.To.Add(model.Email);
            mail.Subject = "Notificacion de Contacto";
            mail.IsBodyHtml = true;
            mail.Body = $"Se ha recibdo informacion del correo <h1>{model.Email}</h1> <br/> <p>{model.Nombre}</p> <br/> <p>{model.Apellido}</p> <br/> <p>{model.FechaNacimiento}</p> <br/> <p>{model.TurnoSelect}</p> <br/> <p>{model.Comentario}</p>";

            smtp.Send(mail);
            return true;
        }
    }
}
