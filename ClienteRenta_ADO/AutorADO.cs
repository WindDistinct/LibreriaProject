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

    public class AutorADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarAutor()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarAutor";
                cmd.Parameters.Clear();

                DataSet dts = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Autores");
                return dts.Tables["Autores"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ListarAutorCompuesto()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarAutorCompuesto";
                cmd.Parameters.Clear();

                DataSet dts = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Autores");
                return dts.Tables["Autores"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public AutorBE ConsultarAutor(String strCodigo)
        {
            try
            {
                AutorBE objAutorBE = new AutorBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarAutor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@aut_id", strCodigo);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objAutorBE.aut_id = Convert.ToInt16(dtr["aut_id"]);
                    objAutorBE.aut_nom = dtr["aut_nom"].ToString();
                    objAutorBE.aut_ape = dtr["aut_ape"].ToString();
                    objAutorBE.aut_pais = dtr["aut_pais"].ToString();
                    objAutorBE.aut_user_reg = dtr["aut_user_reg"].ToString();

                    if (dtr["aut_foto"] != DBNull.Value)
                    {
                        objAutorBE.aut_foto = (byte[])dtr["aut_foto"];
                    }
                    else
                    {
                        objAutorBE.aut_foto = null;
                    }

                }
                else
                {
                    objAutorBE.aut_id = Convert.ToInt16(String.Empty);
                }
                dtr.Close();
                return objAutorBE;

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

        public Boolean InsertarAutor(AutorBE objAutorBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarAutor";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@aut_nom", objAutorBE.aut_nom);
                cmd.Parameters.AddWithValue("@aut_ape", objAutorBE.aut_ape);
                cmd.Parameters.AddWithValue("@aut_pais", objAutorBE.aut_pais);
                cmd.Parameters.AddWithValue("@aut_foto", objAutorBE.aut_foto);
                cmd.Parameters.AddWithValue("@aut_user_reg", objAutorBE.aut_user_reg);

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

        public Boolean EditarAutor(AutorBE objAutorBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EditarAutor";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@aut_id", objAutorBE.aut_id);
                cmd.Parameters.AddWithValue("@aut_nom", objAutorBE.aut_nom);
                cmd.Parameters.AddWithValue("@aut_ape", objAutorBE.aut_ape);
                cmd.Parameters.AddWithValue("@aut_pais", objAutorBE.aut_pais);
                cmd.Parameters.AddWithValue("@aut_foto", objAutorBE.aut_foto);
                cmd.Parameters.AddWithValue("@aut_user_mod", objAutorBE.aut_user_mod);

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
