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
using System.Reflection;
using System.Drawing.Imaging;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO;
using System.Security.Cryptography.Xml;
using ProyectoPrograIII.Util;
using ProyectoPrograIII.Layers.UI.Reportes;

namespace ProyectoPrograIII.Layers.UI.Procesos
{
    public partial class frmProcesosFacturacion : Form
    {
        IBLLFactura facturaBLL;
        IBLLPoliza polizaBLL;
        IBLLPlan planBLL;
        IBLLCliente clienteBLL;
        IBLLFamiliares familiarBLL;
        IBLLTarjeta tarjetaBLL;
        IBLLImpuesto impuestoBLL;
        Poliza oPoliza;
        Tarjeta oTarjeta;
        FacturaDetalle oFacturaDetalle;
        FacturaEncabezado oFacturaEncabezado;

        string Img;

        private string AppPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
        private Signature cSignature;
        private Point? _Previous = null;
        private Pen _Pen = new Pen(Color.Black);


        public frmProcesosFacturacion()
        {
            oFacturaDetalle = new FacturaDetalle();
            oFacturaEncabezado = new FacturaEncabezado();
            InitializeComponent();
        }

        public void Refrescar(Tarjeta oTarjeta)
        {
            this.oTarjeta = oTarjeta;
            this.btnAnnadirTarjeta.Enabled = false;
            this.mskNoTarjeta.Text = oTarjeta.IdTarjeta;
            this.txtDescripcion.Text = oTarjeta.DescripcionTarjeta;
            this.mskCVC.Text = oTarjeta.CVC;
            this.txtFechaExpiracion.Text = oTarjeta.FechaExpiracion.ToString("dd/MM/yyyy");
            this.btnGenerarFactura.Enabled = true;
            this.picSignature.Enabled = true;

        }

