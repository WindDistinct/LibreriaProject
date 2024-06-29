using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_ADO
{
     public class UbigeoADO {

          ConexionADO MiConexion = new ConexionADO();
          SqlConnection cnx = new SqlConnection();
          SqlCommand cmd = new SqlCommand();
          SqlDataReader dtr;

          public DataTable Ubigeo_Region ()
          {
            DataSet dts = new DataSet();
            
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Ubigeo_Region";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Region");
                return dts.Tables["Region"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
          }
        public DataTable Ubigeo_ProvinciasRegion(String strIdRegion)
        {
            DataSet dts = new DataSet();

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Ubigeo_ProvinciasRegion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdRegion", strIdRegion);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Provincias");
                return dts.Tables["Provincias"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Ubigeo_DistritosProvinciaRegion(String strIdRegion, String strIdProvincia)
        {
            DataSet dts = new DataSet();

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Ubigeo_DistritosProvinciaRegion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdRegion", strIdRegion);
                cmd.Parameters.AddWithValue("@IdProvincia", strIdProvincia);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Distritos");
                return dts.Tables["Distritos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
    
}
