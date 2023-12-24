namespace Conselho.API
{
    public static class Configuracoes
    {
        public static SmtpConfiguracao Smtp = new SmtpConfiguracao();
        public class SmtpConfiguracao
        {
            public string Host { get; set; }
            public int Port { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}
