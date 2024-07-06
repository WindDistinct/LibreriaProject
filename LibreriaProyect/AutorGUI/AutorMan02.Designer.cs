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
            lblRuta = new Label();
            pcbFoto = new PictureBox();
            btnCargarFoto = new Button();
            lblFoto = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
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
            // lblRuta
            // 
            lblRuta.BorderStyle = BorderStyle.FixedSingle;
            lblRuta.Location = new Point(401, 164);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(211, 24);
            lblRuta.TabIndex = 31;
            lblRuta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pcbFoto
            // 
            pcbFoto.Location = new Point(316, 146);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(60, 55);
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.TabIndex = 30;
            pcbFoto.TabStop = false;
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.Location = new Point(104, 159);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(191, 29);
            btnCargarFoto.TabIndex = 29;
            btnCargarFoto.Text = "Cargar Foto";
            btnCargarFoto.UseVisualStyleBackColor = true;
            btnCargarFoto.Click += btnCargarFoto_Click;
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Location = new Point(16, 163);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(42, 20);
            lblFoto.TabIndex = 28;
            lblFoto.Text = "Foto:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AutorMan02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 260);
            Controls.Add(lblRuta);
            Controls.Add(pcbFoto);
            Controls.Add(btnCargarFoto);
            Controls.Add(lblFoto);
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
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
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
        private Label lblRuta;
        private PictureBox pcbFoto;
        private Button btnCargarFoto;
        private Label lblFoto;
        private OpenFileDialog openFileDialog1;
    }
}