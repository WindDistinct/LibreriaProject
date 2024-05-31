using Libreria_BL;
using Libreria_BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria_GUI
{
    public partial class AutorMan03 : Form
    {
        AutorBL objAutorBL = new AutorBL();
        AutorBE objAutorBE = new AutorBE();
        public AutorMan03()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }
        private void AutorMan03_Load(object sender, EventArgs e)
        {
            try
            {
                objAutorBE = objAutorBL.ConsultarAutor(this.Codigo);

                lblCodNum.Text = objAutorBE.aut_id.ToString();
                txtNombre.Text = objAutorBE.aut_nom;
                txtApellido.Text = objAutorBE.aut_ape;
                txtPais.Text = objAutorBE.aut_pais;
                // Usuario Ingresado en Login
                objAutorBE.aut_user_mod = "admin";
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
                if (txtPais.Text.Trim() == "")
                {
                    throw new Exception("El pais es obligatorio.");
                }

                objAutorBE.aut_id = Convert.ToInt16(lblCodNum.Text);
                objAutorBE.aut_nom = txtNombre.Text.Trim();
                objAutorBE.aut_ape = txtApellido.Text.Trim();
                objAutorBE.aut_pais = txtPais.Text.Trim();

                // Usuario Ingresado en Login
                objAutorBE.aut_user_reg = "admin";

                if (objAutorBL.EditarAutor(objAutorBE) == true)
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
