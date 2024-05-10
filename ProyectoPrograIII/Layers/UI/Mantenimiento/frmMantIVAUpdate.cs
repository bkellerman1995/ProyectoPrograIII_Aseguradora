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
    public partial class frmMantIVAUpdate : Form
    {
        Impuesto oImpuesto;
        frmMantIVA _form;
        IBLLImpuesto impuestoBLL;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMantIVAUpdate(Impuesto oImpuesto,frmMantIVA form)
        {
            this.oImpuesto = oImpuesto;
            _form = form;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmMantIVAUpdate_Load(object sender, EventArgs e)
        {
            this.mskPorcentaje.Text = oImpuesto.Porcentaje + "";
        }

        /// <summary>
        /// Metodo que se encarga de actualizar el objeto Plan a traves 
        /// del metodo updateimpuesto de plan BLL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.mskPorcentaje.Text))
                {
                    MessageBox.Show("Por favor ingrese un porcentaje para el impuesto", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.mskPorcentaje.Focus();
                    return;
                }

                oImpuesto.Porcentaje = int.Parse(this.mskPorcentaje.Text);

                IBLLImpuesto impuestoBLL = new BLLImpuesto();
                impuestoBLL.UpdateImpuesto(oImpuesto);
                _form.Refrescar();
                this.Dispose();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                MessageBox.Show("Error al actualzar el IVA : " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
