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
using ProyectoPrograIII.Interfaces;
using ProyectoPrograIII.Layers.BLL;

namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    public partial class frmMantCoberturasUPDATE : Form
    {
        frmMantCoberturas _form;
        Cobertura oCobertura;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMantCoberturasUPDATE(Cobertura oCobertura, frmMantCoberturas form)
        {
            _form = form;
            this.oCobertura = oCobertura;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }


        /// <summary>
        /// Metodo que se encarga de asignar los valores asignados a los 
        /// controles del form al objeto Cobetura que se envia como parametro al 
        /// metodo updatecobertura de coberturaBLL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
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

            oCobertura.Nombre = this.txtNombre.Text;
            oCobertura.Prima = double.Parse(this.mskPrima.Text);
            oCobertura.MontoMaximo = double.Parse(this.mskMontoMaximo.Text);
            oCobertura.NumEventosAnno = int.Parse(this.mskNumEventos.Text);

            IBLLCobertura coberturaBLL = new BLLCobertura();

            coberturaBLL.UpdateCobertura(oCobertura);
            _form.Refrescar();
            this.Dispose();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmMantCoberturasUPDATE_Load(object sender, EventArgs e)
        {
            this.mskID.Text = oCobertura.IDCobertura;
            this.txtNombre.Text = oCobertura.Nombre;
            this.mskPrima.Text = oCobertura.Prima + "";
            this.mskMontoMaximo.Text = oCobertura.MontoMaximo + "";
            this.mskNumEventos.Text = oCobertura.NumEventosAnno + "";
        }
    }
}
