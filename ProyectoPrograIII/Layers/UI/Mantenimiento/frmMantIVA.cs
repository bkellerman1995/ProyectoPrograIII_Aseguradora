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
    public partial class frmMantIVA : Form
    {
        frmPrincipal form;
        IBLLImpuesto impuestoBLL;
        Impuesto oImpuesto;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMantIVA(frmPrincipal form)
        {
            this.form = form;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }

        private void btnCrearIVA_Click(object sender, EventArgs e)
        {
            frmMantIVACREAR mantIVACREAR = new frmMantIVACREAR(this);
            mantIVACREAR.StartPosition = FormStartPosition.Manual;
            mantIVACREAR.Location = new Point(0, 0);
            mantIVACREAR.ShowDialog();
        }

        private void frmMantIVA_Load(object sender, EventArgs e)
        {
            Refrescar();

        }

        /// <summary>
        /// Metodo que se encarga de refrescar el datagridview de impuestos
        /// con la lista de impuestos que se obtienen del metodo 
        /// getallimpuesto de impuestoBLL
        /// </summary>
        public void Refrescar()
        {

            impuestoBLL = new BLLImpuesto();
            this.dgvImpuesto.DataSource = impuestoBLL.GEtAllImpuesto();
            this.dgvImpuesto.ClearSelection();

            if (impuestoBLL.GEtAllImpuesto().Count ==1)
            {
                this.btnCrearIVA.Enabled = false;
            }

            if (impuestoBLL.GEtAllImpuesto().Count == 0)
            {
                this.btnCrearIVA.Enabled = true;
            }
        }

        /// <summary>
        /// Metodo que se encarga de instanciar un nuevo form de consulta de IVA con el objeto 
        /// que se extrae cuando se le da doble click a uno de las filas del datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvImpuesto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.dgvImpuesto.CurrentRow.Cells;
            string porcentaje = row["Porcentaje"].Value + "";

            frmMantIVAConsultar frm = new frmMantIVAConsultar(porcentaje);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.ShowDialog();


        }

        /// <summary>
        /// Metodo que se encarga de tomar los valores de las columnas del datagridview usados
        /// para instanciar un objeto de tipo impuesto que se envia como parametro 
        /// al metodo updateImpuesto de impuestoBLL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarIVA_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvImpuesto.Rows.Count == 0)
                {
                    MessageBox.Show("No existen impuestos para actualizar, por favor agregue uno", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.dgvImpuesto.CurrentCell.Selected == false)
                {
                    MessageBox.Show("Por favor elija el impuesto a actualizar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var row = this.dgvImpuesto.CurrentRow.Cells;

                int porcentaje = int.Parse(row["Porcentaje"].Value + "");

                Impuesto oImpuesto = new Impuesto();

                oImpuesto.Porcentaje = porcentaje;

                frmMantIVAUpdate frm = new frmMantIVAUpdate(oImpuesto, this);
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 0);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                MessageBox.Show("Error al actualizar el IVA: " + ex.Message, "Error");
            }
        }

        /// <summary>
        /// Metodo que se encarga de tomar los valores de la fila seleccionada del datagridview, y se envia
        /// el valor del porcentaje de la celda y se llama al meotod DeleteImpuesto de impuestoBLL para eliminar 
        /// el impuesto 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnEliminarIVA_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvImpuesto.Rows.Count == 0)
                {
                    MessageBox.Show("No existen impuestos para eliminar, por favor agregue uno", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.dgvImpuesto.CurrentCell.Selected == false)
                {
                    MessageBox.Show("Por favor elija el impuesto a eliminar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var row = this.dgvImpuesto.CurrentRow.Cells;

                var resultado = MessageBox.Show("Esta seguro(a)?", "Pregunta",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    int porcentaje = int.Parse(row["Porcentaje"].Value.ToString());
                    impuestoBLL = new BLLImpuesto();
                    impuestoBLL.DeleteImpuesto(porcentaje);
                    Refrescar();
                }
            }


            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                MessageBox.Show("Ooops. Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo que agrega el signo "%" al valor del impuesto que se obtiene de la base de datos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dgvImpuesto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.Value != null)
            {
                e.Value = e.Value + " %";
            }
        }

        private void dgvImpuesto_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvImpuesto.ClearSelection();
        }
    }
}
