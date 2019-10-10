using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Proj01.Repositorios
{
    public class Conexao
    {
        #region Atributos
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader dr;
        protected SqlTransaction tr;
        #endregion

        #region Métodos
        protected void AbrirConexao()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);
            con.Open();
        }

        protected void FecharConexao()
        {
            con.Close();
        }

        #endregion



    }
}
