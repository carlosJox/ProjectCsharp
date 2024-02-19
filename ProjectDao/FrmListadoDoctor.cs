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
        private void Listar()
        {
            SQL.ListarProcedure("uspListarDoctorPrograma", dgvDoctors);
        }
        private void FrmListadoDoctor_Load(object sender, EventArgs e)
        {
           Listar();
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
            ofrmPopupDoctor.ShowDialog();
            if (ofrmPopupDoctor.DialogResult.Equals(DialogResult.OK))
            {
                SQL.ListarProcedure("uspListarDoctorPrograma", dgvDoctors);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmPopupDoctor ofrmPopupDoctor = new FrmPopupDoctor();
            ofrmPopupDoctor.accion = "Editar";
            ofrmPopupDoctor.id = dgvDoctors.CurrentRow.Cells[0].Value.ToString();
            ofrmPopupDoctor.ShowDialog();
            if (ofrmPopupDoctor.DialogResult.Equals(DialogResult.OK))
            {
                SQL.ListarProcedure("uspListarDoctorPrograma", dgvDoctors);
            }
        }

        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = dgvDoctors.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Desea Eliminar", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
            {
                int n = SQL.Eliminar("uspeliminardoctos", "@iddoctor", id);
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
