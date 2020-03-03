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
<<<<<<< HEAD
<<<<<<< HEAD
        List<JogoDomain> Listar();
        void Cadastrar(JogoDomain jogo);
=======
=======
>>>>>>> master
        /// <summary>
        /// Lista todos os jogos cadastrados
        /// </summary>
        /// <returns></returns>
        List<JogoDomain> ListarTodosJogos();

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
        JogoDomain BuscarJogoPorId(int Id);

        /// <summary>
        /// Cadastra um novo Jogo
        /// </summary>
        /// <param name="Nome"></param>
        /// <param name="Descricao"></param>
        /// <param name="DataLancamento"></param>
        /// <param name="Valor"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        JogoDomain CadastrarJogo(string Nome, string Descricao, DateTime DataLancamento, float Valor, int Id);
<<<<<<< HEAD
>>>>>>> 378b783d379ff2a6503f6de806906786e9316728
=======
>>>>>>> master
    }
}
