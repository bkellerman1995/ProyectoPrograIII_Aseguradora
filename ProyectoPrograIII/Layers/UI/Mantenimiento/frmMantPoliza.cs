using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPrograIII.Layers.BLL;
using ProyectoPrograIII.Interfaces;
using ProyectoPrograIII.Layers.Entities;
using System.IO;

namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    public partial class frmMantPoliza : Form
    {
        IBLLPoliza polizaBLL;

        frmPrincipal _form;
        Poliza oPoliza;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMantPoliza(frmPrincipal form)
        {
            _form = form;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }

        private void frmMantCoberturas_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        public void Refrescar()
        {
            polizaBLL = new BLLPoliza();

            this.dgvPoliza.DataSource = polizaBLL.GetAllPoliza();
            this.dgvPoliza.ClearSelection();
        }

        private void btnCrearPoliza_Click(object sender, EventArgs e)
        {
            frmMantPolizaCREAR mantPoiizaCrear  = new frmMantPolizaCREAR(this);
            mantPoiizaCrear.StartPosition = FormStartPosition.Manual;
            mantPoiizaCrear.Location = new Point(0, 0);
            mantPoiizaCrear.ShowDialog();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Metodo que se encarga de tomar el valor del ID de la fila seleccionada
        /// y se envia como parametro al metodo DeletePoliza de poliza BLL 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarPoliza_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvPoliza.Rows.Count == 0)
                {
                    MessageBox.Show("No existen polizas para eliminar, por favor agregue una", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (this.dgvPoliza.CurrentCell.Selected == false)
                {
                    MessageBox.Show("Por favor elija una poliza para eliminar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var row = this.dgvPoliza.CurrentRow.Cells;

                var resultado = MessageBox.Show("Esta seguro(a)?", "Pregunta",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    string ID = row["ID"].Value.ToString();
                    polizaBLL = new BLLPoliza();
                    polizaBLL.DeletePoliza(ID);
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
        /// Metodo que se encarga de tomar los valores respectivos de las columnas basados en la fila seleccionada,
        /// instancia el objeto y lo envia al form de consulta de poliza para mostrar su contenido en el nuevo form
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPoliza_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.dgvPoliza.CurrentRow.Cells;

            string ID = row["ID"].Value + "";
            string Descripcion = row["Descripcion"].Value + "";
            Plan oPlan = (Plan)row["IDTipoPlan"].Value;
            Cliente oCliente = (Cliente)row["Cliente"].Value;
            oPoliza = new Poliza();
            oPoliza.ID = ID;
            oPoliza.Descripcion = Descripcion;
            oPoliza.Cliente = oCliente;
            oPoliza.Plan = oPlan;

            frmMantPolizaConsultar frm = new frmMantPolizaConsultar(oPoliza);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.ShowDialog();
        }

        /// <summary>
        /// Metodo que se encarga de leer los valores de cada columna del datagrid view basado 
        /// en la fila seleccionada, instancia el objeto con los valores y lo envia como parametro
        /// en el metodo savePoliza de polizaBLL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarPoliza_Click(object sender, EventArgs e)
        {
            if (this.dgvPoliza.Rows.Count == 0)
            {
                MessageBox.Show("No existen polizas para eliminar, por favor agregue una", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.dgvPoliza.CurrentCell.Selected == false)
            {
                MessageBox.Show("Por favor elija una poliza para actualizar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var row = this.dgvPoliza.CurrentRow.Cells;
            string ID = row["ID"].Value + "";
            string Descripcion = row["Descripcion"].Value + "";
            Plan plan = (Plan)(row["IDTipoPlan"].Value);
            Cliente cliente = (Cliente)(row["Cliente"].Value);

            Poliza oPoliza = new Poliza();

            oPoliza.ID = ID;
            oPoliza.Descripcion = Descripcion;
            oPoliza.Plan = plan;
            oPoliza.Cliente = cliente;
 
            frmMantPolizaUPDATE frm = new frmMantPolizaUPDATE(oPoliza, this);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.ShowDialog();
        }

        private void dgvPoliza_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvPoliza.ClearSelection();
        }
    }
}
