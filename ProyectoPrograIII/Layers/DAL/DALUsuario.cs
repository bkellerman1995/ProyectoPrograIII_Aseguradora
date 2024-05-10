using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrograIII.Interfaces;
using ProyectoPrograIII.Layers.Entities;
using ProyectoPrograIII.Layers.Persistencia;
using ProyectoPrograIII.Util;

namespace ProyectoPrograIII.Layers.DAL
{


    class DALUsuario : IDALUsuario
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Método utilizado por la capa DAL del usuario
        /// para verificar si el usuario y la contraseña son correctos. 
        /// </summary>
        /// <param name="pLogin"></param>
        /// <param name="pPassword"></param>
        /// <returns>objeto (entity) Usuario</returns>
        public Usuarios Login(string pID, string pPassword)
        {
            log4net.Config.XmlConfigurator.Configure();
            StringBuilder conexion = new StringBuilder();
            SqlCommand comando = new SqlCommand();
            IDataReader reader = null;
            Usuarios oUsuario = null;

            try
            {
                comando.CommandText = @"select * from Usuarios with (rowlock) where ID = @pID and Contrasenna = @pPassword";
                comando.Parameters.AddWithValue("@pID", pID);
                comando.Parameters.AddWithValue("@pPassword", pPassword);
                comando.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        oUsuario = new Usuarios();
                        oUsuario.ID = reader["ID"].ToString();
                        oUsuario.Nombre = reader["Nombre"].ToString();
                        oUsuario.Contrasenna = reader["Contrasenna"].ToString();
                        oUsuario.IdRol = int.Parse(reader["IDRol"].ToString());
                        oUsuario.Estado = bool.Parse(reader["Estado"].ToString());
                        oUsuario.Foto = Encoding.ASCII.GetBytes(reader["Foto"].ToString());

                    }

                    return oUsuario;

                }


            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        /// Método utilizado por la capa DAL del usuario
        /// para obtener los usuarios almacenados 
        /// en la base de datos. 
        /// </summary>
        /// <param name="pLogin"></param>
        /// <param name="pPassword"></param>
        /// <returns>objeto (entity) Usuario</returns>
        public List<Usuarios> GetAllLogin()
        {
            log4net.Config.XmlConfigurator.Configure();
            try
            {
                List<Usuarios> list = new List<Usuarios>();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "usp_SELECT_Usuarios_All";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        Usuarios oUsuario = new Usuarios();

                        oUsuario.ID = reader["ID"].ToString();
                        oUsuario.Nombre = reader["Nombre"].ToString();
                        oUsuario.Contrasenna = Criptografia.DecrypthAES(reader["Contrasenna"].ToString());
                        oUsuario.IdRol = int.Parse(reader["IdRol"].ToString());
                        oUsuario.Estado = bool.Parse(reader["Estado"].ToString());
                        oUsuario.Foto = (byte[])reader["Foto"];

                        list.Add(oUsuario);
                    }
                }
                return list;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL del usuario
        /// para salvar al usuario en la Base de Datos
        /// </summary>
        /// <param name="pUsuario"></param>
        /// <returns>objeto (entity) Usuario</returns>
        public Usuarios SaveUsuario(Usuarios pUsuario)
        {
            log4net.Config.XmlConfigurator.Configure();
            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            Usuarios oUsuario = null;
            string sql = @"Insert into Usuarios(ID,Nombre,Contrasenna,IDRol,Estado,Foto) values (@ID,@Nombre,@Contrasenna,@IDRol,@Estado,@Foto)";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@ID", pUsuario.ID);
                command.Parameters.AddWithValue("@IdRol", pUsuario.IdRol);
                command.Parameters.AddWithValue("@Contrasenna", pUsuario.Contrasenna);
                command.Parameters.AddWithValue("@Nombre", pUsuario.Nombre);
                command.Parameters.AddWithValue("@Estado", pUsuario.Estado);
                command.Parameters.AddWithValue("@Foto", pUsuario.Foto);

                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (row > 0)
                    oUsuario = GetUsuarioById(pUsuario.ID);

                return oUsuario;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL del usuario
        /// para actualizar al usuario en la Base de Datos
        /// </summary>
        /// <param name="pUsuario"></param>
        /// <returns>objeto (entity) Usuario</returns>
        public Usuarios UpdateUsuario(Usuarios pUsuario)
        {
            log4net.Config.XmlConfigurator.Configure();
            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            Usuarios oUsuario = null;
            string sql = @"Update Usuarios SET Nombre=@Nombre, Contrasenna=@Contrasenna, IDRol= @IDRol, Estado=@Estado, Foto=@Foto Where (ID = @ID)";
            double row = 0;
            try
            {

                command.Parameters.AddWithValue("@ID", pUsuario.ID);
                command.Parameters.AddWithValue("@Nombre", pUsuario.Nombre);
                command.Parameters.AddWithValue("@Contrasenna", pUsuario.Contrasenna);
                command.Parameters.AddWithValue("@IdRol", pUsuario.IdRol);
                command.Parameters.AddWithValue("@Estado", pUsuario.Estado);
                command.Parameters.AddWithValue("@Foto", pUsuario.Foto);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (row > 0)
                    oUsuario = GetUsuarioById(pUsuario.ID);

                return oUsuario;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL del usuario
        /// para retornar el usuario de la base de datos
        /// usando como filtro el login (llave primaria)
        /// </summary>
        /// <param name="pLogin"></param>
        /// <returns>objeto (entity) Usuario</returns>
        public Usuarios GetUsuarioById(string ID)
        {
            log4net.Config.XmlConfigurator.Configure();
            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            IDataReader reader = null;
            Usuarios oUsuario = null;
            try
            {
                command.CommandText = @"select * from Usuarios with (rowlock) where ID = @ID";
                command.Parameters.AddWithValue("@ID", ID);
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        oUsuario = new Usuarios();
                        oUsuario.ID = reader["ID"].ToString();
                        oUsuario.Nombre = reader["Nombre"].ToString();
                        oUsuario.Contrasenna = reader["Contrasenna"].ToString();
                        oUsuario.IdRol = int.Parse(reader["IDRol"].ToString());
                        oUsuario.Estado = bool.Parse(reader["Estado"].ToString());
                        oUsuario.Foto = Encoding.ASCII.GetBytes(reader["Foto"].ToString());
                    }
                }

                return oUsuario;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL del usuario
        /// para eliminar el usuario de la base de datos
        /// recibiendo como parámetro el login (llave primaria)
        /// </summary>
        /// <param name="pLogin"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar el usuario</returns>
        public bool DeleteUsuario(string ID)
        {
            log4net.Config.XmlConfigurator.Configure();
            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();

            string sql = @"Delete  from  Usuarios where ID = @ID";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@ID", ID);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }


                return row > 0 ? true : false;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }
    }
}
