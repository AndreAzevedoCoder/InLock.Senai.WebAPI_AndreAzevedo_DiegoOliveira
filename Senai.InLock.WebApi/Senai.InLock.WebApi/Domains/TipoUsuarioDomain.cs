using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Domains
{
    /// <summary>
    /// Domain da tabela de Tipos de Usuários
    /// </summary>
    public class TipoUsuarioDomain
    {
        public int ID_TipoUsuario { get; set; }
        public string NOME_TIPO { get; set; }
    }
}
