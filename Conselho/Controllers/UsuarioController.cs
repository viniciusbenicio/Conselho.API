using Conselho.API.Data;
using Conselho.API.Models;
using Conselho.API.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Conselho.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        [Route("v1/GetByIdAsync")]
        [HttpGet]
        public async Task<Usuario> GetByIdAsync(int id)
        {
            var usuario = await _usuarioRepository.GetUsuarioAsync(id);

            return usuario;
        }
    }
}
