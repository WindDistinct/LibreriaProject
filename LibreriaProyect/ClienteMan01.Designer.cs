namespace LibreriaProyect
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
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // dtgDatos
            // 
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Location = new Point(12, 70);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.RowHeadersWidth = 51;
            dtgDatos.Size = new Size(1082, 420);
            dtgDatos.TabIndex = 0;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(988, 512);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(106, 33);
            lblRegistros.TabIndex = 1;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            lblRegistros.Click += label1_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(76, 21);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(476, 27);
            txtFiltro.TabIndex = 2;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(157, 511);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 34);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 512);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 33);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(523, 512);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(163, 35);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += button1_Click;
            // 
            // lblInfo1
            // 
            lblInfo1.AutoSize = true;
            lblInfo1.Location = new Point(20, 28);
            lblInfo1.Name = "lblInfo1";
            lblInfo1.Size = new Size(50, 20);
            lblInfo1.TabIndex = 6;
            lblInfo1.Text = "Filtrar:";
            // 
            // ClienteMan01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 558);
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
            Name = "ClienteMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Clientes";
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
    }
}