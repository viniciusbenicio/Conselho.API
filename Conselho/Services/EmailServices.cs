using Conselho.API.Services.Interfaces;
using System.Net;
using System.Net.Mail;

namespace Conselho.API.Services
{
    public class EmailServices : IEmailServices
    {
        public bool Enviar(string toName, string toEmail, string subject, string body, string fromName = "", string fromEmail = "")
        {
            var smptClient = new SmtpClient(Configuracoes.Smtp.Host, Configuracoes.Smtp.Port);

            smptClient.Credentials = new NetworkCredential(Configuracoes.Smtp.UserName, Configuracoes.Smtp.Password);
            smptClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smptClient.EnableSsl = true;

            var mail = new MailMessage();

            mail.From = new MailAddress(fromEmail, fromName);
            mail.To.Add(new MailAddress(toEmail, toName));
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            try
            {
                smptClient.Send(mail);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}
