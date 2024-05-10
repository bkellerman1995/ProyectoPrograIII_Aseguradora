using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPrograIII.Interfaces;
using ProyectoPrograIII.Layers.BLL;
using ProyectoPrograIII.Layers.Entities;
using log4net;
using System.Reflection;

namespace ProyectoPrograIII.Layers.UI
{
    public partial class frmLogin : Form
    {
        
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        int cont = 0;
        public frmLogin()
        {
            log4net.Config.XmlConfigurator.Configure();
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            IBLLUsuario usuarioBLL = new BLLUsuario();
            Usuarios oUsuario = null;

            try
            {
                if (string.IsNullOrEmpty(this.txtUsuario.Text))
                {
                    //considerar cambiarlo por error provider
                    MessageBox.Show("Debe ingresar para usuario para continuar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtUsuario.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtPwd.Text))
                {
                    //considerar cambiarlo por error provider
                    MessageBox.Show("Debe ingresar una contraseña para continuar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPwd.Focus();
                    return;
                }

                //iniciar el login para el usuario y consultar en la base de datos si el usuario existe

                oUsuario = usuarioBLL.Login(this.txtUsuario.Text, this.txtPwd.Text);

                //Aqui hay que verificar si se puede abrir la nueva interfaz de login
                if (oUsuario == null)
                {
                    cont++;
                    MessageBox.Show("Usuario o contraseña equivocados, por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtUsuario.Text = "";
                    this.txtPwd.Text = "";
                    if (cont == 3)
                    {
                        // se devuelve Cancel
                        MessageBox.Show("Se equivocó en 3 ocasiones, el sistema se cerrará por seguridad", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.Cancel;
                        Application.Exit();
                    }

                }

                else
                {

                    if (oUsuario.Estado == false)
                    {
                        MessageBox.Show("El usuario: " + oUsuario.ID.Trim() + " se encuentra inhabilitado" +
                            "\nPor favor contacte al administrador o intente con otro usuario", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtUsuario.Text = "";
                        this.txtPwd.Text = "";
                        this.txtUsuario.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Bienvenido(a) al sistema: " + oUsuario.Nombre, "Información",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        log.Info("Inicio de login por: " + oUsuario.Nombre + ", Rol: " + oUsuario.IdRol);
                        frmPrincipal mnuPrincipal = new frmPrincipal(oUsuario, this);
                        mnuPrincipal.StartPosition = FormStartPosition.Manual;
                        mnuPrincipal.Location = new Point(0, 0);
                        mnuPrincipal.Show();
                        this.Hide();
                    }

                }
            }

            catch (Exception ex)


            {

                log.Error(ex.Message.ToString());
                MessageBox.Show("Error al procesar el login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
