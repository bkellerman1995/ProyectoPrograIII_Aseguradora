using ProyectoPrograIII.Interfaces;
using ProyectoPrograIII.Layers.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPrograIII.Layers.Entities;

namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    public partial class frmMantPlanesCONSULTAR : Form
    {
        string ID;
        string NombrePlan;
        double CostoPlan;
        IBLLPlan planBLL;
        Plan oPlan;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMantPlanesCONSULTAR(string ID, string NombrePlan, double Costo,Plan oPlan)
        {
            this.ID = ID;
            this.NombrePlan = NombrePlan;
            this.CostoPlan = Costo;
            this.oPlan = oPlan;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }

        private void frmMantPlanesCONSULTAR_Load(object sender, EventArgs e)
        {
            this.txtID.Text = ID;
            this.txtNombre.Text = NombrePlan;
            this.txtCosto.Text = CostoPlan +"";

            planBLL = new BLLPlan();

            this.lstCoberturas.DataSource = planBLL.GetAllCoberturasPlan(oPlan);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
