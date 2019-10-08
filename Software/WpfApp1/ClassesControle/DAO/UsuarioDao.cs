using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesModel.DTO;
using System.Configuration;
using System.Data.SqlClient;
namespace ClassesControle.DAO
{
    public class UsuarioDao
    {
        private static UsuarioDao instancia = null;
        private UsuarioDao(){}
        public static UsuarioDao getinstancia()
        {
            if (instancia == null)
                instancia = new UsuarioDao();
            return instancia;
        }

        // receita de bolo
        public UsuarioDto Login(string senha)
        {
            string cn = ConfigurationManager.ConnectionStrings["Pim"].ConnectionString;
            SqlConnection conn = new SqlConnection(cn);
            string txt = string.Format("SELECT * FROM usuarios WHERE senha = '{0}' ", senha);
            SqlCommand cmd = new SqlCommand(txt, conn);
            UsuarioDto retorno = null;

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    retorno = new UsuarioDto();
                    retorno.Id = Convert.ToInt32(dr["id"]);                   
                    retorno.Senha = Convert.ToString(dr["senha"]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                throw ex;
            }
            return retorno;
        }

        public void Save(UsuarioDto usuario)
        {
            string cs = ConfigurationManager.ConnectionStrings["Pim"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("sp_insereusuario", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@login", usuario.Login);
            cmd.Parameters.AddWithValue("@senha", usuario.Senha);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                throw;
            }
        }
    }
}
