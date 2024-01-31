namespace ProjectDao
{
    partial class FrmListadoEspecialidad
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
            this.dtgListaEspec = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaEspec)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListaEspec
            // 
            this.dtgListaEspec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaEspec.Location = new System.Drawing.Point(12, 160);
            this.dtgListaEspec.Name = "dtgListaEspec";
            this.dtgListaEspec.Size = new System.Drawing.Size(742, 224);
            this.dtgListaEspec.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la Especialidad";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(151, 130);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(163, 20);
            this.txtEspecialidad.TabIndex = 2;
            this.txtEspecialidad.TextChanged += new System.EventHandler(this.filtrar);
            // 
            // FrmListadoEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgListaEspec);
            this.Name = "FrmListadoEspecialidad";
            this.Text = "FrmListadoEspecialidad";
            this.Load += new System.EventHandler(this.FrmListadoEspecialidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaEspec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListaEspec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEspecialidad;
    }
}