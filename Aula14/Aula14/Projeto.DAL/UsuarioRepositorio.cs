using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using System.Data.SqlClient;
using Projeto.Utils;

namespace Projeto.DAL
{
    public class UsuarioRepositorio : Conexao
    {
        public void Insert(Usuario u)
        {
            OpenConnection();

            var query = "INSERT INTO USUARIO " +
                        "(Nome, Login, Senha, Foto) " +
                        "Values " +
                        "(@Nome, @Login, @Senha, @Foto)" ;
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Nome", u.Nome);
            cmd.Parameters.AddWithValue("@Login", u.Login);
            cmd.Parameters.AddWithValue("@Senha", Criptografia.EncriptarParaMD5(u.Senha));
            cmd.Parameters.AddWithValue("@Foto", u.Foto);
            cmd.ExecuteNonQuery();

            CloseConnection();

        }

        public bool HasLogin(string login)
        {
            OpenConnection();

            var query = "SELECT COUNT(*) FROM USUARIO WHERE LOGIN = @Login";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Login", login);
            int qtd = Convert.ToInt32(cmd.ExecuteScalar());

            CloseConnection();
            return qtd > 0;
        }

        public Usuario Find(string login, string senha)
        {
            OpenConnection();

            string query = "Select * from Usuario " +
                "where Login = @Login and Senha = @Senha ";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Senha", senha);

            dr = cmd.ExecuteReader();
            Usuario u = null;

            if (dr.Read())
            {
                u = new Usuario();

                u.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                u.Nome = Convert.ToString(dr["Nome"]);
                u.Login = Convert.ToString(dr["Login"]);
                u.Senha = Convert.ToString(dr["Senha"]);
                u.Foto = Convert.ToString(dr["Foto"]);            
            }
            CloseConnection();
            return u;
        }
    }
}
