using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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

    public class JogosController : ControllerBase
    {
        private IJogoRepository _jogoRepository { get; set; }

        public JogosController()
        {
            _jogoRepository = new JogoRepository();
        }

        [Authorize]
        [HttpGet("allGames")]
        public IActionResult ListarJogosEstudios()
        {
            return StatusCode(200, _jogoRepository.ListarJogosEstudio());
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost("newGame")]
        public IActionResult CadstrarJogo(JogoDomain Jogo)
        {
            _jogoRepository.CadastrarJogo(Jogo);
            return StatusCode(201);
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost("newStudio")]
        public IActionResult CadastrarEstudio(EstudioDomain Estudio)
        {
            _jogoRepository.CadastrarEstudio(Estudio);
            return StatusCode(201);
        }
    }
}
