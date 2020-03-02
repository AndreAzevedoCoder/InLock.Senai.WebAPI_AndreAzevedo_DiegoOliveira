using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        
        public List<JogoDomain> Listar()
        {

            List < JogoDomain > jogos = new List< JogoDomain >();

            return jogos;

        }
    }
}
