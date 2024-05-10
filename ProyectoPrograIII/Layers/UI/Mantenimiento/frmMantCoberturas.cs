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
    public partial class frmMantCoberturas : Form
    {
        IBLLCobertura coberturaBLL;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        frmPrincipal _form;
        public frmMantCoberturas(frmPrincipal form)
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
            coberturaBLL = new BLLCobertura();

            this.dgvCoberturas.DataSource = coberturaBLL.GetAllCobertura();
            this.dgvCoberturas.ClearSelection();
        }

        /// <summary>
        /// Metodo que se encarga de tomar los valores de las celdas de la fila seleccionada, los asigna a una instancia 
        /// de tipo cobertura y lo envia como parametro a un nuevo form utilizado para actualizar el objeto cobertura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarCobertura_Click(object sender, EventArgs e)
        {
            if (this.dgvCoberturas.Rows.Count == 0)
            {
                MessageBox.Show("No existen coberturas para actualizar, por favor agregue una", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.dgvCoberturas.CurrentCell.Selected == false)
            {
                MessageBox.Show("Por favor elija la coberturas a actualizar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var row = this.dgvCoberturas.CurrentRow.Cells;
            string ID = row["ID"].Value + "";
            string Nombre = row["Nombre"].Value + "";
            double Prima = double.Parse(row["Prima"].Value + "");
            double MontoMaximo = double.Parse(row["MontoMaximo"].Value.ToString());
            int NumEventosAnno = int.Parse(row["NumEventosAnno"].Value.ToString());
            

            Cobertura oCobertura = new Cobertura();

            oCobertura.IDCobertura = ID;
            oCobertura.Nombre = Nombre;
            oCobertura.Prima = Prima;
            oCobertura.MontoMaximo = MontoMaximo;
            oCobertura.NumEventosAnno = NumEventosAnno;

            frmMantCoberturasUPDATE frm = new frmMantCoberturasUPDATE(oCobertura, this);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.ShowDialog();
        }

        /// <summary>
        /// Metodo que se encarga de darle formato a las celdas del datagridview para añadir el simbolo de dolar 
        /// a las columnas de prima y maximo a coberturar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCoberturas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
                e.Value = "$ " + e.Value;
            if (e.ColumnIndex == 3 && e.Value != null)
                e.Value = "$ " + e.Value;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        /// <summary>
        /// Metodo que se encarga de tomar los valores de las celdas de la fila
        /// seleccionada del datagridview para abrir un nuevo form que consulta 
        /// los valores de la cobertura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCoberturas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.dgvCoberturas.CurrentRow.Cells;

            string ID = row["ID"].Value + "";
            string Nombre = row["Nombre"].Value + "";
            string Prima = row["Prima"].Value + "";
            string MontoMaximo = row["MontoMaximo"].Value + "";
            string NumeroEventosAnno= row["NumEventosAnno"].Value + "";
            
            frmConsultaCobertura frm = new frmConsultaCobertura (ID, Nombre, Prima, MontoMaximo, NumeroEventosAnno);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.ShowDialog();
        }

        private void btnCrearCobertura_Click(object sender, EventArgs e)
        {
            frmMantCoberturasCREAR mantCoberturasCrear = new frmMantCoberturasCREAR(this);
            mantCoberturasCrear.StartPosition = FormStartPosition.Manual;
            mantCoberturasCrear.Location = new Point(0, 0);
            mantCoberturasCrear.ShowDialog();
        }

        /// <summary>
        /// Metodo que se encarga de eliminar la cobertura con el valor obtenido de la celda bajo columna ID cuando
        /// se selecciona la fila de la cobertura a eliminar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarCobertura_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvCoberturas.Rows.Count == 0)
                {
                    MessageBox.Show("No existen coberturas para eliminar, por favor agregue una", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.dgvCoberturas.CurrentCell.Selected == false)
                {
                    MessageBox.Show("Por favor elija la coberturas a eliminar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var row = this.dgvCoberturas.CurrentRow.Cells;
                var resultado = MessageBox.Show("Esta seguro(a)?", "Pregunta",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    string ID = row["ID"].Value + "";
                    coberturaBLL = new BLLCobertura();
                    coberturaBLL.DeleteCobertura(ID);
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
    }
}
