namespace ProjectDao
{
    partial class FrmConsultaMeicamentoPorFormaF
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxFormaFarm = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forma Farmaceutica";
            // 
            // cbxFormaFarm
            // 
            this.cbxFormaFarm.FormattingEnabled = true;
            this.cbxFormaFarm.Location = new System.Drawing.Point(131, 99);
            this.cbxFormaFarm.Name = "cbxFormaFarm";
            this.cbxFormaFarm.Size = new System.Drawing.Size(134, 21);
            this.cbxFormaFarm.TabIndex = 1;
            // 
            // FrmConsultaMeicamentoPorFormaF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxFormaFarm);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultaMeicamentoPorFormaF";
            this.Text = "FrmConsultaMeicamentoPorFormaF";
            this.Load += new System.EventHandler(this.FrmConsultaMeicamentoPorFormaF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFormaFarm;
    }
}