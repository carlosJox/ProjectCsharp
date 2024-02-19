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
                DataTable tabla= SQL.obtenerDatos("uspObtenerPaciente", "@idpaciente", id);
                txtIdPac.Text = tabla.Rows[0][0].ToString();
                txtNombre.Text = tabla.Rows[0][1].ToString();
                txtApePat.Text = tabla.Rows[0][2].ToString();
                txtApMat.Text = tabla.Rows[0][3].ToString();
                txtEmail.Text = tabla.Rows[0][4].ToString();
                txtDireccion.Text = tabla.Rows[0][5].ToString();
                txtTelfijo.Text = tabla.Rows[0][6].ToString();
                ttxtCelular.Text = tabla.Rows[0][7].ToString();
                dateFechaNac.Value = DateTime.Parse(tabla.Rows[0][8].ToString());
                cbxSexo.SelectedValue = tabla.Rows[0][9].ToString();
                cbxTipoSan.SelectedValue = tabla.Rows[0][10].ToString();
                txtAlergias.Text = tabla.Rows[0][11].ToString();
                txtEnfermeds.Text = tabla.Rows[0][12].ToString();
                txtVacunas.Text = tabla.Rows[0][13].ToString();
                txtAntecedent.Text = tabla.Rows[0][14].ToString();
                if (!tabla.Rows[0][15].ToString().Equals(""))
                {
                    //Actualiza foto y valida en caso q no tenga cargada
                    buffer = (byte[])tabla.Rows[0][15];
                    using (MemoryStream ms = new MemoryStream(buffer))
                    {
                        imgFoto.Image = Image.FromStream(ms);
                    }
                }

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
            string idPact = txtIdPac.Text;
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
            if (accion.Equals("Nuevo"))
            {

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
                if (n == 1)
                {
                    MessageBox.Show("Se agrego Correctamente");
                }
                else
                {
                    MessageBox.Show("Ya existe el Paciente");
                    this.DialogResult = DialogResult.None;
                    return;
                }
            }
            else
            {
                int n = SQL.registrarAcuaRlizaYeliminar("USPACTUALIZARPACIENTE",
           new System.Collections.ArrayList
           {
            "@IDPACIENTE","@NOMBRE","@APPATERNO","@APMATERNO","@EMAIL","@DIRECCION","@TELEFONOFIJO","@TELEFONOCELULAR",
            "@FECHANACIMIENTO","@IIDSEXO","@IIDTIPOSANGRE","@ALERGIAS","@ENFERMEDADESCRONICAS","@CUADRODEVACUNAS",
            "@ANTECENTES","@FOTO"
               },
           new System.Collections.ArrayList
           {
                idPact,nombre,apPateno,apMaterno,email,direccion,telfijo,celular,
                fechaNac,idsexo,idTipoSan,alergias,enfermedades,cuadroVacunas,
                antecedentes,buffer
           }
           );
                if (n == 1)
                {
                    MessageBox.Show("... Update Succes..");
                }
                else
                {
                    MessageBox.Show("Ya existe el Paciente");
                    this.DialogResult = DialogResult.None;
                    return;
                }
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
