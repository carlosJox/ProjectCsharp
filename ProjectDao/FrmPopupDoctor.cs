using ProjectDao.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDao
{
    public partial class FrmPopupDoctor : Form
    {
        public string accion {  get; set; }
        public string id { get; set; }
        public FrmPopupDoctor()
        {
            InitializeComponent();
        }
        private void FrmPopupDoctor_Load(object sender, EventArgs e)
        {
            SQL.LlenarComboBox("USPLLENARCOMBOSEXO", cbxSexo, "NOMBRE", "IIDSEXO", true);
            SQL.LlenarComboBox("USPLISTARCOMBOESPECIALIDAD", cbxEspec, "NOMBRE", "IIDESPECIALIDAD", true);
            SQL.LlenarComboBox("USPLISTARCOMBOCLINICA", cbxClinica, "NOMBRE", "IIDCLINICA", true);

            if (accion.Equals("Nuevo"))
            {
                this.Text = "Ingrese Doctor";
            }
            else
            {
                this.Text = "Actualizar Doctor";
            }

        }

        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivito de Programa |*.pdf; *.png; *jpg; *.jpeg; *.docx";

            if (ofd.ShowDialog().Equals(DialogResult.OK))
            {
                //Prewie del archivo
                string ruta = ofd.FileName;
                buffer = File.ReadAllBytes(ruta);
                bwDoctor.Navigate(ruta);    

            }

        }
        byte[] buffer = null;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apPaterno= txtApePat.Text;
            string apMaterno = txtApMat.Text;
            string idclinica = cbxClinica.SelectedValue.ToString();
            string idespecialidad = cbxEspec.SelectedValue.ToString();
            string email = txtEmail.Text;
            string celular =ttxtCelular.Text;
            string idsexo = cbxSexo.SelectedValue.ToString();
            decimal sueldo = numSueldo.Value;
            DateTime fechaContrato = dtFechaContrat.Value;

           bool exito= SQL.validarRequeridos(this.Controls, errorDatos);
            if(!exito)
            {
                this.DialogResult = DialogResult.None;
                return;
            }

            int n = SQL.registrarAcuaRlizaYeliminar("USPINSERTARDOCTOR",
                    new System.Collections.ArrayList
                    {
                            "@NOMBRE","@APPATERNO","@APMATERNO","IIDCLINICA","IIDESPECIALIDAD",
                        "@EMAIL","@TELEFONOCELULAR","@IIDSEXO","@SUELDO",
                        "@FECHACONTRATO","@ARCHIVO"
                    },
                    new System.Collections.ArrayList
                    {
                      nombre,apPaterno,apMaterno,idclinica,idespecialidad,email,celular,
                        idsexo,sueldo, fechaContrato,buffer
                    } );
            
            if(n == 1 )
            {
                MessageBox.Show("Register Succes");
            }
            else
            {
               this.DialogResult= DialogResult.None;
            }

        }

        
    }
}
