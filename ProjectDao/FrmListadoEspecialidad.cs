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
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString); //Cadena conexion
            SqlCommand cmd = new SqlCommand("uspListarEspecialidades", cn); //consulta a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable(); //Tabla vacia 
            SqlDataAdapter sda = new SqlDataAdapter(cmd); //Ejecuta la consulta del sqlcommand
            sda.Fill(tabla);//Llenar taba //Resultado de una consulta a una tabla (Fill)

            dtgListaEspec.DataSource = tabla; //asignaar la grilla al datatable
        }
    }
}
