using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Domains
{
    public class JogoDomain
    {
        public int ID_JOGO { get; set; }
        public string NOME_JOGO { get; set; }
        public string DESCRICAO { get; set; }
        public DateTime DATA_LANCAMENTO { get; set; }
        public float VALOR { get; set; }
        public int ID_ESTUDIO { get; set; }
        public EstudioDomain ESTUDIO { get; set; }
    }
}
