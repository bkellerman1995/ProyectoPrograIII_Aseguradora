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
    public partial class frmConsultaCobertura : Form
    {
        string ID;
        string Nombre;
        string Prima;
        string MontoMaximo;
        string NumEventos;
        public frmConsultaCobertura(string ID, string Nombre, string Prima, string MontoMaximo, string NumEventos)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Prima = Prima;
            this.MontoMaximo = MontoMaximo;
            this.NumEventos = NumEventos;

            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmConsultaCobertura_Load(object sender, EventArgs e)
        {
            this.txtID.Text = ID;
            this.txtNombre.Text = Nombre;
            this.txtPrima.Text = Prima;
            this.txtMontoMaximo.Text = MontoMaximo;
            this.txtNumEventos.Text = NumEventos;
        }
    }
}
