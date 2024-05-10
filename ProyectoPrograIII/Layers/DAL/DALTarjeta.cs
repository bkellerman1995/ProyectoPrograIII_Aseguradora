using ProyectoPrograIII.Interfaces;
using ProyectoPrograIII.Layers.Entities;
using ProyectoPrograIII.Layers.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Layers.DAL
{
    public class DALTarjeta : IDALTarjeta
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        ///Método utilizado por la capa DAL de tarjeta
        /// para eliminar la tarjeta de la base de datos
        /// recibiendo como parámetro el número de tarjeta (llave primaria) 
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar la tarjeta</returns>
        public bool DeleteTarjeta(string pId)
        {
            log4net.Config.XmlConfigurator.Configure();
            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();

            string sql = @"Delete  from  TarjetaCredito where IDTarjeta = @IDTarjeta";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@IDTarjeta", pId);
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

        /// <summary>
        /// Método utilizado por la capa DAL de tarjeta 
        /// para retornar una lista con todas las tarjetas
        /// almacenadas en la base de datos 
        /// </summary>
        /// <returns>Lista de tipo tarjeta (entity)</returns>
        public List<Tarjeta> GetAllTarjeta()
        {
            log4net.Config.XmlConfigurator.Configure();
            IDataReader reader = null;
            List<Tarjeta> lista = new List<Tarjeta>();
            Tarjeta oTarjeta = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  TarjetaCredito  With (NoLock)";
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(command);
                    // Si devolvió filas
                    while (reader.Read())
                    {
                        oTarjeta = new Tarjeta();
                        oTarjeta.IdTarjeta = reader["IDTarjeta"].ToString();
                        oTarjeta.DescripcionTarjeta = reader["DescripcionTarjeta"].ToString();
                        oTarjeta.CVC = reader["CVC"].ToString();
                        oTarjeta.FechaExpiracion = (DateTime)reader["FechaExpiracion"];
                        lista.Add(oTarjeta);
                    }
                }
                return lista;

            }
            catch (Exception er)

            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Metodo utilizada por la capa DAL de tarjeta
        /// para retornar la tarjeta de la base de datos
        /// usando como filtro el número de tarjeta (llave primaria) 
        /// </summary>
        /// <param name="pIdTarjeta"></param>
        /// <returns>objeto (entity) Tarjeta</returns>
        public Tarjeta GetTarjetaById(string pIdTarjeta)
        {
            log4net.Config.XmlConfigurator.Configure();
            DataSet ds = null;
            Tarjeta oTarjeta = null;
            SqlCommand command = new SqlCommand();
            string sql = @" select * from  TarjetaCredito  With (NoLock)
                               where IDtarjeta = @idTarjeta";

            try
            {
                command.Parameters.AddWithValue("@idTarjeta", pIdTarjeta);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        oTarjeta = new Tarjeta();
                        oTarjeta.IdTarjeta = dr["IDTarjeta"].ToString();
                        oTarjeta.DescripcionTarjeta = dr["DescripcionTarjeta"].ToString();
                        oTarjeta.CVC = dr["CVC"].ToString();
                        oTarjeta.FechaExpiracion = DateTime.Parse(dr["FechaExpiracion"].ToString());

                    }
                }

                return oTarjeta;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL de tarjeta
        /// para salvar a la tarjeta en la Base de Datos
        /// </summary>
        /// <param name="pTarjeta"></param>
        /// <returns>objeto (entity) Tarjeta</returns>
        public Tarjeta SaveTarjeta(Tarjeta pTarjeta)
        {
            log4net.Config.XmlConfigurator.Configure();
            Tarjeta oTarjeta = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"Insert into TarjetaCredito (IDTarjeta,DescripcionTarjeta,CVC,FechaExpiracion) 
            values (@IDTarjeta,@DescripcionTarjeta,@CVC,@FechaExpiracion)";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@IDTarjeta", pTarjeta.IdTarjeta);
                command.Parameters.AddWithValue("@DescripcionTarjeta", pTarjeta.DescripcionTarjeta);
                command.Parameters.AddWithValue("@CVC", pTarjeta.CVC);
                command.Parameters.AddWithValue("@FechaExpiracion", pTarjeta.FechaExpiracion);

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (row > 0)
                        oTarjeta = this.GetTarjetaById(pTarjeta.IdTarjeta);
                }

                return oTarjeta;

            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL de tarjeta
        /// para actualizar la tarjeta en la Base de Datos
        /// </summary>
        /// <param name="pTarjeta"></param>
        /// <returns>objeto (entity) Tarjeta</returns>
        public Tarjeta UpdateTarjeta(Tarjeta pTarjeta)
        {
            log4net.Config.XmlConfigurator.Configure();
            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            Tarjeta oTarjeta = null;
            string sql = @"Update TarjetaCredito SET DescripcionTarjeta=@DescripcionTarjeta,CVC=@CVC,FechaExpiracion=@FechaExpiracion Where (IDTarjeta = @ID)";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@ID", pTarjeta.IdTarjeta);
                command.Parameters.AddWithValue("@DescripcionTarjeta", pTarjeta.DescripcionTarjeta);
                command.Parameters.AddWithValue("@CVC", pTarjeta.CVC);
                command.Parameters.AddWithValue("@FechaExpiracion", pTarjeta.FechaExpiracion);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (row > 0)
                    oTarjeta = GetTarjetaById(pTarjeta.IdTarjeta);

                return oTarjeta;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }
    }
}
