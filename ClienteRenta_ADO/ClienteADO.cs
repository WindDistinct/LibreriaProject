using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using ClienteRenta_BE;
namespace ClienteRenta_ADO
{
    public class ClienteADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarCliente()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCliente";
                cmd.Parameters.Clear();

                DataSet dts = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Clientes");
                return dts.Tables["Clientes"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ClienteBE ConsultarCliente(String strCodigo)
        {
            try
            {
                ClienteBE objClienteBE = new ClienteBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cli_id", strCodigo);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objClienteBE.cli_id = Convert.ToInt16(dtr["cli_id"]);
                    objClienteBE.cli_nom = dtr["cli_nom"].ToString();
                    objClienteBE.cli_ape = dtr["cli_ape"].ToString();
                    objClienteBE.cli_dir = dtr["cli_dir"].ToString();
                    objClienteBE.cli_tel = dtr["cli_tel"].ToString();
                    objClienteBE.cli_mail = dtr["cli_mail"].ToString();
                    objClienteBE.cli_dni = dtr["cli_dni"].ToString();
                    objClienteBE.ubg_id = Convert.ToInt16(dtr["ubg_id"]);
                    objClienteBE.cli_fec_nac = Convert.ToDateTime(dtr["cli_fec_nac"]);
                    objClienteBE.cli_sex = Convert.ToChar(dtr["cli_sex"]);
                    objClienteBE.cli_user_reg = dtr["cli_user_reg"].ToString();
                }
                else
                {
                    objClienteBE.cli_id = Convert.ToInt16(String.Empty);
                }
                dtr.Close();
                return objClienteBE;

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

        public Boolean InsertarCliente(ClienteBE objClienteBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarCliente";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@cli_nom", objClienteBE.cli_nom);
                cmd.Parameters.AddWithValue("@cli_ape", objClienteBE.cli_ape);
                cmd.Parameters.AddWithValue("@cli_dir", objClienteBE.cli_dir);
                cmd.Parameters.AddWithValue("@cli_tel", objClienteBE.cli_tel);
                cmd.Parameters.AddWithValue("@cli_mail", objClienteBE.cli_mail);
                cmd.Parameters.AddWithValue("@cli_dni", objClienteBE.cli_dni);
                cmd.Parameters.AddWithValue("@ubg_id", objClienteBE.ubg_id);
                cmd.Parameters.AddWithValue("@cli_fec_nac", objClienteBE.cli_fec_nac);
                cmd.Parameters.AddWithValue("@cli_sex", objClienteBE.cli_sex);
                cmd.Parameters.AddWithValue("@cli_user_reg", objClienteBE.cli_user_reg);

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

        public Boolean EditarCliente(ClienteBE objClienteBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EditarCliente";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@cli_id", objClienteBE.cli_id);
                cmd.Parameters.AddWithValue("@cli_nom", objClienteBE.cli_nom);
                cmd.Parameters.AddWithValue("@cli_ape", objClienteBE.cli_ape);
                cmd.Parameters.AddWithValue("@cli_dir", objClienteBE.cli_dir);
                cmd.Parameters.AddWithValue("@cli_tel", objClienteBE.cli_tel);
                cmd.Parameters.AddWithValue("@cli_mail", objClienteBE.cli_mail);
                cmd.Parameters.AddWithValue("@cli_dni", objClienteBE.cli_dni);
                cmd.Parameters.AddWithValue("@ubg_id", objClienteBE.ubg_id);
                cmd.Parameters.AddWithValue("@cli_fec_nac", objClienteBE.cli_fec_nac);
                cmd.Parameters.AddWithValue("@cli_sex", objClienteBE.cli_sex);
                cmd.Parameters.AddWithValue("@cli_user_mod", objClienteBE.cli_user_mod);

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
