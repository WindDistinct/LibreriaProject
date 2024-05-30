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
            cboUbigeo = new ComboBox();
            lblUbi = new Label();
            lblDni = new Label();
            lblEmail = new Label();
            lblTel = new Label();
            lblDir = new Label();
            lblApe = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            lblCodNum = new Label();
            groupBox1.SuspendLayout();
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
            btnCancelar.Location = new Point(508, 426);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 35);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(362, 426);
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
            groupBox1.Location = new Point(21, 368);
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
            optMujer.Size = new Size(68, 24);
            optMujer.TabIndex = 1;
            optMujer.TabStop = true;
            optMujer.Text = "Mujer";
            optMujer.UseVisualStyleBackColor = true;
            // 
            // optHombre
            // 
            optHombre.AutoSize = true;
            optHombre.Location = new Point(34, 26);
            optHombre.Name = "optHombre";
            optHombre.Size = new Size(85, 24);
            optHombre.TabIndex = 0;
            optHombre.TabStop = true;
            optHombre.Text = "Hombre";
            optHombre.UseVisualStyleBackColor = true;
            // 
            // dtpFecNac
            // 
            dtpFecNac.Location = new Point(193, 322);
            dtpFecNac.MaxDate = new DateTime(2006, 6, 15, 0, 0, 0, 0);
            dtpFecNac.Name = "dtpFecNac";
            dtpFecNac.Size = new Size(280, 27);
            dtpFecNac.TabIndex = 28;
            dtpFecNac.Value = new DateTime(2006, 6, 1, 0, 0, 0, 0);
            // 
            // lblFecNac
            // 
            lblFecNac.AutoSize = true;
            lblFecNac.Location = new Point(21, 327);
            lblFecNac.Name = "lblFecNac";
            lblFecNac.Size = new Size(152, 20);
            lblFecNac.TabIndex = 27;
            lblFecNac.Text = "Fecha de Nacimiento:";
            // 
            // cboUbigeo
            // 
            cboUbigeo.FormattingEnabled = true;
            cboUbigeo.Location = new Point(109, 278);
            cboUbigeo.Name = "cboUbigeo";
            cboUbigeo.Size = new Size(308, 28);
            cboUbigeo.TabIndex = 26;
            // 
            // lblUbi
            // 
            lblUbi.AutoSize = true;
            lblUbi.Location = new Point(21, 286);
            lblUbi.Name = "lblUbi";
            lblUbi.Size = new Size(61, 20);
            lblUbi.TabIndex = 25;
            lblUbi.Text = "Ubigeo:";
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
            // ClienteMan03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 499);
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
            Controls.Add(cboUbigeo);
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
            Name = "ClienteMan03";
            Text = "Editar Cliente";
            Load += ClienteMan03_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private ComboBox cboUbigeo;
        private Label lblUbi;
        private Label lblDni;
        private Label lblEmail;
        private Label lblTel;
        private Label lblDir;
        private Label lblApe;
        private Label lblNombre;
        private Label lblCodigo;
        private Label lblCodNum;
    }
}