using ProjectDao.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDao
{
    public partial class FrmPopupEspecialidad : Form
    {
        public string accion { get; set; }
        public string id { get; set; }
        public FrmPopupEspecialidad()
        {
            InitializeComponent();
        }

        private void FrmPopupEspecialidad_Load(object sender, EventArgs e)
        {
            if (accion.Equals("Nuevo"))
            {
                this.Text = "Ingrese Especialidad";
            }
            else
            {
                this.Text = "Actualizar Especialidad";
                DataTable tabla= SQL.obtenerDatos("uspObtenerEspecialidad", "@idespecialidad", id);
                txtIdEspec.Text= tabla.Rows[0][0].ToString();
                txtNombre.Text= tabla.Rows[0][1].ToString();
                txtDescripcion.Text = tabla.Rows[0][2].ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string idEspecialidad = txtIdEspec.Text;
            string nombre= txtNombre.Text;
            string descripcion  = txtDescripcion.Text;
            bool exito = SQL.validarRequeridos(this.Controls, errorDatos);
            if (!exito)
            {
                this.DialogResult = DialogResult.None;
                return;
            }
            if (accion.Equals("Nuevo"))
            {
                int n = SQL.registrarAcuaRlizaYeliminar("uspInsertarEspecialidad",
                        new ArrayList { "@nombre", "@descripcion" },
                        new ArrayList { nombre, descripcion });
                if(n == 1)
                {
                    MessageBox.Show("Register Succes");
                }
                else
                {
                    MessageBox.Show("YA existe la especialidad");
                    this.DialogResult = DialogResult.None;
                    return;
                }
            }else
            {
                //Editar
                int n = SQL.registrarAcuaRlizaYeliminar("uspActualizarEspecialidad",
                        new ArrayList { "idEspecialidad","@nombre", "@descripcion" },
                        new ArrayList { idEspecialidad, nombre, descripcion });
                if (n == 1)
                {
                    MessageBox.Show("Update Succes");
                }
                else
                {
                    MessageBox.Show("YA existe la especialidad");
                    this.DialogResult = DialogResult.None;
                    return;
                }
            }
        }
    }
}
