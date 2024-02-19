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
            Listar();
            
        }
        private void Listar()
        {
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            campo ofrmPopupPacient = new campo();
            ofrmPopupPacient.accion = "Nuevo";
            ofrmPopupPacient.ShowDialog();
            if (ofrmPopupPacient.DialogResult.Equals(DialogResult.OK))
            {
                SQL.ListarProcedure("uspListarPacientesPrograma", dgvPaciente);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            campo ofrmPopupPacient = new campo();
            ofrmPopupPacient.accion = "Editar";
            ofrmPopupPacient.id = dgvPaciente.CurrentRow.Cells[0].Value.ToString();

            ofrmPopupPacient.ShowDialog();
            if (ofrmPopupPacient.DialogResult.Equals(DialogResult.OK))
            {
                SQL.ListarProcedure("uspListarPacientesPrograma", dgvPaciente);
            }
        }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = dgvPaciente.CurrentRow.Cells[0].Value.ToString();    
            if(MessageBox.Show("Desea Eliminar","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question).Equals(DialogResult.Yes))
            {
              int n =  SQL.Eliminar("uspelimnarpaciente", "@idpaciente", id);
                if (n == 1)
                {
                    MessageBox.Show("Delete Success ");
                    Listar();
                }
                else
                {
                    MessageBox.Show("Not Delete Success ");
                }
               
            }
        }
    }
}
