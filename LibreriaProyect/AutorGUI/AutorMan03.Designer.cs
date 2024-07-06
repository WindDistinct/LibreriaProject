namespace Libreria_GUI
{
    partial class AutorMan03
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
            btnCancelar = new Button();
            btnGrabar = new Button();
            txtPais = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblPais = new Label();
            lblApe = new Label();
            lblNombre = new Label();
            lblCodNum = new Label();
            lblCodigo = new Label();
            lblRuta = new Label();
            pcbFoto = new PictureBox();
            btnCargarFoto = new Button();
            lblFoto = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(514, 255);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 35);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(350, 255);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(111, 35);
            btnGrabar.TabIndex = 30;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(115, 154);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(508, 27);
            txtPais.TabIndex = 29;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(115, 106);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(508, 27);
            txtApellido.TabIndex = 28;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(115, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(508, 27);
            txtNombre.TabIndex = 27;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(27, 157);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(37, 20);
            lblPais.TabIndex = 26;
            lblPais.Text = "Pais:";
            // 
            // lblApe
            // 
            lblApe.AutoSize = true;
            lblApe.Location = new Point(27, 113);
            lblApe.Name = "lblApe";
            lblApe.Size = new Size(69, 20);
            lblApe.TabIndex = 25;
            lblApe.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(27, 75);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 24;
            lblNombre.Text = "Nombre:";
            // 
            // lblCodNum
            // 
            lblCodNum.BorderStyle = BorderStyle.FixedSingle;
            lblCodNum.Location = new Point(221, 18);
            lblCodNum.Name = "lblCodNum";
            lblCodNum.Size = new Size(58, 32);
            lblCodNum.TabIndex = 41;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(154, 30);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(61, 20);
            lblCodigo.TabIndex = 40;
            lblCodigo.Text = "Código:";
            // 
            // lblRuta
            // 
            lblRuta.BorderStyle = BorderStyle.FixedSingle;
            lblRuta.Location = new Point(412, 208);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(211, 24);
            lblRuta.TabIndex = 45;
            lblRuta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pcbFoto
            // 
            pcbFoto.Location = new Point(327, 190);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(60, 55);
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.TabIndex = 44;
            pcbFoto.TabStop = false;
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.Location = new Point(115, 203);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(191, 29);
            btnCargarFoto.TabIndex = 43;
            btnCargarFoto.Text = "Cargar Foto";
            btnCargarFoto.UseVisualStyleBackColor = true;
            btnCargarFoto.Click += btnCargarFoto_Click;
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Location = new Point(27, 207);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(42, 20);
            lblFoto.TabIndex = 42;
            lblFoto.Text = "Foto:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AutorMan03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 314);
            Controls.Add(lblRuta);
            Controls.Add(pcbFoto);
            Controls.Add(btnCargarFoto);
            Controls.Add(lblFoto);
            Controls.Add(lblCodNum);
            Controls.Add(lblCodigo);
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
            Name = "AutorMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Autor";
            Load += AutorMan03_Load;
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGrabar;
        private TextBox txtPais;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblPais;
        private Label lblApe;
        private Label lblNombre;
        private Label lblCodNum;
        private Label lblCodigo;
        private Label lblRuta;
        private PictureBox pcbFoto;
        private Button btnCargarFoto;
        private Label lblFoto;
        private OpenFileDialog openFileDialog1;
    }
}