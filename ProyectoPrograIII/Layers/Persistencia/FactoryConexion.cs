using System;
using System.Configuration;
using System.Text;

namespace ProyectoPrograIII.Layers.Persistencia
{

    class FactoryConexion
    {
        /// <summary>
        /// Método que se encarga de retornar la cadena de conexión 
        /// para que la aplicacion pueda conectarse con el motor de base de datos.
        /// </summary>
        /// <returns>Cadena de conexión como valor de tipo string</returns>
        public static string CreateConnection()
        {

            StringBuilder conexion = new StringBuilder();
            bool existe = false;

            // Validacion de la conexion
            if (ConfigurationManager.ConnectionStrings.Count == 0)
            {
                throw new Exception("No existen registradas ConnectionStrings/Cadenas de conxion en el archivo app.config, revise!");
            }

            for (int i = 0; i <= ConfigurationManager.ConnectionStrings.Count - 1; i++)
            {
                if (ConfigurationManager.ConnectionStrings[i].Name.Equals("ProyectoPrograIII.Properties.Settings.BDConnection", StringComparison.InvariantCultureIgnoreCase))
                    existe = true;
            }

            if (!existe)
            {
                throw new Exception("No existe registrada en ConnectionStrings del app.config el Key default!");
            }


            // Lee la conexion default

            return ConfigurationManager.ConnectionStrings["ProyectoPrograIII.Properties.Settings.BDConnection"].ConnectionString;
        }

        /// <summary>
        /// Método que se encarga de retornar la cadena de conexión 
        /// para que la aplicacion pueda conectarse con el motor de base de datos.
        /// En este caso se recibe como parametros el usuario y la contraseña
        /// </summary>
        /// <returns>Cadena de conexión como valor de tipo string</returns>
        public static string CreateConnection(string pUsuario, String pContrasena)
        {

            StringBuilder conexion = new StringBuilder();
            bool existe = false;

            // Validacion de la conexion
            if (ConfigurationManager.ConnectionStrings.Count == 0)
            {
                throw new Exception("No existen registradas ConnectionStrings en el archivo app.config, revise!");
            }

            for (int i = 0; i < ConfigurationManager.ConnectionStrings.Count - 1; i++)
            {
                if (ConfigurationManager.ConnectionStrings[i].Name.Equals("default", StringComparison.InvariantCultureIgnoreCase))
                    existe = true;
            }

            if (!existe)
            {
                throw new Exception("No existe registrada en ConnectionStrings del app.config el Key default!");
            }


            // Lee la conexion default
            conexion.AppendFormat("{0}", ConfigurationManager.ConnectionStrings["default"].ConnectionString);
            // Agrega al usuario
            conexion.AppendFormat("User Id={0};Password={1}", pUsuario, pContrasena);
            return conexion.ToString();
        }

        /// <summary>
        /// Método que se encarga de retornar la cadena de conexión 
        /// para que la aplicacion pueda conectarse con el motor de base de datos.
        /// En este caso se recibe como parametros el usuario, la contraseña y la cadena de conexión
        /// </summary>
        /// <returns>Cadena de conexión como valor de tipo string</returns>
        public static string CreateConnection(string pUsuario, String pContrasena, string pConexion)
        {

            StringBuilder conexion = new StringBuilder();
            bool existe = false;
            // Validacion de la conexion
            if (ConfigurationManager.ConnectionStrings.Count == 0)
            {
                throw new Exception("No existen registradas ConnectionStrings en el archivo app.confi, revise!");
            }

            for (int i = 0; i < ConfigurationManager.ConnectionStrings.Count - 1; i++)
            {
                if (ConfigurationManager.ConnectionStrings[i].Name.Equals(pConexion, StringComparison.InvariantCultureIgnoreCase))
                    existe = true;
            }

            if (!existe)
            {
                throw new Exception("No existe registrada en ConnectionStrings del app.config el Key default!");
            }


            // Lee la conexion default
            conexion.AppendFormat("{0}", ConfigurationManager.ConnectionStrings[pConexion].ConnectionString);
            // Agrega al usuario
            conexion.AppendFormat("User Id={0};Password={1}", pUsuario, pContrasena);
            return conexion.ToString();
        }

    }
}

