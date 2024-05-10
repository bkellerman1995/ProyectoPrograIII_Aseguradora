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

namespace ProyectoPrograIII.Layers.UI.Procesos
{
    public partial class frmProcesosTarjetaADD : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        frmProcesosFacturacion form;

        public frmProcesosTarjetaADD(frmProcesosFacturacion form)
        {
            this.form = form;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }

        /// <summary>
        /// Metodo que se encarga de tomar los valores asignados a los controles del form y salvar el objeto tarjeta mediante
        /// el metodo saveTarjeta de tarjeta BLL. 
        /// Tambien valida si la tarjeta existe y la carga directamente de la base de datos en caso de ser asi 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.mskNoTarjeta.MaskFull == false)
                {
                    MessageBox.Show("Por favor agregue un numero de tarjeta valido", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.mskNoTarjeta.Focus();
                    this.mskNoTarjeta.Text = "";
                    return;
                }

                if (string.IsNullOrEmpty(this.txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor agregue una descripcion para la tarjeta", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtDescripcion.Focus();
                    this.txtDescripcion.Text = "";
                    return;
                }

                if (this.mskCVC.MaskFull == false)
                {
                    MessageBox.Show("Por favor agregue un CVC valido", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.mskCVC.Focus();
                    this.mskCVC.Text = "";
                    return;
                }

                Tarjeta oTarjeta = new Tarjeta();
                IBLLTarjeta tarjetaBLL = new BLLTarjeta();

                oTarjeta.IdTarjeta = this.mskNoTarjeta.Text;

                if (tarjetaBLL.GetTarjetaById(oTarjeta.IdTarjeta) != null)
                {
                    var resultado = MessageBox.Show("La tarjeta ya existe " +
                        "\n¿Desea utilizarla?", "Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        oTarjeta = tarjetaBLL.GetTarjetaById(oTarjeta.IdTarjeta);
                        form.Refrescar(oTarjeta);
                        this.Dispose();

                    }

                }
                else
                {
                    oTarjeta.DescripcionTarjeta = this.txtDescripcion.Text;
                    oTarjeta.CVC = this.mskCVC.Text;
                    oTarjeta.FechaExpiracion = this.dateTimePicker1.Value;

                    tarjetaBLL.SaveTarjeta(oTarjeta);
                    form.Refrescar(oTarjeta);
                    form.HabilitarBotonGenerarFactura();
                    form.HabilitarFirmaDigital();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                MessageBox.Show("Error al procesar la tarjeta: " + ex.Message, "Error" ,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
