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
    public partial class LibroMan02 : Form
    {
        LibroBL objLibroBL = new LibroBL();
        LibroBE objLibroBE = new LibroBE();
        AutorBL objAutorBL = new AutorBL();
        EditorialBL objEditorialBL = new EditorialBL();
        GeneroBL objGeneroBL = new GeneroBL();

        public LibroMan02()
        {
            InitializeComponent();
        }

        private void LibroMan02_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objAutorBL.ListarAutorCompuesto();
                DataRow dr;

                dr = dt.NewRow();
                dr["aut_id"] = 0;
                dr["aut_nombre"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboAutor.DataSource = dt;
                cboAutor.ValueMember = "aut_id";
                cboAutor.DisplayMember = "aut_nombre";

                dt = objGeneroBL.ListarGenero();
              
                dr = dt.NewRow();
                dr["gen_id"] = 0;
                dr["gen_desc"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboGenero.DataSource = dt;
                cboGenero.ValueMember = "gen_id";
                cboGenero.DisplayMember = "gen_desc";

                dt = objEditorialBL.ListarEditorial();

                dr = dt.NewRow();
                dr["edi_id"] = 0;
                dr["edi_nom"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboEditorial.DataSource = dt;
                cboEditorial.ValueMember = "edi_id";
                cboEditorial.DisplayMember = "edi_nom";
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
                if (cboAutor.SelectedIndex==0)
                {
                    throw new Exception("El autor es obligatorio.");
                }
                if (cboEditorial.SelectedIndex==0)
                {
                    throw new Exception("La editorial es obligatoria.");
                }
                if (cboGenero.SelectedIndex==0)
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
                    throw new Exception("La fecha de publicación es obligatoria");
                }

                objLibroBE.lib_nom = txtNombre.Text.Trim();
                objLibroBE.aut_id = Convert.ToInt16(cboAutor.SelectedValue);
                objLibroBE.edi_id = Convert.ToInt16(cboEditorial.SelectedValue);
                objLibroBE.gen_id = Convert.ToInt16(cboGenero.SelectedValue);
                objLibroBE.lib_edi = txtEdicion.Text.Trim();
                objLibroBE.lib_disp_stock = Convert.ToInt16(txtStock.Text.Trim());
                objLibroBE.lib_fec_pub = Convert.ToInt16(txtFecPub.Text.Trim());

                // Usuario Ingresado en Login
                objLibroBE.lib_user_reg = "admin";

                if (objLibroBL.InsertarLibro(objLibroBE) == true)
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

        private void NoNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }
    }
}
