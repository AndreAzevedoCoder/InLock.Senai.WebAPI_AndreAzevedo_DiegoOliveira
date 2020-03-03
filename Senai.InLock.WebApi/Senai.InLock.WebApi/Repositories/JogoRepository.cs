using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private string StringConexaoDiegoSala = "Data Source=DEV16\\SQLEXPRESS; initial catalog=M_PEOPLES; user Id=sa; pwd=sa@132;";
        
        public List<JogoDomain> ListarTodosJogos()
        {
            List<JogoDomain> jogos = new List<JogoDomain>();

            using (SqlConnection connection = new SqlConnection(StringConexaoDiegoSala))
            {

            }
        }
    }
}
