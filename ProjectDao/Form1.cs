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



namespace ProjectDao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SQL.ListarConsultaSQL("select IIDCLINICA, NOMBRE, DIRECCION from Clinica where BHABILITADO = 1", cn);
            
        }
    }
}
