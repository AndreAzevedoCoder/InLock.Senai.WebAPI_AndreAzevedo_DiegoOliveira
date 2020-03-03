using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Interfaces;
using Senai.InLock.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    public class JogosControllers : ControllerBase
    {
        private IJogoRepository _jogoRepository { get; set; }

        public JogosControllers()
        {
            Console.WriteLine("aaa");
            _jogoRepository = new JogoRepository();
        }

        [HttpGet]
        public IActionResult ListarTodosJogos()
        {
            Console.WriteLine("oooooooooooo");
            Console.WriteLine("oooooooooooo");
            Console.WriteLine("oooooooooooo");
            Console.WriteLine("oooooooooooo");
            Console.WriteLine("oooooooooooo");
            return StatusCode(200, _jogoRepository.ListarTodosJogos());
        }

        [HttpGet("/Jogos&Estudios")]
        public IActionResult ListarJogosEstudios()
        {
            return StatusCode(200, _jogoRepository.ListarJogosEstudio());
        }

        //[HttpPost]
        //public IActionResult Cadstrar(JogoDomain jogo)
        //{
        //    return StatusCode(200, _jogoRepository.Cadastrar(jogo));
        //}
    }
}
