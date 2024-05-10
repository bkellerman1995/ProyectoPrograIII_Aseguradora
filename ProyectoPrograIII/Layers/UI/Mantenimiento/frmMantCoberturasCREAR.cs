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
using ProyectoPrograIII.Layers.BLL;
using ProyectoPrograIII.Interfaces;

namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    public partial class frmMantCoberturasCREAR : Form
    {
        frmMantCoberturas _form;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMantCoberturasCREAR(frmMantCoberturas form)
        {
            _form = form;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }

        /// <summary>
        /// Metodo que se encarga de tomar los valores asignados 
        /// a los controles del form, instancia el objeto Cobertura y lo envia como 
        /// parametro del metodo savecobertura de coberturaBLL para salvar 
        /// la cobertura en la base de datos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.mskID.Text))
                {
                    MessageBox.Show("Por favor ingree un ID de cobertura", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.mskID.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    MessageBox.Show("Por favor ingrese nombre de cobertura", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtNombre.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.mskPrima.Text))
                {
                    MessageBox.Show("Por favor ingrese la prima de la cobertura", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.mskPrima.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.mskMontoMaximo.Text))
                {
                    MessageBox.Show("Por favor ingrese el monto maximo de la cobertura", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.mskMontoMaximo.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.mskNumEventos.Text))
                {
                    MessageBox.Show("Por favor ingrese el numero de eventos por año", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.mskNumEventos.Focus();
                    return;
                }

                Cobertura oCobertura = new Cobertura();
                oCobertura.IDCobertura = this.mskID.Text;
                oCobertura.Nombre = this.txtNombre.Text;
                oCobertura.Prima = double.Parse(this.mskPrima.Text);
                oCobertura.MontoMaximo = double.Parse(this.mskMontoMaximo.Text);
                oCobertura.NumEventosAnno = int.Parse(this.mskNumEventos.Text);

                IBLLCobertura coberturaBLL = new BLLCobertura();

                foreach (var cobertura in coberturaBLL.GetAllCobertura())
                {
                    if (string.Equals(oCobertura.IDCobertura, cobertura.IDCobertura.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("La cobertura con ID: " + cobertura.IDCobertura.Trim() + " ya existe" +
                            "\nPor favor utilice otro ID", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.mskID.Text = "";
                        this.mskID.Focus();
                        return;
                    }
                }

                coberturaBLL.SaveCobertura(oCobertura);
                _form.Refrescar();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la cobertura: " + ex.Message, "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex.Message.ToString());
   
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
