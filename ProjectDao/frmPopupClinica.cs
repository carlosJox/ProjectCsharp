using ProjectDao.Utilitarios;
using System;
using System.Collections;
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
    public partial class frmPopupClinica : Form
    {
        public string accion {  get; set; }
        public string id {  get; set; }
       

        public frmPopupClinica()
        {
            InitializeComponent();
        }

        private void frmPopupClinica_Load(object sender, EventArgs e)
        {
            

            if (accion.Equals("Nuevo"))
            {
                this.Text = "Agregando Clinica";
            }
            else
            {
                this.Text = "Editar Clinica";
                DataTable tabla= SQL.obtenerDatos("uspObtenerDatosClinica", "@idclinica", id);
                txtIdClinica.Text = tabla.Rows[0][0].ToString();
                txtNombre.Text = tabla.Rows[0][1].ToString();
                txtDireccion.Text = tabla.Rows[0][2].ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string id =txtIdClinica.Text;
            string nombre = txtNombre.Text; ;
            string direccion = txtDireccion.Text;
            bool exito = SQL.validarRequeridos(this.Controls, errorDatos);
                        
           if (!exito)
                {
                    this.DialogResult = DialogResult.None; return;
                }

   
            if (accion.Equals("Nuevo"))

            {
                /*
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
                cn.Open(); //Abrir conexion
                SqlCommand cmd = new SqlCommand("uspInsertarClinica",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                int resultado = cmd.ExecuteNonQuery();//Ejecuta la consulta y devuelve 1 si hizo la insercion y 0 si no 
                */
                int resultado = SQL.registrarAcuaRlizaYeliminar("uspInsertarClinica",
                                new ArrayList { "@nombre", "direccion" },
                                new ArrayList { nombre, direccion }
                                );
                    if (resultado == 1)
                    {
                        MessageBox.Show("Se Agrego Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("ya se encuentra registrada la sede");
                        this.DialogResult = DialogResult.None;
                    }
                //   cn.Close();

            }
            else
            {
                //Actualizar 
                int resultado = SQL.registrarAcuaRlizaYeliminar("uspActualizarClinica",
                                new ArrayList { "@idclinica","@nombre", "direccion" },
                                new ArrayList { id,nombre, direccion }
                                );
                if (resultado == 1)
                {
                    MessageBox.Show("Update Succes");
                }
                else
                {
                    MessageBox.Show("ya se encuentra registrada la sede");
                    this.DialogResult = DialogResult.None;
                }
            }
        }
    }
}
