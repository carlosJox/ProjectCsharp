using ProjectDao.Utilitarios;
using System;
using System.Collections;
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
    public partial class frmPopupMedicamento : Form
    {
        public string accion {  get; set; } 
        public string id { get; set; }
        public frmPopupMedicamento()
        {
            InitializeComponent();
        }

        private void frmPopupMedicamento_Load(object sender, EventArgs e)
        {
            SQL.LlenarComboBox("USPLLENARCOMBOFORMAFARMACEUTICA", cbxFormfar);
            
            if (accion.Equals("Nuevo"))
            {
                this.Text = "Ingrese Medicamento";
            }
            else
            {
                this.Text = "Actualize Medicamento";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreMedto.Text;
            string concentracion = txtConcentracion.Text;   
            string iideformaFarm = cbxFormfar.SelectedValue.ToString();
            decimal precio = txtPrecio.Value;
            int stock = int.Parse(txtStock.Text); //.Text siempre devuelve una cadena
            string presentacion = txtPresentacion.Text;

            //Validar requeridos caoles son los obligatorios
            bool exito = SQL.validarRequeridos(this.Controls, errorDatos);
            if (!exito)
            {
                this.DialogResult = DialogResult.None;
                return;
            }

            if (accion.Equals("Nuevo"))
            {
             int n=   SQL.registrarAcuaRlizaYeliminar("USPINSERTARMEDICAMENTOS",
                                    new ArrayList { "@NOMBRE", "@CONCENTRACION","@IIDFORMAFARMACEUTICA","@PRECIO","@STOCK","@PRESENTACION"},
                                    new ArrayList { nombre,concentracion,iideformaFarm,precio,stock,presentacion});
                if (n == 1)
                {
                    MessageBox.Show("The registred SUCCESS");
                }
                else
                {
                    MessageBox.Show("The registred NOT SUCCESS");
                }
            }
        }
    }
}
