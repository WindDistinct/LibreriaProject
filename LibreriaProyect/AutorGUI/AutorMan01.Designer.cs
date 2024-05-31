namespace Libreria_GUI
{
    partial class AutorMan01
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
            lblInfo1 = new Label();
            btnCerrar = new Button();
            btnAgregar = new Button();
            btnEditar = new Button();
            txtFiltro = new TextBox();
            lblRegistros = new Label();
            dtgDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // lblInfo1
            // 
            lblInfo1.AutoSize = true;
            lblInfo1.Location = new Point(6, 9);
            lblInfo1.Name = "lblInfo1";
            lblInfo1.Size = new Size(50, 20);
            lblInfo1.TabIndex = 13;
            lblInfo1.Text = "Filtrar:";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(661, 494);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(122, 35);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(11, 494);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 33);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(209, 494);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(122, 34);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(62, 6);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(476, 27);
            txtFiltro.TabIndex = 9;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(966, 496);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(122, 33);
            lblRegistros.TabIndex = 8;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtgDatos
            // 
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Location = new Point(6, 51);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.RowHeadersWidth = 51;
            dtgDatos.Size = new Size(1082, 420);
            dtgDatos.TabIndex = 7;
            // 
            // AutorMan01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 550);
            Controls.Add(lblInfo1);
            Controls.Add(btnCerrar);
            Controls.Add(btnAgregar);
            Controls.Add(btnEditar);
            Controls.Add(txtFiltro);
            Controls.Add(lblRegistros);
            Controls.Add(dtgDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AutorMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Autores";
            Load += AutorMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo1;
        private Button btnCerrar;
        private Button btnAgregar;
        private Button btnEditar;
        private TextBox txtFiltro;
        private Label lblRegistros;
        private DataGridView dtgDatos;
    }
}