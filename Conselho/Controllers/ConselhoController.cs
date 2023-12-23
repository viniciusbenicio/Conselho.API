using Conselho.API.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Conselho.API.Controllers
{
    [ApiController]
    public class ConselhoController : ControllerBase
    {
        private readonly IUsuarioConselhoRepository _usuarioConselhoRepository;
        public ConselhoController(IUsuarioConselhoRepository usuarioConselhoRepository)
        {
            _usuarioConselhoRepository = usuarioConselhoRepository;
        }

        [HttpGet("v1/conselhos/{Id}")]
        public IActionResult GetUsuarioConselhoById(int Id)
        {
            var usuario = _usuarioConselhoRepository.GetByIdUsuarioConselho(Id);
            if (usuario == null)
                return NoContent();

            return Ok(usuario);
        }
    }
}
