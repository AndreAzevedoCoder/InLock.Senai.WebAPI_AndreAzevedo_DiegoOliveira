using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Domains
{
    /// <summary>
    /// Domain da tabela de Usuários
    /// </summary>
    public class UsuarioDomain
    {
        public int ID_USUARIO { get; set; }
        public string APELIDO { get; set; }

        [Required(ErrorMessage = "Informe o Email")]
        [DataType(DataType.EmailAddress)]
        public string EMAIL { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "O campo precisa ter no mínimo 3 caracteres")]
        public string SENHA { get; set; }

        public int ID_TipoUsuario { get; set; }
        public string NOME_TIPO { get; set; }
    }
}
