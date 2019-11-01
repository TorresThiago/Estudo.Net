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

        public void Update(Cliente c)
        {
            OpenConnection();

            string query = "UPDATE CLIENTE "
                          + "SET NOME = @NOME AND EMAIL = @EMAIL "
                          + "WHERE IDCLIENTE = @IDCLIENTE";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NOME", c.Nome);
            cmd.Parameters.AddWithValue("@EMAIL",c.Email);
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public void Delete(int idCliente)
        {
            OpenConnection();

            string query = "DELETE FROM CLIENTE WHERE IDCLIENTE = @IDCLIENTE";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@IDCLIENTE", idCliente);
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public List<Cliente> FindAll()
        {
            OpenConnection();

            string query = "SELECT * FROM CLIENTE";

            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();

            List<Cliente> lista = new List<Cliente>();

            while (dr.Read())
            {
                Cliente c = new Cliente();
                c.IdCliente = (int)dr["IdCliente"];
                c.Nome = (string)dr["Nome"];
                c.Email = (string)dr["Email"];
                c.DataCadastro = (DateTime)dr["DataCadastro"];

                lista.Add(c);
            }

            CloseConnection();
            return lista;
        }

        public Cliente FindById(int idCliente)
        {
            OpenConnection();

            string query = "SELECT * FROM CLIENTE WHERE IDCLIENTE = @IDCLIENTE";


            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@IDCLIENTE", idCliente);
            dr = cmd.ExecuteReader();

            Cliente c = null;

            if (dr.Read())
            {
                c = new Cliente();

                c.IdCliente = (int)dr["IdCliente"];
                c.Nome = (string)dr["Nome"];
                c.Email = (string)dr["Email"];
                c.DataCadastro = (DateTime)dr["DataCadastro"];
            }

            CloseConnection();
            return c;
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

