using Senai.InLock.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Interfaces
{
    /// <summary>
    /// Interface respostável pelo repositório de Jogos
    /// </summary>
    interface IJogoRepository
    {
        /// <summary>
        /// Lista todos os jogos e seus respectivos estúdios
        /// </summary>
        /// <returns></returns>
        List<JogoDomain> ListarJogosEstudio();

        /// <summary>
        /// Lista todos os jogos com determinado ID
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        //JogoDomain BuscarJogoPorId(int Id);

        /// <summary>
        /// Cadastra um novo jogo
        /// </summary>
        /// <param name="Jogo"></param>
        void CadastrarJogo(JogoDomain Jogo);

        /// <summary>
        /// Cadastrar um novo estúdio
        /// </summary>
        /// <param name="Estudio"></param>
        void CadastrarEstudio(EstudioDomain Estudio);
    }
}
