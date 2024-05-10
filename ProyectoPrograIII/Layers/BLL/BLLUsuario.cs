using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrograIII.Interfaces;
using ProyectoPrograIII.Layers.Entities;
using ProyectoPrograIII.Layers.DAL;
using ProyectoPrograIII.Util;

namespace ProyectoPrograIII.Layers.BLL

{
    public class BLLUsuario : IBLLUsuario
    {

        /// <summary>
        /// Método utilizado por la capa BLL del usuario
        /// para verificar si el usuario y la contraseña son correctos. 
        /// </summary>
        /// <param name="pLogin"></param>
        /// <param name="pPassword"></param>
        /// <returns>objeto (DAL) DALUsuario </returns>
        public Usuarios Login(string ID, string password)
        {
            IDALUsuario usuarioDAL = new DALUsuario();

            string crytpPasswd = Criptografia.EncrypthAES(password);

            return usuarioDAL.Login(ID, crytpPasswd);
        }

        /// <summary>
        ///Método utilizado por la capa BLL del usuario
        /// para salvar al usuario en la Base de Datos
        /// </summary>
        /// <param name="pUsuario"></param>
        /// <returns>objeto (DAL) DALUsuario</returns>
        public Usuarios SaveUsuario(Usuarios pUsuario)
        {
            IDALUsuario usuarioDAL = new DALUsuario();
            Usuarios oUsuario = null;
            string mensaje = "";

            if (pUsuario == null)
                throw new ApplicationException("No se envio el usuario");
            if (pUsuario.ID == null)
                throw new ApplicationException("Se requiere un ID para el usuario");
            if (string.IsNullOrEmpty(pUsuario.Nombre))
                throw new ApplicationException("Se requiere el nombre de usuario");

            if (!IsValidPassword(pUsuario.Contrasenna, ref mensaje))
            {
                throw new Exception(mensaje);
            }

            pUsuario.Contrasenna = Criptografia.EncrypthAES(pUsuario.Contrasenna);

            if (usuarioDAL.GetUsuarioById(pUsuario.ID) != null)
                oUsuario = usuarioDAL.UpdateUsuario(pUsuario);
            else
                oUsuario = usuarioDAL.SaveUsuario(pUsuario);
            return oUsuario;
        }

        /// <summary>
        ///Método utilizado por la capa BLL del usuario
        /// para actualizar al usuario en la Base de Datos
        /// </summary>
        /// <param name="pUsuario"></param>
        /// <returns>objeto (DAL) DALUsuario</returns>
        public Usuarios UpdateUsuario(Usuarios pUsuario)
        {
            IDALUsuario usuarioDAL = new DALUsuario();
            string mensaje = "";

            if (!IsValidPassword(pUsuario.Contrasenna, ref mensaje))
            {
                throw new Exception(mensaje);
            }

            pUsuario.Contrasenna = Criptografia.EncrypthAES(pUsuario.Contrasenna);

            return usuarioDAL.UpdateUsuario(pUsuario);
        }

        /// <summary>
        ///Método utilizado por la capa BLL del usuario
        /// para eliminar el usuario de la base de datos
        /// recibiendo como parámetro el login (llave primaria)
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar el usuario</returns>
        public bool DeleteUsuario(string ID)
        {
            IDALUsuario usuarioDAL = new DALUsuario();
            return usuarioDAL.DeleteUsuario(ID);
        }

        /// <summary>
        /// Método utilizado por la capa BLL del usuario
        /// para obtener los usuarios almacenados 
        /// en la base de datos. 
        /// </summary>
        /// <param name="pLogin"></param>
        /// <param name="pPassword"></param>
        /// <returns>Lista (DAL) DALUsuario</returns>
        public List<Usuarios> GetAllLogin()
        {
            IDALUsuario usuarioDAL = new DALUsuario();
            var list = usuarioDAL.GetAllLogin();
            return list;
        }

        /// <summary>
        ///Método utilizado por la capa BLL del usuario
        /// para retornar el usuario de la base de datos
        /// usando como filtro el login (llave primaria)
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>objeto (DAL) DALUsuario</returns>
        public Usuarios GetUsuarioById(string ID)
        {
            IDALUsuario usuarioDAL = new DALUsuario();
            return usuarioDAL.GetUsuarioById(ID);
        }

        /// <summary>
        /// Método utilizado por la capa BLL del usuario para validar si
        /// el password cumple con los requisitos minimos para 
        /// poder salvar/actualizar el usuario
        /// </summary>
        /// <param name="pContrasenna"></param>
        /// <param name="pMensaje"></param>
        /// <returns></returns>
        private bool IsValidPassword(string pContrasenna, ref string pMensaje)
        {
            if (pContrasenna.Trim().Length <= 6)
            {
                pMensaje = "La contraseña debe ser mayor o igual a 8 caracteres";
                return false;
            }

            if (pContrasenna.Trim().Length > 10)
            {
                pMensaje = "La contraseña debe ser mayor o igual a 8 caracteres y menor o igual que 10";
                return false;
            }

            return true;
        }
    }
}
