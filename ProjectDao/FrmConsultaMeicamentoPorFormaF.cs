using ProjectDao.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDao
{
    public partial class FrmConsultaMeicamentoPorFormaF : Form
    {
        public FrmConsultaMeicamentoPorFormaF()
        {
            InitializeComponent();
        }

        private void FrmConsultaMeicamentoPorFormaF_Load(object sender, EventArgs e)
        {
            SQL.LlenarComboBox("USPLLENARCOMBOFORMAFARMACEUTICA", cbxFormaFarm);
                /*
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            SqlCommand cmd = new SqlCommand("USPLLENARCOMBOFORMAFARMACEUTICA", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            cbxFormaFarm.DataSource = tabla;
            cbxFormaFarm.DisplayMember = "NOMBRE";
            cbxFormaFarm.ValueMember = "IIDFORMAFARMACEUTICA";
                */

        
        }
    }
}
