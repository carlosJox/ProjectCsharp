using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
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

        public static int registrarAcuaRlizaYeliminar(string nombreProcedure, ArrayList parametros,ArrayList valores)
        {
            
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            cn.Open(); //Abrir conexion
            SqlCommand cmd = new SqlCommand(nombreProcedure,cn);
            cmd.CommandType = CommandType.StoredProcedure;
                 for(int i = 0; i < parametros.Count; i++)
                {
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), valores[i]);
                }
             int resultado = cmd.ExecuteNonQuery();//Ejecuta la consulta y devuelve 1 si hizo la insercion y 0 si no 
             cn.Close();
                return resultado;
        }

        //Validacion 'La función es estática, lo que significa que puede ser llamada sin necesidad de crear una instancia de la clase que la contiene.'
        public static bool validarRequeridos(Control.ControlCollection controles, ErrorProvider error)
        {
            bool exito = true;
            int ncontroles = controles.Count; //Numero de controles q se han pasado
            Control control; 
            for (int i = 0; i < ncontroles;i++)
            {
                control= controles[i];
                if(control is TextBox)
                {
                    if(control.Tag != null && control.Tag.ToString().Equals("O")) //O colocada en la propiedad Tag
                    {
                        if(((TextBox)control).Text.Equals(""))
                        {
                            error.SetError(control, "INGRESE DATOS");
                            exito = false;
                        }
                        else
                        {
                            error.SetError(control, "");
                        }
                    }
                }else if (control is NumericUpDown)
                {

                    if (control.Tag != null && control.Tag.ToString().Equals("O")) //O colocada en la propiedad Tag
                    {
                        if (((NumericUpDown)control).Value.Equals(0))
                        {
                            error.SetError(control, "INGRESE DATOS no puede ir en 0");
                            exito = false;
                        }
                        else
                        {
                            error.SetError(control, "");
                        }
                    }
                }
            }
            return exito;

        }
        

    }
}
