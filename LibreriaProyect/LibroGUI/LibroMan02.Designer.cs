namespace Libreria_GUI.LibroGUI
{
    partial class LibroMan02
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
            txtNombre = new TextBox();
            btnCancelar = new Button();
            btnGrabar = new Button();
            lblNombre = new Label();
            lblAutor = new Label();
            txtEdicion = new TextBox();
            cboAutor = new ComboBox();
            lblGenero = new Label();
            cboGenero = new ComboBox();
            lblEdicion = new Label();
            lblFecPub = new Label();
            txtStock = new TextBox();
            lblStock = new Label();
            lblEditorial = new Label();
            cboEditorial = new ComboBox();
            txtFecPub = new TextBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(104, 19);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(443, 23);
            txtNombre.TabIndex = 32;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(453, 179);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 26);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(326, 179);
            btnGrabar.Margin = new Padding(3, 2, 3, 2);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(97, 26);
            btnGrabar.TabIndex = 30;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(27, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Nombre:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(27, 50);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(40, 15);
            lblAutor.TabIndex = 33;
            lblAutor.Text = "Autor:";
            // 
            // txtEdicion
            // 
            txtEdicion.Location = new Point(104, 76);
            txtEdicion.Name = "txtEdicion";
            txtEdicion.Size = new Size(443, 23);
            txtEdicion.TabIndex = 34;
            // 
            // cboAutor
            // 
            cboAutor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAutor.FormattingEnabled = true;
            cboAutor.Location = new Point(104, 47);
            cboAutor.Name = "cboAutor";
            cboAutor.Size = new Size(195, 23);
            cboAutor.TabIndex = 35;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(305, 50);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(48, 15);
            lblGenero.TabIndex = 36;
            lblGenero.Text = "Género:";
            // 
            // cboGenero
            // 
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(359, 47);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(188, 23);
            cboGenero.TabIndex = 37;
            // 
            // lblEdicion
            // 
            lblEdicion.AutoSize = true;
            lblEdicion.Location = new Point(27, 79);
            lblEdicion.Name = "lblEdicion";
            lblEdicion.Size = new Size(52, 15);
            lblEdicion.TabIndex = 38;
            lblEdicion.Text = "Edición: ";
            // 
            // lblFecPub
            // 
            lblFecPub.AutoSize = true;
            lblFecPub.Location = new Point(27, 108);
            lblFecPub.Name = "lblFecPub";
            lblFecPub.Size = new Size(113, 15);
            lblFecPub.TabIndex = 39;
            lblFecPub.Text = "Año de publicación:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(383, 105);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(164, 23);
            txtStock.TabIndex = 41;
            txtStock.KeyPress += NoNumber_KeyPress;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(335, 108);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(42, 15);
            lblStock.TabIndex = 42;
            lblStock.Text = "Stock: ";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Location = new Point(29, 137);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(53, 15);
            lblEditorial.TabIndex = 43;
            lblEditorial.Text = "Editorial:";
            // 
            // cboEditorial
            // 
            cboEditorial.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEditorial.FormattingEnabled = true;
            cboEditorial.Location = new Point(104, 134);
            cboEditorial.Name = "cboEditorial";
            cboEditorial.Size = new Size(443, 23);
            cboEditorial.TabIndex = 44;
            // 
            // txtFecPub
            // 
            txtFecPub.Location = new Point(157, 105);
            txtFecPub.Name = "txtFecPub";
            txtFecPub.Size = new Size(172, 23);
            txtFecPub.TabIndex = 45;
            txtFecPub.KeyPress += NoNumber_KeyPress;
            // 
            // LibroMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 226);
            Controls.Add(txtFecPub);
            Controls.Add(cboEditorial);
            Controls.Add(lblEditorial);
            Controls.Add(lblStock);
            Controls.Add(txtStock);
            Controls.Add(lblFecPub);
            Controls.Add(lblEdicion);
            Controls.Add(cboGenero);
            Controls.Add(lblGenero);
            Controls.Add(cboAutor);
            Controls.Add(txtEdicion);
            Controls.Add(lblAutor);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LibroMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Libro";
            Load += LibroMan02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label lblNombre;
        private Label lblAutor;
        private TextBox txtEdicion;
        private ComboBox cboAutor;
        private Label lblGenero;
        private ComboBox cboGenero;
        private Label lblEdicion;
        private Label lblFecPub;
        private TextBox txtStock;
        private Label lblStock;
        private Label lblEditorial;
        private ComboBox cboEditorial;
        private TextBox txtFecPub;
    }
}