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

    public partial class frmMantClienteCREAR : Form
    {
        frmMantClientes _form;

        OpenFileDialog ofdDialogo1 = new OpenFileDialog();
        OpenFileDialog ofdDialogo2 = new OpenFileDialog();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMantClienteCREAR (frmMantClientes form)
        {
            _form = form;
            log4net.Config.XmlConfigurator.Configure();
            InitializeComponent();
        }

        private void frmMantUsuariosCREAR_Load(object sender, EventArgs e)
        {
            this.cmbSex.Items.Add("Masculino");
            this.cmbSex.Items.Add("Femenino");

            IBLLPais paisBLL = new BLLPais();

            this.cmbPais.DataSource = paisBLL.GetAllPaises();


        }

        /// <summary>
        /// Metodo que se encarga de instanciar un objeto de tipo Cliente, asigna los valores asignados 
        /// a los controles del form al objeto y añade ese objeto a la base de datos a traves del metodo
        /// saveCliente de clienteBLL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrear_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(this.mskCedula.Text))
                {
                    MessageBox.Show("Por favor ingrese un ID para el cliente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.mskCedula.Focus();
                    return;
                }

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

                if (this.cmbSex.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione el Pais del cliente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(this.mskCorreo.Text))
                {
                    MessageBox.Show("Por favor ingrese el correo del cliente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.mskCorreo.Focus();
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

                byte[] foto = ImageToStream(ofdDialogo1.FileName);
                oCliente.Foto = foto;

                oCliente.NumTelefono = this.mskNumTelefono.Text;
                
                oCliente.Direccion = this.txtDireccion.Text;

                oCliente.Pais = (Pais)this.cmbPais.SelectedItem;

                oCliente.CorreoElectronico = this.mskCorreo.Text;    

                byte[] cedula = ImageToStream(ofdDialogo2.FileName);
                oCliente.Cedula = cedula;

                IBLLCliente clienteBLL = new BLLCliente();

                foreach (var cliente in clienteBLL.GetAllCliente())
                {
                    if (oCliente.ID == cliente.ID)
                    {
                        MessageBox.Show("El cliente con identificacion: " + cliente.ID + " ya existe" +
                            "\nPor favor introduza otra identificacion", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.mskCedula.Text = "";
                        this.mskCedula.Focus();
                        return;
                    }
                }

                clienteBLL.SaveCliente(oCliente);
                _form.Refrescar();
                this.Dispose();


            }
            catch (Exception ex) 
            {
                log.Error(ex.Message.ToString());
                MessageBox.Show("Error al crear el cliente: "+ ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /// <summary>
        /// Metodo que se encarga de cargar una imagen de tipo .jpg que se va utilizar como 
        /// la foto del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFoto_Click(object sender, EventArgs e)
        {

            ofdDialogo1.Title = "Buscar Imágenes";
            ofdDialogo1.SupportMultiDottedExtensions = true;
            ofdDialogo1.DefaultExt = "*.jpg";
            ofdDialogo1.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";



            if (ofdDialogo1.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    this.picBoxFoto.ImageLocation = ofdDialogo1.FileName;
                    this.picBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                catch (Exception ex)
                {
                    log.Error(ex.Message.ToString());

                    MessageBox.Show("Error: No se pudo abrir el archivo de imagen. Error original: " + ex.Message,"Error",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            ofdDialogo2.Title = "Buscar Imágenes";
            ofdDialogo2.SupportMultiDottedExtensions = true;
            ofdDialogo2.DefaultExt = "*.jpg";
            ofdDialogo2.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";



            if (ofdDialogo2.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    this.picBoxCedula.ImageLocation = ofdDialogo2.FileName;
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
