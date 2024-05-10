using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProyectoPrograIII.Layers.Entities;
using ProyectoPrograIII.Layers.BLL;
using ProyectoPrograIII.Interfaces;

namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{

    public partial class frmMantUsuariosCREAR : Form
    {
        frmMantUsuarios _form;

        OpenFileDialog ofdDialogo = new OpenFileDialog();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMantUsuariosCREAR(frmMantUsuarios form)
        {
            _form = form;
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
        }

        private void frmMantUsuariosCREAR_Load(object sender, EventArgs e)
        {
            this.cmbRol.Items.Add("Administrador");
            this.cmbRol.Items.Add("Procesos");
            this.cmbRol.Items.Add("Reportes");

        }

        /// <summary>
        /// Método que se encarga de crear el objeto Usuario con base 
        /// en los valores insertados en los diferentes controles del form 
        /// y a su vez instancia la clase BLLUsuario para poder almacenar 
        /// este usuario en la base de datos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrear_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(this.txtID.Text))
                {
                    MessageBox.Show("Por favor ingrese un ID de usuario", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtID.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    MessageBox.Show("Por favor ingrese nombre de Usuario", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtID.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.txtPwd.Text))
                {
                    MessageBox.Show("Por favor ingrese una contraseña", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtID.Focus();
                    return;
                }

                if (string.Equals(this.txtPwd.Text, this.txtConfirmPwd.Text) == false)
                {
                    MessageBox.Show("La contraseña no coincide", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPwd.Text = "";
                    this.txtConfirmPwd.Text = "";
                    this.txtPwd.Focus();
                    return;
                }

                if (this.cmbRol.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione el tipo de rol", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.picBoxFoto.Image == null)
                {
                    MessageBox.Show("Por favor introduzca la fotografia", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Usuarios oUsuario = new Usuarios();
                oUsuario.ID = this.txtID.Text;
                oUsuario.Nombre = this.txtNombre.Text;
                oUsuario.Contrasenna = this.txtPwd.Text;

                switch (this.cmbRol.SelectedIndex)
                {
                    case 0:
                        oUsuario.IdRol = 1;
                        break;

                    case 1:
                        oUsuario.IdRol = 2;
                        break;

                    case 2:
                        oUsuario.IdRol = 3;
                        break;
                }

                if (this.rdHabilitado.Checked)
                    oUsuario.Estado = true;

                if (this.rdDeshabilitado.Checked)
                    oUsuario.Estado = false;

                byte[] foto = ImageToStream(ofdDialogo.FileName);
                oUsuario.Foto = foto;

                IBLLUsuario usuarioBLL = new BLLUsuario();

                foreach (var usuario in usuarioBLL.GetAllLogin())
                {
                    if (string.Equals(oUsuario.ID, usuario.ID.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("El usuario con ID: " + usuario.ID.Trim() + " ya existe" +
                            "\nPor favor utilice otro ID", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtID.Text = "";
                        this.txtID.Focus();
                        return;
                    }
                }

                usuarioBLL.SaveUsuario(oUsuario);
                MessageBox.Show("Usuario creado satisfactoriamente", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                _form.Refrescar();
                this.Dispose();


            }
            catch (Exception ex) 
            {
                log.Error(ex.Message.ToString());
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        /// <summary>
        /// Método que se encarga de abrir un archivo de tipo .jpg
        /// para poder cargar la foto del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFoto_Click(object sender, EventArgs e)
        {

            ofdDialogo.Title = "Buscar Imágenes";
            ofdDialogo.SupportMultiDottedExtensions = true;
            ofdDialogo.DefaultExt = "*.jpg";
            ofdDialogo.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";



            if (ofdDialogo.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    this.picBoxFoto.ImageLocation = ofdDialogo.FileName;
                    this.picBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                catch (Exception ex)
                {
                    log.Error(ex.Message.ToString());
                    MessageBox.Show("Error: No se pudo abrir el archivo de imagen. Error original: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Método que se encarga de convertir un objeto de tipo Image (imagen)
        /// a un array de bytes para poder actualizar el atributo varbinarymax 
        /// en la base de datos 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>array de bytes que representa la foto del usuario</returns>
        private byte[] ImageToStream(string fileName)
        {
            MemoryStream stream = new MemoryStream();
        tryagain:
            try
            {
                Bitmap image = new Bitmap(fileName);
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                goto tryagain;
            }

            return stream.ToArray();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
