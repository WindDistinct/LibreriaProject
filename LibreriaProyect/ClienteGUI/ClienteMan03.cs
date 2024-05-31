using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_BE;
using Libreria_BL;

namespace LibreriaProyect
{
    public partial class ClienteMan03 : Form
    {
        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();
        UbigeoBL objUbigeoBL = new UbigeoBL();

        public ClienteMan03()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }

        private void ClienteMan03_Load(object sender, EventArgs e)
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

                objClienteBE = objClienteBL.ConsultarCliente(this.Codigo);

                lblCodNum.Text = objClienteBE.cli_id.ToString();
                txtNombre.Text = objClienteBE.cli_nom;
                txtApellido.Text = objClienteBE.cli_ape;
                txtDireccion.Text = objClienteBE.cli_dir;
                txtTelefono.Text = objClienteBE.cli_tel;
                txtDni.Text = objClienteBE.cli_dni;
                txtEmail.Text = objClienteBE.cli_mail;
                cboUbigeo.SelectedValue = objClienteBE.ubg_id.ToString();
                dtpFecNac.Value = objClienteBE.cli_fec_nac;

                if (objClienteBE.cli_sex == 'H')
                {
                    optHombre.Checked = true;
                }
                else
                {
                    optMujer.Checked = true;
                }

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

                objClienteBE.cli_id = Convert.ToInt16(lblCodNum.Text);
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
                objClienteBE.cli_user_mod = "admin";

                if (objClienteBL.EditarCliente(objClienteBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se editó el registro.");

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
