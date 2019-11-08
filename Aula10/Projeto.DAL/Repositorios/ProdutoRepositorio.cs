using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto.DAL.Entidades;

namespace Projeto.DAL.Repositorios
{
    public class ProdutoRepositorio : Conexao
    {
        public void Insert(Produto p)
        {
            OpenConection();

            string query = "insert into Produto " +
                            "values (@Nome, @Preco, @Quantidade) ";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Nome",p.Nome);
            cmd.Parameters.AddWithValue("@Preco", p.Preco);
            cmd.Parameters.AddWithValue("@Quantidade", p.Quantidade);
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

    }
}
