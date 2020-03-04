using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Domains
{
    /// <summary>
    /// Domain da tabela de Jogos
    /// </summary>
    public class JogoDomain
    {
        public int ID_JOGO { get; set; }

        [Required(ErrorMessage = "Informe o nome do jogo")]
        public string NOME_JOGO { get; set; }

        [Required(ErrorMessage = "Descreva o jogo")]
        public string DESCRICAO { get; set; }

        [Required(ErrorMessage = "Defina a data de lançamento")]
        public DateTime DATA_LANCAMENTO { get; set; }

        [Required(ErrorMessage = "Quanto o jogo custa? (Se for gratuito, insira 0)")]
        public float VALOR { get; set; }

        [Required(ErrorMessage = "Informe o código do estúdio que produziu")]
        public int ID_ESTUDIO { get; set; }
        public EstudioDomain ESTUDIO { get; set; }
    }
}
