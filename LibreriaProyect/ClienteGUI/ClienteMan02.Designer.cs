namespace LibreriaProyect
{
    partial class ClienteMan02
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
            lblNombre = new Label();
            lblApe = new Label();
            lblDir = new Label();
            lblTel = new Label();
            lblEmail = new Label();
            lblDni = new Label();
            lblUbi = new Label();
            cboRegion = new ComboBox();
            lblFecNac = new Label();
            dtpFecNac = new DateTimePicker();
            groupBox1 = new GroupBox();
            optMujer = new RadioButton();
            optHombre = new RadioButton();
            btnGrabar = new Button();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtDni = new TextBox();
            txtEmail = new TextBox();
            cboProvincia = new ComboBox();
            cboDistrito = new ComboBox();
            lblReg = new Label();
            lblProv = new Label();
            lblDist = new Label();
            lblFoto = new Label();
            btnCargarFoto = new Button();
            pcbFoto = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            lblRuta = new Label();
            groupBox2 = new GroupBox();
            optPremium = new RadioButton();
            optBasico = new RadioButton();
            optEstandar = new RadioButton();
            label1 = new Label();
            dtpCaducidad = new DateTimePicker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(31, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApe
            // 
            lblApe.AutoSize = true;
            lblApe.Location = new Point(31, 63);
            lblApe.Name = "lblApe";
            lblApe.Size = new Size(69, 20);
            lblApe.TabIndex = 1;
            lblApe.Text = "Apellido:";
            // 
            // lblDir
            // 
            lblDir.AutoSize = true;
            lblDir.Location = new Point(31, 107);
            lblDir.Name = "lblDir";
            lblDir.Size = new Size(75, 20);
            lblDir.TabIndex = 2;
            lblDir.Text = "Dirección:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(31, 150);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(70, 20);
            lblTel.TabIndex = 3;
            lblTel.Text = "Teléfono:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(31, 191);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(363, 150);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(38, 20);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI:";
            // 
            // lblUbi
            // 
            lblUbi.AutoSize = true;
            lblUbi.Location = new Point(31, 238);
            lblUbi.Name = "lblUbi";
            lblUbi.Size = new Size(61, 20);
            lblUbi.TabIndex = 6;
            lblUbi.Text = "Ubigeo:";
            // 
            // cboRegion
            // 
            cboRegion.FormattingEnabled = true;
            cboRegion.Location = new Point(119, 261);
            cboRegion.Name = "cboRegion";
            cboRegion.Size = new Size(162, 28);
            cboRegion.TabIndex = 7;
            cboRegion.SelectionChangeCommitted += cboRegion_SelectionChangeCommitted;
            // 
            // lblFecNac
            // 
            lblFecNac.AutoSize = true;
            lblFecNac.Location = new Point(31, 389);
            lblFecNac.Name = "lblFecNac";
            lblFecNac.Size = new Size(152, 20);
            lblFecNac.TabIndex = 8;
            lblFecNac.Text = "Fecha de Nacimiento:";
            // 
            // dtpFecNac
            // 
            dtpFecNac.Format = DateTimePickerFormat.Short;
            dtpFecNac.Location = new Point(203, 384);
            dtpFecNac.MaxDate = new DateTime(2006, 6, 15, 0, 0, 0, 0);
            dtpFecNac.Name = "dtpFecNac";
            dtpFecNac.Size = new Size(107, 27);
            dtpFecNac.TabIndex = 9;
            dtpFecNac.Value = new DateTime(2006, 6, 1, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optMujer);
            groupBox1.Controls.Add(optHombre);
            groupBox1.Location = new Point(377, 384);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 93);
            groupBox1.TabIndex = 10;
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
            // btnGrabar
            // 
            btnGrabar.Location = new Point(377, 572);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(111, 35);
            btnGrabar.TabIndex = 11;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(518, 572);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 35);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(119, 18);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(508, 27);
            txtNombre.TabIndex = 13;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(119, 56);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(508, 27);
            txtApellido.TabIndex = 14;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(119, 100);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(508, 27);
            txtDireccion.TabIndex = 15;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(119, 143);
            txtTelefono.MaxLength = 11;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(191, 27);
            txtTelefono.TabIndex = 16;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(407, 143);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(220, 27);
            txtDni.TabIndex = 17;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(119, 184);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(508, 27);
            txtEmail.TabIndex = 18;
            // 
            // cboProvincia
            // 
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(292, 261);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(162, 28);
            cboProvincia.TabIndex = 19;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // cboDistrito
            // 
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(465, 261);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(162, 28);
            cboDistrito.TabIndex = 20;
            // 
            // lblReg
            // 
            lblReg.AutoSize = true;
            lblReg.Location = new Point(119, 238);
            lblReg.Name = "lblReg";
            lblReg.Size = new Size(59, 20);
            lblReg.TabIndex = 21;
            lblReg.Text = "Región:";
            lblReg.Click += label1_Click;
            // 
            // lblProv
            // 
            lblProv.AutoSize = true;
            lblProv.Location = new Point(292, 238);
            lblProv.Name = "lblProv";
            lblProv.Size = new Size(72, 20);
            lblProv.TabIndex = 22;
            lblProv.Text = "Provincia:";
            // 
            // lblDist
            // 
            lblDist.AutoSize = true;
            lblDist.Location = new Point(465, 238);
            lblDist.Name = "lblDist";
            lblDist.Size = new Size(61, 20);
            lblDist.TabIndex = 23;
            lblDist.Text = "Distrito:";
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Location = new Point(31, 330);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(42, 20);
            lblFoto.TabIndex = 24;
            lblFoto.Text = "Foto:";
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.Location = new Point(119, 326);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(191, 29);
            btnCargarFoto.TabIndex = 25;
            btnCargarFoto.Text = "Cargar Foto";
            btnCargarFoto.UseVisualStyleBackColor = true;
            btnCargarFoto.Click += btnCargarFoto_Click;
            // 
            // pcbFoto
            // 
            pcbFoto.Location = new Point(331, 313);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(60, 55);
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.TabIndex = 26;
            pcbFoto.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblRuta
            // 
            lblRuta.BorderStyle = BorderStyle.FixedSingle;
            lblRuta.Location = new Point(416, 331);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(211, 24);
            lblRuta.TabIndex = 27;
            lblRuta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.CausesValidation = false;
            groupBox2.Controls.Add(optPremium);
            groupBox2.Controls.Add(optBasico);
            groupBox2.Controls.Add(optEstandar);
            groupBox2.Location = new Point(31, 493);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(279, 114);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de Membresia";
            // 
            // optPremium
            // 
            optPremium.AutoSize = true;
            optPremium.Location = new Point(10, 86);
            optPremium.Name = "optPremium";
            optPremium.Size = new Size(89, 24);
            optPremium.TabIndex = 2;
            optPremium.TabStop = true;
            optPremium.Text = "Premium";
            optPremium.UseVisualStyleBackColor = true;
            // 
            // optBasico
            // 
            optBasico.AutoSize = true;
            optBasico.Location = new Point(10, 56);
            optBasico.Name = "optBasico";
            optBasico.Size = new Size(73, 24);
            optBasico.TabIndex = 1;
            optBasico.TabStop = true;
            optBasico.Text = "Básico";
            optBasico.UseVisualStyleBackColor = true;
            // 
            // optEstandar
            // 
            optEstandar.AutoSize = true;
            optEstandar.Location = new Point(10, 26);
            optEstandar.Name = "optEstandar";
            optEstandar.Size = new Size(87, 24);
            optEstandar.TabIndex = 0;
            optEstandar.TabStop = true;
            optEstandar.Text = "Estandar";
            optEstandar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Location = new Point(31, 440);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 29;
            label1.Text = "Memb. Caducidad:";
            // 
            // dtpCaducidad
            // 
            dtpCaducidad.CausesValidation = false;
            dtpCaducidad.Format = DateTimePickerFormat.Short;
            dtpCaducidad.Location = new Point(203, 437);
            dtpCaducidad.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dtpCaducidad.MinDate = new DateTime(2024, 5, 1, 0, 0, 0, 0);
            dtpCaducidad.Name = "dtpCaducidad";
            dtpCaducidad.Size = new Size(107, 27);
            dtpCaducidad.TabIndex = 30;
            dtpCaducidad.Value = new DateTime(2024, 8, 1, 0, 0, 0, 0);
            // 
            // ClienteMan02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 619);
            Controls.Add(dtpCaducidad);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(lblRuta);
            Controls.Add(pcbFoto);
            Controls.Add(btnCargarFoto);
            Controls.Add(lblFoto);
            Controls.Add(lblDist);
            Controls.Add(lblProv);
            Controls.Add(lblReg);
            Controls.Add(cboDistrito);
            Controls.Add(cboProvincia);
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
            Controls.Add(cboRegion);
            Controls.Add(lblUbi);
            Controls.Add(lblDni);
            Controls.Add(lblEmail);
            Controls.Add(lblTel);
            Controls.Add(lblDir);
            Controls.Add(lblApe);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClienteMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Cliente";
            Load += ClienteMan02_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApe;
        private Label lblDir;
        private Label lblTel;
        private Label lblEmail;
        private Label lblDni;
        private Label lblUbi;
        private ComboBox cboRegion;
        private Label lblFecNac;
        private DateTimePicker dtpFecNac;
        private GroupBox groupBox1;
        private RadioButton optMujer;
        private RadioButton optHombre;
        private Button btnGrabar;
        private Button btnCancelar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtDni;
        private TextBox txtEmail;
        private ComboBox cboProvincia;
        private ComboBox cboDistrito;
        private Label lblReg;
        private Label lblProv;
        private Label lblDist;
        private Label lblFoto;
        private Button btnCargarFoto;
        private PictureBox pcbFoto;
        private OpenFileDialog openFileDialog1;
        private Label lblRuta;
        private GroupBox groupBox2;
        private RadioButton optBasico;
        private RadioButton optEstandar;
        private RadioButton optPremium;
        private Label label1;
        private DateTimePicker dtpCaducidad;
    }
}