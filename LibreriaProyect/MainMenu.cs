﻿using Libreria_GUI.Libro;
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

namespace Libreria_GUI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void smiClientes_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteMan01 clientes = new ClienteMan01();
                clientes.MdiParent = this;
                clientes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void smiLibros_Click(object sender, EventArgs e)
        {
            try
            {
                LibroMan01 libros = new LibroMan01();
                libros.MdiParent = this;
                libros.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void smiAutores_Click(object sender, EventArgs e)
        {
            try
            {
                AutorMan01 autores = new AutorMan01();
                autores.MdiParent = this;
                autores.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
