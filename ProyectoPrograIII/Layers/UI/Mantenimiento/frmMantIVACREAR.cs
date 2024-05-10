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
    public partial class frmMantIVACREAR : Form
    {
        frmMantIVA _form;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMantIVACREAR(frmMantIVA form)
        {
            _form = form;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }

        /// <summary>
        /// Metodo que se encarga de salvar el objeto de tipo Impuesto a traves 
        /// del metodo saveimpuesto de impuestoBLL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrear_Click(object sender, EventArgs e)
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

                Impuesto oImpuesto = new Impuesto();
                oImpuesto.Porcentaje = int.Parse(this.mskPorcentaje.Text);

                IBLLImpuesto impuestoBLL = new BLLImpuesto();

                impuestoBLL.SaveImpuesto(oImpuesto);
                _form.Refrescar();
                this.Dispose();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                MessageBox.Show("Error al crear el impuesto: " + ex.Message, "Error" ,
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
