using Libreria_BE;
using Libreria_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria_GUI.LibroGUI
{
    public partial class LibroMan03 : Form
    {
        LibroBL objLibroBL = new LibroBL();
        LibroBE objLibroBE = new LibroBE();
        AutorBL objAutorBL = new AutorBL();
        EditorialBL objEditorialBL = new EditorialBL();
        GeneroBL objGeneroBL = new GeneroBL(); 

        public LibroMan03()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }

        private void LibroMan03_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtAutor = objAutorBL.ListarAutorCompuesto();
                DataTable dtGenero = objGeneroBL.ListarGenero();
                DataTable dtEditorial = objEditorialBL.ListarEditorial();
                DataRow drAutor;
                DataRow drGenero;
                DataRow drEditorial;

                drAutor = dtAutor.NewRow();
                drAutor["aut_id"] = 0;
                drAutor["aut_nombre"] = "--Seleccione--";
                dtAutor.Rows.InsertAt(drAutor, 0);
                cboAutor.DataSource = dtAutor;
                cboAutor.ValueMember = "aut_id";
                cboAutor.DisplayMember = "aut_nombre";

                drGenero = dtGenero.NewRow();
                drGenero["gen_id"] = 0;
                drGenero["gen_desc"] = "--Seleccione--";
                dtGenero.Rows.InsertAt(drGenero, 0);
                cboGenero.DataSource = dtGenero;
                cboGenero.ValueMember = "gen_id";
                cboGenero.DisplayMember = "gen_desc";

                drEditorial = dtEditorial.NewRow();
                drEditorial["edi_id"] = 0;
                drEditorial["edi_nom"] = "--Seleccione--";
                dtEditorial.Rows.InsertAt(drEditorial, 0);
                cboEditorial.DataSource = dtEditorial;
                cboEditorial.ValueMember = "edi_id";
                cboEditorial.DisplayMember = "edi_nom";

                objLibroBE = objLibroBL.ConsultarLibro(this.Codigo);

                lblCodNum.Text = objLibroBE.lib_id.ToString();
                txtNombre.Text = objLibroBE.lib_nom;
                cboAutor.SelectedValue = objLibroBE.aut_id.ToString();
                cboEditorial.SelectedValue = objLibroBE.edi_id.ToString();
                cboGenero.SelectedValue = objLibroBE.gen_id.ToString();
                txtEdicion.Text = objLibroBE.lib_edi;
                txtFecPub.Text = objLibroBE.lib_fec_pub.ToString();
                txtStock.Text = objLibroBE.lib_disp_stock.ToString();   
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
                if (cboAutor.SelectedIndex == 0)
                {
                    throw new Exception("El autor es obligatorio.");
                }
                if (cboEditorial.SelectedIndex == 0)
                {
                    throw new Exception("La editorial es obligatoria.");
                }
                if (cboGenero.SelectedIndex == 0)
                {
                    throw new Exception("El genéro es obligatorio.");
                }
                if (txtEdicion.Text.Trim() == "")
                {
                    throw new Exception("La edición es obligatoria.");
                }
                if (txtStock.Text.Trim() == "")
                {
                    throw new Exception("El stock es obligatorio.");
                }
                if (txtFecPub.Text.Trim() == "")
                {
                    throw new Exception("La fecha de publicación es obligatorio.");
                }

                objLibroBE.lib_id = Convert.ToInt16(lblCodNum.Text);
                objLibroBE.lib_nom = txtNombre.Text.Trim();
                objLibroBE.aut_id = Convert.ToInt16(cboAutor.SelectedValue);
                objLibroBE.edi_id = Convert.ToInt16(cboEditorial.SelectedValue);
                objLibroBE.gen_id = Convert.ToInt16(cboGenero.SelectedValue);
                objLibroBE.lib_edi = txtEdicion.Text.Trim();
                objLibroBE.lib_disp_stock = Convert.ToInt16(txtStock.Text);
                objLibroBE.lib_fec_pub = Convert.ToInt16(txtFecPub.Text);

                // Usuario Ingresado en Login
                objLibroBE.lib_user_mod = "admin";

                if (objLibroBL.EditarLibro(objLibroBE) == true)
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

        private void NoNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }
    }
}
