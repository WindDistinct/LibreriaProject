using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClienteRenta_ADO
{
     public class UbigeoADO {

          ConexionADO MiConexion = new ConexionADO();
          SqlConnection cnx = new SqlConnection();
          SqlCommand cmd = new SqlCommand();
          SqlDataReader dtr;

          public DataTable ListarUbigeo ()
          {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarUbigeos";
            try
            {

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Ubigeos");
                return dts.Tables["Ubigeos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        }
    
}
