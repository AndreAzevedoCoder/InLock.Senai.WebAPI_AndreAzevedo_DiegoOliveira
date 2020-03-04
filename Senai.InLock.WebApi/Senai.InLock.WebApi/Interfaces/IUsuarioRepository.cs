using Senai.InLock.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Interfaces
{
    /// <summary>
    /// Interface resposável pelo repositório de Usuários
    /// </summary>
    interface IUsuarioRepository
    {
        /// <summary>
        /// Lista Todos os usuários cadastrados
        /// </summary>
        /// <returns></returns>
        //List<UsuarioDomain> ListarTodosUsuarios();

        /// <summary>
        /// Busca o usuário cadastrado com determinado email e senha
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="Senha"></param>
        /// <returns></returns>
        UsuarioDomain BuscarUsuarioPorEmailSenha(string Email, string Senha);
    }
}
