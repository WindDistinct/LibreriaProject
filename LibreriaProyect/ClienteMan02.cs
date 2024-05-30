using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteRenta_BE;
using ClienteRenta_BL;

namespace LibreriaProyect
{
    public partial class ClienteMan02 : Form
    {
        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();
        UbigeoBL objUbigeoBL = new UbigeoBL();
        public ClienteMan02()
        {
            InitializeComponent();
        }

        private void ClienteMan02_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objUbigeoBL.ListarUbigeo();
                DataRow dr;

                dr = dt.NewRow();
                dr["ubg_id"] = 0;
                dr["ubg_desc"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboUbigeo.DataSource = dt;
                cboUbigeo.ValueMember = "ubg_id";
                cboUbigeo.DisplayMember = "ubg_desc";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Trim() == "")
                {
                    throw new Exception("El nombre es obligatorio.");
                }
                if (txtApellido.Text.Trim() == "")
                {
                    throw new Exception("El apellido es obligatorio.");
                }
                if (txtDireccion.Text.Trim() == "")
                {
                    throw new Exception("La dirección es obligatorio.");
                }
                if (txtTelefono.Text.Trim() == "")
                {
                    throw new Exception("El teléfono es obligatorio.");
                }
                if (txtDni.Text.Trim() == "")
                {
                    throw new Exception("El DNI es obligatorio.");
                }
                if (txtEmail.Text.Trim() == "")
                {
                    throw new Exception("El correo electrónico es obligatorio.");
                }
                if (cboUbigeo.SelectedIndex == 0)
                {
                    throw new Exception("El ubigeo es obligatorio.");
                }

                objClienteBE.cli_nom = txtNombre.Text.Trim();
                objClienteBE.cli_ape = txtApellido.Text.Trim();
                objClienteBE.cli_dir = txtDireccion.Text.Trim();
                objClienteBE.cli_tel = txtTelefono.Text.Trim();
                objClienteBE.cli_dni = txtDni.Text.Trim();
                objClienteBE.cli_mail = txtEmail.Text.Trim();

                if (optHombre.Checked == true)
                {
                    objClienteBE.cli_sex = 'H';
                }
                else if (optMujer.Checked == true)
                {
                    objClienteBE.cli_sex = 'F';
                }
                else
                {
                    throw new Exception("Debe seleecionar un sexo.");
                }

                objClienteBE.ubg_id = Convert.ToInt16(cboUbigeo.SelectedValue);
                objClienteBE.cli_fec_nac = Convert.ToDateTime(dtpFecNac.Value);

                // Usuario Ingresado en Login
                objClienteBE.cli_user_reg = "admin";

                if (objClienteBL.InsertarCliente(objClienteBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("Error: No se insertó el registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }

        
    }
}
