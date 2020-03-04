using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Domains
{
    /// <summary>
    /// Domain da tabela de Estúdios
    /// </summary>
    public class EstudioDomain
    {
        public int ID_ESTUDIO { get; set; }

        [Required(ErrorMessage = "Informe o nome do estúdio")]
        public string NOME_ESTUDIO { get; set; }
    }
}
