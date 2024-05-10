using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograIII.Layers.UI.Reportes
{
    public partial class frmReporteFactura : Form
    {
        int numfactura;
        Image firma;
        public frmReporteFactura(int numFactura, Image firma)
        {
            numfactura = numFactura;
            this.firma = firma;
            InitializeComponent();
        }

        private void frmReporteFactura_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
