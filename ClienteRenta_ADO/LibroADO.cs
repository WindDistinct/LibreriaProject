using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Libreria_BE;

namespace Libreria_ADO
{
    public class LibroADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarLibro()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarLibro";
                cmd.Parameters.Clear();

                DataSet dts = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Libros");
                return dts.Tables["Libros"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public LibroBE ConsultarLibro(String strCodigo)
        {
            try
            {
                LibroBE objLibroBE = new LibroBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarLibro";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@lib_id", strCodigo);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objLibroBE.lib_id = Convert.ToInt16(dtr["lib_id"]);
                    objLibroBE.lib_nom = dtr["lib_nom"].ToString();
                    objLibroBE.aut_id = Convert.ToInt16(dtr["aut_id"]);
                    objLibroBE.gen_id = Convert.ToInt16(dtr["gen_id"]);
                    objLibroBE.lib_edi = dtr["cli_tel"].ToString();
                    objLibroBE.lib_fec_pub = Convert.ToInt16(dtr["lib_fec_pub"]);
                    objLibroBE.lib_disp_stock = Convert.ToInt16(dtr["lib_disp_stock"]);
                    objLibroBE.edi_id = Convert.ToInt16(dtr["edi_id"]);
                    objLibroBE.lib_user_reg = dtr["lib_user_reg"].ToString();
                    objLibroBE.lib_state = Convert.ToInt16(dtr["state"]);
                }
                else
                {
                    objLibroBE.lib_id = Convert.ToInt16(String.Empty);
                }
                dtr.Close();
                return objLibroBE;

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

        public Boolean InsertarLibro(LibroBE objLibroBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertaLibro";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@lib_nom", objLibroBE.lib_nom);
                cmd.Parameters.AddWithValue("@aut_id", objLibroBE.aut_id);
                cmd.Parameters.AddWithValue("@gen_id", objLibroBE.gen_id);
                cmd.Parameters.AddWithValue("@lib_edi", objLibroBE.lib_edi);
                cmd.Parameters.AddWithValue("@lib_fec_pub", objLibroBE.lib_fec_pub);
                cmd.Parameters.AddWithValue("@lib_disp_stock", objLibroBE.lib_disp_stock);
                cmd.Parameters.AddWithValue("@edi_id", objLibroBE.edi_id);
                cmd.Parameters.AddWithValue("@lib_user_reg", objLibroBE.lib_user_reg);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }

        public Boolean EditarLibro(LibroBE objLibroBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EditarLibro";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@lib_id", objLibroBE.lib_id);
                cmd.Parameters.AddWithValue("@lib_nom", objLibroBE.lib_nom);
                cmd.Parameters.AddWithValue("@aut_id", objLibroBE.aut_id);
                cmd.Parameters.AddWithValue("@gen_id", objLibroBE.gen_id);
                cmd.Parameters.AddWithValue("@lib_edi", objLibroBE.lib_edi);
                cmd.Parameters.AddWithValue("@lib_fec_pub", objLibroBE.lib_fec_pub);
                cmd.Parameters.AddWithValue("@lib_disp_stock", objLibroBE.lib_disp_stock);
                cmd.Parameters.AddWithValue("@edi_id", objLibroBE.edi_id);
                cmd.Parameters.AddWithValue("@lib_user_mod", objLibroBE.lib_user_mod);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
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
