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
    public partial class frmMantClientes : Form
    {
        IBLLCliente clienteBLL;
        IBLLPoliza polizaBLL;
        frmPrincipal _form;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMantClientes(frmPrincipal form)
        {
            _form = form;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }

        private void frmMantClienteLoad (object sender, EventArgs e)
        {

            Refrescar();
        }

        //Este codigo refresca el datagrid view junto con las fotos guardadas en la base de datos 
        //este codigo recorre la lista de clientes que devuelve
        //el objecto BLL usuario (GetAllClientes) y a la vez carga las imagenes 
        //desde el array de bytes utilizando el metodo byteArraytoImage

        /// <summary>
        ///Este codigo refresca el datagrid view junto con las fotos guardadas en la base de datos 
        ///este codigo recorre la lista de clientes que devuelve
        ///el objecto BLL usuario (GetAllClientes) y a la vez carga las imagenes 
        ///desde el array de bytes utilizando el metodo byteArraytoImage
        /// </summary>
        public void Refrescar()
        {
            clienteBLL = new BLLCliente();
            polizaBLL = new BLLPoliza();



            foreach (var oCliente in clienteBLL.GetAllCliente())
            {
                Image foto = byteArrayToImage(oCliente.Foto);
            }
            this.dgvClientes.DataSource = clienteBLL.GetAllCliente();

            foreach (var oCliente in clienteBLL.GetAllCliente())
            {
                Image cedula = byteArrayToImage(oCliente.Cedula);
            }
            this.dgvClientes.DataSource = clienteBLL.GetAllCliente();

        }

        /// <summary>
        /// Método que se encarga de convertir un objeto de tipo Image (imagen)
        /// a un array de bytes para poder actualizar el atributo varbinarymax 
        /// en la base de datos 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>array de bytes que representa la foto del cliente</returns>
        private Image byteArrayToImage(byte[] fotoUsuario)
        {
            try
            {
                using (var ms = new MemoryStream(fotoUsuario))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                MessageBox.Show("Error al procesar la foto", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCrearCliente_Click_1(object sender, EventArgs e)
        {
            frmMantClienteCREAR mantClientesCrear = new frmMantClienteCREAR(this);
            mantClientesCrear.StartPosition = FormStartPosition.Manual;
            mantClientesCrear.Location = new Point(0, 0);
            mantClientesCrear.ShowDialog();
        }

        /// <summary>
        /// Metodo que se encarga de tomar los valores de las celdas de la fila seleccionada del 
        /// datagridview y los envia al form de consulta de cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.dgvClientes.CurrentRow.Cells;

            string ID = row["ID"].Value + "";
            string Nombre = row["Nombre"].Value + "";
            string Apellido1 = row["Apellido1"].Value + "";
            string Apellido2 = row["Apellido2"].Value + "";
            string Sexo = row["Sexo"].Value + "";
            DateTime FechaNacimiento = (DateTime)row["FechaNacimiento"].Value;
            Image Foto = byteArrayToImage((byte[])row["Foto"].Value);
            string NumTelefono = row["NumTelefono"].Value + "";
            string Direccion = row["Direccion"].Value + "";
            string Pais = row["Pais"].Value + "";
            string Email = row["CorreoElectronico"].Value + "";
            Image Cedula = byteArrayToImage((byte[])row["Cedula"].Value);

            frmConsultaCliente frm = new frmConsultaCliente(ID, Nombre, Apellido1, Apellido2, Sexo,
                FechaNacimiento, Foto, NumTelefono, Direccion, Pais, Email,Cedula);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.ShowDialog();
        }

        /// <summary>
        /// Metodo que se encarga de tomar los valores de las celdas de la fila del datagridview y se utilizan para
        /// instanciar un objeto de tipo Cliente que se utiliza para eliminar al usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarCliente_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvClientes.Rows.Count == 0)
                {
                    MessageBox.Show("No existen clientes para eliminar, por favor agregue uno", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.dgvClientes.CurrentCell.Selected == false)
                {
                    MessageBox.Show("Por favor elija un cliente para eliminar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var row = this.dgvClientes.CurrentRow.Cells;
                var resultado = MessageBox.Show("Esta seguro(a)?", "Pregunta",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Cliente oCliente = new Cliente();
                    int ID = int.Parse(row["ID"].Value + "");
                    string Nombre = row["Nombre"].Value + "";
                    string Apellido1 = row["Apellido1"].Value + "";
                    string Apellido2 = row["Apellido2"].Value + "";
                    int Sexo = int.Parse(row["Sexo"].Value + "");
                    DateTime FechaNacimiento = (DateTime)row["FechaNacimiento"].Value;
                    byte[] Foto = (byte[])row["Foto"].Value;
                    string NumTelefono = row["NumTelefono"].Value + "";
                    string Direccion = row["Direccion"].Value + "";
                    Pais Pais = (Pais)row["Pais"].Value;
                    string Email = row["CorreoElectronico"].Value + "";
                    byte[] Cedula = (byte[])row["Cedula"].Value;

                    oCliente.ID = ID;
                    oCliente.Nombre = Nombre;
                    oCliente.Apellido1 = Apellido1;
                    oCliente.Apellido2 = Apellido2;
                    oCliente.Sexo = Sexo;
                    oCliente.FechaNacimiento = FechaNacimiento;
                    oCliente.Foto = Foto;
                    oCliente.NumTelefono = NumTelefono;
                    oCliente.Direccion = Direccion;
                    oCliente.Pais = Pais;
                    oCliente.CorreoElectronico = Email;
                    oCliente.Cedula = Cedula;

                    clienteBLL = new BLLCliente();

                    foreach (var poliza in polizaBLL.GetAllPoliza())
                    {
                        if (oCliente.ID == poliza.Cliente.ID)
                        {
                            MessageBox.Show("El cliente esta ligado a una poliza, por favor elimine la poliza primero");
                            return;
                        }
                    }

                    clienteBLL.DeleteCliente(oCliente);

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
        /// Metodo que se encarga de tomar los valores de las celdas de la fila seleccionada 
        /// y los asigna a un objeto de tipo cliente que se envia como parametro al form que se encarga 
        /// de actualizarlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarCliente_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvClientes.Rows.Count == 0)
                {
                    MessageBox.Show("No existen clientes para actualizar, por favor agregue uno", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.dgvClientes.CurrentCell.Selected == false)
                {
                    MessageBox.Show("Por favor elija un cliente para actualizar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var row = this.dgvClientes.CurrentRow.Cells;

                int ID = int.Parse(row["ID"].Value + "");
                string Nombre = row["Nombre"].Value + "";
                string Apellido1 = row["Apellido1"].Value + "";
                string Apellido2 = row["Apellido2"].Value + "";
                int Sexo = int.Parse(row["Sexo"].Value + "");
                DateTime FechaNacimiento = DateTime.Parse(row["FechaNacimiento"].Value + "");
                string NumTelefono = row["NumTelefono"].Value + "";
                string Direccion = row["Direccion"].Value + "";
                Pais Pais = (Pais)row["Pais"].Value;
                string Email = row["CorreoElectronico"].Value + "";
                Image Foto = byteArrayToImage((byte[])row["Foto"].Value);
                Image Cedula = byteArrayToImage((byte[])row["Cedula"].Value);

                Cliente oCliente = new Cliente();

                oCliente.ID = ID;
                oCliente.Nombre = Nombre;
                oCliente.Apellido1 = Apellido1;
                oCliente.Apellido2 = Apellido2;
                oCliente.Sexo = Sexo;
                oCliente.FechaNacimiento = FechaNacimiento;
                oCliente.NumTelefono = NumTelefono;
                oCliente.Direccion = Direccion;
                oCliente.Pais = Pais;
                oCliente.CorreoElectronico = Email;
                oCliente.Foto = null;
                oCliente.Cedula = null;

                frmMantClientesUPDATE frm = new frmMantClientesUPDATE(oCliente, this, Foto, Cedula);
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 0);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                MessageBox.Show("Error al seleccionar el cliente: " + ex.Message, "Error" ,
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvClientes.ClearSelection();
        }

        /// <summary>
        /// Metodo que se encarga de formatear la columna que contiene el valor de sexo del cliente y lo reemplaza a texto amigable
        /// para el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 4 && e.Value != null)
            {
                if (e.Value.ToString() == "1")
                    e.Value = "Masculino";
                if (e.Value.ToString() == "2")
                    e.Value = "Femenino";
            }
        }
    }
}
