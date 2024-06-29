namespace LibreriaProyect
{
    partial class ClienteMan03
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
            txtEmail = new TextBox();
            txtDni = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            btnCancelar = new Button();
            btnGrabar = new Button();
            groupBox1 = new GroupBox();
            optMujer = new RadioButton();
            optHombre = new RadioButton();
            dtpFecNac = new DateTimePicker();
            lblFecNac = new Label();
            lblDni = new Label();
            lblEmail = new Label();
            lblTel = new Label();
            lblDir = new Label();
            lblApe = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            lblCodNum = new Label();
            lblDist = new Label();
            lblProv = new Label();
            lblReg = new Label();
            cboDistrito = new ComboBox();
            cboProvincia = new ComboBox();
            cboRegion = new ComboBox();
            lblUbi = new Label();
            lblRuta = new Label();
            pcbFoto = new PictureBox();
            btnCargarFoto = new Button();
            lblFoto = new Label();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(109, 232);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(508, 27);
            txtEmail.TabIndex = 37;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(397, 191);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(220, 27);
            txtDni.TabIndex = 36;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(109, 191);
            txtTelefono.MaxLength = 11;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(191, 27);
            txtTelefono.TabIndex = 35;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(109, 148);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(508, 27);
            txtDireccion.TabIndex = 34;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(109, 104);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(508, 27);
            txtApellido.TabIndex = 33;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(109, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(508, 27);
            txtNombre.TabIndex = 32;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(193, 466);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 35);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(57, 466);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(111, 35);
            btnGrabar.TabIndex = 30;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optMujer);
            groupBox1.Controls.Add(optHombre);
            groupBox1.Location = new Point(353, 408);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 93);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sexo:";
            // 
            // optMujer
            // 
            optMujer.AutoSize = true;
            optMujer.Location = new Point(34, 56);
            optMujer.Name = "optMujer";
            optMujer.Size = new Size(95, 24);
            optMujer.TabIndex = 1;
            optMujer.TabStop = true;
            optMujer.Text = "Femenino";
            optMujer.UseVisualStyleBackColor = true;
            // 
            // optHombre
            // 
            optHombre.AutoSize = true;
            optHombre.Location = new Point(34, 26);
            optHombre.Name = "optHombre";
            optHombre.Size = new Size(97, 24);
            optHombre.TabIndex = 0;
            optHombre.TabStop = true;
            optHombre.Text = "Masculino";
            optHombre.UseVisualStyleBackColor = true;
            // 
            // dtpFecNac
            // 
            dtpFecNac.Format = DateTimePickerFormat.Short;
            dtpFecNac.Location = new Point(193, 420);
            dtpFecNac.MaxDate = new DateTime(2006, 6, 15, 0, 0, 0, 0);
            dtpFecNac.Name = "dtpFecNac";
            dtpFecNac.Size = new Size(105, 27);
            dtpFecNac.TabIndex = 28;
            dtpFecNac.Value = new DateTime(2006, 6, 1, 0, 0, 0, 0);
            // 
            // lblFecNac
            // 
            lblFecNac.AutoSize = true;
            lblFecNac.Location = new Point(21, 425);
            lblFecNac.Name = "lblFecNac";
            lblFecNac.Size = new Size(152, 20);
            lblFecNac.TabIndex = 27;
            lblFecNac.Text = "Fecha de Nacimiento:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(353, 198);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(38, 20);
            lblDni.TabIndex = 24;
            lblDni.Text = "DNI:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(21, 239);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Email:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(21, 198);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(70, 20);
            lblTel.TabIndex = 22;
            lblTel.Text = "Teléfono:";
            // 
            // lblDir
            // 
            lblDir.AutoSize = true;
            lblDir.Location = new Point(21, 155);
            lblDir.Name = "lblDir";
            lblDir.Size = new Size(75, 20);
            lblDir.TabIndex = 21;
            lblDir.Text = "Dirección:";
            // 
            // lblApe
            // 
            lblApe.AutoSize = true;
            lblApe.Location = new Point(21, 111);
            lblApe.Name = "lblApe";
            lblApe.Size = new Size(69, 20);
            lblApe.TabIndex = 20;
            lblApe.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(21, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(237, 28);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(61, 20);
            lblCodigo.TabIndex = 38;
            lblCodigo.Text = "Código:";
            // 
            // lblCodNum
            // 
            lblCodNum.BorderStyle = BorderStyle.FixedSingle;
            lblCodNum.Location = new Point(306, 20);
            lblCodNum.Name = "lblCodNum";
            lblCodNum.Size = new Size(58, 32);
            lblCodNum.TabIndex = 39;
            // 
            // lblDist
            // 
            lblDist.AutoSize = true;
            lblDist.Location = new Point(455, 284);
            lblDist.Name = "lblDist";
            lblDist.Size = new Size(61, 20);
            lblDist.TabIndex = 46;
            lblDist.Text = "Distrito:";
            // 
            // lblProv
            // 
            lblProv.AutoSize = true;
            lblProv.Location = new Point(282, 284);
            lblProv.Name = "lblProv";
            lblProv.Size = new Size(72, 20);
            lblProv.TabIndex = 45;
            lblProv.Text = "Provincia:";
            // 
            // lblReg
            // 
            lblReg.AutoSize = true;
            lblReg.Location = new Point(109, 284);
            lblReg.Name = "lblReg";
            lblReg.Size = new Size(59, 20);
            lblReg.TabIndex = 44;
            lblReg.Text = "Región:";
            // 
            // cboDistrito
            // 
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(455, 307);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(162, 28);
            cboDistrito.TabIndex = 43;
            // 
            // cboProvincia
            // 
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(282, 307);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(162, 28);
            cboProvincia.TabIndex = 42;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // cboRegion
            // 
            cboRegion.FormattingEnabled = true;
            cboRegion.Location = new Point(109, 307);
            cboRegion.Name = "cboRegion";
            cboRegion.Size = new Size(162, 28);
            cboRegion.TabIndex = 41;
            cboRegion.SelectionChangeCommitted += cboRegion_SelectionChangeCommitted;
            // 
            // lblUbi
            // 
            lblUbi.AutoSize = true;
            lblUbi.Location = new Point(21, 284);
            lblUbi.Name = "lblUbi";
            lblUbi.Size = new Size(61, 20);
            lblUbi.TabIndex = 40;
            lblUbi.Text = "Ubigeo:";
            // 
            // lblRuta
            // 
            lblRuta.BorderStyle = BorderStyle.FixedSingle;
            lblRuta.Location = new Point(406, 365);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(211, 24);
            lblRuta.TabIndex = 50;
            lblRuta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pcbFoto
            // 
            pcbFoto.Location = new Point(321, 347);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(60, 55);
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.TabIndex = 49;
            pcbFoto.TabStop = false;
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.Location = new Point(109, 360);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(191, 29);
            btnCargarFoto.TabIndex = 48;
            btnCargarFoto.Text = "Cargar Foto";
            btnCargarFoto.UseVisualStyleBackColor = true;
            btnCargarFoto.Click += btnCargarFoto_Click;
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Location = new Point(21, 364);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(42, 20);
            lblFoto.TabIndex = 47;
            lblFoto.Text = "Foto:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ClienteMan03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 554);
            Controls.Add(lblRuta);
            Controls.Add(pcbFoto);
            Controls.Add(btnCargarFoto);
            Controls.Add(lblFoto);
            Controls.Add(lblDist);
            Controls.Add(lblProv);
            Controls.Add(lblReg);
            Controls.Add(cboDistrito);
            Controls.Add(cboProvincia);
            Controls.Add(cboRegion);
            Controls.Add(lblUbi);
            Controls.Add(lblCodNum);
            Controls.Add(lblCodigo);
            Controls.Add(txtEmail);
            Controls.Add(txtDni);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(groupBox1);
            Controls.Add(dtpFecNac);
            Controls.Add(lblFecNac);
            Controls.Add(lblDni);
            Controls.Add(lblEmail);
            Controls.Add(lblTel);
            Controls.Add(lblDir);
            Controls.Add(lblApe);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClienteMan03";
            Text = "Editar Cliente";
            Load += ClienteMan03_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtDni;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnCancelar;
        private Button btnGrabar;
        private GroupBox groupBox1;
        private RadioButton optMujer;
        private RadioButton optHombre;
        private DateTimePicker dtpFecNac;
        private Label lblFecNac;
        private Label lblDni;
        private Label lblEmail;
        private Label lblTel;
        private Label lblDir;
        private Label lblApe;
        private Label lblNombre;
        private Label lblCodigo;
        private Label lblCodNum;
        private Label lblDist;
        private Label lblProv;
        private Label lblReg;
        private ComboBox cboDistrito;
        private ComboBox cboProvincia;
        private ComboBox cboRegion;
        private Label lblUbi;
        private Label lblRuta;
        private PictureBox pcbFoto;
        private Button btnCargarFoto;
        private Label lblFoto;
        private OpenFileDialog openFileDialog1;
    }
}