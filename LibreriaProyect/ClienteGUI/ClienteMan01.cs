using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Libreria_BL;

namespace LibreriaProyect
{
    public partial class ClienteMan01 : Form
    {

        ClienteBL objClienteBL = new ClienteBL();
        DataView dtv;

        public ClienteMan01()
        {
            InitializeComponent();
        }

        private void ClienteMan01_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objClienteBL.ListarCliente());
            dtv.RowFilter = "Apellido like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteMan02 formulario = new ClienteMan02();
                formulario.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteMan03 objClienteMan03 = new ClienteMan03();
                String strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objClienteMan03.Codigo = strCodigo;

                objClienteMan03.ShowDialog();
                dtv = new DataView(objClienteBL.ListarCliente());
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        // Boton Cerrar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // No borrar
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ClienteMan01_Load_1(object sender, EventArgs e)
        {

        }

        
    }
}
