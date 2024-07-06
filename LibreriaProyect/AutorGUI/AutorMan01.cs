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
using LibreriaProyect;
namespace Libreria_GUI
{
    public partial class AutorMan01 : Form
    {
        AutorBL objAutorBL = new AutorBL();
        DataView dtv;
        public AutorMan01()
        {
            InitializeComponent();
        }

        private void AutorMan01_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }
        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objAutorBL.ListarAutor());
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
                AutorMan02 formulario = new AutorMan02();
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
                AutorMan03 objAutorMan03 = new AutorMan03();
                String strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objAutorMan03.Codigo = strCodigo;

                objAutorMan03.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim());
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
