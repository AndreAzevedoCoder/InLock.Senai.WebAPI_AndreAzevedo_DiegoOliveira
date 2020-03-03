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

                string select = "EXEC SP_ListarTodosJogos;";

                using (SqlCommand command = new SqlCommand(select, connection))
                {
                    connection.Open();
                    SqlDataReader reader;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        JogoDomain jogo = new JogoDomain
                        {
                            ID_JOGO = Convert.ToInt32(reader["ID_JOGO"]),
                            NOME_JOGO = (reader["NOME_JOGO"]).ToString(),
                            DESCRICAO = (reader["DESCICAO"]).ToString(),
                            DATA_LANCAMENTO = Convert.ToDateTime(reader["DATA_LANCAMENTO"]),
                            VALOR = float.Parse(reader["VALOR"].ToString()),
                            ID_ESTUDIO = Convert.ToInt32(reader["ID_ESTUDIO"])
                        };
                        jogos.Add(jogo);
                    }
                }
            }
            return jogos;
        }

        public List<JogoDomain> ListarJogosEstudio()
        {
            List<JogoDomain> jogos = new List<JogoDomain>();

            using (SqlConnection connection = new SqlConnection(StringConexaoDiegoSala))
            {
                string select = "EXEC SP_ListarJogosEstudios;";

                using (SqlCommand command = new SqlCommand(select, connection))
                {
                    connection.Open();
                    SqlDataReader reader;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        JogoDomain jogo = new JogoDomain
                        {
                            ID_JOGO = Convert.ToInt32(reader["ID_JOGO"]),
                            NOME_JOGO = (reader["NOME_JOGO"]).ToString(),
                            DESCRICAO = (reader["DESCICAO"]).ToString(),
                            DATA_LANCAMENTO = Convert.ToDateTime(reader["DATA_LANCAMENTO"]),
                            VALOR = float.Parse(reader["VALOR"].ToString()),
                            ID_ESTUDIO = Convert.ToInt32(reader["ID_ESTUDIO"]),
                            NOME_ESTUDIO = (reader["NOME_ESTUDIO"]).ToString()
                        };
                        jogos.Add(jogo);
                    }
                }
            }
            return jogos;
        }

        public void CadastrarJogo(JogoDomain Jogo)
        {
            using (SqlConnection connection = new SqlConnection(StringConexaoDiegoSala))
            {
                string insert = "SP_CadastrarJogo @Nome, @Descricao, @Data_Lancamento, @Valor, @Id_Estudio;";
                using (SqlCommand command = new SqlCommand(insert, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Nome", Jogo.NOME_JOGO);
                    command.Parameters.AddWithValue("@Descricao", Jogo.DESCRICAO);
                    command.Parameters.AddWithValue("@Data_Lancamento", Jogo.DATA_LANCAMENTO);
                    command.Parameters.AddWithValue("@Valor", Jogo.VALOR);
                    command.Parameters.AddWithValue("@Id_Estudio", Jogo.ID_ESTUDIO);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void CadastrarEstudio(EstudioDomain Estudio)
        {
            using (SqlConnection connection = new SqlConnection(StringConexaoDiegoSala))
            {
                string insert = "EXEC SP_CadastrarEstudio @Nome;";
                using (SqlCommand command = new SqlCommand(insert, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Nome", Estudio.NOME_ESTUDIO);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
