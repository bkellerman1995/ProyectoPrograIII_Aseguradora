using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrograIII.Layers.Entities;
namespace ProyectoPrograIII.Interfaces
{
    interface IBLLUsuario
    {
        /// <summary>
        /// Método utilizado por la capa BLL del usuario
        /// para verificar si el usuario y la contraseña son correctos. 
        /// </summary>
        /// <param name="pLogin"></param>
        /// <param name="pPassword"></param>
        /// <returns>objeto (DAL) DALUsuario </returns>
        Usuarios Login(string ID, string password);

        /// <summary>
        /// Método utilizado por la capa BLL del usuario
        /// para obtener los usuarios almacenados 
        /// en la base de datos. 
        /// </summary>
        /// <param name="pLogin"></param>
        /// <param name="pPassword"></param>
        /// <returns>Lista (DAL) DALUsuario</returns>
        List<Usuarios> GetAllLogin();

        /// <summary>
        ///Método utilizado por la capa BLL del usuario
        /// para retornar el usuario de la base de datos
        /// usando como filtro el login (llave primaria)
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>objeto (DAL) DALUsuario</returns>
        Usuarios GetUsuarioById(string ID);

        /// <summary>
        ///Método utilizado por la capa BLL del usuario
        /// para salvar al usuario en la Base de Datos
        /// </summary>
        /// <param name="pUsuario"></param>
        /// <returns>objeto (DAL) DALUsuario</returns>
        Usuarios SaveUsuario(Usuarios pUsuario);

        /// <summary>
        ///Método utilizado por la capa BLL del usuario
        /// para actualizar al usuario en la Base de Datos
        /// </summary>
        /// <param name="pUsuario"></param>
        /// <returns>objeto (DAL) DALUsuario</returns>
        Usuarios UpdateUsuario(Usuarios pUsuario);

        /// <summary>
        ///Método utilizado por la capa BLL del usuario
        /// para eliminar el usuario de la base de datos
        /// recibiendo como parámetro el login (llave primaria)
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar el usuario</returns>
        bool DeleteUsuario(string ID);
    }
}
