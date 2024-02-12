using System;
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
    public partial class FrmPopupDoctor : Form
    {
        public string accion {  get; set; }
        public string id { get; set; }
        public FrmPopupDoctor()
        {
            InitializeComponent();
        }

        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivito de Programa |*.pdf; *.png; *jpg; *.jpeg; *.docx";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string ruta = ofd.FileName;
                bwDoctor.Navigate(ruta);    

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
