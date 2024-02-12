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
    public partial class FrmListadoMedicamentos : Form
    {
        public FrmListadoMedicamentos()
        {
            InitializeComponent();
        }

        private void FrmListadoMedicamentos_Load(object sender, EventArgs e)
        {
            radButNombre.Checked = true;
            SQL.ListarProcedure("uspListarMedicamentoPrograma", dgvMedicam);
        }

        private void filtrar(object sender, EventArgs e)
        {
            String valor =txtValor.Text;
            if(radButNombre.Checked==true)
            {
                SQL.FiltradoDatos("uspConsultarMedicamentoPorNombre", "@nombre", valor, dgvMedicam);
            }
            else {
                SQL.FiltradoDatos("uspConsultarMedicamentoPorConcentracion", "@concentracion", valor, dgvMedicam);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            frmPopupMedicamento ofrmPopupMedicamento = new frmPopupMedicamento();
            ofrmPopupMedicamento.accion = "Nuevo";
            ofrmPopupMedicamento.ShowDialog();
            if (ofrmPopupMedicamento.DialogResult.Equals(DialogResult.OK))
            {
                SQL.ListarProcedure("uspListarMedicamentoPrograma", dgvMedicam);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmPopupMedicamento ofrmPopupMedicamento = new frmPopupMedicamento();
            ofrmPopupMedicamento.accion = "Editar";
            ofrmPopupMedicamento.ShowDialog();
        }
    }
}
