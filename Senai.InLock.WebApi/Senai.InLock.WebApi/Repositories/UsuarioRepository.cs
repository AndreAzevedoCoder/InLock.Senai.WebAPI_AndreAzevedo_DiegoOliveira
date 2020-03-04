using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Repositories
{
    /// <summary>
    /// Repostório de usuários
    /// </summary>
    public class UsuarioRepository : IUsuarioRepository
    {
        private string StringConexaoDiegoCasa = "Data Source=VELSTADT\\SQLEXPRESS; initial catalog=InLock_Games_Manha; integrated security=true;";
        

        public UsuarioDomain BuscarUsuarioPorEmailSenha (string Email,string Senha)
        {
            using(SqlConnection connection = new SqlConnection(StringConexaoDiegoCasa))
            {
                string select = "EXEC SP_BuscarPorEmailSenha @Email, @Senha;";
                using(SqlCommand command = new SqlCommand(select,connection))
                {
                    command.Parameters.AddWithValue("@Email",Email);
                    command.Parameters.AddWithValue("@Senha", Senha);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if(reader.HasRows)
                    {
                        UsuarioDomain Usuario = new UsuarioDomain();
                        while(reader.Read())
                        {
                            Usuario.ID_USUARIO = Convert.ToInt32(reader["CÓDIGO DO USUÁRIO"]);
                            Usuario.APELIDO = (reader["NICKNAME"]).ToString();
                            Usuario.EMAIL = (reader["EMAIL DO USUÁRIO"]).ToString();
                            Usuario.NOME_TIPO = (reader["TIPO DO USUÁRIO"]).ToString();
                            Usuario.ID_TipoUsuario = Convert.ToInt32(reader["CÓDIGO DO TIPO"]);
                        }
                        return Usuario;
                    } else
                    {
                        return null;
                    }
                }
            }
        }
    }
}
