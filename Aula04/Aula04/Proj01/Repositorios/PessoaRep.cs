using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Proj01.Entidades;


namespace Proj01.Repositorios
{
    public class PessoaRep : Conexao
    {
        public void Inserir(Pessoa p)
        {
            AbrirConexao();

            string query = "INSERT INTO PESSOA(Nome, DataNascimento) "
                            + "values(@Nome, @DataNascimento) ";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Nome", p.Nome);
            cmd.Parameters.AddWithValue("@DataNascimento", p.DataNascimento);
            cmd.ExecuteNonQuery();

            FecharConexao();
        }


        public void Alterar(Pessoa p)
        {
            string query = "UPDATE PESSOA "
                         + "SET Nome = @Nome, "
                         + "SET DataNascimento  = @DataNascimento "
                         + "WHERE IdPessoa      = @IdPessoa ";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Nome", p.Nome);
            cmd.Parameters.AddWithValue("@DataNascimento", p.DataNascimento);
            cmd.ExecuteNonQuery();

            FecharConexao();
        }

        public void Excluir(Pessoa p)
        {
            string query = "DELETE PESSOA   "                     
                         + "WHERE IdPessoa  = @IdPessoa ";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@IdPessoa", p.IdPessoa);            
            cmd.ExecuteNonQuery();

            FecharConexao();
        }

        public List<Pessoa> ListarTodos()
        {
            string query = "SELECT * FROM PESSOA";

            AbrirConexao();

            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();

            List<Pessoa> lista = new List<Pessoa>();

            while (dr.Read())
            {
                Pessoa p = new Pessoa();
                p.IdPessoa = Convert.ToInt32(dr["IdPessoa"]);
                p.Nome = Convert.ToString(dr["Nome"]);
                p.DataNascimento = Convert.ToDateTime(dr["DataNascimento"]);

                lista.Add(p);
            }

            FecharConexao();
            return lista;

        }

        public Pessoa PessoaPorId(int idPessoa)
        {
            AbrirConexao();
            string query = " SELECT * FROM PESSOA "
                         + " WGERE IdPessoa = @IdPessoa";
            
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@IdPessoa", idPessoa);
            dr = cmd.ExecuteReader();

            Pessoa p = null;

            if (dr.Read())
            {
                p = new Pessoa();
                p.IdPessoa = Convert.ToInt32(dr["IdPessoa"]);
                p.Nome = Convert.ToString(dr["Nome"]);
                p.DataNascimento = Convert.ToDateTime(dr["DataNascimento"]);
            }
            
            FecharConexao();
            return p;
        }
    }
}
