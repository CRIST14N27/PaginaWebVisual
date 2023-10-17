using PaginaWebCSharp.Models;

namespace PaginaWebCSharp.Services
{
    public interface IEmailService
    {
        bool SendEmail(string email);

        bool SendEmailWithData(EmailData data);

        bool sendEmailWithoutData(string email);
    }
}
