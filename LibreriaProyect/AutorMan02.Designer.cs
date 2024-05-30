namespace Libreria_GUI
{
    partial class AutorMan02
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
            txtPais = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblPais = new Label();
            lblApe = new Label();
            lblNombre = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            SuspendLayout();
            // 
            // txtPais
            // 
            txtPais.Location = new Point(104, 106);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(508, 27);
            txtPais.TabIndex = 21;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(104, 62);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(508, 27);
            txtApellido.TabIndex = 20;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(104, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(508, 27);
            txtNombre.TabIndex = 19;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(16, 113);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(37, 20);
            lblPais.TabIndex = 18;
            lblPais.Text = "Pais:";
            // 
            // lblApe
            // 
            lblApe.AutoSize = true;
            lblApe.Location = new Point(16, 69);
            lblApe.Name = "lblApe";
            lblApe.Size = new Size(69, 20);
            lblApe.TabIndex = 17;
            lblApe.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(16, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 16;
            lblNombre.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(503, 211);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 35);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(339, 211);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(111, 35);
            btnGrabar.TabIndex = 22;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // AutorMan02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 260);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(txtPais);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblPais);
            Controls.Add(lblApe);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AutorMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Autor";
            Load += AutorMan02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPais;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblPais;
        private Label lblApe;
        private Label lblNombre;
        private Button btnCancelar;
        private Button btnGrabar;
    }
}