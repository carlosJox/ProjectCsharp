using ProjectDao.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDao
{
    public partial class FrmListadoDoctor : Form
    {
        public FrmListadoDoctor()
        {
            InitializeComponent();
        }

        private void FrmListadoDoctor_Load(object sender, EventArgs e)
        {
            SQL.ListarProcedure("uspListarDoctorPrograma", dgvDoctors);
        }

        private void filtrar(object sender, EventArgs e)
        {
            string valor = txtValor.Text;
            if(rbtAPaterno.Checked ==true)
            {
                SQL.FiltradoDatos("uspConsultaDoctorPorApPaterno", "@apPaterno", valor, dgvDoctors);
            }
            else
            {
                SQL.FiltradoDatos("uspConsultaDoctorPorApMaterno", "@apMaterno", valor, dgvDoctors);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmPopupDoctor ofrmPopupDoctor = new FrmPopupDoctor();
            ofrmPopupDoctor.accion = "Nuevo";
            //ofrmPopupClinica.accion = "New";
            ofrmPopupDoctor.ShowDialog();
            if (ofrmPopupDoctor.DialogResult.Equals(DialogResult.OK)) ;
        }
    }
}
