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
    public class DALFactura : IDALFactura
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        ///Método utilizado por la capa DAL de factura
        /// para eliminar la factura de la base de datos
        /// recibiendo como parámetro el número de factura (llave primaria) 
        /// </summary>
        /// <param name="pFacturaID"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar la factura</returns>
        public bool DeleteFactura(int pFacturaID)
        {
            log4net.Config.XmlConfigurator.Configure();
            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();

            string command1 = @"Delete  from  FacturaEncabezado where IDFactura = @ID";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@ID", pFacturaID);
                command.CommandText = command1;
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
        /// Método utilizado por la capa DAL de factura
        /// para obtener la lista de encabezados de factura
        /// desde la base de datos
        /// </summary>
        /// <returns>Lista de facturas</returns>
        public List<FacturaEncabezado> GetAllFactura()
        {
            log4net.Config.XmlConfigurator.Configure();
            try
            {
                List<FacturaEncabezado> list = new List<FacturaEncabezado>();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "usp_SELECT_FacturaEncabezado_All";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        FacturaEncabezado oFacturaEncabezado = new FacturaEncabezado();

                        oFacturaEncabezado.IdFactura = int.Parse(reader["IDFactura"].ToString());

                        IDALTarjeta extraerTarjeta = new DALTarjeta();

                        foreach (var tarjeta in extraerTarjeta.GetAllTarjeta())
                        {
                            if (string.Equals(reader["IDTarjeta"].ToString(), tarjeta.IdTarjeta))
                                oFacturaEncabezado.Tarjeta = tarjeta;
                        }

                        //oFacturaEncabezado.TarjetaNumero = reader["IDTarjeta"].ToString();

                        IDALCliente extraerCliente = new DALCliente();

                        foreach (var cliente in extraerCliente.GetAllCliente())
                        {
                            if (int.Parse(reader["IDCliente"].ToString()) == cliente.ID)
                                oFacturaEncabezado.Cliente = cliente;
                        }

                        oFacturaEncabezado.FechaFacturacion = DateTime.Parse(reader["FechaFacturacion"].ToString());
                        oFacturaEncabezado.EstadoFactura = bool.Parse(reader["Estado"].ToString());

                        list.Add(oFacturaEncabezado);
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
        /// Método utilizado por la capa DAL de factura
        /// para obtener el número de factura actual
        /// obtenido por la secuencia (CREATE SEQUENCE) de la base de datos 
        /// </summary>
        /// <returns>valor de tipo entero con el número de factura</returns>
        public int GetCurrentNumeroFactura()
        {
            log4net.Config.XmlConfigurator.Configure();
            DataSet ds = null;
            IDbCommand command = new SqlCommand();
            int numeroFactura = 0;
            string sql = @"SELECT current_value FROM sys.sequences WHERE name = 'SequenciaNumeroFactura'  ";
            DataTable dt = null;
            try
            {

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    ds = db.ExecuteReader(command, "query");
                }

                // Extraer la tabla 
                dt = ds.Tables[0];
                //Extraer el valor que viene en el DataTable 
                numeroFactura = int.Parse(dt.Rows[0][0].ToString());
                return numeroFactura;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        /// Método utilizado por la capa DAL de factura
        /// para obtener el objeto factura desde la base de datos
        /// </summary>
        /// <param name="pNumeroFactura"></param>
        /// <returns>objeto (entity) Factura</returns>
        public FacturaEncabezado GetFactura(int pNumeroFactura)
        {
            log4net.Config.XmlConfigurator.Configure();
            FacturaEncabezado oFacturaEncabezado = new FacturaEncabezado();
            DataSet ds = null;
            IDALCliente DALCliente = new DALCliente();
            SqlCommand command = new SqlCommand();

            string sql = @"  ";


            sql = @"SELECT        FacturaEncabezado.IDFactura, FacturaEncabezado.IDTarjeta, FacturaEncabezado.IDCliente, FacturaEncabezado.FechaFacturacion, FacturaEncabezado.Estado, 
                                             FacturaEncabezado.IDTarjeta, FacturaDetalle.IDPoliza, FacturaDetalle.PrecioColones, FacturaDetalle.PrecioDolares, FacturaDetalle.Impuesto
                    FROM            FacturaEncabezado INNER JOIN
                                             FacturaDetalle ON FacturaEncabezado.IDFactura = FacturaDetalle.IDFactura
                    WHERE        (FacturaEncabezado.IDFactura = @IDFactura) ";

            try
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@IDFactura", pNumeroFactura);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    oFacturaEncabezado = new FacturaEncabezado()
                    {
                        IdFactura = int.Parse(dr["IDFactura"].ToString()),
                        TarjetaNumero = dr["IDTarjeta"].ToString(),
                        Cliente = DALCliente.GetClienteById(int.Parse(dr["IDCliente"].ToString())),
                        FechaFacturacion = DateTime.Parse(dr["FechaFacturacion"].ToString()),
                        EstadoFactura = (bool)dr["Estado"],
                    };


                    foreach (var item in ds.Tables[0].Rows)
                    {
                        FacturaDetalle oFacturaDetalle = new FacturaDetalle();
                        oFacturaDetalle.IdFactura = int.Parse(dr["IDFactura"].ToString());
                        oFacturaDetalle.IDPoliza = dr["IDPoliza"].ToString();
                        oFacturaDetalle.PrecioColones = double.Parse(dr["PrecioColones"].ToString());
                        oFacturaDetalle.PrecioDolares = double.Parse(dr["PrecioDolares"].ToString());
                        oFacturaDetalle.Impuesto = int.Parse(dr["Impuesto"].ToString());
                        oFacturaEncabezado.AddDetalle(oFacturaDetalle);
                    }
                }


                return oFacturaEncabezado;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        /// Método utilizado por la capa DAL de factura
        /// para obtener la lista de facturas por fecha (parámetro)
        /// desde la base de datos
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns>Lista de facturas filtrada por fecha</returns>
        public List<FacturaEncabezado> GetFacturasPorFecha(DateTime fecha)
        {
            log4net.Config.XmlConfigurator.Configure();
            try
            {
                List<FacturaEncabezado> list = new List<FacturaEncabezado>();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = @"select * from FacturaEncabezado with (rowlock) where FechaFacturacion = @Fecha";
                    command.Parameters.AddWithValue("@Fecha", fecha);
                    command.CommandType = CommandType.Text;
                    var reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        FacturaEncabezado oFacturaEncabezado = new FacturaEncabezado();

                        oFacturaEncabezado.IdFactura = int.Parse(reader["IDFactura"].ToString());

                        IDALTarjeta extraerTarjeta = new DALTarjeta();

                        foreach (var tarjeta in extraerTarjeta.GetAllTarjeta())
                        {
                            if (string.Equals(reader["IDTarjeta"].ToString(), tarjeta.IdTarjeta))
                                oFacturaEncabezado.Tarjeta = tarjeta;
                        }
                        
                        
                        oFacturaEncabezado.TarjetaNumero = reader["IDTarjeta"].ToString();

                        IDALCliente extraerCliente = new DALCliente();

                        foreach (var cliente in extraerCliente.GetAllCliente())
                        {
                            if (int.Parse(reader["IDCliente"].ToString()) == cliente.ID)
                                oFacturaEncabezado.Cliente = cliente;
                        }

                        oFacturaEncabezado.FechaFacturacion = DateTime.Parse(reader["FechaFacturacion"].ToString());
                        oFacturaEncabezado.EstadoFactura = bool.Parse(reader["Estado"].ToString());
                        list.Add(oFacturaEncabezado);
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
        /// Método utilizado por la capa DAL de factura
        /// para obtener el siguiente número de factura 
        /// obtenido por la secuencia (CREATE SEQUENCE) de la base de datos 
        /// </summary>
        /// <returns>valor de tipo entero con el número de siguiente factura</returns>
        public int GetNextNumeroFactura()
        {
            log4net.Config.XmlConfigurator.Configure();
            DataSet ds = null;
            IDbCommand command = new SqlCommand();
            int numeroFactura = 0;
            string sql = @"SELECT NEXT VALUE FOR SequenciaNumeroFactura";

            DataTable dt = null;
            try
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Extraer la tabla 
                dt = ds.Tables[0];
                //Extraer el valor que viene en el DataTable 
                numeroFactura = int.Parse(dt.Rows[0][0].ToString());
                return numeroFactura;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL de factura
        /// para salvar la factura en la base de datos
        /// </summary>
        /// <param name="pFactura"></param>
        /// <param name="oPoliza"></param>
        /// <returns>objeto (entity) Factura</returns>
        public FacturaEncabezado SaveFactura(FacturaEncabezado pFactura, Poliza oPoliza)
        {
            log4net.Config.XmlConfigurator.Configure();
            FacturaEncabezado oFacturaEncabezado = null;
            double row = 0;
            string comm1 = @"Insert into FacturaEncabezado (IDFactura,IDTarjeta,IDCliente,FechaFacturacion,Estado) 
                    values (@IDFactura,@IDTarjeta,@IDCliente,@FechaFacturacion,@Estado)";
            string comm2 = @"Insert into FacturaDetalle (IDFactura, IDPoliza,PrecioColones, PrecioDolares,Impuesto)
                    values (@IDFactura,@IDPoliza,@PrecioColones,@PrecioDolares,@Impuesto)";

            try
            {
                using (var db = new SqlConnection("Data Source = BRIAN22MSFT; Initial Catalog = Aseguradora; Persist Security Info = True; User ID = sa; Password = Sarah2022br,"))
                {
                    SqlTransaction trans = null;
                    db.Open();
                    trans = db.BeginTransaction();

                    foreach (var facturaDetalle in pFactura._ListaFacturaDetalle)
                    {
                        using (SqlCommand command2 = new SqlCommand(comm2, db, trans))
                        {
                            command2.Parameters.AddWithValue("@IDFactura", facturaDetalle.IdFactura);
                            command2.Parameters.AddWithValue("@IDPoliza", facturaDetalle.IDPoliza);
                            command2.Parameters.AddWithValue("@PrecioColones", facturaDetalle.PrecioColones);
                            command2.Parameters.AddWithValue("@PrecioDolares", facturaDetalle.PrecioDolares);
                            command2.Parameters.AddWithValue("@Impuesto", facturaDetalle.Impuesto);

                            command2.CommandType = CommandType.Text;
                            command2.ExecuteNonQuery();
                        }
                    }

                    using (SqlCommand command1 = new SqlCommand(comm1, db, trans))
                    {
                        command1.Parameters.AddWithValue("@IDFactura", pFactura.IdFactura);
                        command1.Parameters.AddWithValue("@IDTarjeta", pFactura.Tarjeta.IdTarjeta);
                        command1.Parameters.AddWithValue("@IDCliente", oPoliza.Cliente.ID);
                        command1.Parameters.AddWithValue("@FechaFacturacion", pFactura.FechaFacturacion);
                        command1.Parameters.AddWithValue("@Estado", pFactura.EstadoFactura);

                        command1.CommandType = CommandType.Text;
                        command1.ExecuteNonQuery();
                    }


                    trans.Commit();
                    row++;

                }

                if (row > 0)
                {
                    oFacturaEncabezado = GetFactura(pFactura.IdFactura);
                }

                return oFacturaEncabezado;
            }
            catch (Exception er) 
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL de factura
        /// para actualizar la factura en la Base de Datos
        /// </summary>
        /// <param name="pFacturaEncabezado"></param>
        /// <returns>objeto (entity) Factura</returns>
        public FacturaEncabezado UpdateEstadoFactura(FacturaEncabezado pFacturaEncabezado)
        {
            log4net.Config.XmlConfigurator.Configure();
            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            FacturaEncabezado oFacturaEncabezado = null;
            string sql = @"Update FacturaEncabezado SET Estado=@EstadoFactura Where (IDFactura = @ID)";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@ID", pFacturaEncabezado.IdFactura);
                command.Parameters.AddWithValue("@EstadoFactura", pFacturaEncabezado.EstadoFactura);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (row > 0)
                    oFacturaEncabezado = GetFactura(pFacturaEncabezado.IdFactura);

                return oFacturaEncabezado;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

    }
}




