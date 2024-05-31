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
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            smiLibros = new ToolStripMenuItem();
            smiFiltros = new ToolStripMenuItem();
            smiAutores = new ToolStripMenuItem();
            smiCategorias = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            smiClientes = new ToolStripMenuItem();
            smiRentas = new ToolStripMenuItem();
            reabastecimientoToolStripMenuItem = new ToolStripMenuItem();
            smiEditoriales = new ToolStripMenuItem();
            smiRequerimientos = new ToolStripMenuItem();
            panelDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
            smiPerfil = new ToolStripMenuItem();
            smiEmpleados = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inventarioToolStripMenuItem, pedidosToolStripMenuItem, reabastecimientoToolStripMenuItem, panelDeUsuarioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smiLibros, smiFiltros });
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(72, 20);
            inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // smiLibros
            // 
            smiLibros.Name = "smiLibros";
            smiLibros.Size = new Size(180, 22);
            smiLibros.Text = "Libros";
            smiLibros.Click += smiLibros_Click;
            // 
            // smiFiltros
            // 
            smiFiltros.DropDownItems.AddRange(new ToolStripItem[] { smiAutores, smiCategorias });
            smiFiltros.Name = "smiFiltros";
            smiFiltros.Size = new Size(180, 22);
            smiFiltros.Text = "Gestor de Filtros";
            // 
            // smiAutores
            // 
            smiAutores.Name = "smiAutores";
            smiAutores.Size = new Size(180, 22);
            smiAutores.Text = "Autores";
            smiAutores.Click += smiAutores_Click;
            // 
            // smiCategorias
            // 
            smiCategorias.Name = "smiCategorias";
            smiCategorias.Size = new Size(180, 22);
            smiCategorias.Text = "Categorias";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smiClientes, smiRentas });
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(61, 20);
            pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // smiClientes
            // 
            smiClientes.Name = "smiClientes";
            smiClientes.Size = new Size(116, 22);
            smiClientes.Text = "Clientes";
            smiClientes.Click += smiClientes_Click;
            // 
            // smiRentas
            // 
            smiRentas.Name = "smiRentas";
            smiRentas.Size = new Size(116, 22);
            smiRentas.Text = "Rentas";
            // 
            // reabastecimientoToolStripMenuItem
            // 
            reabastecimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smiEditoriales, smiRequerimientos });
            reabastecimientoToolStripMenuItem.Name = "reabastecimientoToolStripMenuItem";
            reabastecimientoToolStripMenuItem.Size = new Size(113, 20);
            reabastecimientoToolStripMenuItem.Text = "Reabastecimiento";
            // 
            // smiEditoriales
            // 
            smiEditoriales.Name = "smiEditoriales";
            smiEditoriales.Size = new Size(180, 22);
            smiEditoriales.Text = "Editoriales";
            // 
            // smiRequerimientos
            // 
            smiRequerimientos.Name = "smiRequerimientos";
            smiRequerimientos.Size = new Size(180, 22);
            smiRequerimientos.Text = "Requerimientos";
            // 
            // panelDeUsuarioToolStripMenuItem
            // 
            panelDeUsuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smiPerfil, smiEmpleados });
            panelDeUsuarioToolStripMenuItem.Name = "panelDeUsuarioToolStripMenuItem";
            panelDeUsuarioToolStripMenuItem.Size = new Size(107, 20);
            panelDeUsuarioToolStripMenuItem.Text = "Panel de Usuario";
            // 
            // smiPerfil
            // 
            smiPerfil.Name = "smiPerfil";
            smiPerfil.Size = new Size(180, 22);
            smiPerfil.Text = "Perfil";
            // 
            // smiEmpleados
            // 
            smiEmpleados.Name = "smiEmpleados";
            smiEmpleados.Size = new Size(180, 22);
            smiEmpleados.Text = "Empleados";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainMenu";
            Text = "Menu Principal";
            WindowState = FormWindowState.Maximized;
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
    }
}