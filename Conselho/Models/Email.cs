namespace Conselho.API.Models
{
    public class Email
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public Usuario Usuario { get; set;}
    }
}
