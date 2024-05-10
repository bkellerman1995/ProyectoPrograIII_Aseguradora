using ProyectoPrograIII.Interfaces;
using ProyectoPrograIII.Layers.BLL;
using ProyectoPrograIII.Layers.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;


namespace ProyectoPrograIII.Layers.UI.Procesos
{


    public partial class frmFacturaProcesada : Form
    {
        int idFactura;
        System.Drawing.Image Qr;
        System.Drawing.Image eSignature;
        IBLLFactura facturaBLL;
        IBLLCliente clienteBLL;
        Cliente oCliente;
        Poliza oPoliza;
        IBLLPoliza polizaBLL;
        IBLLPlan planBLL;
        Plan oPlan;
        IBLLFamiliares familiarBLL;
        Bitmap MemoryImage;
        PrintDocument printDocument1;
        string rutaPDF;
        bool btnEnviarCorreoWasclicked;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);



        public frmFacturaProcesada(int idFactura, System.Drawing.Image Qr, System.Drawing.Image firmaElectronica)
        {
            this.idFactura = idFactura;
            this.Qr = Qr;
            eSignature = firmaElectronica;
            btnEnviarCorreoWasclicked = false;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }

        private void frmFacturaProcesada_Load(object sender, EventArgs e)
        {
            this.picQR.Image = this.Qr;
            this.picQR.SizeMode = PictureBoxSizeMode.StretchImage;

            this.picEsignature.Image = eSignature;
            this.picEsignature.SizeMode = PictureBoxSizeMode.StretchImage;

            printDocument1 = new PrintDocument();
            rutaPDF = @"c:\temp\factura.pdf";

            facturaBLL = new BLLFactura();
            clienteBLL = new BLLCliente();
            oCliente = new Cliente();
            oPoliza = new Poliza();
            oPlan = new Plan();
            polizaBLL = new BLLPoliza();
            familiarBLL = new BLLFamiliares();
            planBLL = new BLLPlan();

            StringBuilder sbFactura = new StringBuilder();
            sbFactura.Append("====================================================");
            sbFactura.AppendLine("             ASEGURADORA SECLIFE S.A.");
            sbFactura.AppendLine("====================================================");
            sbFactura.AppendLine("No. Factura: " + idFactura);
            sbFactura.AppendLine("Fecha de Facturacion: " + facturaBLL.GetFactura(idFactura).FechaFacturacion.ToString("dd/MM/yyyy"));
            this.txtEncabezado.Text = sbFactura.ToString();

            oCliente = facturaBLL.GetFactura(idFactura).Cliente;

            StringBuilder sbCliente = new StringBuilder();
            sbCliente.Append("DATOS DEL CLIENTE: ");
            sbCliente.AppendLine(" ");
            sbCliente.AppendLine("Cédula : " + oCliente.ID);
            sbCliente.AppendLine("Nombre Completo: " + oCliente.Nombre.Trim() + " " + oCliente.Apellido1 + " " + oCliente.Apellido2);

            if (oCliente.Sexo == 1)
                sbCliente.AppendLine("Sexo: Masculino");
            if (oCliente.Sexo == 2)
                sbCliente.AppendLine("Sexo: Femenino");

            sbCliente.AppendLine("No.Teléfono: " + oCliente.NumTelefono);
            sbCliente.AppendLine("Dirección: " + oCliente.Direccion);
            sbCliente.AppendLine("País: " + oCliente.Pais.Nombre);
            sbCliente.AppendLine("E-mail: " + oCliente.CorreoElectronico);
            this.txtDetallesCliente.Text = sbCliente.ToString();

            foreach (var facturaDetalle in facturaBLL.GetFactura(idFactura)._ListaFacturaDetalle)
            {
                oPoliza = polizaBLL.GetPolizaByID(facturaDetalle.IDPoliza);
                oPlan = polizaBLL.GetPolizaByID(facturaDetalle.IDPoliza).Plan;
                break;
            }

            StringBuilder sbPolizaPlan = new StringBuilder();
            sbPolizaPlan.Append("Póliza : " + oPoliza.ID.Trim() + ", " + oPoliza.Descripcion);
            sbPolizaPlan.AppendLine(" ");
            sbPolizaPlan.AppendLine("Plan: " + oPlan.ID.Trim() + ", " + oPlan.NombrePlan + " - Costo: $" + oPlan.CostoPlan);

            if (oPlan.Familiar == true)
                sbPolizaPlan.Append(" - Familiar: Sí");
            else
                sbPolizaPlan.Append(" - Familiar: No");


            this.txtDetallesPlan.Text = sbPolizaPlan.ToString();

            StringBuilder sbListaFamiliares = new StringBuilder();
            sbListaFamiliares.Append("LISTA DE FAMILIARES");
            sbListaFamiliares.AppendLine("");
            sbListaFamiliares.AppendLine("");

            foreach (var familiar in familiarBLL.GetAllFamiliaresCliente(oCliente))
            {
                sbListaFamiliares.AppendLine(familiar.ToString());
            }

            this.txtListaFamiliares.Text = sbListaFamiliares.ToString();

            StringBuilder sbCoberturasPlan = new StringBuilder();
            sbCoberturasPlan.Append("LISTA DE COBERTURAS");
            sbCoberturasPlan.AppendLine("");
            sbCoberturasPlan.AppendLine("");

            foreach (var cobertura in planBLL.GetAllCoberturasPlan(oPlan))
            {
                sbCoberturasPlan.AppendLine(cobertura.IDCobertura.Trim() +
                    ", " + cobertura.Nombre + ", " + "Prima: $" + cobertura.Prima +
                    ", " + "Monto Máximo a cubrir: $" + (cobertura.MontoMaximo - cobertura.Prima) +
                    ", " + "No. Eventos por año: " + cobertura.NumEventosAnno);
            }

            this.txtListaCoberturas.Text = sbCoberturasPlan.ToString();

            StringBuilder sbMontosaPagar = new StringBuilder();
            sbMontosaPagar.Append("RUBROS");
            sbMontosaPagar.AppendLine("");
            sbMontosaPagar.AppendLine("Impuesto: " + facturaBLL.GetFactura(idFactura).GetImpuesto() + " %");
            sbMontosaPagar.AppendLine("Monto a pagar en Colones: ₡" + facturaBLL.GetFactura(idFactura).GetTotalColones());
            sbMontosaPagar.AppendLine("Monto a pagar en Dolares: $" + facturaBLL.GetFactura(idFactura).GetTotalDolares());

            this.txtCalculos.Text = sbMontosaPagar.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {

            try
            {
                if (File.Exists(rutaPDF))
                    File.Delete(rutaPDF);

                else
                {
                    StreamWriter sw = new StreamWriter(rutaPDF, true);
                    sw.Close();
                }

                int width = this.panel1.Width;
                int height = this.panel1.Height;

                var pgSize = new iTextSharp.text.Rectangle(width, height);
                iTextSharp.text.Document doc = new iTextSharp.text.Document(pgSize);

                MemoryImage = new Bitmap(width, height);
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, width, height);

                this.panel1.DrawToBitmap(MemoryImage, new System.Drawing.Rectangle(0, 0, width, height));

                iTextSharp.text.Image image1 = iTextSharp.text.Image.GetInstance((System.Drawing.Image)MemoryImage,
                    System.Drawing.Imaging.ImageFormat.Png);

                image1.Alignment = iTextSharp.text.Image.ALIGN_CENTER;

                PdfWriter.GetInstance(doc, new FileStream(rutaPDF, FileMode.Create));
                doc.Open();
                doc.Add(image1);
                doc.Close();

                this.btnEnviarCorreoWasclicked = true;
                this.btnSalir.Enabled = true;
                BLLFactura.EnviarCorreo(rutaPDF);
                MessageBox.Show("Correo enviado", "Informacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                MessageBox.Show("Por favor ingrese un ID para el cliente", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmFacturaProcesada_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.btnEnviarCorreoWasclicked == false)
            {
                var resultado = MessageBox.Show("Aun no ha enviado el correo, por favor envie el correo de la factura", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

        }
    }
}
