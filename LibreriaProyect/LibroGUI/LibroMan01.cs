using Libreria_BL;
using Libreria_GUI.LibroGUI;
using LibreriaProyect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria_GUI.Libro
{
    public partial class LibroMan01 : Form
    {

        LibroBL objLibroBL = new LibroBL();
        DataView dtv;

        public LibroMan01()
        {
            InitializeComponent();
        }

        private void LibroMan01_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objLibroBL.ListarLibro());
            dtv.RowFilter = "lib_nom like '%" + strFiltro + "%'";
            dgvDatos.DataSource = dtv;
            lblRegistros.Text = dgvDatos.Rows.Count.ToString();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtBuscador.Text.Trim());
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
                LibroMan02 formulario = new LibroMan02();
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
                LibroMan03 objLibroMan03 = new LibroMan03();
                String strCodigo = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                objLibroMan03.Codigo = strCodigo;

                objLibroMan03.ShowDialog();

                CargarDatos(txtBuscador.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
