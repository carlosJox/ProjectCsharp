using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using ProjectDao.Utilitarios;


namespace ProjectDao
{
    public partial class FrmListadoEspecialidad : Form
    {
     
        public FrmListadoEspecialidad()
        {
            InitializeComponent();
        }

        private void FrmListadoEspecialidad_Load(object sender, EventArgs e)
        {
            SQL.ListarProcedure("uspListarEspecialidades",dtgListaEspec);
        }

        //Filtrar por nombre 
        private void filtrar(object sender, EventArgs e)
        {
            string nombre =txtEspecialidad.Text;
            SQL.FiltradoDatos("USPLISTARESPECIALIDADPORNOMBRE", "@NOMBRE", nombre, dtgListaEspec);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmPopupEspecialidad ofrmPopupEspecialidad = new FrmPopupEspecialidad();
            ofrmPopupEspecialidad.accion = "Editar";
            ofrmPopupEspecialidad.id = dtgListaEspec.CurrentRow.Cells[0].Value.ToString();
            ofrmPopupEspecialidad.ShowDialog();
            if (ofrmPopupEspecialidad.DialogResult.Equals(DialogResult.OK))
            {
                SQL.ListarProcedure("uspListarEspecialidades", dtgListaEspec);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmPopupEspecialidad ofrmPopupEspecialidad = new FrmPopupEspecialidad();
            ofrmPopupEspecialidad.accion = "Nuevo";
            ofrmPopupEspecialidad.ShowDialog();
           //Actualizar la grilla
            if (ofrmPopupEspecialidad.DialogResult.Equals(DialogResult.OK))
            {
                SQL.ListarProcedure("uspListarEspecialidades", dtgListaEspec);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = dtgListaEspec.CurrentRow.Cells[0].Value.ToString();
            if(MessageBox.Show("Desea Elimnar ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
            {
                int n = SQL.Eliminar("uspeliminarespecialidad", "@idespecialidad", id);
                if(n == 1)
                {
                    MessageBox.Show("..Update Success ..");
                }
                else
                {
                    MessageBox.Show("..Not Update Success ..");
                }
            }
        }
    }
}
