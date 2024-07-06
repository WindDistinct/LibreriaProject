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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Filtro = new Label();
            txtBuscador = new TextBox();
            dtgDatos = new DataGridView();
            lib_id = new DataGridViewTextBoxColumn();
            Libro = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            Edicion = new DataGridViewTextBoxColumn();
            Ano_de_publicacion = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Editorial = new DataGridViewTextBoxColumn();
            btnCerrar = new Button();
            btnAgregar = new Button();
            btnEditar = new Button();
            lblRegistros = new Label();
            bkgDatos = new System.ComponentModel.BackgroundWorker();
            btnImportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
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
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AllowUserToOrderColumns = true;
            dtgDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dtgDatos.BackgroundColor = SystemColors.ControlLight;
            dtgDatos.BorderStyle = BorderStyle.Fixed3D;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { lib_id, Libro, Autor, Genero, Edicion, Ano_de_publicacion, Stock, Editorial });
            dtgDatos.Location = new Point(10, 52);
            dtgDatos.Margin = new Padding(3, 2, 3, 2);
            dtgDatos.MultiSelect = false;
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.ShowCellErrors = false;
            dtgDatos.ShowCellToolTips = false;
            dtgDatos.ShowEditingIcon = false;
            dtgDatos.ShowRowErrors = false;
            dtgDatos.Size = new Size(947, 315);
            dtgDatos.TabIndex = 2;
            // 
            // lib_id
            // 
            lib_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            lib_id.DataPropertyName = "lib_id";
            lib_id.HeaderText = "ID";
            lib_id.Name = "lib_id";
            lib_id.ReadOnly = true;
            lib_id.Width = 43;
            // 
            // Libro
            // 
            Libro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Libro.DataPropertyName = "Libro";
            Libro.HeaderText = "Libro";
            Libro.Name = "Libro";
            Libro.ReadOnly = true;
            // 
            // Autor
            // 
            Autor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Autor.DataPropertyName = "Autor";
            Autor.HeaderText = "Autor";
            Autor.Name = "Autor";
            Autor.ReadOnly = true;
            // 
            // Genero
            // 
            Genero.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Genero.DataPropertyName = "Genero";
            Genero.HeaderText = "Género";
            Genero.Name = "Genero";
            Genero.ReadOnly = true;
            // 
            // Edicion
            // 
            Edicion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Edicion.DataPropertyName = "Edicion";
            Edicion.HeaderText = "Edición";
            Edicion.Name = "Edicion";
            Edicion.ReadOnly = true;
            // 
            // Ano_de_publicacion
            // 
            Ano_de_publicacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Ano_de_publicacion.DataPropertyName = "Ano_de_publicacion";
            Ano_de_publicacion.HeaderText = "Año de publicación";
            Ano_de_publicacion.Name = "Ano_de_publicacion";
            Ano_de_publicacion.ReadOnly = true;
            Ano_de_publicacion.Width = 124;
            // 
            // Stock
            // 
            Stock.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Stock.DataPropertyName = "Stock";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            Stock.DefaultCellStyle = dataGridViewCellStyle2;
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 61;
            // 
            // Editorial
            // 
            Editorial.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Editorial.DataPropertyName = "Editorial";
            Editorial.HeaderText = "Editorial";
            Editorial.Name = "Editorial";
            Editorial.ReadOnly = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(864, 382);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(93, 25);
            lblRegistros.TabIndex = 6;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // bkgDatos
            // 
            bkgDatos.WorkerReportsProgress = true;
            bkgDatos.WorkerSupportsCancellation = true;
            bkgDatos.DoWork += bkgDatos_DoWork;
            bkgDatos.RunWorkerCompleted += bkgDatos_RunWorkerCompleted;
            // 
            // btnImportar
            // 
            btnImportar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnImportar.Location = new Point(261, 380);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(88, 27);
            btnImportar.TabIndex = 10;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // LibroMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 418);
            Controls.Add(btnImportar);
            Controls.Add(btnCerrar);
            Controls.Add(btnAgregar);
            Controls.Add(btnEditar);
            Controls.Add(lblRegistros);
            Controls.Add(dtgDatos);
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
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Filtro;
        private TextBox txtBuscador;
        private DataGridView dtgDatos;
        private Button btnCerrar;
        private Button btnAgregar;
        private Button btnEditar;
        private Label lblRegistros;
        private System.ComponentModel.BackgroundWorker bkgDatos;
        private Button btnImportar;
        private DataGridViewTextBoxColumn lib_id;
        private DataGridViewTextBoxColumn Libro;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Edicion;
        private DataGridViewTextBoxColumn Ano_de_publicacion;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Editorial;
    }
}