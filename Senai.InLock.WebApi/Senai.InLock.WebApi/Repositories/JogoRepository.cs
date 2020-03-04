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
        private string StringConexaoDiegoSala = "Data Source=DEV16\\SQLEXPRESS; initial catalog=Senai.InLock; user Id=sa; pwd=sa@132;";
        private string StringConexaoDiegoCasa = "Data Source=VELSTADT\\SQLEXPRESS; initial catalog=InLock_Games_Manha; integrated security=true;";        
        public List<JogoDomain> ListarJogosEstudio()
        {
            List<JogoDomain> jogos = new List<JogoDomain>();

            using (SqlConnection connection = new SqlConnection(StringConexaoDiegoCasa))
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
                            ID_JOGO = Convert.ToInt32(reader["CÓDIGO DO JOGO"]),
                            NOME_JOGO = (reader["NOME DO JOGO"]).ToString(),
                            DESCRICAO = (reader["DESCRIÇÃO"]).ToString(),
                            DATA_LANCAMENTO = Convert.ToDateTime(reader["DATA DE LANÇAMENTO"]),
                            VALOR = float.Parse(reader["PREÇO"].ToString()),
                            ID_ESTUDIO = Convert.ToInt32(reader["CÓDIGO DO ESTÚDIO"]),
                            ESTUDIO = new EstudioDomain
                            {
                                ID_ESTUDIO = Convert.ToInt32(reader["CÓDIGO DO ESTÚDIO"]),
                                NOME_ESTUDIO = (reader["ESTÚDIO"]).ToString()
                            }
                        };
                        jogos.Add(jogo);
                    }
                }
            }
            return jogos;
        }

        public void CadastrarJogo(JogoDomain Jogo)
        {
            using (SqlConnection connection = new SqlConnection(StringConexaoDiegoCasa))
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
            using (SqlConnection connection = new SqlConnection(StringConexaoDiegoCasa))
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
