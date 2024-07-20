namespace Libreria_GUI
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            smiMantenimientos = new ToolStripMenuItem();
            autoresToolStripMenuItem = new ToolStripMenuItem();
            librosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            smiClientes = new ToolStripMenuItem();
            smiRentas = new ToolStripMenuItem();
            reabastecimientoToolStripMenuItem = new ToolStripMenuItem();
            smiEditoriales = new ToolStripMenuItem();
            smiRequerimientos = new ToolStripMenuItem();
            panelDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
            smiPerfil = new ToolStripMenuItem();
            smiEmpleados = new ToolStripMenuItem();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            smiLibros = new ToolStripMenuItem();
            smiFiltros = new ToolStripMenuItem();
            smiAutores = new ToolStripMenuItem();
            smiCategorias = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { smiMantenimientos, pedidosToolStripMenuItem, reabastecimientoToolStripMenuItem, panelDeUsuarioToolStripMenuItem, inventarioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // smiMantenimientos
            // 
            smiMantenimientos.DropDownItems.AddRange(new ToolStripItem[] { autoresToolStripMenuItem, librosToolStripMenuItem, clientesToolStripMenuItem });
            smiMantenimientos.Name = "smiMantenimientos";
            smiMantenimientos.Size = new Size(130, 24);
            smiMantenimientos.Text = "Mantenimientos";
            // 
            // autoresToolStripMenuItem
            // 
            autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            autoresToolStripMenuItem.Size = new Size(144, 26);
            autoresToolStripMenuItem.Text = "Autores";
            autoresToolStripMenuItem.Click += smiAutores_Click;
            // 
            // librosToolStripMenuItem
            // 
            librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            librosToolStripMenuItem.Size = new Size(144, 26);
            librosToolStripMenuItem.Text = "Libros";
            librosToolStripMenuItem.Click += smiLibros_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(144, 26);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += smiClientes_Click;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smiClientes, smiRentas });
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(75, 24);
            pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // smiClientes
            // 
            smiClientes.Name = "smiClientes";
            smiClientes.Size = new Size(144, 26);
            smiClientes.Text = "Clientes";
            smiClientes.Click += smiClientes_Click;
            // 
            // smiRentas
            // 
            smiRentas.Name = "smiRentas";
            smiRentas.Size = new Size(144, 26);
            smiRentas.Text = "Rentas";
            // 
            // reabastecimientoToolStripMenuItem
            // 
            reabastecimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smiEditoriales, smiRequerimientos });
            reabastecimientoToolStripMenuItem.Name = "reabastecimientoToolStripMenuItem";
            reabastecimientoToolStripMenuItem.Size = new Size(142, 24);
            reabastecimientoToolStripMenuItem.Text = "Reabastecimiento";
            // 
            // smiEditoriales
            // 
            smiEditoriales.Name = "smiEditoriales";
            smiEditoriales.Size = new Size(196, 26);
            smiEditoriales.Text = "Editoriales";
            // 
            // smiRequerimientos
            // 
            smiRequerimientos.Name = "smiRequerimientos";
            smiRequerimientos.Size = new Size(196, 26);
            smiRequerimientos.Text = "Requerimientos";
            // 
            // panelDeUsuarioToolStripMenuItem
            // 
            panelDeUsuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smiPerfil, smiEmpleados });
            panelDeUsuarioToolStripMenuItem.Name = "panelDeUsuarioToolStripMenuItem";
            panelDeUsuarioToolStripMenuItem.Size = new Size(133, 24);
            panelDeUsuarioToolStripMenuItem.Text = "Panel de Usuario";
            // 
            // smiPerfil
            // 
            smiPerfil.Name = "smiPerfil";
            smiPerfil.Size = new Size(166, 26);
            smiPerfil.Text = "Perfil";
            // 
            // smiEmpleados
            // 
            smiEmpleados.Name = "smiEmpleados";
            smiEmpleados.Size = new Size(166, 26);
            smiEmpleados.Text = "Empleados";
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smiLibros, smiFiltros });
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(89, 24);
            inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // smiLibros
            // 
            smiLibros.Name = "smiLibros";
            smiLibros.Size = new Size(200, 26);
            smiLibros.Text = "Libros";
            smiLibros.Click += smiLibros_Click;
            // 
            // smiFiltros
            // 
            smiFiltros.DropDownItems.AddRange(new ToolStripItem[] { smiAutores, smiCategorias });
            smiFiltros.Name = "smiFiltros";
            smiFiltros.Size = new Size(200, 26);
            smiFiltros.Text = "Gestor de Filtros";
            // 
            // smiAutores
            // 
            smiAutores.Name = "smiAutores";
            smiAutores.Size = new Size(163, 26);
            smiAutores.Text = "Autores";
            smiAutores.Click += smiAutores_Click;
            // 
            // smiCategorias
            // 
            smiCategorias.Name = "smiCategorias";
            smiCategorias.Size = new Size(163, 26);
            smiCategorias.Text = "Categorias";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.libreria;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            Text = "Menu Principal";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainMenu_FormClosing;
            FormClosed += MainMenu_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem smiLibros;
        private ToolStripMenuItem smiFiltros;
        private ToolStripMenuItem smiAutores;
        private ToolStripMenuItem smiCategorias;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem smiClientes;
        private ToolStripMenuItem smiRentas;
        private ToolStripMenuItem reabastecimientoToolStripMenuItem;
        private ToolStripMenuItem smiEditoriales;
        private ToolStripMenuItem smiRequerimientos;
        private ToolStripMenuItem panelDeUsuarioToolStripMenuItem;
        private ToolStripMenuItem smiPerfil;
        private ToolStripMenuItem smiEmpleados;
        private ToolStripMenuItem smiMantenimientos;
        private ToolStripMenuItem autoresToolStripMenuItem;
        private ToolStripMenuItem librosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
    }
}