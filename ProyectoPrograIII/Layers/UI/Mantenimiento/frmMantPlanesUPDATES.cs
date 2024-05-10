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
    public partial class frmMantPlanesUPDATES : Form
    {
        frmMantPlanes _form;
        Plan oPlan;
        IBLLPlan planBLL;
        IBLLCobertura coberturaBLL;
        Cobertura oCobertura;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMantPlanesUPDATES(Plan oPlan, frmMantPlanes form)
        {
            _form = form;
            this.oPlan = oPlan;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }

        /// <summary>
        /// Este evento carga los valores del objeto que se recibe como 
        /// parametro en los controles respectivos para actualizarlos a traves del metodo 
        /// updatePoliza de polizaBLL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMantPlanesUPDATES_Load(object sender, EventArgs e)
        {

            this.txtID.Text = oPlan.ID;
            this.txtNombre.Text = oPlan.NombrePlan;
            this.mskCosto.Text = oPlan.CostoPlan +"";

            if (oPlan.Familiar == true)
                this.chcFamiliar.Checked = true;

            if (oPlan.Familiar == false)
                this.chcFamiliar.Checked = false;

            planBLL = new BLLPlan();

            foreach (var cobertura in planBLL.GetAllCoberturasPlan(oPlan))
            {
                this.lstCoberturaPlan.Items.Add(cobertura);
            }

            coberturaBLL = new BLLCobertura();

            this.lstCobertura.DataSource = coberturaBLL.GetAllCobertura();



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            oCobertura = new Cobertura();

            oCobertura = (Cobertura)this.lstCobertura.SelectedItem;

            foreach (var cobertura in planBLL.GetAllCoberturasPlan(oPlan))
            {
                if (oCobertura.IDCobertura == cobertura.IDCobertura)
                {
                    MessageBox.Show("La cobertura ya existe en el plan, por favor seleccione otra", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            planBLL.SaveCoberturaPlan(oPlan, oCobertura);
            this.lstCoberturaPlan.Items.Add(oCobertura);

        }

        /// <summary>
        /// Metodo que se encarga de tomar los valores de los controles del form y se 
        /// los asigna al objeto de tipo Plan para luego enviarlo como parametro 
        /// al metodo updateplan de plan BLL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {

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

            oPlan.NombrePlan = this.txtNombre.Text;

            if (this.chcFamiliar.Checked)
                oPlan.Familiar = true;
            if (this.chcFamiliar.Checked == false)
                oPlan.Familiar = false;

            oPlan.CostoPlan = double.Parse(this.mskCosto.Text);

            planBLL.UpdatePlan(oPlan);

            this.txtNombre.Enabled = false;

            this.btnAgregar.Enabled = true;
            this.btnQuitar.Enabled = true;
            _form.Refrescar();
        }

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

            this.lstCoberturaPlan.Items.Remove(oCobertura);
        }
    }
}
