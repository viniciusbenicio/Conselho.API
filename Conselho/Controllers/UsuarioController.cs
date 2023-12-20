using Conselho.API.Models;
using Conselho.API.Repository.Interfaces;
using Conselho.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Conselho.API.Controllers
{
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IRepository<Usuario> _usuarioRepository;
        private readonly IRepository<Slip> _adviceSlipRepository;
        private readonly IAdviceSlipServices _adviceSlipServices;

        public UsuarioController(IRepository<Usuario> usuarioRepository, IAdviceSlipServices adviceSlipServices, IRepository<Slip> adviceSlipRepository)
        {
            _usuarioRepository = usuarioRepository;
            _adviceSlipServices = adviceSlipServices;
            _adviceSlipRepository = adviceSlipRepository;
        }

        [HttpGet("v1/usuarios")]
        public IActionResult GetUsuarios()
        {
            var usuarios = _usuarioRepository.GetAll();


            return Ok(usuarios);
        }

        [HttpGet("v1/usuarios/{Id}")]
        public IActionResult GetUsuariosById(int Id)
        {
            var usuarios = _usuarioRepository.GetById(Id);
            if (usuarios == null)
                return NotFound();

            return Ok(usuarios);
        }

        [HttpPost("v1/usuarios")]
        public IActionResult PostUsuario(string Nome)
        {
           var result =  _adviceSlipServices.GetAdviceAsync().Result;

            var user = new Usuario(Nome)
            {
                Nome = Nome,
                //Conselho = result.Slip.Advice
            };

            var slip = new Slip()
            {
                IdSlip = result.Conselho.IdSlip,
                Usuario = user,
                Conselho = result.Conselho.Conselho
            };

            user.Id = 0;

            if (String.IsNullOrEmpty(Nome))
                return NotFound();

            _adviceSlipRepository.Add(slip);

            _usuarioRepository.Add(user);

            return Ok(user);
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
