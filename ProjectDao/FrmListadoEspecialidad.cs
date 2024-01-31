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
    }
}
