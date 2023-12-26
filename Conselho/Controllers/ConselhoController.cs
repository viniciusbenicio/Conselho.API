using Conselho.API.Data.DTO;
using Conselho.API.Models;
using Conselho.API.Repository.Interfaces;
using Conselho.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Conselho.API.Controllers
{
    /// <summary>
    /// Controller de Conselhos
    /// </summary>
    [ApiController]
    public class ConselhoController : ControllerBase
    {
        private readonly IUsuarioConselhoRepository _usuarioConselhoRepository;
        private readonly IRepository<Usuario> _usuarioRepository;
        private readonly IRepository<Slip> _adviceSlipRepository;
        private readonly IAdviceSlipServices _adviceSlipServices;
        private readonly ITraducaoServices _traducaoServices;
        private readonly IEmailServices _emailServices;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="usuarioConselhoRepository"></param>
        /// <param name="usuarioRepository"></param>
        /// <param name="adviceSlipServices"></param>
        /// <param name="adviceSlipRepository"></param>
        /// <param name="traducaoServices"></param>
        /// <param name="emailServices"></param>
        public ConselhoController(IUsuarioConselhoRepository usuarioConselhoRepository, IRepository<Usuario> usuarioRepository, IAdviceSlipServices adviceSlipServices, IRepository<Slip> adviceSlipRepository, ITraducaoServices traducaoServices, IEmailServices emailServices)
        {
            _usuarioConselhoRepository = usuarioConselhoRepository;
            _usuarioRepository = usuarioRepository;
            _adviceSlipServices = adviceSlipServices;
            _adviceSlipRepository = adviceSlipRepository;
            _traducaoServices = traducaoServices;
            _emailServices = emailServices;
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

        /// <summary>
        /// Irá criar um novo conselho para o usuário que será passado no body e será disparado para o e-mail informado.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("v1/conselhos")]
        public IActionResult PostNovoConselhoUsuario([FromBody] UsuarioDTO model)
        {
            var usuario = _usuarioRepository.GetAll().FirstOrDefault(x => x.Nome == model.Nome);


            if (usuario == null)
                return NoContent();

            var novoConselho = _adviceSlipServices.GetAdviceAsync().Result;

            if(novoConselho == null)
                return NoContent();


            var traducao = _traducaoServices.RealizarTraducao(novoConselho.Conselho.Conselho).Result;

            Slip slip = new Slip()
            {
                IdSlip = novoConselho.Conselho.IdSlip,
                Conselho = traducao,
                Usuario = usuario
            };

            _adviceSlipRepository.Add(slip);

            _emailServices.Enviar("API Conselho ", "vinicius.benicio97@gmail.com", "Conselho", slip.Conselho, usuario.Nome, "vinicius.benicio97@gmail.com");

            return Ok(usuario);

        }
    }
}
