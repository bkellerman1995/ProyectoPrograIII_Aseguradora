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
    public partial class frmReporteVentas : Form
    {
        public frmReporteVentas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que se encarga de generar el reporte con base en los valores enviados con la fecha de inicial y la fecha final
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (!this.dateTimePickerFechaInicio.Checked ||
                !this.dateTimePickerFechaFinal.Checked)
            {
                MessageBox.Show("Por favor elija una fecha válida para el inicio y para el final", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime fechaInicio = new DateTime();
            DateTime fechaFinal = new DateTime();

            fechaInicio = this.dateTimePickerFechaInicio.Value.Date;
            fechaFinal = this.dateTimePickerFechaFinal.Value.Date;

            fechaInicio.ToString("dd/MM/yyyy");
            fechaFinal.ToString("dd/MM/yyyy");

            this.usp_SELECT_FechaEncabezado_ByFechaFacturacionTableAdapter.Fill(this.dataSetReporteVentasPoliza.usp_SELECT_FechaEncabezado_ByFechaFacturacion, fechaInicio, fechaFinal);
            this.reportViewer1.RefreshReport();
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
