namespace Conselho.API.Models
{
    public class Usuario
    {
        public Usuario(string nome)
        {
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }

       
    }
}
