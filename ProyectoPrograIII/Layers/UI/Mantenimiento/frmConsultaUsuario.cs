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
    public partial class frmConsultaUsuario : Form
    {
        string ID;
        string Nombre;
        string Rol;
        string Estado;
        Image foto;
        public frmConsultaUsuario(string ID,string Nombre, string Rol, string Estado, Image foto)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Rol = Rol;
            this.Estado = Estado;
            this.foto = foto;
            InitializeComponent();
        }

        private void frmConsultaUsuario_Load(object sender, EventArgs e)
        {
            this.txtID.Text = ID;
            this.txtNombre.Text = Nombre;
            this.txtRol.Text = Rol;
            this.txtEstado.Text = Estado;
            this.picBoxFoto.Image = foto;
            this.picBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
