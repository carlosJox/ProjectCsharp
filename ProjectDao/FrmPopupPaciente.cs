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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectDao
{
    public partial class campo : Form
    {
        public string accion { get; set; }
        public string id { get; set; }

        byte[] buffer = null;

        public campo()
        {
            InitializeComponent();
        }

        private void FrmPopupPaciente_Load(object sender, EventArgs e)
        {
            
            SQL.LlenarComboBox("USPLLENARCOMBOSEXO", cbxSexo,"NOMBRE","IIDSEXO",true);
            SQL.LlenarComboBox("USPLLENARCOMBOTIPOSANGRE", cbxTipoSan, "NOMBRE", "IIDTIPOSANGRE",true);
            if (accion.Equals("Nuevo"))
            {
                this.Text = "Ingrese Paciente";
            }
            else
            {
                this.Text = "Editar Paciente";
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cbxTipoSan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apPateno = txtApePat.Text;
            string apMaterno = txtApMat.Text;
            string email = txtEmail.Text;   
            string direccion = txtDireccion.Text;
            string telfijo = txtTelfijo.Text;
            string celular = ttxtCelular.Text;
            DateTime fechaNac = dateFechaNac.Value;
            string idsexo = cbxSexo.SelectedValue.ToString();
            string idTipoSan = cbxTipoSan.SelectedValue.ToString();
            string alergias = txtAlergias.Text;
            string enfermedades = txtEnfermeds.Text;
            string cuadroVacunas = txtVacunas.Text;
            string antecedentes = txtAntecedent.Text;
            

            //Validacion requeeridos
            bool exito = SQL.validarRequeridos(this.Controls, errorDatos);
            if (!exito)
            {
                this.DialogResult = DialogResult.None;
                return;
            }

            int n = SQL.registrarAcuaRlizaYeliminar("USPINSERTARPACIENTE",
            new System.Collections.ArrayList
            {
            "@NOMBRE","@APPATERNO","@APMATERNO","@EMAIL","@DIRECCION","@TELEFONOFIJO","@TELEFONOCELULAR",
            "@FECHANACIMIENTO","@IIDSEXO","@IIDTIPOSANGRE","@ALERGIAS","@ENFERMEDADESCRONICAS","@CUADRODEVACUNAS",
            "@ANTECENTES","@FOTO"
                },
            new System.Collections.ArrayList
            {
                nombre,apPateno,apMaterno,email,direccion,telfijo,celular,
                fechaNac,idsexo,idTipoSan,alergias,enfermedades,cuadroVacunas,
                antecedentes,buffer
            }
            );
            if ( n == 1 ) {
                MessageBox.Show("Se agrego Correctamente");
            }
            else
            {
                MessageBox.Show("Ya existe el Paciente");
                this.DialogResult = DialogResult.None;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivo de programa | *.jpg;*.png;*.jpeg";
            if (ofd.ShowDialog().Equals(DialogResult.OK))
            {
                string ruta = ofd.FileName;
                buffer = File.ReadAllBytes( ruta );
                using(MemoryStream ms = new MemoryStream( buffer ) )
                { 
                    imgFoto.Image = Image.FromStream( ms );
                }
            }
        }
    }
}