        private void frmProcesosFacturacion_Load(object sender, EventArgs e)
        {
            try
            {
                planBLL = new BLLPlan();
                clienteBLL = new BLLCliente();
                polizaBLL = new BLLPoliza();
                familiarBLL = new BLLFamiliares();
                facturaBLL = new BLLFactura();
                tarjetaBLL = new BLLTarjeta();
                impuestoBLL = new BLLImpuesto();
                oPoliza = new Poliza();

                if (polizaBLL.GetAllPoliza().Count == 0)
                {
                    MessageBox.Show("No existen polizas para facturar, por favor cree al menos una",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Dispose();
                    return;
                }

                if (planBLL.GetAllPlan().Count == 0)
                {
                    MessageBox.Show("No existen planes para facturar la poliza, por favor cree al menos uno",
                        "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Dispose();
                    return;

                }

                if (clienteBLL.GetAllCliente().Count == 0)
                {
                    MessageBox.Show("No existen clientes para facturar la poliza, por favor cree al menos uno",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Dispose();
                    return;

                }

                if (impuestoBLL.GEtAllImpuesto().Count == 0)
                {
                    MessageBox.Show("No se ha añadido el valor de impuesto en el sistema, por favor ingrese uno",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Dispose();
                    return;
                }

                oTarjeta = new Tarjeta();
                DateTime fecha = DateTime.Today;
                string fechahoy = fecha.ToString("dd/MM/yyyy");

                this.lblTipoCambio.Text = "Tipo de cambio del dólar a la fecha de hoy: " + fechahoy +
                    "\n₡" + FacturaDetalle.RetornarTipoCambio();

                foreach (var impuesto in impuestoBLL.GEtAllImpuesto())
                {
                    this.txtIVA.Text = impuesto.Porcentaje + " %";
                    oFacturaDetalle.Impuesto = impuesto.Porcentaje;
                    break;
                }

                if (facturaBLL.GetFactura(facturaBLL.GetCurrentNumeroFactura()).IdFactura == 
                    facturaBLL.GetCurrentNumeroFactura())
                {
                    this.txtNoFactura.Text = facturaBLL.GetNextNumeroFactura().ToString();
                }
                else
                {
                    this.txtNoFactura.Text = facturaBLL.GetCurrentNumeroFactura().ToString();
                }

                this.cmbPoliza.DataSource = polizaBLL.GetAllPoliza();

                this.txtTipoPlan.Text = oPoliza.Plan.ToString();
                this.lstCoberturas.DataSource = planBLL.GetAllCoberturasPlan(oPoliza.Plan);
                this.lstCoberturas.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                log4net.Config.XmlConfigurator.Configure();
                MessageBox.Show("Error al procesar la facturacion: " + ex.Message, "Error" ,
    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }

        private void cmbPoliza_SelectedIndexChanged(object sender, EventArgs e)
        {
            oPoliza = (Poliza)this.cmbPoliza.SelectedItem;
            this.txtCliente.Text = oPoliza.Cliente.ToString();

            this.txtTipoPlan.Text = oPoliza.Plan.ToString();
            this.lstCoberturas.DataSource = planBLL.GetAllCoberturasPlan(oPoliza.Plan);
            this.lstCoberturas.SelectedIndex = -1;
            this.lstFamiliares.DataSource = familiarBLL.GetAllFamiliaresCliente(oPoliza.Cliente);
            this.lstFamiliares.SelectedIndex = -1;

            this.txtTotalColones.Text = "₡ " + oFacturaDetalle.calcularTotalColones(oPoliza);
            this.txtDolares.Text = "$ " + oFacturaDetalle.calcularTotalDolares(oPoliza);
        }

        private void btnAnnadirTarjeta_Click(object sender, EventArgs e)
        {
            frmProcesosTarjetaADD form = new frmProcesosTarjetaADD(this);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void HabilitarBotonGenerarFactura()
        {
            this.btnGenerarFactura.Enabled = true;
        }

        public void HabilitarFirmaDigital()
        {
            this.picSignature.Enabled = true;
        }

        private void lstFamiliares_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstCoberturas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Metodo que se encarga de generar el codigo necesario para poder escribir la 
        /// firma electronica en la factura a procesar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picSignature_MouseMove(object sender, MouseEventArgs e)
        {
            if (_Previous != null)
            {
                if (this.picSignature.Image == null)
                {
                    Bitmap bmp = new Bitmap(this.picSignature.Width, this.picSignature.Height);
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.Clear(Color.White);
                    }
                    this.picSignature.Image = bmp;
                }
                using (Graphics g = Graphics.FromImage(this.picSignature.Image))
                {
                    g.DrawLine(_Pen, _Previous.Value.X, _Previous.Value.Y, e.X, e.Y);
                }
                this.picSignature.Invalidate();
                _Previous = new Point(e.X, e.Y);
            }
        }

        private void picSignature_MouseDown(object sender, MouseEventArgs e)
        {
            _Previous = new Point(e.X, e.Y);
            picSignature_MouseMove(sender, e);
        }

        private void picSignature_MouseUp(object sender, MouseEventArgs e)
        {
            _Previous = null;
        }

        private void btnBorrarFirma_Click(object sender, EventArgs e)
        {
            this.picSignature.Image = null;
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            int numfactura = 0;
            string rutaImagen = @"c:\temp\qr.png";
            if (this.picSignature.Image == null)
            {
                MessageBox.Show("Por favor inserte una firma para generar la factura", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            oFacturaDetalle.IdFactura = int.Parse(this.txtNoFactura.Text);
            oFacturaDetalle.IDPoliza = oPoliza.ID;

            oFacturaEncabezado.IdFactura = int.Parse(this.txtNoFactura.Text);
            oFacturaEncabezado.Tarjeta = oTarjeta;
            oFacturaEncabezado.FechaFacturacion = DateTime.Today;
            oFacturaEncabezado.Cliente = oPoliza.Cliente;
            oFacturaEncabezado.EstadoFactura = true;

            oFacturaEncabezado.AddDetalle(oFacturaDetalle);

            facturaBLL.SaveFactura(oFacturaEncabezado, oPoliza);
            this.btnGenerarFactura.Enabled = false;

            numfactura = int.Parse(this.txtNoFactura.Text);


            if (File.Exists(rutaImagen))
                File.Delete(rutaImagen);

            Image quickResponseImage = QuickResponse.QuickResponseGenerador(numfactura.ToString(), 53);

            // Salvarla en c:\temp para luego ser leida
            quickResponseImage.Save(rutaImagen, ImageFormat.Png);

            frmFacturaProcesada form = new frmFacturaProcesada(numfactura, quickResponseImage, this.picSignature.Image);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.ShowDialog();
        }
    }
}
