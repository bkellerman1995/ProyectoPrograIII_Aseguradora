using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPrograIII.Layers.Entities;
using ProyectoPrograIII.Interfaces;
using ProyectoPrograIII.Layers.BLL;

namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    public partial class frmMantUsuariosUPDATE : Form
    {
        frmMantUsuarios _form;
        Usuarios oUsuario;
        OpenFileDialog ofdDialogo = new OpenFileDialog();
        Image foto;
        private bool btnFotoWasClicked = false;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        /// <summary>
        /// Método que recibe como parametros el usuario logueado,
        /// un objeto de tipo frmMantUsuarios y la foto (Image) 
        /// para inicializar el form
        /// </summary>
        /// <param name="oUsuario"></param>
        /// <param name="form"></param>
        /// <param name="foto"></param>
        public frmMantUsuariosUPDATE(Usuarios oUsuario, frmMantUsuarios form, Image foto)
        {
            log4net.Config.XmlConfigurator.Configure();
            _form = form;
            this.oUsuario = oUsuario;
            this.foto = foto;
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que carga el form con los valores del objeto usuario 
        /// para actualizar los textbox y los radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMantUsuariosUPDATE_Load(object sender, EventArgs e)
        {
            this.picBoxFoto.Image = foto;
            this.picBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;

            this.cmbRol.Items.Add("Administrador");
            this.cmbRol.Items.Add("Procesos");
            this.cmbRol.Items.Add("Reportes");

            this.txtID.Text = oUsuario.ID;
            this.txtNombre.Text = oUsuario.Nombre;
            this.txtPwd.Text = oUsuario.Contrasenna;

            switch (oUsuario.IdRol)
            {
                case 1:
                    this.cmbRol.SelectedItem = "Administrador";
                    break;
                case 2:
                    this.cmbRol.SelectedItem = "Procesos";
                    break;
                case 3:
                    this.cmbRol.SelectedItem = "Reportes";
                    break;
                default:
                    break;
            }

            if (oUsuario.Estado == true)
                this.rdHabilitado.Checked = true;
            if (oUsuario.Estado == false)
                this.rdDeshabilitado.Checked = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Método que actualiza el objeto usuario con los valores insertados en los
        /// diferentes controles y a la vez instancia la clase usuarioBLL para poder
        /// actualizar el usario en la base de datos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    MessageBox.Show("Por favor ingrese nombre de Usuario", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtNombre.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.txtPwd.Text))
                {
                    MessageBox.Show("Por favor ingrese una contraseña", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPwd.Focus();
                    return;
                }

                if (string.Equals(this.txtPwd.Text, this.txtConfirmPwd.Text) == false)
                {
                    MessageBox.Show("La contraseña no coincide");
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

                byte[] fotoModificada = null;
                byte[] fotoNoModificada = null;

                if (btnFotoWasClicked == true)
                {
                    fotoModificada = ImageToStream(ofdDialogo.FileName);
                    oUsuario.Foto = fotoModificada;
                }

                else
                {
                    fotoNoModificada = ImageToStreamII(foto);
                    oUsuario.Foto = fotoNoModificada;
                }

                IBLLUsuario usuarioBLL = new BLLUsuario();

                usuarioBLL.UpdateUsuario(oUsuario);
                _form.Refrescar();
                this.Dispose();

            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            byte[] fotoNoModificada = null;
            MemoryStream stream = new MemoryStream();
        tryagain:
            try
            {
                Bitmap image = new Bitmap(fileName);
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                fotoNoModificada = stream.ToArray();
                oUsuario.Foto = fotoNoModificada;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());

                goto tryagain;
            }
            return stream.ToArray();
        }

        /// <summary>
        /// Método que se encarga de leer el archivo de imagen que se 
        /// envio en el form de mantenimiento de usuarios para desplegarlo en 
        /// el form de actualizar. 
        /// </summary>
        /// <param name="foto"></param>
        /// <returns></returns>
        private byte[] ImageToStreamII(System.Drawing.Image foto)
        {
            MemoryStream stream = new MemoryStream();
        tryagain:
            try
            {
                Bitmap image = new Bitmap(foto);
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());

                goto tryagain;
            }

            return stream.ToArray();
        }

        /// <summary>
        /// Método que se encarga de abrir un archivo de tipo .jpg
        /// para poder cargar la foto del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFoto_Click(object sender, EventArgs e)
        {
            btnFotoWasClicked = true;

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
                    MessageBox.Show("Error: No se pudo abrir el archivo de imagen. Error original: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

