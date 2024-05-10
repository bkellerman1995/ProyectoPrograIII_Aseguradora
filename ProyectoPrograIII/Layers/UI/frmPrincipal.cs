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
using ProyectoPrograIII.Layers.UI;
using ProyectoPrograIII.Layers.UI.Mantenimiento;
using ProyectoPrograIII.Layers.UI.Procesos;
using ProyectoPrograIII.Layers.UI.Reportes;

namespace ProyectoPrograIII
{

    public partial class frmPrincipal : Form
    {

        Usuarios oUsuario;
        frmLogin form;
        public frmPrincipal(Usuarios oUsuario, frmLogin form)
        {

            InitializeComponent();
            this.oUsuario = oUsuario;
            this.form = form;

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string usuarioRol = "";

            if (this.oUsuario.IdRol == 1)
            {
                usuarioRol = "Administrador";
            }

            if (this.oUsuario.IdRol == 2)
            {
                this.usuariosToolStripMenuItem.Enabled = false;
                usuarioRol = "Procesos";

            }

            if (this.oUsuario.IdRol == 3)
            {
                this.mantenimientosToolStripMenuItem.Enabled = false;
                this.procesosToolStripMenuItem.Enabled = false;
                usuarioRol = "Reportes";
            }

            this.toolStripLabel1.Text = "Usuario logueado: " + oUsuario.ID.Trim() +
                " - " + oUsuario.Nombre + " - " + usuarioRol;
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
            form.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantClientes mantClientes = new frmMantClientes(this);
            mantClientes.StartPosition = FormStartPosition.Manual;
            mantClientes.Location = new Point(0, 0);
            mantClientes.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmMantUsuarios mantUsuarios = new frmMantUsuarios(this);
            mantUsuarios.StartPosition = FormStartPosition.Manual;
            mantUsuarios.Location = new Point(0, 0);
            mantUsuarios.ShowDialog();

        }

        private void coberturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantCoberturas mantCoberturas = new frmMantCoberturas(this);
            mantCoberturas.StartPosition = FormStartPosition.Manual;
            mantCoberturas.Location = new Point(0, 0);
            mantCoberturas.ShowDialog();
        }

        private void polizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantPoliza mantPoliza = new frmMantPoliza(this);
            mantPoliza.StartPosition = FormStartPosition.Manual;
            mantPoliza.Location = new Point(0, 0);
            mantPoliza.ShowDialog();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantPlanes mantPlanes = new frmMantPlanes(this);
            mantPlanes.StartPosition = FormStartPosition.Manual;
            mantPlanes.Location = new Point(0, 0);
            mantPlanes.ShowDialog();
        }

        private void iVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantIVA mantIVA = new frmMantIVA(this);
            mantIVA.StartPosition = FormStartPosition.Manual;
            mantIVA.Location = new Point(0, 0);
            mantIVA.ShowDialog();
        }

        private void polizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportesPoliza form = new frmReportesPoliza();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.ShowDialog();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcesosFacturacion form = new frmProcesosFacturacion();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.ShowDialog();
        }

        private void anularFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcesoAnularFactura form = new frmProcesoAnularFactura();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.ShowDialog();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ventasDePolizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteVentas form = new frmReporteVentas();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.ShowDialog();
        }
    }
}
