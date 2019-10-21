using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assistente_social.Modelo
{
    class Conexao
    {
        public static string connString = @"server = ASSISTENTESOCIA\SQLEXPRESS; Database = ASSISTENTE; integrated security = true;";
        //public static string connString = @"server = ESTAGIARIO\TESTESQL; Database = ANDAFAPE; integrated security = true;";

        public static SqlConnection conn = null;

        // metodo que permite obter a conexeao

        public static SqlConnection obterConexao()
        {
            conn = new SqlConnection(connString);

            try
            {
                conn.Open();
            }
            catch (SqlException)
            {
                conn = null;
            }
            return conn;
        }

        public static void FecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
