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
    public partial class frmMantPolizaCREAR : Form
    {
        IBLLCliente clienteBLL;
        IBLLPlan planBLL;
        IBLLPoliza polizaBLL;
        Cliente oCliente;
        Plan oPlan;
        Poliza oPoliza;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        frmMantPoliza _form;
        public frmMantPolizaCREAR(frmMantPoliza form)
        {
            _form = form;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }

        /// <summary>
        /// Metodo que se encarga de leer los valores de los controles del 
        /// form para salvar la poliza en la base de datos mediante el metodo 
        /// SavePoliza de poliza BLL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrear_Click(object sender, EventArgs e)
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


                foreach (var poliza in polizaBLL.GetAllPoliza())
                {
                    if (string.Equals(oPoliza.ID, poliza.ID.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("La poliza con ID: " + poliza.ID.Trim() + " ya existe" +
                            "\nPor favor utilice otro ID", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.mskID.Enabled = true;
                        this.mskID.Text = "";
                        this.mskID.Focus();
                        return;
                    }
                }


                polizaBLL.SavePoliza(oPoliza);
                _form.Refrescar();
                this.Dispose();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                MessageBox.Show("Error al crear la poliza: " +ex.Message, "Error",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void frmMantPolizaCREAR_Load(object sender, EventArgs e)
        {

            clienteBLL = new BLLCliente();
            planBLL = new BLLPlan();
            polizaBLL = new BLLPoliza();
            this.mskID.Focus();
            this.cmbCliente.DataSource = clienteBLL.GetAllCliente();
            this.cmbTipoPlan.Enabled = false;
        }

        /// <summary>
        /// Metodo que se encarga de cargar los planes disponibles para el cliente
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
                    MessageBox.Show("Por favor ingrese un ID para la poliza");
                    this.mskID.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor ingrese una descripcion para la poliza");
                    this.txtDescripcion.Focus();
                    return;
                }

                if (this.cmbCliente.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor ingrese un cliente");
                    this.cmbCliente.Focus();
                    return;
                }

                oCliente = (Cliente)this.cmbCliente.SelectedItem;
                this.mskID.Enabled = false;
                this.txtDescripcion.Enabled = false;
                this.btnCrear.Enabled = true;
                this.btnGenerarPlanes.Enabled = false;

                this.cmbTipoPlan.Enabled = true;
                this.cmbTipoPlan.DataSource = planBLL.GetAllPlan();

            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                MessageBox.Show("Error al generar los planes :" + ex.Message, "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        /// <summary>
        /// Metodo que se encarga de activar los botones de agregar familiares 
        /// dependiendo del valor de atributo "Familiar" del plan. Ejemplo: true habilita el boton, 
        /// false deshabilita el boton
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
    }
}
