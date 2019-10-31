using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.DAL.Entities;
using System.Data.SqlClient;

namespace Projeto.DAL.Repositories
{
    public class ClienteRepository : Conexao
    {
        public void Insert(Cliente c)
        {
            OpenConnection();

            string query = "INSERT INTO CLIENTE(NOME, EMAIL, DATACADASTRO)"
                          +"VALUES(@NOME, @EMAIL, GetDate())";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Nome", c.Nome);
            cmd.Parameters.AddWithValue("@Email", c.Email);
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public bool HasEmail(string email)
        {
            OpenConnection();

            string query = "SELECT COUNT(*) FROM CLIENTE "
                           +"WHERE EMAIL = @EMAIL";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@EMAIL", email);
            int count = (int)(cmd.ExecuteScalar());

            CloseConnection();

            return count > 0;
        }
    }
}

