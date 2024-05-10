
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
    public partial class frmMantPolizaFamiliaresADD : Form
    {
        Cliente oCliente;

        IBLLFamiliares familarBLL;
        Familiares oFamiliar;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMantPolizaFamiliaresADD(Cliente oCliente)
        {
            this.oCliente = oCliente;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }

        private void frmMantPolizaFamiliaresADD_Load(object sender, EventArgs e)
        {
            familarBLL = new BLLFamiliares();
            this.cmbParentesco.Items.Add("Madre");
            this.cmbParentesco.Items.Add("Padre");
            this.cmbParentesco.Items.Add("Hermano");
            this.cmbParentesco.Items.Add("Hermana");
            this.cmbParentesco.Items.Add("Abuelo");
            this.cmbParentesco.Items.Add("Abuela");

            foreach (var familiar in familarBLL.GetAllFamiliaresCliente(oCliente))
            {
                this.lstFamiliares.Items.Add(familiar);
            }
        }

        /// <summary>
        /// Metodo que se encarga de leer los valores asignados a los controles del form para
        /// agregar familiares, llama al metodo SaveFamiliarCliente y savefamiliar de FamiliarBLL para
        /// guardar el familiar del cliente en la base de datos (tabla intermedia)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(this.mskCedula.Text))
            {
                MessageBox.Show("Por favor ingrese una cedula para el pariente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.mskCedula.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("Por favor ingrese un nombre para el cliente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNombre.Focus();
                return;
            }

            if (this.cmbParentesco.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor ingrese el tipo de parentesco", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbParentesco.Focus();
                return;
            }

            foreach (var familiar in familarBLL.GetAllFamiliares())
            {
                if (string.Equals(this.mskCedula.Text, familiar.Cedula.Trim()) == true)
                {
                    MessageBox.Show("El ID: " + familiar.Cedula.Trim() + " ya existe" +
                        "\nPor favor utilice otro ID", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.mskCedula.Focus();
                    this.mskCedula.Text = "";
                    return;
                }


            }

            oFamiliar = new Familiares();
            oFamiliar.Cedula = this.mskCedula.Text;
            oFamiliar.Nombre = this.txtNombre.Text;
            oFamiliar.Parentesco = (string)this.cmbParentesco.SelectedItem;
            familarBLL.SaveFamiliar(oFamiliar);
            familarBLL.SaveFamiliarCliente(oCliente, oFamiliar);

            this.lstFamiliares.Items.Add(oFamiliar);





        }

        /// <summary>
        /// Metodo que se encarga de quitar los familiares del cliente mediante
        /// el metodo DeleteFamiliarCliente de familiarBLL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (this.lstFamiliares.Items.Count == 0)
            {
                MessageBox.Show("No existen familiares que quitar, por favor agregue al menos uno");
                return;
            }

            if (this.lstFamiliares.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un familiar para quitar");
                return;
            }

            oFamiliar = (Familiares)this.lstFamiliares.SelectedItem;
            familarBLL.DeleteFamiliarCliente(oFamiliar);

            this.lstFamiliares.Items.Remove(oFamiliar);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
