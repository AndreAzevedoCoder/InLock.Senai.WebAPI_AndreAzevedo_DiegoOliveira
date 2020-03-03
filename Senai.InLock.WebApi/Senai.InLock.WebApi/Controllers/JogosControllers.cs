using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]

    public class JogosControllers : ControllerBase
    {
        private JogoRepository _jogoRepository { get; set; }

        public JogosControllers()
        {
            _jogoRepository = new JogoRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return StatusCode(200, _jogoRepository.Listar());
        }

        [HttpPost]
        public IActionResult Cadstrar(JogoDomain jogo)
        {
            return StatusCode(200, _jogoRepository.Cadastrar(jogo));
        }


    }
}
