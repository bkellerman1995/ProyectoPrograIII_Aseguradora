using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    public partial class frmConsultaCliente : Form
    {
        string ID;
        string Nombre;
        string Apellido1;
        string Apellido2;
        string Sexo;
        DateTime FechaNacimiento;
        Image Foto;
        string NumTelefono;
        string Direccion;
        string Pais;
        string Email;
        Image Cedula;
        public frmConsultaCliente(string ID, string Nombre, string Apellido1, string Apellido2, 
            string Sexo, DateTime FechaNacimiento, Image Foto, string NumTelefono, string Direccion, string Pais,
            string Email,Image Cedula)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Apellido1 = Apellido1;
            this.Apellido2 = Apellido2;
            this.Sexo = Sexo;
            this.FechaNacimiento = FechaNacimiento;
            this.Foto = Foto;
            this.NumTelefono = NumTelefono;
            this.Direccion = Direccion;
            this.Pais = Pais;
            this.Email = Email;
            this.Cedula = Cedula;
            InitializeComponent();
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            this.txtID.Text= ID;
            this.txtNombre.Text= Nombre;
            this.txtApellido1.Text= Apellido1;
            this.txtApellido2.Text= Apellido2;
            this.txtSexo.Text= Sexo;
            this.txtFechaNacimiento.Text= FechaNacimiento.ToString("dd/MM/yyyy");
            this.picBoxFoto.Image = Foto;
            this.picBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            this.txtNumTelefono.Text = NumTelefono;
            this.txtDireccion.Text = Direccion;
            this.txtPais.Text = Pais;
            this.txtEmail.Text= Email;
            this.picBoxCedula.Image = Cedula;
            this.picBoxCedula.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
