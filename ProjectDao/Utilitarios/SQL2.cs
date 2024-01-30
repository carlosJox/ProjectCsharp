using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDao.Utilitarios
{
    public class SQL2

    {
        //1. Crear variable de conexion 
        private static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString); //Cadena conexion

        public static void ListarConsultaSQL(string consulta, DataGridView grilla)
        {
            SqlCommand cmd = new SqlCommand(consulta, cn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            grilla.DataSource = tabla;
        }
    }
}
