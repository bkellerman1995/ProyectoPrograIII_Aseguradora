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
using ProyectoPrograIII.Layers.DAL;

namespace ProyectoPrograIII.Interfaces
{
    class DALPoliza : IDALPoliza
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        ///Método utilizado por la capa DAL de póliza 
        /// para eliminar la póliza en la base de datos
        /// recibiendo como parámetro el ID (llave primaria)
        /// </summary>
        /// <param name="pPoliza"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar la póliza</returns>
        public bool DeletePoliza(string pID)
        {
            log4net.Config.XmlConfigurator.Configure();

            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();

            string sql = @"Delete  from  Poliza where IDPoliza = @ID";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@ID", pID);
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
        ///Método utilizado por la capa DAL de póliza 
        /// para retornar todas las pólizas de la base de datos
        /// </summary>
        /// <returns>Lista de objetos tipo Póliza</returns>
        public List<Poliza> GetAllPoliza()
        {
            log4net.Config.XmlConfigurator.Configure();

            try
            {
                List<Poliza> list = new List<Poliza>();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "usp_SELECT_Poliza_All";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        Poliza oPoliza = new Poliza();

                        oPoliza.ID = reader["IDPoliza"].ToString();
                        oPoliza.Descripcion = reader["Descripcion"].ToString();
                        IDALCliente extraerCliente = new DALCliente();

                        foreach (var cliente in extraerCliente.GetAllCliente())
                        {
                            if (int.Parse(reader["IDCliente"].ToString()) == cliente.ID)
                                oPoliza.Cliente = cliente;
                        }
                        
                        IDALPlan extraerPlan = new DALPlan();
                        foreach (var plan in extraerPlan.GetAllPlan())
                        {
                            if (string.Equals(reader["IDTipoPlan"], plan.ID))
                                oPoliza.Plan = plan;
                        }

                        list.Add(oPoliza);
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
        ///Método utilizado por la capa DAL de póliza 
        /// para retornar la póliza  de la base de datos
        /// usando como filtro el ID (llave primaria)
        /// </summary>
        /// <param name="pID"></param>
        /// <returns>objeto (entity) Póliza</returns>
        public Poliza GetPolizaByID(string pID)
        {
            log4net.Config.XmlConfigurator.Configure();

            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            IDataReader reader = null;
            Poliza oPoliza = null;

            try
            {
                command.CommandText = @"select * from Poliza with (rowlock) where IDPoliza = @ID";
                command.Parameters.AddWithValue("@ID", pID);
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        oPoliza = new Poliza();
                        oPoliza.ID = (reader["IDPoliza"].ToString());
                        oPoliza.Descripcion = reader["Descripcion"].ToString();
                        
                        IDALCliente extraerCliente = new DALCliente();

                        foreach (var cliente in extraerCliente.GetAllCliente())
                        {
                            if (string.Equals(reader["IDCliente"], cliente.ID))
                                oPoliza.Cliente = cliente;
                        }

                        IDALPlan extraerPlan = new DALPlan();

                        foreach (var plan in extraerPlan.GetAllPlan())
                        {
                            if (string.Equals(reader["IDTipoPlan"], plan.ID))
                                oPoliza.Plan = plan;
                        }
                        
                    }
                }

                return oPoliza;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL de póliza 
        /// para salvar la póliza en la base de datos
        /// </summary>
        /// <param name="pPoliza"></param>
        /// <returns>objeto (entity) Póliza</returns>
        public Poliza SavePoliza(Poliza pPoliza)
        {
            log4net.Config.XmlConfigurator.Configure();

            Poliza oPoliza = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"Insert into Poliza (IDPoliza,Descripcion,IDCliente,IDTipoPlan) values (@ID,@Descripcion,@IDCliente,@IDTipoPlan)";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@ID", pPoliza.ID);
                command.Parameters.AddWithValue("@Descripcion", pPoliza.Descripcion);
                command.Parameters.AddWithValue("@IDCliente", pPoliza.Cliente.ID);
                command.Parameters.AddWithValue("@IDTipoPlan", pPoliza.Plan.ID);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (row > 0)
                        oPoliza = this.GetPolizaByID(pPoliza.ID);
                }

                return oPoliza;

            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL de póliza 
        /// para actualizar la póliza en la base de datos
        /// </summary>
        /// <param name="pPoliza"></param>
        /// <returns>objeto (entity) Póliza</returns>
        public Poliza UpdatePoliza(Poliza pPoliza)
        {
            log4net.Config.XmlConfigurator.Configure();

            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            Poliza oPoliza = null;
            string sql = @"Update Poliza SET Descripcion=@Descripcion,IDCliente=@IDCliente,IDTipoPlan=@IDTipoPlan Where (IDPoliza = @ID)";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@ID", pPoliza.ID);
                command.Parameters.AddWithValue("@Descripcion", pPoliza.Descripcion);
                command.Parameters.AddWithValue("@IDCliente", pPoliza.Cliente.ID);
                command.Parameters.AddWithValue("@IDTipoPlan", pPoliza.Plan.ID);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (row > 0)
                    oPoliza = GetPolizaByID(pPoliza.ID);

                return oPoliza;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }
    }
}
