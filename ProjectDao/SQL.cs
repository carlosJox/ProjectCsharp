using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ProjectDao.Utilitarios
{
    public class SQL
    {
        //1. Crear variable de conexion 
        private static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString); //Cadena conexion

        //Metodo para hacer los listados genericos
        public static void ListarConsultaSQL(string consulta, DataGridView grilla)
        {
            SqlCommand cmd = new SqlCommand(consulta, cn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            grilla.DataSource = tabla;
        }

        public static void ListarProcedure(string nombreProcedure, DataGridView grilla)
        {
            SqlCommand cmd = new SqlCommand(nombreProcedure, cn); //consulta a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable(); //Tabla vacia 
            SqlDataAdapter sda = new SqlDataAdapter(cmd); //Ejecuta la consulta del sqlcommand
            sda.Fill(tabla);//Llenar taba //Resultado de una consulta a una tabla (Fill)

            grilla.DataSource = tabla; //asignaar la grilla al datatable
        }


        public static void FiltradoDatos(string nombreProcedure,string nombreParametro, string valorParametro, DataGridView grilla)
        {
            SqlCommand cmd = new SqlCommand(nombreProcedure, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(nombreParametro, valorParametro);
            DataTable tabla = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd); //Ejecutar consulta 'cmd'
            sda.Fill(tabla);
            grilla.DataSource = tabla; //Llenar contenido
        }

        public static void LlenarComboBox(string nombreProcedure, ComboBox combo, string displayMember ="Nombre", string valueMember = "Id")
        {
            SqlCommand cmd = new SqlCommand(nombreProcedure, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd); //Ejecutar consulta 'cmd'
            sda.Fill(tabla);
            combo.DataSource = tabla; //Llenar contenido
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }
    }
}
