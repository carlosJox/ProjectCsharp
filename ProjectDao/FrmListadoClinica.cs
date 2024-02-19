using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using ProjectDao.Utilitarios;
using System.Runtime.CompilerServices;



namespace ProjectDao
{
    public partial class FrmListadoClinica : Form
    {
        public FrmListadoClinica()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Listar();          
        }

        private void Listar()
        {
            SQL.ListarConsultaSQL("select IIDCLINICA, NOMBRE, DIRECCION from Clinica where BHABILITADO = 1", dgvClinic);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string idclinica = txtIdClinica.Text;
            SQL.FiltradoDatos("uspFiltrarClinicaPorId", "@idclinica", idclinica, dgvClinic);
            /*
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            SqlCommand cmd = new SqlCommand("uspFiltrarClinicaPorId", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idclinica", idclinica);
            DataTable tabla = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd); //Ejecutar consulta 'cmd'
            sda.Fill(tabla);
            dgvClinic.DataSource = tabla; //Llenar contenido  */
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Listar();
            txtIdClinica.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmPopupClinica ofrmPopupClinica = new frmPopupClinica();
            ofrmPopupClinica.accion = "Nuevo";
            //ofrmPopupClinica.accion = "New";
            ofrmPopupClinica.ShowDialog();
            if(ofrmPopupClinica.DialogResult.Equals(DialogResult.OK))
            {
                Listar();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmPopupClinica ofrmPopupClinica = new frmPopupClinica();
            ofrmPopupClinica.accion = "Editar";
            ofrmPopupClinica.id = dgvClinic.CurrentRow.Cells[0].Value.ToString();
            ofrmPopupClinica.ShowDialog();
            if(ofrmPopupClinica.DialogResult.Equals(DialogResult.OK))
            {
                Listar();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id =dgvClinic.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("Desea Eliminar ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
            {
                int n = SQL.registrarAcuaRlizaYeliminar("uspeliminarclinica",
                      new System.Collections.ArrayList { "@IDCLINICA" },
                      new System.Collections.ArrayList { id }
                      ); ;
                if (n == 1)
                {
                    MessageBox.Show("Delete Succes");
                    Listar();
                }
                else
                {
                    MessageBox.Show("Ocurrio un Error");
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = printDoct;
            ppd.ShowDialog();
        }
        int contador;
        private void iniciarContador(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            contador = 0;
        }

        private void iniciarConfiguracion(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fuente = new Font("Arial", 10);
            int espaciado = 10;
            int altoLinea= (int)fuente.GetHeight()+espaciado;
            int totalLineasPAgina = e.MarginBounds.Height / altoLinea;

            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;

            int ncolums = dgvClinic.Columns.Count;


        }
    }
}
