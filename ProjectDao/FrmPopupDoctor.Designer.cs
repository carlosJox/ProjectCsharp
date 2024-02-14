namespace ProjectDao
{
    partial class FrmPopupDoctor
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
            this.components = new System.ComponentModel.Container();
            this.dtFechaContrat = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxClinica = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTelfijo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ttxtCelular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApMat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApePat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEspec = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.numSueldo = new System.Windows.Forms.NumericUpDown();
            this.bwDoctor = new System.Windows.Forms.WebBrowser();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargarImg = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdDoctor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errorDatos = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numSueldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFechaContrat
            // 
            this.dtFechaContrat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaContrat.Location = new System.Drawing.Point(439, 268);
            this.dtFechaContrat.Name = "dtFechaContrat";
            this.dtFechaContrat.Size = new System.Drawing.Size(172, 20);
            this.dtFechaContrat.TabIndex = 62;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(336, 272);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 16);
            this.label17.TabIndex = 61;
            this.label17.Text = "Fecha Contrato";
            // 
            // cbxClinica
            // 
            this.cbxClinica.FormattingEnabled = true;
            this.cbxClinica.Location = new System.Drawing.Point(437, 101);
            this.cbxClinica.Name = "cbxClinica";
            this.cbxClinica.Size = new System.Drawing.Size(171, 21);
            this.cbxClinica.TabIndex = 56;
            this.cbxClinica.Tag = "O";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(380, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 55;
            this.label13.Text = "Clinica:";
            // 
            // cbxSexo
            // 
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Location = new System.Drawing.Point(439, 181);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(171, 21);
            this.cbxSexo.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(396, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 49;
            this.label12.Text = "Sexo";
            // 
            // txtTelfijo
            // 
            this.txtTelfijo.Location = new System.Drawing.Point(440, 236);
            this.txtTelfijo.Name = "txtTelfijo";
            this.txtTelfijo.Size = new System.Drawing.Size(171, 20);
            this.txtTelfijo.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(369, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Tel Fijo";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(437, 135);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 20);
            this.txtEmail.TabIndex = 46;
            this.txtEmail.Tag = "O";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(379, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "Email🆗";
            // 
            // ttxtCelular
            // 
            this.ttxtCelular.Location = new System.Drawing.Point(143, 167);
            this.ttxtCelular.Name = "ttxtCelular";
            this.ttxtCelular.Size = new System.Drawing.Size(171, 20);
            this.ttxtCelular.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(88, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Celular";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(143, 135);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(171, 20);
            this.txtDireccion.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(74, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Dirección";
            // 
            // txtApMat
            // 
            this.txtApMat.Location = new System.Drawing.Point(143, 102);
            this.txtApMat.Name = "txtApMat";
            this.txtApMat.Size = new System.Drawing.Size(171, 20);
            this.txtApMat.TabIndex = 40;
            this.txtApMat.Tag = "O";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(35, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Apellido Materno";
            // 
            // txtApePat
            // 
            this.txtApePat.Location = new System.Drawing.Point(439, 66);
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.Size = new System.Drawing.Size(171, 20);
            this.txtApePat.TabIndex = 38;
            this.txtApePat.Tag = "O";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(326, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Apellido Paterno";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(143, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 20);
            this.txtNombre.TabIndex = 36;
            this.txtNombre.Tag = "O";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(66, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "REGISTRO DOCTOR";
            // 
            // cbxEspec
            // 
            this.cbxEspec.FormattingEnabled = true;
            this.cbxEspec.Location = new System.Drawing.Point(143, 202);
            this.cbxEspec.Name = "cbxEspec";
            this.cbxEspec.Size = new System.Drawing.Size(171, 21);
            this.cbxEspec.TabIndex = 65;
            this.cbxEspec.Tag = "O";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(59, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 64;
            this.label7.Text = "Especialidad";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(84, 252);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 16);
            this.label16.TabIndex = 66;
            this.label16.Text = "Sueldo";
            // 
            // numSueldo
            // 
            this.numSueldo.Location = new System.Drawing.Point(143, 248);
            this.numSueldo.Name = "numSueldo";
            this.numSueldo.Size = new System.Drawing.Size(120, 20);
            this.numSueldo.TabIndex = 67;
            // 
            // bwDoctor
            // 
            this.bwDoctor.Location = new System.Drawing.Point(632, 57);
            this.bwDoctor.MinimumSize = new System.Drawing.Size(20, 20);
            this.bwDoctor.Name = "bwDoctor";
            this.bwDoctor.Size = new System.Drawing.Size(250, 250);
            this.bwDoctor.TabIndex = 68;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Thistle;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(178, 310);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 34);
            this.btnCancelar.TabIndex = 70;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Thistle;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(62, 310);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 34);
            this.btnGuardar.TabIndex = 69;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargarImg
            // 
            this.btnCargarImg.Location = new System.Drawing.Point(727, 320);
            this.btnCargarImg.Name = "btnCargarImg";
            this.btnCargarImg.Size = new System.Drawing.Size(75, 24);
            this.btnCargarImg.TabIndex = 72;
            this.btnCargarImg.Text = "Cargar";
            this.btnCargarImg.UseVisualStyleBackColor = true;
            this.btnCargarImg.Click += new System.EventHandler(this.btnCargarImg_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(652, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 71;
            this.label10.Text = "Archivo🎴";
            // 
            // txtIdDoctor
            // 
            this.txtIdDoctor.Location = new System.Drawing.Point(143, 42);
            this.txtIdDoctor.Name = "txtIdDoctor";
            this.txtIdDoctor.ReadOnly = true;
            this.txtIdDoctor.Size = new System.Drawing.Size(80, 20);
            this.txtIdDoctor.TabIndex = 74;
            this.txtIdDoctor.Tag = "O";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(66, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 73;
            this.label11.Text = "Id Doctor";
            // 
            // errorDatos
            // 
            this.errorDatos.ContainerControl = this;
            // 
            // FrmPopupDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 466);
            this.Controls.Add(this.txtIdDoctor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCargarImg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.bwDoctor);
            this.Controls.Add(this.numSueldo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbxEspec);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaContrat);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbxClinica);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTelfijo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ttxtCelular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApMat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApePat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Name = "FrmPopupDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPopupDoctor";
            this.Load += new System.EventHandler(this.FrmPopupDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSueldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFechaContrat;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbxClinica;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTelfijo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ttxtCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApMat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApePat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEspec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numSueldo;
        private System.Windows.Forms.WebBrowser bwDoctor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargarImg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdDoctor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorDatos;
    }
}