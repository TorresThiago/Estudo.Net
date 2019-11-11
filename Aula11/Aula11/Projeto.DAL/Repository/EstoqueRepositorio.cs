using Projeto.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto.DAL.Entities.Types;


namespace Projeto.DAL.Repository
{
    public class EstoqueRepositorio : Conexao
    {
        public void Insert(Estoque e)
        {
            OpenConnection();

            string query =  "INSERT INTO ESTOQUE(Nome, Descricao, Tipo) "
                          + "VALUES (@Nome, @Descricao, @Tipo)";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Nome", e.Nome);
            cmd.Parameters.AddWithValue("@Descricao", e.Descricao);
            cmd.Parameters.AddWithValue("@Tipo", (int) e.Tipo);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public void Update(Estoque e)
        {
            OpenConnection();

            var query = "UPDATE ESTOQUE " +
                        "SET Nome = @Nome " +
                        "   ,Descricao = @Descricao " +
                        "   ,Tipo = @Tipo " +
                        "Where IdEstoque = @IdEstoque ";

            cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@Nome", e.Nome);
            cmd.Parameters.AddWithValue("@Descricao", e.Descricao);
            cmd.Parameters.AddWithValue("@Tipo", e.Tipo);
            cmd.Parameters.AddWithValue("@IdEstoque", e.IdEstoque);
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public void Delete(int idEstoque)
        {
            OpenConnection();

            var query = "DELETE FROM ESTOQUE WHERE IdEstoque = @IdEstoque";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@IdEstoque",idEstoque);
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public List<Estoque> BuscarTodos()
        {
            OpenConnection();

            var query = "SELECT * FROM ESTOQUE";

            cmd = new SqlCommand(query,con);
            dr = cmd.ExecuteReader();

            List<Estoque> lista = new List<Estoque>();

            while (dr.Read())
            {
                Estoque e = new Estoque();
                e.IdEstoque = (int)dr["IdEstoque"];
                e.Nome = (string)dr["Nome"];
                e.Descricao = (string)dr["Descricao"];
                e.Tipo = (TipoEstoque)dr["Tipo"];

                lista.Add(e);
            }
            CloseConnection();

            return lista;
        }

        public Estoque FindById(int idEstoque)
        {
            OpenConnection();

            var query = "SELECT * FROM ESTOQUE WHERE idEstoque = @IdEstoque";

            cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@IdEstoque",idEstoque);
            dr = cmd.ExecuteReader();

            Estoque e = null;

            if (dr.Read())
            {
                e = new Estoque();

                e.IdEstoque = (int)dr["IdEstoque"];
                e.Nome = (string)dr["Nome"];
                e.Descricao = (string)dr["Descricao"];
                e.Tipo = (TipoEstoque)dr["Tipo"];
            }
            CloseConnection();
            return e;
        }
    }
}
