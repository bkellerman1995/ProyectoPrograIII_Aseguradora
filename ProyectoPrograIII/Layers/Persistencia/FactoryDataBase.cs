using System;
using System.Data.SqlClient;
using System.Data;
namespace ProyectoPrograIII.Layers.Persistencia
{

    class FactoryDatabase
    {
        /// <summary>
        /// Método estático que se encarga de crear una conexión con la 
        /// base de datos usando la cadena de conexión que recibe como parametro
        /// </summary>
        /// <param name="pStringConnection"></param>
        /// <returns>Objeto tipo DataBase con los detalles de conexión, etc.</returns>
        public static IDataBase CreateDataBase(string pStringConnection)
        {
            IDbConnection conexion = null;
            try
            {
                IDataBase db = new DataBase();

                conexion = new SqlConnection(pStringConnection);

                conexion.Open();

                db._Conexion = conexion;

                if (conexion.State != ConnectionState.Open)
                {

                    throw new Exception("No se pudo abrir la Base de Datos, revise los parámetros de conexión! ");
                }
                return db;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Método estático que se encarga de crear una conexión con la 
        /// base de datos de forma asincrónica usando la cadena de conexión que recibe como parametro
        /// </summary>
        /// <param name="pStringConnection"></param>
        /// <returns>Objeto tipo DataBase con los detalles de conexión, etc.</returns>
        public static IDataBase CreateDataBaseAsync(string pStringConnection)
        {
            SqlConnection conexion = null;
            try
            {
                IDataBase db = new DataBase();
                conexion = new SqlConnection(pStringConnection);
                db._Conexion = conexion;
                if (conexion.State != ConnectionState.Open)
                {
                    throw new Exception("No se pudo abrir la Base de Datos, revise los parámetros de conexión! ");
                }
                return db;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}

