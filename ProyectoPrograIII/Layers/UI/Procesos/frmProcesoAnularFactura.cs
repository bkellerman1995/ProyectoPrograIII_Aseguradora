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
    public partial class frmProcesoAnularFactura : Form
    {
        IBLLFactura facturaBLL;
        DateTime fecha;

        public frmProcesoAnularFactura()
        {

            InitializeComponent();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            if (this.dateTimePicker1.Value == null)
            {
                MessageBox.Show("Por favor seleccione una fecha valida", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime fecha = this.dateTimePicker1.Value;
            

            fecha.ToString("yyyy/MM/dd");

            this.dgvFacturas.DataSource = facturaBLL.GetFacturasPorFecha(fecha);


            if (fecha.Date == DateTime.Today)
                this.btnAnular.Enabled = true;
            else
                this.btnAnular.Enabled = false;
        }

        private void frmProcesoAnularFactura_Load(object sender, EventArgs e)
        {
            facturaBLL = new BLLFactura();
            this.dateTimePicker1.Value = DateTime.Today;
            fecha = this.dateTimePicker1.Value;
            fecha.ToString("yyyy/MM/dd");

            this.dgvFacturas.DataSource = facturaBLL.GetFacturasPorFecha(fecha);
            this.dgvFacturas.ClearSelection();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvFacturas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "Habilitada";
                if (e.Value.ToString() == "False")
                    e.Value = "Deshabiitada";
            }

            if (e.ColumnIndex == 1 && e.Value != null)
            {
                char[] arrayNumTarjeta = e.Value.ToString().Trim().ToCharArray();

                e.Value = null;

                for (int i = 0; i < arrayNumTarjeta.Length - 4; i++)
                {
                    arrayNumTarjeta[i] = 'x';
                }

                foreach (var ch in arrayNumTarjeta)
                {
                    e.Value += ch.ToString();
                }

            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            var row = this.dgvFacturas.CurrentRow.Cells;

            var resultado = MessageBox.Show("Esta seguro(a)?", "Pregunta",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                FacturaEncabezado oFacturaEncabezado = new FacturaEncabezado();
                oFacturaEncabezado.IdFactura = int.Parse(row["IDFactura"].Value.ToString());
                oFacturaEncabezado.EstadoFactura = false;
                facturaBLL.UpdateEstadoFactura(oFacturaEncabezado);
                Refrescar();
            }

        }

        private void Refrescar()
        {
            this.dgvFacturas.DataSource = facturaBLL.GetFacturasPorFecha(fecha);
        }

        private void dgvFacturas_SelectionChanged(object sender, EventArgs e)
        {
            var row = this.dgvFacturas.CurrentRow.Cells;

            if ((bool)row["Estado"].Value == false)
                this.btnAnular.Enabled = false;
            else
                this.btnAnular.Enabled = true;
        }
    }
}
