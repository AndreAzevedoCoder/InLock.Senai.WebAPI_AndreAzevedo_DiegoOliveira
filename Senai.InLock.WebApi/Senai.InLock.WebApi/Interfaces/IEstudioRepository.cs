using Senai.InLock.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório de Estúdios
    /// </summary>
    interface IEstudioRepository
    {
        /// <summary>
        /// Lista todos os estúdios
        /// </summary>
        /// <returns></returns>
        List<EstudioDomain> ListarTodosEstudios();

        /// <summary>
        /// Lista todos os estúdios e os jogos que produziu
        /// </summary>
        /// <returns></returns>
        List<EstudioDomain> ListarEstudiosJogos();

        /// <summary>
        /// Lista o estúdio que tenha determinado ID
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        EstudioDomain BuscarJogoPorId(int Id);
    }
}
