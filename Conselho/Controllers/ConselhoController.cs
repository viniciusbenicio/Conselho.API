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

        /// <summary>
        /// Retorna o Usuário pelo ID passado e os seus conselhos salvos.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
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
