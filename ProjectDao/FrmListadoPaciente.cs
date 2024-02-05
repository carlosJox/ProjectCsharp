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
    public partial class FrmListadoPaciente : Form
    {
        public FrmListadoPaciente()
        {
            InitializeComponent();
        }

        private void FrmListadoPaciente_Load(object sender, EventArgs e)
        {
            cbxOpcion.SelectedIndex = 0;
            SQL.ListarProcedure("uspListarPacientesPrograma", dgvPaciente);
        }

        private void filtrar(object sender, EventArgs e)
        {
            string opcion = cbxOpcion.Text;
            string valor = txtValor.Text;
           

            if(opcion == "Nombre")
            {
                SQL.FiltradoDatos("uspConsultarPacientesProgramaPorNombre", "@Nombre", valor, dgvPaciente);
            }
            else if(opcion == "Apellido Paterno")
            {
                SQL.FiltradoDatos("uspConsultarPacientesProgramaPorApPaterno", "@ApPaterno", valor, dgvPaciente);
            }
            else
            {
                SQL.FiltradoDatos("uspConsultarPacientesProgramaPorApMaterno", "@ApMaterno", valor, dgvPaciente);
            }
        }
    }
}
