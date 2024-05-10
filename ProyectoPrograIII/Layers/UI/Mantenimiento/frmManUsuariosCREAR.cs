using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograIII.Capas.UI.Mantenimiento
{
    public partial class frmManUsuariosCREAR : Form
    {
        public frmManUsuariosCREAR()
        {
            InitializeComponent();
        }

        private void frmManUsuariosCREAR_Load(object sender, EventArgs e)
        {
            this.cmbRol.Items.Add("Administrador");
            this.cmbRol.Items.Add("Procesos");
            this.cmbRol.Items.Add("Reportes");

        }
    }
}
