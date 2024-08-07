﻿namespace LibreriaProyect
{
    partial class ClienteMan01
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
            dtgDatos = new DataGridView();
            lblRegistros = new Label();
            txtFiltro = new TextBox();
            btnEditar = new Button();
            btnAgregar = new Button();
            btnCerrar = new Button();
            lblInfo1 = new Label();
            Id = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Distrito = new DataGridViewTextBoxColumn();
            Fecha_de_nacimiento = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Tipo_Membresia = new DataGridViewTextBoxColumn();
            Caducidad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AllowUserToOrderColumns = true;
            dtgDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.BackgroundColor = SystemColors.ControlLight;
            dtgDatos.BorderStyle = BorderStyle.Fixed3D;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { Id, Apellido, Nombre, DNI, Foto, Direccion, Correo, Distrito, Fecha_de_nacimiento, Sexo, Tipo_Membresia, Caducidad });
            dtgDatos.Location = new Point(10, 52);
            dtgDatos.Margin = new Padding(3, 2, 3, 2);
            dtgDatos.MultiSelect = false;
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersWidth = 51;
            dtgDatos.RowTemplate.Height = 50;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.ShowCellErrors = false;
            dtgDatos.ShowCellToolTips = false;
            dtgDatos.ShowEditingIcon = false;
            dtgDatos.ShowRowErrors = false;
            dtgDatos.Size = new Size(947, 315);
            dtgDatos.TabIndex = 0;
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(864, 384);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(93, 25);
            lblRegistros.TabIndex = 1;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            lblRegistros.Click += label1_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(66, 16);
            txtFiltro.Margin = new Padding(3, 2, 3, 2);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(417, 23);
            txtFiltro.TabIndex = 2;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.Location = new Point(137, 383);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(105, 26);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.Location = new Point(10, 384);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(107, 25);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrar.Location = new Point(454, 383);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(143, 26);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += button1_Click;
            // 
            // lblInfo1
            // 
            lblInfo1.AutoSize = true;
            lblInfo1.Location = new Point(18, 21);
            lblInfo1.Name = "lblInfo1";
            lblInfo1.Size = new Size(40, 15);
            lblInfo1.TabIndex = 6;
            lblInfo1.Text = "Filtrar:";
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 42;
            // 
            // Apellido
            // 
            Apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // DNI
            // 
            DNI.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DNI.DataPropertyName = "DNI";
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            // 
            // Foto
            // 
            Foto.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Foto.DataPropertyName = "Foto";
            Foto.HeaderText = "Foto";
            Foto.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Foto.Name = "Foto";
            Foto.ReadOnly = true;
            Foto.Resizable = DataGridViewTriState.True;
            Foto.SortMode = DataGridViewColumnSortMode.Automatic;
            Foto.Width = 56;
            // 
            // Direccion
            // 
            Direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Telefono";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Correo.DataPropertyName = "Correo";
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Distrito
            // 
            Distrito.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Distrito.DataPropertyName = "Distrito";
            Distrito.HeaderText = "Distrito";
            Distrito.Name = "Distrito";
            Distrito.ReadOnly = true;
            // 
            // Fecha_de_nacimiento
            // 
            Fecha_de_nacimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Fecha_de_nacimiento.DataPropertyName = "Fecha_de_nacimiento";
            Fecha_de_nacimiento.HeaderText = "Fecha de Nacimiento";
            Fecha_de_nacimiento.Name = "Fecha_de_nacimiento";
            Fecha_de_nacimiento.ReadOnly = true;
            // 
            // Sexo
            // 
            Sexo.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Sexo.DataPropertyName = "Sexo";
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            Sexo.Width = 57;
            // 
            // Tipo_Membresia
            // 
            Tipo_Membresia.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Tipo_Membresia.DataPropertyName = "Tipo_Membresia";
            Tipo_Membresia.HeaderText = "Membresía";
            Tipo_Membresia.Name = "Tipo_Membresia";
            Tipo_Membresia.ReadOnly = true;
            Tipo_Membresia.Width = 91;
            // 
            // Caducidad
            // 
            Caducidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Caducidad.DataPropertyName = "Caducidad";
            Caducidad.HeaderText = "Caducidad";
            Caducidad.Name = "Caducidad";
            Caducidad.ReadOnly = true;
            Caducidad.Width = 89;
            // 
            // ClienteMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 418);
            Controls.Add(lblInfo1);
            Controls.Add(btnCerrar);
            Controls.Add(btnAgregar);
            Controls.Add(btnEditar);
            Controls.Add(txtFiltro);
            Controls.Add(lblRegistros);
            Controls.Add(dtgDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClienteMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Clientes";
            WindowState = FormWindowState.Maximized;
            Load += ClienteMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDatos;
        private Label lblRegistros;
        private TextBox txtFiltro;
        private Button btnEditar;
        private Button btnAgregar;
        private Button btnCerrar;
        private Label lblInfo1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewImageColumn Foto;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Distrito;
        private DataGridViewTextBoxColumn Fecha_de_nacimiento;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn Tipo_Membresia;
        private DataGridViewTextBoxColumn Caducidad;
    }
}