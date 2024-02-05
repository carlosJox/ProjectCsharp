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
    public partial class FrmConsultaMedicoPorEspecialiad : Form
    {
        public FrmConsultaMedicoPorEspecialiad()
        {
            InitializeComponent();
        }

        private void FrmConsultaMedicoPorEspecialiad_Load(object sender, EventArgs e)
        {
            SQL.LlenarComboBox("USPLISTARCOMBOESPECIALIDAD", cbxEspecialidad,"NOMBRE","IIDESPECIALIDAD");
            //LLENA EL DATAGRID
            SQL.ListarProcedure("USPLISTARDOCTOR", dvgMedicos);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SQL.FiltradoDatos("USPCONSULTARDOCTORPORESPECIALIDAD", "@IDESPECIALIDAD", cbxEspecialidad.SelectedValue.ToString(), dvgMedicos);
        }
    }
}
