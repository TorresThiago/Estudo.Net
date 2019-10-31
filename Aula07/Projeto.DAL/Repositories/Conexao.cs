using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Projeto.DAL.Repositories
{
    public class Conexao
    {
        protected SqlConnection con; //Classe para conexão BD
        protected SqlDataReader dr;  //Classe para fazer a leitura dos dados (Select)
        protected SqlCommand cmd;    //Classe para executar comandos SQL no BD (Insert, Update, etc)
        protected SqlTransaction tr; //Classe utilizada para trabalhar com as transações no BD (Commit ou rollback)

        protected void OpenConnection()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnBD"].ConnectionString);
            con.Open();
        }

        protected void CloseConnection()
        {            
            con.Close();
        }
    }
}
