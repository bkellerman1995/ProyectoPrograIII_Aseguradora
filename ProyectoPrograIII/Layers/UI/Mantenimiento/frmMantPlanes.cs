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

namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    public partial class frmMantPlanes : Form
    {
        IBLLPlan planBLL;
        IBLLCobertura coberturaBLL;
        IBLLPoliza polizaBLL;
        Plan oPlan;
        frmPrincipal _form;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMantPlanes(frmPrincipal form)
        {
            _form = form;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCrearPlan_Click(object sender, EventArgs e)
        {
            frmMantPlanesCREAR mantPlanesCREAR = new frmMantPlanesCREAR(this);
            mantPlanesCREAR.StartPosition = FormStartPosition.Manual;
            mantPlanesCREAR.Location = new Point(0, 0);
            mantPlanesCREAR.ShowDialog();
        }

        private void frmMantPlanes_Load(object sender, EventArgs e)
        {
            coberturaBLL = new BLLCobertura();

            if (coberturaBLL.GetAllCobertura().Count == 0)
            {
                MessageBox.Show("No existen coberturas, por favor agregue en el menu de coberturas", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
                return;
            }

            oPlan = new Plan();
            Refrescar();

        }

        public void Refrescar()
        {
            planBLL = new BLLPlan();
            polizaBLL = new BLLPoliza();

            this.dgvPlanes.DataSource = planBLL.GetAllPlan();
            this.dgvPlanes.ClearSelection();
        }

        /// <summary>
        /// Metodo que se encarga de abrir un form de tipo frmMantPlanesCONSULTAR que recibe como 
        /// parametro un objeto 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPlanes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.dgvPlanes.CurrentRow.Cells;

            string ID = row["ID"].Value + "";
            string Nombre = row["NombrePlan"].Value + "";
            double Costo = double.Parse(row["CostoPlan"].Value + "");


            oPlan.ID = ID;
            oPlan.NombrePlan = Nombre;


            if (row["Familiar"].Value.ToString().Equals("True"))
                oPlan.Familiar = true;

            if (row["Familiar"].Value.ToString().Equals("False"))
                oPlan.Familiar = false;

            foreach (var plan in planBLL.GetAllPlan())
            {
                if (oPlan.ID == plan.ID)
                {
                    oPlan = plan;
                    break;
                }
            }

            oPlan.CostoPlan = Costo;

            frmMantPlanesCONSULTAR frm = new frmMantPlanesCONSULTAR(ID, Nombre, Costo, oPlan);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.ShowDialog();
        }

        /// <summary>
        /// Metodo que se encarga de eliminar el plan usando el objeto que
        /// se forma con los valores obtenidos de las columnas del datagridview. 
        /// Se llama al metodo Deleteplan de planBLL para borrar al objeto de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvPlanes.Rows.Count == 0)
                {
                    MessageBox.Show("No existen planes para eliminar, por favor agregue uno", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (this.dgvPlanes.CurrentCell.Selected == false)
                {
                    MessageBox.Show("Por favor elija un plan para eliminar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var row = this.dgvPlanes.CurrentRow.Cells;

                var resultado = MessageBox.Show("Esta seguro(a)?", "Pregunta",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    Plan oPlan = new Plan();
                    string ID = row["ID"].Value + "";
                    string NomrePlan = row["NombrePlan"].Value + "";
                    bool Familiar = bool.Parse(row["Familiar"].Value + "");

                    oPlan.ID = ID;
                    oPlan.NombrePlan = NomrePlan;
                    oPlan.Familiar = Familiar;

                    planBLL = new BLLPlan();

                    foreach (var poliza in polizaBLL.GetAllPoliza())
                    {
                        if (oPlan.ID == poliza.Plan.ID)
                        {
                            MessageBox.Show("El plan esta ligado a una poliza, por favor elimine la poliza primero", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    planBLL.DeletePlan(ID.Trim());
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
        /// Metodo que se encarga de instanciar un objeto tipo Plan usando los valores 
        /// extraidos de las columnas del datagridview relacionados y lo envia como 
        /// parametro al form que se encarga de actualizar el plan 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvPlanes.Rows.Count == 0)
                {
                    MessageBox.Show("No existen planes para actualizar, por favor agregue uno", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.dgvPlanes.CurrentCell.Selected == false)
                {
                    MessageBox.Show("Por favor elija un plan para actualizar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var row = this.dgvPlanes.CurrentRow.Cells;
                string ID = row["ID"].Value + "";
                string NombrePlan = row["NombrePlan"].Value+ "";
                bool Familiar = bool.Parse(row["Familiar"].Value + "");
                double CostoPlan = double.Parse(row["CostoPlan"].Value + "");

                oPlan = new Plan();

                oPlan.ID = ID;
                oPlan.NombrePlan = NombrePlan;
                oPlan.Familiar = Familiar;
                oPlan.CostoPlan = CostoPlan;

                frmMantPlanesUPDATES frm = new frmMantPlanesUPDATES(oPlan, this);
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 0);
                frm.ShowDialog();
            }


            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());

                MessageBox.Show("Ooops. Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo que se encarga de formatear las celdas debajo de la columna de "Familiar" 
        /// y Costo para hacerlos amigables al usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPlanes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "Si";
                if (e.Value.ToString() == "False")
                    e.Value = "No";

            }
            if (e.ColumnIndex == 3 && e.Value != null)
                e.Value = "$ " + e.Value;

        }

        private void dgvPlanes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvPlanes.ClearSelection();
        }
    }
}
