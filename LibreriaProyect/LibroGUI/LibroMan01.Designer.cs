namespace Libreria_GUI.Libro
{
    partial class LibroMan01
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
            Filtro = new Label();
            txtBuscador = new TextBox();
            dgvDatos = new DataGridView();
            btnCerrar = new Button();
            btnAgregar = new Button();
            btnEditar = new Button();
            lblRegistros = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // Filtro
            // 
            Filtro.AutoSize = true;
            Filtro.Location = new Point(18, 21);
            Filtro.Name = "Filtro";
            Filtro.Size = new Size(37, 15);
            Filtro.TabIndex = 0;
            Filtro.Text = "Filtro:";
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(66, 16);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(417, 23);
            txtBuscador.TabIndex = 1;
            txtBuscador.TextChanged += txtFiltro_TextChanged;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(10, 52);
            dgvDatos.Margin = new Padding(3, 2, 3, 2);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(947, 315);
            dgvDatos.TabIndex = 2;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(458, 382);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(143, 26);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(10, 382);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(107, 25);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(137, 381);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(105, 26);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(864, 382);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(93, 25);
            lblRegistros.TabIndex = 6;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LibroMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 418);
            Controls.Add(btnCerrar);
            Controls.Add(btnAgregar);
            Controls.Add(btnEditar);
            Controls.Add(lblRegistros);
            Controls.Add(dgvDatos);
            Controls.Add(txtBuscador);
            Controls.Add(Filtro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LibroMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LibroMan01";
            WindowState = FormWindowState.Maximized;
            Load += LibroMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Filtro;
        private TextBox txtBuscador;
        private DataGridView dgvDatos;
        private Button btnCerrar;
        private Button btnAgregar;
        private Button btnEditar;
        private Label lblRegistros;
    }
}