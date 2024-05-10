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
    public partial class frmMantUsuarios : Form
    {
        IBLLUsuario usuarioBLL;

        frmPrincipal _form;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMantUsuarios(frmPrincipal form)
        {
            _form = form;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }

        private void frmMantUsuarios_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        /// <summary>
        /// Este codigo refresca el datagrid view junto con las fotos guardadas en la base de datos
        /// </summary>
        public void Refrescar()
        {
            usuarioBLL = new BLLUsuario();

            //este codigo recorre la lista de usuarios que devuelve
            //BLL usuario (lista) y a la vez carga las imagenes 
            //desde el array de bytes utilizando el metodo byteArraytoImage

            foreach (var oUsuario in usuarioBLL.GetAllLogin())
            {
                Image foto = byteArrayToImage(oUsuario.Foto);
            }
            this.dgvUsuarios.DataSource = usuarioBLL.GetAllLogin();
            this.dgvUsuarios.ClearSelection();

        }

        /// <summary>
        /// Metodo para convertir el array de bytes (Foto) del usuario a una Imagen
        /// </summary>
        /// <param name="fotoUsuario"></param>
        /// <returns>Imagen a partir del array de bytes </returns>
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
                MessageBox.Show("Ooops. Error: " + ex.Message, "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        /// <summary>
        ///Codigo para ocultar los datos de la columna de la contraseña del datagridview
        ///Tambien cambia el texto bajo la columna Rol de numero a string.
        ///Tambien cambia el texto bajo la columna Habilitado de bool a string.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
                e.Value = new String('*', e.Value.ToString().Length);

            if (e.ColumnIndex == 4 && e.Value != null)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "Habilitado";
                if (e.Value.ToString() == "False")
                    e.Value = "Deshabiitado";
            }

            if (e.ColumnIndex == 3 && e.Value != null)
            {
                switch ((int)e.Value)
                {
                    case 1:
                        e.Value = "Administrador";
                        break;
                    case 2:
                        e.Value = "Procesos";
                        break;
                    case 3:
                        e.Value = "Reportes";
                        break;
                }
            }
        }

        private void btbCrearUsuario_Click(object sender, EventArgs e)
        {
            frmMantUsuariosCREAR mantUsuariosCrear = new frmMantUsuariosCREAR(this);
            mantUsuariosCrear.StartPosition = FormStartPosition.Manual;
            mantUsuariosCrear.Location = new Point(0, 0);
            mantUsuariosCrear.ShowDialog();

        }

        /// <summary>
        /// Método que extrae los valores de la fila que se selecciona (doble) click y los envia a otro form
        /// que despliega los atributos del usuario. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var row = this.dgvUsuarios.CurrentRow.Cells;

            string ID = row["ID"].Value + "";
            string Nombre = row["Nombre"].Value + "";
            string Rol = "";


            if ((int)row["Rol"].Value == 1)
                Rol = "Administrador";
            if ((int)row["Rol"].Value == 2)
                Rol = "Procesos";
            if ((int)row["Rol"].Value == 3)
                Rol = "Reportes";

            string Estado = "";

            if (row["Estado"].Value.ToString().Equals("True"))
                Estado = "Habilitado";
            if (row["Estado"].Value.ToString().Equals("False"))
                Estado = "Deshabilitado";

            Image foto = byteArrayToImage((byte[])row["Foto"].Value);

            frmConsultaUsuario frm = new frmConsultaUsuario(ID, Nombre, Rol, Estado, foto);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.ShowDialog();
        }

        /// <summary>
        /// Metodo que toma los valores de la fila seleccionada, instancia el objeto de tipo usuario y
        /// utiliza el metodo UpdateUsuario del BLL para actualizar el usuario. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {

            if (this.dgvUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("No existen usuarios para eliminar, por favor agregue uno", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.dgvUsuarios.CurrentCell.Selected == false)
            {
                MessageBox.Show("Por favor elija un usuario para actualizar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var row = this.dgvUsuarios.CurrentRow.Cells;
            string ID = row["ID"].Value + "";
            string Nombre = row["Nombre"].Value + "";
            string Contrasenna = row["Contraseña"].Value + "";
            int IDRol = int.Parse(row["Rol"].Value.ToString());
            bool Estado = bool.Parse(row["Estado"].Value.ToString());
            Image foto = byteArrayToImage((byte[])row["Foto"].Value);

            Usuarios oUsuario = new Usuarios();

            oUsuario.ID = ID;
            oUsuario.Nombre = Nombre;
            oUsuario.Contrasenna = Contrasenna;
            oUsuario.IdRol = IDRol;
            oUsuario.Estado = Estado;
            oUsuario.Foto = null;

            frmMantUsuariosUPDATE frm = new frmMantUsuariosUPDATE(oUsuario, this,foto);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.ShowDialog();

        }

        /// <summary>
        /// Metodo que se encarga de extrar el valor de la columna
        /// ID para enviarlo como parametro al metodo DeleteUsuario de usuarioBLL y borrarlo
        /// de la base de datos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUsuarios.Rows.Count == 0)
                {
                    MessageBox.Show("No existen usuarios para eliminar, por favor agregue uno", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.dgvUsuarios.CurrentCell.Selected == false)
                {
                    MessageBox.Show("Por favor elija un usuario para eliminar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var row = this.dgvUsuarios.CurrentRow.Cells;
                var resultado = MessageBox.Show("Esta seguro(a)?", "Pregunta",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    string ID = row["ID"].Value + "";
                    usuarioBLL = new BLLUsuario();
                    usuarioBLL.DeleteUsuario(ID);

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
