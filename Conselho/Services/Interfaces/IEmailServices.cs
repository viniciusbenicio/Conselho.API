namespace Conselho.API.Services.Interfaces
{
    public interface IEmailServices
    {
        bool Enviar(string toName, string toEmail, string subject, string body, string fromName = "", string fromEmail = "");
    }
}
