using Conselho.API.Models;
using Conselho.API.Repository.Interfaces;
using Conselho.API.Services;
using Conselho.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Conselho.API.Controllers
{
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IRepository<Usuario> _usuarioRepository;
        private readonly IRepository<Slip> _adviceSlipRepository;
        private readonly IRepository<Email> _emailRepository;
        private readonly IAdviceSlipServices _adviceSlipServices;
        private readonly IEmailServices _emailServices;

        public UsuarioController(IRepository<Usuario> usuarioRepository, IAdviceSlipServices adviceSlipServices, IRepository<Slip> adviceSlipRepository, IEmailServices emailServices, IRepository<Email> emailRepository)
        {
            _usuarioRepository = usuarioRepository;
            _adviceSlipServices = adviceSlipServices;
            _adviceSlipRepository = adviceSlipRepository;
            _emailServices = emailServices;
            _emailRepository = emailRepository;
        }

        [HttpGet("v1/usuarios")]
        public IActionResult GetUsuarios()
        {
            var usuarios = _usuarioRepository.GetAll();

            if (!usuarios.Any())
                return NoContent();


            return Ok(usuarios);
        }

        [HttpGet("v1/usuarios/{Id}")]
        public IActionResult GetUsuariosById(int Id)
        {
            var usuarios = _usuarioRepository.GetById(Id);
            if (usuarios == null)
                return NoContent();

            return Ok(usuarios);
        }

        [HttpPost("v1/usuarios")]
        public IActionResult PostUsuario(string Nome, string email)
        {

            var result = _adviceSlipServices.GetAdviceAsync().Result;

            var user = new Usuario(Nome)
            {
                Nome = Nome,
            };

            var slip = new Slip()
            {
                IdSlip = result.Conselho.IdSlip,
                Usuario = user,
                Conselho = result.Conselho.Conselho
            };

            var mail = new Email()
            {
                Endereco = email,
                Usuario = user,
            };


            if (String.IsNullOrEmpty(Nome))
                return NotFound();

            _usuarioRepository.Add(user);
            _adviceSlipRepository.Add(slip);
            _emailRepository.Add(mail);

            _emailServices.Enviar("API Conselho ", mail.Endereco, "Conselho", slip.Conselho, user.Nome, "vinicius.benicio97@gmail.com");


            return Ok($"Usuario registrado com sucesso: {user.Nome} ");
        }

        [HttpPut("v1/usuarios/{Id}")]
        public IActionResult PutUsuario(int Id)
        {
            var user = _usuarioRepository.GetById(Id);

            if (user == null)
                return NotFound();


            _usuarioRepository.Update(user);

            return Ok();
        }

        [HttpDelete("v1/usuarios/{Id}")]
        public IActionResult DeleteUsuario(int Id)
        {
            var user = _usuarioRepository.GetById(Id);

            if (user == null)
                return NotFound();

            _usuarioRepository.Delete(user);

            return Ok();
        }

    }
}
