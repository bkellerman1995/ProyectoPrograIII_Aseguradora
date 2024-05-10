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
    public class DALImpuesto : IDALImpuesto
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        ///Método utilizado por la capa DAL de Impuesto
        /// para eliminar el Impuesto de la base de datos
        /// recibiendo como parámetro el porcentaje de impuesto 
        /// </summary>
        /// <param name="porcentaje"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar el impuesto</returns>
        public bool DeleteImpuesto(int porcentaje)
        {
            log4net.Config.XmlConfigurator.Configure();

            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();

            string sql = @"Delete  from  Impuesto where Porcentaje = @Porcentaje";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@Porcentaje", porcentaje);
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
        /// Método utilizado por la capa DAL de Impuesto 
        /// para retornar todos los IVAs (impuestos) 
        /// almacenados en la base de datos 
        /// </summary>
        /// <returns>Lista de tipo impuesto (entity)</returns>
        public List<Impuesto> GEtAllImpuesto ()
        {
            log4net.Config.XmlConfigurator.Configure();

            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            IDataReader reader = null;
            List<Impuesto> list = new List<Impuesto>();

            try
            {
                command.CommandText = "usp_SELECT_Impuesto_All";
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        Impuesto oImpuesto = new Impuesto();
                        oImpuesto.Porcentaje = int.Parse(reader["Porcentaje"].ToString());
                        list.Add(oImpuesto);
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
        ///Método utilizado por la capa DAL de Impuesto
        /// para salvar el Impuesto en la Base de Datos
        /// </summary>
        /// <param name="pImpuesto"></param>
        /// <returns>objeto (entity) Impuesto</returns>
        public Impuesto SaveImpuesto(Impuesto pImpuesto)
        {
            log4net.Config.XmlConfigurator.Configure();

            Impuesto oImpuesto = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"Insert into Impuesto (Porcentaje) values (@Porcentaje)";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@Porcentaje", pImpuesto.Porcentaje);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (row > 0)
                        oImpuesto = this.GetImpuestoByID(pImpuesto.Porcentaje);
                }

                return oImpuesto;

            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL de Impuesto
        /// para actualizar el Impuesto en la Base de Datos
        /// </summary>
        /// <param name="pImpuesto"></param>
        /// <returns>objeto (entity) Impuesto</returns>
        public Impuesto UpdateImpuesto(Impuesto pImpuesto)
        {
            log4net.Config.XmlConfigurator.Configure();

            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            Impuesto oImpuesto = null;
            string sql = @"Update Impuesto SET Porcentaje=@Porcentaje";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@Porcentaje", pImpuesto.Porcentaje);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (row > 0)
                    oImpuesto = this.GetImpuestoByID(pImpuesto.Porcentaje);

                return oImpuesto;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Metodo utilizada por la capa DAL de Impuesto
        /// para retornar el Impuesto de la base de datos
        /// usando como filtro el porcentaje
        /// </summary>
        /// <param name="pPocentaje"></param>
        /// <returns>objeto (BLL) BLLImpuesto</returns>
        public Impuesto GetImpuestoByID(int pPocentaje)
        {
            log4net.Config.XmlConfigurator.Configure();

            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            IDataReader reader = null;
            Impuesto oImpuesto = null;

            try
            {
                command.CommandText = @"select * from Impuesto with (rowlock) where Porcentaje = @Porcentaje";
                command.Parameters.AddWithValue("@Porcentaje", pPocentaje);
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        oImpuesto = new Impuesto();
                        oImpuesto.Porcentaje = int.Parse(reader["Porcentaje"].ToString());
                    }
                }

                return oImpuesto;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }
    }
}
