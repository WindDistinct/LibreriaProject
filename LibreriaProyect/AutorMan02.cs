using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteRenta_BL;
using Libreria_BE;
namespace Libreria_GUI
{
    public partial class AutorMan02 : Form
    {
        AutorBL objAutorBL = new AutorBL();
        AutorBE objAutorBE = new AutorBE();
        public AutorMan02()
        {
            InitializeComponent();
        }

        private void AutorMan02_Load(object sender, EventArgs e)
        {

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
                if (txtPais.Text.Trim() == "")
                {
                    throw new Exception("El pais es obligatorio.");
                }

                objAutorBE.aut_nom = txtNombre.Text.Trim();
                objAutorBE.aut_ape = txtApellido.Text.Trim();
                objAutorBE.aut_pais = txtPais.Text.Trim();

                // Usuario Ingresado en Login
                objAutorBE.aut_user_reg = "admin";

                if (objAutorBL.InsertarAutor(objAutorBE) == true)
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
    }
}
