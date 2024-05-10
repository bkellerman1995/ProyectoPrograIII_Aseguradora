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
    public class DALFamiliares : IDALFamiliares
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        ///Método utilizado por la capa DAL de Familiares
        /// para eliminar el familiar de un cliente en la Base de Datos
        /// </summary>
        /// <param name="pFamiliar"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar el familiar</returns>
        public bool DeleteFamiliarCliente(Familiares pFamiliar)
        {
            log4net.Config.XmlConfigurator.Configure();

            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();

            string comm1 = "Delete  from  ClienteFamiliares where IDFamiliar = @ID";
            string comm2 = "Delete from Familiares where IDCedula = @IDCedula";
            double row = 0;
            try
            {
                using (var db = new SqlConnection("Data Source = BRIAN22MSFT; Initial Catalog = Aseguradora; Persist Security Info = True; User ID = sa; Password = 123456"))
                {
                    SqlTransaction trans = null;

                    try
                    {
                        db.Open();
                        trans = db.BeginTransaction();

                        using (SqlCommand command1 = new SqlCommand(comm1, db, trans))
                        {
                            command1.Parameters.AddWithValue("@ID", pFamiliar.Cedula);
                            command1.CommandType = CommandType.Text;
                            command1.ExecuteNonQuery();


                        }
                        using (SqlCommand command2 = new SqlCommand(comm2, db, trans))
                        {
                            command2.Parameters.AddWithValue("@IDCedula", pFamiliar.Cedula);
                            command2.CommandType = CommandType.Text;
                            command2.ExecuteNonQuery();
                        }
                        trans.Commit();
                        row++;

                    }
                    catch (Exception)
                    {
                        throw;
                    }
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
        /// Método utilizado por la capa DAL de Familiares 
        /// para retornar todos los familiares
        /// almacenados en la base de datos 
        /// </summary>
        /// <returns>Lista de tipo Familiares (entity)</returns>
        public List<Familiares> GetAllFamiliares()
        {
            log4net.Config.XmlConfigurator.Configure();

            try
            {
                List<Familiares> list = new List<Familiares>();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "usp_SELECT_Familiares_All";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        Familiares oFamiliares = new Familiares();

                        oFamiliares.Cedula = reader["IDCedula"].ToString();
                        oFamiliares.Nombre = reader["Nombre"].ToString();
                        oFamiliares.Parentesco = reader["Parentesco"].ToString();

                        list.Add(oFamiliares);
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
        /// Método utilizado por la capa DAL de Familiares 
        /// para retornar todos los familiares de UN CLIENTE
        /// almacenados en la base de datos 
        /// </summary>
        /// <param name="pCliente"></param>
        /// <returns>Lista de tipo Familiares (entity)</returns>
        public List<Familiares> GetAllFamiliaresCliente(Cliente pCliente)
        {
            log4net.Config.XmlConfigurator.Configure();

            try
            {
                List<Familiares> list = new List<Familiares>();

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    SqlCommand command = new SqlCommand();
                    command.Parameters.AddWithValue("@ID", pCliente.ID);
                    command.CommandText = "SELECT  a.*, c.* FROM Cliente AS a INNER JOIN ClienteFamiliares AS b ON a.ID = b.IDCliente INNER JOIN Familiares AS c ON b.IDFamiliar = c.IDCedula WHERE a.ID = @ID";
                    command.CommandType = CommandType.Text;
                    var reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        Familiares oFamiliares = new Familiares();

                        oFamiliares.Cedula = reader["IDCedula"].ToString();
                        oFamiliares.Nombre = reader["Nombre"].ToString();
                        oFamiliares.Parentesco = reader["Parentesco"].ToString();

                        list.Add(oFamiliares);
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
        ///Metodo utilizada por la capa DAL de Familiares
        /// para retornar el familiar de un cliente
        /// usando como filtro el ID (identificación) del familiar (llave primaria) 
        /// </summary>
        /// <param name="pIDFamiliar"></param>
        /// <returns>objeto (entity) Familiares<</returns>
        public Familiares GetFamiliarByID(string pIDFamiliar)
        {
            log4net.Config.XmlConfigurator.Configure();

            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            IDataReader reader = null;
            Familiares oFamiliar = null;

            try
            {
                command.CommandText = @"select * from Familiares with (rowlock) where IDCedula = @ID";
                command.Parameters.AddWithValue("@ID", pIDFamiliar);
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        oFamiliar = new Familiares();
                        oFamiliar.Cedula = reader["IDCedula"].ToString();
                        oFamiliar.Nombre = reader["Nombre"].ToString();
                        oFamiliar.Parentesco = reader["Parentesco"].ToString();
                    }
                }

                return oFamiliar;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL de tarjeta
        /// para salvar al familiar en la Base de Datos
        /// </summary>
        /// <param name="pFamiliar"></param>
        /// <returns>objeto (entity) Familiares</returns>
        public Familiares SaveFamiliar(Familiares pFamiliar)
        {
            log4net.Config.XmlConfigurator.Configure();

            Familiares oFamiliar = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"Insert into Familiares (IDCedula,Nombre,Parentesco) values (@IDCedula,@Nombre,@Parentesco)";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@IDCedula", pFamiliar.Cedula);
                command.Parameters.AddWithValue("@Nombre", pFamiliar.Nombre);
                command.Parameters.AddWithValue("@Parentesco", pFamiliar.Parentesco.ToString());

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (row > 0)
                        oFamiliar = this.GetFamiliarByID(pFamiliar.Cedula);
                }

                return oFamiliar;

            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL de Familiares
        /// para salvar al familiar de un cliente en 
        /// tabla intermedia (muchos a muchos) en la Base de Datos
        /// </summary>
        /// <param name="pCliente"></param>
        /// <param name="pFamiliar"></param>
        public void SaveFamiliarCliente(Cliente pCliente, Familiares pFamiliar)
        {
            log4net.Config.XmlConfigurator.Configure();

            Cliente oCliente = pCliente;
            SqlCommand command = new SqlCommand();
            // Insert

            string command1 = @"Insert into ClienteFamiliares (IDClienteFamiliares,IDCliente,IDFamiliar) values (@IDClienteFamiliares,@IDCliente,@IDFamiliar)";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@IDClienteFamiliares", (pCliente.ID + "") + pFamiliar.Cedula);
                command.Parameters.AddWithValue("@IDCliente", pCliente.ID);
                command.Parameters.AddWithValue("@IDFamiliar", pFamiliar.Cedula);

                command.CommandText = command1;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (row > 0)
                        oCliente.listaFamiliares.Add(pFamiliar);
                }

            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }
    }
}
