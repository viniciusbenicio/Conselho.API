﻿using Conselho.API.Data;
using Conselho.API.Models;
using Conselho.API.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Conselho.API.Controllers
{
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IRepository<Usuario> _usuarioRepository;

        public UsuarioController(IRepository<Usuario> usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
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
        public IActionResult PostUsuario(string nome)
        {
            var user = new Usuario(nome);

            if (String.IsNullOrEmpty(nome))
                return NotFound();

            _usuarioRepository.Add(user);

            return Ok();
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