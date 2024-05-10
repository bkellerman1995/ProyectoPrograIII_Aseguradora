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
using ProyectoPrograIII.Interfaces;
using ProyectoPrograIII.Layers.BLL;
using System.IO;

namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{

    public partial class frmMantClientesUPDATE : Form
    {
        frmMantClientes _form;
        Cliente oCliente;
        OpenFileDialog ofdDialogo = new OpenFileDialog();
        Image Foto;
        Image Cedula;
        private bool btnFotoWasClicked = false;
        private bool bntCedulaWasClicked = false;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMantClientesUPDATE(Cliente oCliente, frmMantClientes form, Image Foto, Image Cedula)
        {
            _form = form;
            this.oCliente = oCliente;
            this.Foto = Foto;
            this.Cedula = Cedula;
            log4net.Config.XmlConfigurator.Configure();


            InitializeComponent();
        }

        private void frmMantClientesUPDATE_Load(object sender, EventArgs e)
        {

            this.cmbSex.Items.Add("Masculino");
            this.cmbSex.Items.Add("Femenino");

            this.picBoxFoto.Image = Foto;
            this.picBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picBoxCedula.Image = Cedula;
            this.picBoxCedula.SizeMode = PictureBoxSizeMode.StretchImage;

            IBLLPais paisBLL = new BLL.BLLPais();

            this.cmbPais.DataSource = paisBLL.GetAllPaises();

            this.lblPais.Text = "País: " + oCliente.Pais;

            this.mskCedula.Text = oCliente.ID + "";
            this.txtNombre.Text = oCliente.Nombre;
            this.txtApellido1.Text = oCliente.Apellido1;
            this.txtApellido2.Text = oCliente.Apellido2;

            switch (oCliente.Sexo)
            {
                case 1:
                    this.cmbSex.SelectedItem = "Masculino";
                    break;

                case 2:
                    this.cmbSex.SelectedItem = "Femenino";
                    break;
                default:
                    break;
            }

            this.dateTimePicker1.Value = oCliente.FechaNacimiento;

            this.mskNumTelefono.Text = oCliente.NumTelefono;
            this.txtDireccion.Text = oCliente.Direccion;

            this.mskCorreo.Text = oCliente.CorreoElectronico;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// Metodo que se encarga de tomar los valores asignados a los controles del form 
        /// para actualizar el objeto de tipo Cliente en la base de datos, llamando al metodo 
        /// UpdateCliente de clienteBLL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    MessageBox.Show("Por favor ingrese un nombre para el cliente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtNombre.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.txtApellido1.Text))
                {
                    MessageBox.Show("Por favor ingrese el primer apellido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtApellido1.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.txtApellido2.Text))
                {
                    MessageBox.Show("Por favor ingrese el segundo apellido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtApellido2.Focus();
                    return;
                }

                if (this.cmbSex.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione el sexo del cliente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.picBoxFoto.Image == null)
                {
                    MessageBox.Show("Por favor introduzca la fotografia", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(this.mskNumTelefono.Text))
                {
                    MessageBox.Show("Por favor ingrese el numero de telefono del cliente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.mskNumTelefono.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.txtDireccion.Text))
                {
                    MessageBox.Show("Por favor ingrese la direccion del cliente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtDireccion.Focus();
                    return;
                }

                if (this.cmbPais.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione el pais del cliente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.picBoxCedula.Image == null)
                {
                    MessageBox.Show("Por favor introduzca la cedula del cliente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Cliente oCliente = new Cliente();
                oCliente.ID = int.Parse(this.mskCedula.Text);
                oCliente.Nombre = this.txtNombre.Text;
                oCliente.Apellido1 = this.txtApellido1.Text;
                oCliente.Apellido2 = this.txtApellido2.Text;

                switch (this.cmbSex.SelectedIndex)
                {
                    case 0:
                        oCliente.Sexo = 1;
                        break;

                    case 1:
                        oCliente.Sexo = 2;
                        break;
                }

                oCliente.FechaNacimiento = this.dateTimePicker1.Value;

                oCliente.NumTelefono = this.mskNumTelefono.Text;

                oCliente.Direccion = this.txtDireccion.Text;

                oCliente.Pais = (Pais)this.cmbPais.SelectedItem;

                oCliente.CorreoElectronico = this.mskCorreo.Text;

                byte[] fotoModificada = null;
                byte[] fotoNOModificada = null;

                byte[] cedulaModificada = null;
                byte[] cedulaNOModificada = null;

                if (btnFotoWasClicked == true)
                {
                    fotoModificada = ImageToStream(ofdDialogo.FileName);
                    oCliente.Foto = fotoModificada;
                }

                else
                {
                    fotoNOModificada = ImageToStreamII(Foto);
                    oCliente.Foto = fotoNOModificada;
                }

                if (bntCedulaWasClicked == true)
                {
                    cedulaModificada = ImageToStream(ofdDialogo.FileName);
                    oCliente.Cedula = cedulaModificada;
                }

                else
                {
                    cedulaNOModificada = ImageToStreamII(Foto);
                    oCliente.Cedula = cedulaNOModificada;
                }

                IBLLCliente clienteBLL = new BLLCliente();

                clienteBLL.UpdateCliente(oCliente);
                _form.Refrescar();
                this.Dispose();


            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                MessageBox.Show("Error al actualizar el cliente: " + ex.Message, "Error" ,
    MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }
        }


        /// <summary>
        /// Método que se encarga de convertir un objeto de tipo Image (imagen)
        /// a un array de bytes para poder actualizar el atributo varbinarymax 
        /// en la base de datos 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>array de bytes que representa la foto del cliente</returns>
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
                oCliente.Foto = fotoNoModificada;
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
        /// envio en el form de mantenimiento de clientes para desplegarlo en 
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
        /// para poder cargar la foto del cliente
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

        /// <summary>
        /// Método que se encarga de abrir un archivo de tipo .jpg
        /// para poder cargar la cedula del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCedula_Click(object sender, EventArgs e)
        {
            bntCedulaWasClicked = true;

            ofdDialogo.Title = "Buscar Imágenes";
            ofdDialogo.SupportMultiDottedExtensions = true;
            ofdDialogo.DefaultExt = "*.jpg";
            ofdDialogo.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";

            if (ofdDialogo.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    this.picBoxCedula.ImageLocation = ofdDialogo.FileName;
                    this.picBoxCedula.SizeMode = PictureBoxSizeMode.StretchImage;
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
