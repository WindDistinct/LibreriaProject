namespace Libreria_GUI.LibroGUI
{
    partial class LibroMan03
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
            txtFecPub = new TextBox();
            cboEditorial = new ComboBox();
            lblEditorial = new Label();
            lblStock = new Label();
            txtStock = new TextBox();
            lblFecPub = new Label();
            lblEdicion = new Label();
            cboGenero = new ComboBox();
            lblGenero = new Label();
            cboAutor = new ComboBox();
            txtEdicion = new TextBox();
            lblAutor = new Label();
            txtNombre = new TextBox();
            btnCancelar = new Button();
            btnGrabar = new Button();
            lblNombre = new Label();
            lblCodNum = new Label();
            lblCodigo = new Label();
            SuspendLayout();
            // 
            // txtFecPub
            // 
            txtFecPub.Location = new Point(142, 130);
            txtFecPub.Name = "txtFecPub";
            txtFecPub.Size = new Size(172, 23);
            txtFecPub.TabIndex = 61;
            txtFecPub.KeyPress += NoNum_KeyPress;
            // 
            // cboEditorial
            // 
            cboEditorial.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEditorial.FormattingEnabled = true;
            cboEditorial.Location = new Point(89, 159);
            cboEditorial.Name = "cboEditorial";
            cboEditorial.Size = new Size(443, 23);
            cboEditorial.TabIndex = 60;
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Location = new Point(14, 162);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(53, 15);
            lblEditorial.TabIndex = 59;
            lblEditorial.Text = "Editorial:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(320, 133);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(42, 15);
            lblStock.TabIndex = 58;
            lblStock.Text = "Stock: ";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(368, 130);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(164, 23);
            txtStock.TabIndex = 57;
            txtStock.KeyPress += NoNum_KeyPress;
            // 
            // lblFecPub
            // 
            lblFecPub.AutoSize = true;
            lblFecPub.Location = new Point(14, 133);
            lblFecPub.Name = "lblFecPub";
            lblFecPub.Size = new Size(122, 15);
            lblFecPub.TabIndex = 56;
            lblFecPub.Text = "Fecha de publicación:";
            // 
            // lblEdicion
            // 
            lblEdicion.AutoSize = true;
            lblEdicion.Location = new Point(12, 104);
            lblEdicion.Name = "lblEdicion";
            lblEdicion.Size = new Size(52, 15);
            lblEdicion.TabIndex = 55;
            lblEdicion.Text = "Edición: ";
            // 
            // cboGenero
            // 
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(344, 72);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(188, 23);
            cboGenero.TabIndex = 54;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(290, 75);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(48, 15);
            lblGenero.TabIndex = 53;
            lblGenero.Text = "Género:";
            // 
            // cboAutor
            // 
            cboAutor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAutor.FormattingEnabled = true;
            cboAutor.Location = new Point(89, 72);
            cboAutor.Name = "cboAutor";
            cboAutor.Size = new Size(195, 23);
            cboAutor.TabIndex = 52;
            // 
            // txtEdicion
            // 
            txtEdicion.Location = new Point(89, 101);
            txtEdicion.Name = "txtEdicion";
            txtEdicion.Size = new Size(443, 23);
            txtEdicion.TabIndex = 51;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(12, 75);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(40, 15);
            lblAutor.TabIndex = 50;
            lblAutor.Text = "Autor:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(89, 44);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(443, 23);
            txtNombre.TabIndex = 49;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(438, 204);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 26);
            btnCancelar.TabIndex = 48;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(311, 204);
            btnGrabar.Margin = new Padding(3, 2, 3, 2);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(97, 26);
            btnGrabar.TabIndex = 47;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 46;
            lblNombre.Text = "Nombre:";
            // 
            // lblCodNum
            // 
            lblCodNum.BorderStyle = BorderStyle.FixedSingle;
            lblCodNum.Location = new Point(263, 9);
            lblCodNum.Name = "lblCodNum";
            lblCodNum.Size = new Size(51, 24);
            lblCodNum.TabIndex = 63;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(202, 15);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 62;
            lblCodigo.Text = "Código:";
            // 
            // LibroMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 245);
            Controls.Add(lblCodNum);
            Controls.Add(lblCodigo);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LibroMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Libro";
            Load += LibroMan03_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFecPub;
        private ComboBox cboEditorial;
        private Label lblEditorial;
        private Label lblStock;
        private TextBox txtStock;
        private Label lblFecPub;
        private Label lblEdicion;
        private ComboBox cboGenero;
        private Label lblGenero;
        private ComboBox cboAutor;
        private TextBox txtEdicion;
        private Label lblAutor;
        private TextBox txtNombre;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label lblNombre;
        private Label lblCodNum;
        private Label lblCodigo;
    }
}