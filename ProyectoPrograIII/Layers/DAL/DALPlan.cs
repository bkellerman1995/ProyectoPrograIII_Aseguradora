using ProyectoPrograIII.Interfaces;
using ProyectoPrograIII.Layers.Entities;
using ProyectoPrograIII.Layers.Persistencia;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Layers.DAL
{
    public class DALPlan : IDALPlan
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        ///Método utilizado por la capa DAL de plan 
        /// para eliminar el plan en la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar el plan</returns>
        public bool DeletePlan(string pID)

        {
            log4net.Config.XmlConfigurator.Configure();
            double row = 0;
            string comm1 = "Delete from TipoPlanCobertura where TipoPlanID = @TipoPlanID";
            string comm2 = "Delete from TipoPlan where ID = @ID";
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
                            command1.Parameters.AddWithValue("@TipoPlanID", pID);
                            command1.CommandType = CommandType.Text;
                            command1.ExecuteNonQuery();
                        }

                        using (SqlCommand command2 = new SqlCommand(comm2, db, trans))
                        {
                            command2.Parameters.AddWithValue("@ID", pID);
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
        ///Método utilizado por la capa DAL de plan 
        /// para retornar todas las coberturas del plan 
        /// enviado como parámetro desde la base de datos
        /// </summary>
        /// <param name="pPlan"></param>
        /// <returns>Lista de objetos tipo Cobertura</returns>
        public List<Cobertura> GetAllCoberturasPlan(Plan pPlan)
        {
            log4net.Config.XmlConfigurator.Configure();
            try
            {
                List<Cobertura> list = new List<Cobertura>();

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    SqlCommand command = new SqlCommand();
                    command.Parameters.AddWithValue("@ID", pPlan.ID);
                    command.CommandText = "SELECT  a.*, c.* FROM TipoPlan a INNER JOIN TipoPlanCobertura b ON a.ID = b.TipoPlanID INNER JOIN Cobertura c ON b.CoberturaID = c.IDCobertura WHERE a.ID = @ID";
                    command.CommandType = CommandType.Text;
                    var reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        Cobertura oCobertura = new Cobertura();

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
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL de plan 
        /// para retornar todas los planes de la base de datos
        /// </summary>
        /// <returns>Lista de objetos tipo Plan</returns>
        public List<Plan> GetAllPlan()
        {
            log4net.Config.XmlConfigurator.Configure();
            try
            {
                List<Plan> list = new List<Plan>();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "usp_SELECT_TipoPlan_All";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        Plan oPlan = new Plan();

                        oPlan.ID = reader["ID"].ToString();
                        oPlan.NombrePlan = reader["NombrePlan"].ToString();
                        oPlan.Familiar = bool.Parse(reader["Familiar"].ToString());
                        oPlan.CostoPlan = double.Parse(reader["CostoPlan"].ToString());

                        list.Add(oPlan);
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
        ///Método utilizado por la capa DAL de plan 
        /// para retornar el plan de la base de datos
        /// usando como filtro el ID (llave primaria)
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>objeto (entity) Plan</returns>
        public Plan GetPlanByID(string pId)
        {
            log4net.Config.XmlConfigurator.Configure();

            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            IDataReader reader = null;
            Plan oPlan = null;

            try
            {
                command.CommandText = @"select * from TipoPlan with (rowlock) where ID = @ID";
                command.Parameters.AddWithValue("@ID", pId);
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        oPlan = new Plan();
                        oPlan.ID = reader["ID"].ToString();
                        oPlan.NombrePlan = reader["NombrePlan"].ToString();
                        oPlan.Familiar = bool.Parse(reader["Familiar"].ToString());
                        oPlan.CostoPlan = double.Parse(reader["CostoPlan"].ToString());
                    }
                }

                return oPlan;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL de plan 
        /// para salvar la cobertura del plan en la tabla intermedia (1 a muchos) 
        /// en la base de datos
        /// <param name="plan"></param>
        /// <param name="pCobertura"></param>
        public void SaveCobertura(Plan pPlan, Cobertura pCobertura)
        {
            log4net.Config.XmlConfigurator.Configure();

            Plan oPlan = pPlan;
            SqlCommand command = new SqlCommand();
            // Insert

            string sql = @"Insert into TipoPlanCobertura (TipoPlanCoberturaId,TipoPlanID,CoberturaID) values (@TipoPlanCoberturaId,@TipoPlanID,@CoberturaID)";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@TipoPlanCoberturaId", pPlan.ID + pCobertura.IDCobertura);
                command.Parameters.AddWithValue("@TipoPlanID", pPlan.ID);
                command.Parameters.AddWithValue("@CoberturaID", pCobertura.IDCobertura);

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (row > 0)
                        oPlan.listaCoberturas.Add(pCobertura);
                }

            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL de plan 
        /// para salvar el plan en la base de datos
        /// </summary>
        /// <param name="pPlan"></param>
        /// <returns>objeto (entity) Plan</returns>
        public Plan SavePlan(Plan pPlan)
        {
            log4net.Config.XmlConfigurator.Configure();

            Plan oPlan = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"Insert into TipoPlan (ID,NombrePlan,Familiar,CostoPlan) values (@ID,@NombrePlan,@Familiar,@CostoPlan)";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@ID", pPlan.ID);
                command.Parameters.AddWithValue("@NombrePlan", pPlan.NombrePlan);
                command.Parameters.AddWithValue("@Familiar", pPlan.Familiar);
                command.Parameters.AddWithValue("@CostoPlan", pPlan.CostoPlan);

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (row > 0)
                        oPlan = this.GetPlanByID(pPlan.ID);
                }

                return oPlan;

            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL de plan 
        /// para actualizar el plan en la base de datos
        /// </summary>
        /// <param name="pPlan"></param>
        /// <returns>objeto (entity) Plan</returns>
        public Plan UpdatePlan(Plan pPlan)
        {
            log4net.Config.XmlConfigurator.Configure();

            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            Plan oPlan = null;
            string sql = @"Update TipoPlan SET NombrePlan=@NombrePlan,Familiar=@Familiar,CostoPlan=@CostoPlan Where (ID = @ID)";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@ID", pPlan.ID);
                command.Parameters.AddWithValue("@NombrePlan", pPlan.NombrePlan);
                command.Parameters.AddWithValue("@Familiar", pPlan.Familiar);
                command.Parameters.AddWithValue("@CostoPlan", pPlan.CostoPlan);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (row > 0)
                    oPlan = GetPlanByID(pPlan.ID);

                return oPlan;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL de plan 
        /// para eliminar la cobertura del plan en la tabla 
        /// intermedia (1 a muchos) en la base de datos
        /// </summary>
        /// <param name="pCobertura"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar la cobertura del plan</returns>
        public bool DeleteCobertura(Cobertura pCobertura)
        {
            log4net.Config.XmlConfigurator.Configure();

            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();

            string sql = @"Delete  from  TipoPlanCobertura where CoberturaID = @ID";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@ID", pCobertura.IDCobertura);
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
