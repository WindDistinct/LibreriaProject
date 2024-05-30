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

                /*dr = dt.NewRow();
                dr["ubg_id"] = 0;
                dr["ubg_desc"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboUbigeo.DataSource = dt;
                cboUbigeo.ValueMember = "ubg_id";
                cboUbigeo.DisplayMember = "ubg_desc";*/

                objClienteBE = objClienteBL.ConsultarCliente(this.Codigo);

                /*txtNombre.Text = objClienteBE.cli_nom;
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
                else if (objClienteBE.cli_sex == 'F')
                {
                    optMujer.Checked = true;
                }*/

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
