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
                objClienteBE = objClienteBL.ConsultarCliente(this.Codigo);

                lblCodNum.Text = objClienteBE.cli_id.ToString();
                txtNombre.Text = objClienteBE.cli_nom;
                txtApellido.Text = objClienteBE.cli_ape;
                txtDireccion.Text = objClienteBE.cli_dir;
                txtTelefono.Text = objClienteBE.cli_tel;
                txtDni.Text = objClienteBE.cli_dni;
                txtEmail.Text = objClienteBE.cli_mail;

                String ubg_id = objClienteBE.ubg_id;
                CargarUbigeo(ubg_id.Substring(0,2), ubg_id.Substring(2,2), ubg_id.Substring(4,2));

                if (objClienteBE.cli_foto != null && objClienteBE.cli_foto.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(objClienteBE.cli_foto))
                    {
                        pcbFoto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pcbFoto.Image = null;
                }

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

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Multiselect = false;
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "Fotos (Solo jpg) | *.jpg";
                openFileDialog1.ShowDialog();

                lblRuta.Text = openFileDialog1.FileName;
                pcbFoto.Image = Image.FromFile(openFileDialog1.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void CargarUbigeo(String IdReg, String IdProv, String IdDist)
        {
            UbigeoBL objUbigeoBL = new UbigeoBL();
            cboRegion.DataSource = objUbigeoBL.Ubigeo_Region();
            cboRegion.ValueMember = "ubg_reg_id";
            cboRegion.DisplayMember = "ubg_reg";
            cboRegion.SelectedValue = IdReg;

            cboProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasRegion(IdReg);
            cboProvincia.ValueMember = "ubg_prov_id";
            cboProvincia.DisplayMember = "ubg_prov";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaRegion(IdReg, IdProv);
            cboDistrito.ValueMember = "ubg_dist_id";
            cboDistrito.DisplayMember = "ubg_dist";
            cboDistrito.SelectedValue = IdDist;
        }

        private void cboRegion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboRegion.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboRegion.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
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

                objClienteBE.ubg_id = cboRegion.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() + cboDistrito.SelectedValue.ToString();
                objClienteBE.cli_fec_nac = Convert.ToDateTime(dtpFecNac.Value);

                if (!string.IsNullOrEmpty(lblRuta.Text))
                {
                    using (FileStream fs = new FileStream(lblRuta.Text, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            objClienteBE.cli_foto = br.ReadBytes((int)fs.Length);
                        }
                    }
                }

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
