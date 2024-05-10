using ProyectoPrograIII.Interfaces;
using ProyectoPrograIII.Layers.BLL;
using ProyectoPrograIII.Layers.Entities;
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
    public partial class frmReportesPoliza : Form
    {
        IBLLCliente clienteBLL;
        public frmReportesPoliza()
        {
            InitializeComponent();
        }

        private void frmReportesPoliza_Load(object sender, EventArgs e)
        {
            
            clienteBLL = new BLLCliente();
            this.cmbPolizas.DisplayMember = "ID";
            this.cmbPolizas.ValueMember = "ID";
            this.cmbPolizas.DataSource = clienteBLL.GetAllCliente();

            this.reportViewer1.RefreshReport();
        }

        private void cmbPolizas_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.usp_SELECT_Poliza_ByClienteIDTableAdapter.Fill(this.dataSetPolizaCliente.usp_SELECT_Poliza_ByClienteID, (int)this.cmbPolizas.SelectedValue);
            this.reportViewer1.RefreshReport();
        }
    }
}
