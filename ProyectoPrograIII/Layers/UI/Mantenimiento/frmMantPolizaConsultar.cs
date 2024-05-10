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

namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    public partial class frmMantPolizaConsultar : Form
    {
        Poliza oPoliza;

        IBLLFamiliares familiarBLL;
        IBLLPlan planBLL;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMantPolizaConsultar(Poliza oPoliza)
        {
            this.oPoliza = oPoliza;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmMantPolizaConsultar_Load(object sender, EventArgs e)
        {
            familiarBLL = new BLLFamiliares();
            planBLL = new BLLPlan();
            this.txtID.Text = oPoliza.ID;
            this.txtDescripcion.Text = oPoliza.Descripcion;
            this.txtBoxCliente.Text = oPoliza.Cliente.ToString();
            this.txtTipodePlan.Text = oPoliza.Plan.ToString();

            if (oPoliza.Plan.Familiar == true)
            {
                this.lstFamilares.DataSource = familiarBLL.GetAllFamiliaresCliente(oPoliza.Cliente);
            }

            this.lstCoberturas.DataSource = planBLL.GetAllCoberturasPlan(oPoliza.Plan);



        }
    }
}
