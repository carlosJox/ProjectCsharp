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
            if (accion.Equals("Nuevo"))
            {
                this.Text = "Ingrese Medicamento";
            }
            else
            {
                this.Text = "Actualize Medicamento";
            }
        }
    }
}
