using Libreria_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_ADO
{
    public class PersonalADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;


        public PersonalBE ValidarUsuario(String strLogin, String strPassword)
        {
            PersonalBE objPersonalBE = new PersonalBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ValidarUsuario";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@user", strLogin);
            cmd.Parameters.AddWithValue("@pass", strPassword);
            try
            {
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objPersonalBE.per_mail = dtr["per_mail"].ToString();
                    objPersonalBE.per_pass = dtr["per_pass"].ToString();
                }
                dtr.Close();
                return objPersonalBE;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }

        }
    }
}
