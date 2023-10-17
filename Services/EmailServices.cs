using System.Net.Mail;
using System.Net;
using PaginaWebCSharp.Models;

namespace PaginaWebCSharp.Services
{
    public class EmailServices : IEmailService
    {
        public bool SendEmail(string email)
        {
            bool result = false;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("mail.shapp.mx", 587);

                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("moises.puc@shapp.mx", "Dhaserck_999");

                mail.From = new MailAddress("moises.puc@shapp.mx", "Administrador");
                mail.To.Add(email);
                mail.Subject = "Notificacion de Contacto";
                mail.IsBodyHtml = true;
                mail.Body = $"Se ha recibdo informacion del correo <h1>{email}</h1>";

                smtp.Send(mail);
                return true;
            }
            catch (Exception e)
            {

            }
            return result;

        }

        public bool SendEmailWithData(EmailData data)
        {
            bool result = false;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("mail.shapp.mx", 587);

                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("moises.puc@shapp.mx", "Dhaserck_999");

                mail.From = new MailAddress("moises.puc@shapp.mx", "Administrador");
                mail.To.Add(data.Email);
                mail.Subject = data.Subject;
                mail.IsBodyHtml = true;
                mail.Body = data.Content;

                smtp.Send(mail);
                return true;
            }
            catch (Exception e)
            {

            }
            return result;
        }

        public bool sendEmailWithoutData(string email)
        {
            throw new NotImplementedException();
        }
    }
}
