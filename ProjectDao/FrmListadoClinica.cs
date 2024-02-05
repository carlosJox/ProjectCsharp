using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using ProjectDao.Utilitarios;
using System.Runtime.CompilerServices;



namespace ProjectDao
{
    public partial class FrmListadoClinica : Form
    {
        public FrmListadoClinica()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Listar();          
        }

        private void Listar()
        {
            SQL.ListarConsultaSQL("select IIDCLINICA, NOMBRE, DIRECCION from Clinica where BHABILITADO = 1", dgvClinic);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string idclinica = txtIdClinica.Text;
            SQL.FiltradoDatos("uspFiltrarClinicaPorId", "@idclinica", idclinica, dgvClinic);
            /*
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            SqlCommand cmd = new SqlCommand("uspFiltrarClinicaPorId", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idclinica", idclinica);
            DataTable tabla = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd); //Ejecutar consulta 'cmd'
            sda.Fill(tabla);
            dgvClinic.DataSource = tabla; //Llenar contenido  */
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Listar();
            txtIdClinica.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmPopupClinica ofrmPopupClinica = new frmPopupClinica();
            ofrmPopupClinica.accion = "Nuevo";
            //ofrmPopupClinica.accion = "New";
            ofrmPopupClinica.ShowDialog();
            if(ofrmPopupClinica.DialogResult.Equals(DialogResult.OK))
            {
                Listar();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmPopupClinica ofrmPopupClinica = new frmPopupClinica();
            ofrmPopupClinica.accion = "Editar";
            ofrmPopupClinica.ShowDialog();
        }
    }
}
