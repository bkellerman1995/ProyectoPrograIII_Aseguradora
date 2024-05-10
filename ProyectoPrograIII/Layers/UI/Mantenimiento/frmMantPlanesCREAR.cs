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
    public partial class frmMantPlanesCREAR : Form
    {
        frmMantPlanes _form;
        IBLLPlan planBLL;
        IBLLCobertura coberturaBLL;
        Cobertura oCobertura;
        Cobertura coberturaAuxiliar;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        Plan oPLan;
        public frmMantPlanesCREAR(frmMantPlanes form)
        {
            _form = form;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmMantPlanesCREAR_Load(object sender, EventArgs e)
        {

            coberturaBLL = new BLLCobertura();

            this.lstCobertura.DataSource = coberturaBLL.GetAllCobertura();

            coberturaAuxiliar = new Cobertura();
        }

        /// <summary>
        /// Metodo que se encarga de salvar la cobertura para el plan a traves del 
        /// metodo SaveCoberturaPlan del plan BLL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            
            oCobertura = new Cobertura();


            oCobertura = (Cobertura)this.lstCobertura.SelectedItem;

            if (coberturaAuxiliar == oCobertura)
            {
                MessageBox.Show("Ya se escogio la cobertura :" +
                    "\nPor favor seleccione otra cobertura", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            planBLL.SaveCoberturaPlan(oPLan, oCobertura);
            coberturaAuxiliar = oCobertura;
            _form.Refrescar();

            this.lstCoberturaPlan.Items.Add(oCobertura);
        }

        /// <summary>
        /// Metodo que se encarga de borrar la cobertura del sistema a traves 
        /// del metodo deletecobertura de planBLL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (this.lstCoberturaPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecciona una cobertura para quitar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            oCobertura = (Cobertura)this.lstCoberturaPlan.SelectedItem;
            planBLL.DeleteCobertura(oCobertura);

            this.lstCoberturaPlan.Items.Remove((Cobertura)this.lstCoberturaPlan.SelectedItem);

        }

        /// <summary>
        /// Metodo que se encarga de crear el plan usando los 
        /// valores de los controles y llama al metodo saveplan de
        /// planBLL para salvar el objeto Plan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckPLan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.mskID.Text))
            {
                MessageBox.Show("Por favor ingrese un ID de plan", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.mskID.Focus();
                return;
            }


            if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("Por favor ingrese un nombre de plan", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNombre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.mskCosto.Text))
            {
                MessageBox.Show("Por favor ingrese el costo del plan", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.mskCosto.Focus();
                return;
            }

            oPLan = new Plan();
            oPLan.ID = this.mskID.Text;
            oPLan.NombrePlan = this.txtNombre.Text;

            if (this.chcFamiliar.Checked)
            {
                oPLan.Familiar = true;
            }
            else
            {
                oPLan.Familiar = false;
            }

            oPLan.CostoPlan = Double.Parse(this.mskCosto.Text);

            planBLL = new BLLPlan();

            foreach (var plan in planBLL.GetAllPlan())
            {
                if ((string.Equals(oPLan.ID, plan.ID.Trim(), StringComparison.OrdinalIgnoreCase))
                    && mskID.Enabled == true)
                {
                    MessageBox.Show("El plan con ID: " + plan.ID.Trim() + " ya existe" +
                        "\nPor favor introduza otro ID", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.mskID.Enabled = true;
                    this.mskID.Text = "";
                    this.mskID.Focus();
                    return;
                }

            }

            planBLL.SavePlan(oPLan);

            this.btnCrear.Enabled = false;
            this.mskID.Enabled = false;
            this.txtNombre.Enabled = false;
            this.chcFamiliar.Enabled = false;

            this.btnAgregar.Enabled = true;
            this.btnQuitar.Enabled = true;

            _form.Refrescar();
        }
    }
}
