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
    public partial class frmMantPolizaUPDATE : Form
    {
        IBLLCliente clienteBLL;
        IBLLPlan planBLL;
        IBLLPoliza polizaBLL;
        Cliente oCliente;
        Poliza oPoliza;
        Plan oPlan;

        frmMantPoliza _form;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMantPolizaUPDATE(Poliza oPoliza,frmMantPoliza form)
        {
            this.oPoliza = oPoliza;
            _form = form;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }

        private void frmMantPolizaUPDATE_Load(object sender, EventArgs e)
        {
            clienteBLL = new BLLCliente();
            planBLL = new BLLPlan();
            polizaBLL = new BLLPoliza();
            this.mskID.Text = oPoliza.ID;
            this.txtDescripcion.Text = oPoliza.Descripcion;
            this.txtDescripcion.Focus();
            this.cmbCliente.DataSource = clienteBLL.GetAllCliente();
            this.cmbTipoPlan.Enabled = false;
        }

        /// <summary>
        /// Metodo que se encarga de llamar el metodo getallplanes de planBLL para enlistar los planes 
        /// disponibles para el cliente. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerarPlanes_Click(object sender, EventArgs e)
        {
            try
            {
                oCliente = new Cliente();
                if (string.IsNullOrEmpty(this.mskID.Text))
                {
                    MessageBox.Show("Por favor ingrese un ID para la poliza", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.mskID.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor ingrese una descripcion para la poliza", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtDescripcion.Focus();
                    return;
                }

                if (this.cmbCliente.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor ingrese un cliente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cmbCliente.Focus();
                    return;
                }

                oCliente = (Cliente)this.cmbCliente.SelectedItem;
                this.mskID.Enabled = false;
                this.txtDescripcion.Enabled = false;
                this.btnActualizar.Enabled = true;
                this.btnGenerarPlanes.Enabled = false;

                this.cmbTipoPlan.Enabled = true;
                this.cmbTipoPlan.DataSource = planBLL.GetAllPlan();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                MessageBox.Show("Error al generar los planes : " + ex.Message, "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Metodo que se encarga de recibir los valores que se asignan a los controles
        /// del form para poder actualizar la poliza. Llama al metodo updatePoliza de 
        /// BLLPoliza para actualizar la poliza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.mskID.Text))
                {
                    MessageBox.Show("Por favor ingree un ID de poliza", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.mskID.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor ingrese descripcion de poliza", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtDescripcion.Focus();
                    return;
                }

                if (this.cmbTipoPlan.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione un plan", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cmbTipoPlan.Focus();
                    return;
                }

                if (this.cmbCliente.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione un cliente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cmbTipoPlan.Focus();
                    return;
                }

                oPoliza = new Poliza();
                oPoliza.ID = this.mskID.Text;
                oPoliza.Descripcion = this.txtDescripcion.Text;
                oPoliza.Cliente = oCliente;
                oPoliza.Plan = (Plan)this.cmbTipoPlan.SelectedItem;

                polizaBLL.UpdatePoliza(oPoliza);
                _form.Refrescar();
                this.Dispose();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                MessageBox.Show("Error al actualizar la poliza: " + ex.Message, "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbTipoPlan.Focus();
                return;
                
            }
        }

        /// <summary>
        /// Metodo que se encarga de leer el atributo "Familiar" del plan
        /// asignarlo al valor del combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTipoPlan_SelectedValueChanged(object sender, EventArgs e)
        {
            oPlan = (Plan)this.cmbTipoPlan.SelectedItem;

            if (oPlan.Familiar == true)
            {
                this.btnAnnadirFamiliar.Enabled = true;
            }
            else
            {
                this.btnAnnadirFamiliar.Enabled = false;
            }

            this.lstCoberturas.DataSource = planBLL.GetAllCoberturasPlan(oPlan);
        }

        private void btnAnnadirFamiliar_Click(object sender, EventArgs e)
        {
            frmMantPolizaFamiliaresADD form = new frmMantPolizaFamiliaresADD(oCliente);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
