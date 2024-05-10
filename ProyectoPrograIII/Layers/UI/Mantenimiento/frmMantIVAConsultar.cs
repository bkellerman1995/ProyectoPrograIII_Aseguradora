using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    public partial class frmMantIVAConsultar : Form
    {
        string porcentaje;
        public frmMantIVAConsultar(string porcentaje)
        {
            this.porcentaje = porcentaje;
            InitializeComponent();
        }

        private void frmMantIVAConsultar_Load(object sender, EventArgs e)
        {
            this.txtPorcentaje.Text = porcentaje;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
