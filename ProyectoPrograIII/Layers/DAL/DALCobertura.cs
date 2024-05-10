using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrograIII.Layers.Entities;
using ProyectoPrograIII.Interfaces;
using System.Data.SqlClient;
using System.Data;
using ProyectoPrograIII.Layers.Persistencia;

namespace ProyectoPrograIII.Layers.DAL
{
    public class DALCobertura : IDALCobertura
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        ///Método utilizado por la capa DAL de cobertura
        /// para eliminar la cobertura de la base de datos
        /// recibiendo como parámetro el ID de cobertura (llave primaria) 
        /// </summary>
        /// <param name="pID"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar la cobertura</returns>
        public bool DeleteCobertura(string pID)
        {
            log4net.Config.XmlConfigurator.Configure();
            double row = 0;
            string comm1 = "Delete from TipoPlanCobertura where CoberturaID = @CoberturaID";
            string comm2 = "Delete from Cobertura where IDCobertura = @IDCobertura";
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
                            command1.Parameters.AddWithValue("@CoberturaID", pID);
                            command1.CommandType = CommandType.Text;
                            command1.ExecuteNonQuery();
                        }

                        using (SqlCommand command2 = new SqlCommand(comm2, db, trans))
                        {
                            command2.Parameters.AddWithValue("@IDCobertura", pID);
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
        /// Método utilizado por la capa DAL de cobertura 
        /// para retornar una lista con todas las coberturas
        /// almacenadas en la base de datos 
        /// </summary>
        /// <returns>Lista de tipo coberturas</returns>
        public List<Cobertura> GetAllCobertura()
        {
            log4net.Config.XmlConfigurator.Configure();
            try
            {
                List<Cobertura> list = new List<Cobertura>();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "usp_SELECT_Cobertura_All";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        Cobertura oCobertura = new Cobertura();

                        oCobertura = new Cobertura();
                        oCobertura.IDCobertura = reader["IDCobertura"].ToString();
                        oCobertura.Nombre = reader["Nombre"].ToString();
                        oCobertura.Prima = double.Parse(reader["Prima"].ToString());
                        oCobertura.MontoMaximo = double.Parse(reader["MontoMaximo"].ToString());
                        oCobertura.NumEventosAnno = int.Parse(reader["NumEventosAnno"].ToString());

                        list.Add(oCobertura);
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
        ///Metodo utilizada por la capa DAL de cobertura
        /// para retornar la cobertura de la base de datos
        /// usando como filtro el ID de cobertura(llave primaria) 
        /// </summary>
        /// <param name="pID"></param>
        /// <returns>objeto (entity) Cobertura</returns>
        public Cobertura GetCoberturabyID(string pID)
        {
            log4net.Config.XmlConfigurator.Configure();
            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            IDataReader reader = null;
            Cobertura oCobertura = null;

            try
            {
                command.CommandText = @"select * from Cobertura with (rowlock) where IDCobertura = @ID";
                command.Parameters.AddWithValue("@ID", pID);
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        oCobertura = new Cobertura();
                        oCobertura.IDCobertura = reader["IDCobertura"].ToString();
                        oCobertura.Nombre = reader["Nombre"].ToString();
                        oCobertura.Prima = double.Parse(reader["Prima"].ToString());
                        oCobertura.MontoMaximo = double.Parse(reader["MontoMaximo"].ToString());
                        oCobertura.NumEventosAnno = int.Parse(reader["NumEventosAnno"].ToString());
                    }
                }

                return oCobertura;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL de cobertura
        /// para salvar a la cobertura en la Base de Datos
        /// </summary>
        /// <param name="pCobertura"></param>
        /// <returns>objeto (entity) Cobertura</returns>
        public Cobertura SaveCobertura(Cobertura pCobertura)
        {
            log4net.Config.XmlConfigurator.Configure();
            Cobertura oCobertura = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"Insert into Cobertura (IDCobertura,Nombre,Prima,MontoMaximo,NumEventosAnno) 
            values (@IDCobertura,@Nombre,@Prima,@MontoMaximo,@NumEventosAnno)";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@IDCobertura", pCobertura.IDCobertura);
                command.Parameters.AddWithValue("@Nombre", pCobertura.Nombre);
                command.Parameters.AddWithValue("@Prima", pCobertura.Prima);
                command.Parameters.AddWithValue("@MontoMaximo", pCobertura.MontoMaximo);
                command.Parameters.AddWithValue("@NumEventosAnno", pCobertura.NumEventosAnno);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (row > 0)
                        oCobertura = this.GetCoberturabyID(pCobertura.IDCobertura);

                }
                return oCobertura;

            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL de cobertura
        /// para actualizar la cobertura en la Base de Datos
        /// </summary>
        /// <param name="pCobertura"></param>
        /// <returns>objeto (entity) Cobertura</returns>
        public Cobertura UpdateCobertura(Cobertura pCobertura)
        {
            log4net.Config.XmlConfigurator.Configure();
            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            Cobertura oCobertura = null;
            string sql = @"Update Cobertura SET Nombre=@Nombre,Prima=@Prima,MontoMAximo=@MontoMAximo,NumEventosAnno=@NumEventosAnno Where (IDCobertura = @IDCobertura)";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@IDCobertura", pCobertura.IDCobertura);
                command.Parameters.AddWithValue("@Nombre", pCobertura.Nombre);
                command.Parameters.AddWithValue("@Prima", pCobertura.Prima);
                command.Parameters.AddWithValue("@MontoMaximo", pCobertura.MontoMaximo);
                command.Parameters.AddWithValue("@NumEventosAnno", pCobertura.NumEventosAnno);
   
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (row > 0)
                    oCobertura = GetCoberturabyID(pCobertura.IDCobertura);

                return oCobertura;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }
    }
}
