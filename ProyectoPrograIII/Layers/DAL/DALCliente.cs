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

namespace ProyectoPrograIII.Layers.DAL
{
    public class DALCliente : IDALCliente
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        ///Metodo utilizada por la capa DAL de Cliente
        /// para retornar el cliente de la base de datos
        /// usando como filtro el ID del cliente(llave primaria) 
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>objeto (entity) Cliente</returns>
        public Cliente GetClienteById(int pId)
        {
            log4net.Config.XmlConfigurator.Configure();
            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            IDataReader reader = null;
            Cliente oCliente = null;

            try
            {
                command.CommandText = @"select * from Cliente with (rowlock) where ID = @ID";
                command.Parameters.AddWithValue("@ID", pId);
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        oCliente = new Cliente();
                        oCliente.ID = int.Parse(reader["ID"].ToString());
                        oCliente.Nombre = reader["Nombre"].ToString();
                        oCliente.Apellido1 = reader["Apellido1"].ToString();
                        oCliente.Apellido2 = reader["Apellido2"].ToString();
                        oCliente.Sexo = int.Parse(reader["Sexo"].ToString());
                        oCliente.FechaNacimiento = DateTime.Parse(reader["FechaNacimiento"].ToString());
                        oCliente.Foto = (byte[])reader["Foto"];
                        oCliente.NumTelefono = reader["NumTelefono"].ToString();
                        oCliente.Direccion = reader["Direccion"].ToString();
                        IDALPais extraerPais = new DALPais();

                        foreach (var pais in extraerPais.GetAllPaises())
                        {
                            if (string.Equals(reader["IDPais"], pais.ID))
                                oCliente.Pais = pais;
                        }

                        oCliente.CorreoElectronico = reader["CorreoElectronico"].ToString();
                        oCliente.Cedula = (byte[])reader["Cedula"];
                    }
                }

                return oCliente;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        /// Método utilizado por la capa DAL de Cliente 
        /// para retornar una lista con todos los clientes
        /// almacenados en la base de datos 
        /// </summary>
        /// <returns>Lista de objetos tipo Cliente</returns>
        public List<Cliente> GetAllCliente()
        {
            log4net.Config.XmlConfigurator.Configure();
            try
            {
                List<Cliente> list = new List<Cliente>();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "usp_SELECT_Cliente_All";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        Cliente oCliente = new Cliente();

                        oCliente.ID = int.Parse(reader["ID"].ToString());
                        oCliente.Nombre = reader["Nombre"].ToString();
                        oCliente.Apellido1 = reader["Apellido1"].ToString();
                        oCliente.Apellido2 = reader["Apellido2"].ToString();
                        oCliente.Sexo = int.Parse(reader["Sexo"].ToString());
                        oCliente.FechaNacimiento = DateTime.Parse(reader["FechaNacimiento"].ToString());
                        oCliente.Foto = (byte[])reader["Foto"];
                        oCliente.NumTelefono = reader["NumTelefono"].ToString();
                        oCliente.Direccion = reader["Direccion"].ToString();

                        IDALPais extraerPais = new DALPais();

                        foreach (var pais in extraerPais.GetAllPaises())
                        {
                            if (string.Equals(reader["IDPais"], pais.ID))
                                oCliente.Pais = pais;
                        }

                        oCliente.CorreoElectronico = reader["CorreoElectronico"].ToString();
                        oCliente.Cedula = (byte[])reader["Cedula"];

                        list.Add(oCliente);
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
        ///Método utilizado por la capa DAL de Cliente
        /// para salvar el cliente en la Base de Datos
        /// </summary>
        /// <param name="pCliente"></param>
        /// <returns>objeto (entity) Cliente</returns>
        public Cliente SaveCliente(Cliente pCliente)
        {
            log4net.Config.XmlConfigurator.Configure();
            Cliente oCliente = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"Insert into Cliente (ID,Nombre,Apellido1,Apellido2,Sexo,FechaNacimiento,Foto,NumTelefono,Direccion,IDPais,CorreoElectronico,Cedula) 
            values (@IdCliente,@Nombre,@Apellido1,@Apellido2,@Sexo,@FechaNacimiento,@Foto,@NumTelefono,@Direccion,@IDPais,@CorreoElectronico,@Cedula)";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@IdCliente", pCliente.ID);
                command.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
                command.Parameters.AddWithValue("@Apellido1", pCliente.Apellido1);
                command.Parameters.AddWithValue("@Apellido2", pCliente.Apellido2);
                command.Parameters.AddWithValue("@Sexo", pCliente.Sexo);
                command.Parameters.AddWithValue("@FechaNacimiento", pCliente.FechaNacimiento);
                command.Parameters.AddWithValue("@Foto", pCliente.Foto);
                command.Parameters.AddWithValue("@NumTelefono", pCliente.NumTelefono);
                command.Parameters.AddWithValue("@Direccion", pCliente.Direccion);
                command.Parameters.AddWithValue("@IDPais", pCliente.Pais.ID);
                command.Parameters.AddWithValue("@CorreoElectronico", pCliente.CorreoElectronico);
                command.Parameters.AddWithValue("@Cedula", pCliente.Cedula);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (row > 0)
                        oCliente = this.GetClienteById(pCliente.ID);
                }

                return oCliente;

            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }

        }

        /// <summary>
        ///Método utilizado por la capa DAL de Cliente
        ///para actualizar el cliente en la Base de Datos
        /// </summary>
        /// <param name="pCliente"></param>
        /// <returns>objeto (entity) Cliente</returns>
        public Cliente UpdateCliente(Cliente pCliente)
        {
            log4net.Config.XmlConfigurator.Configure();
            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            Cliente oCliente = null;
            string sql = @"Update Cliente SET Nombre=@Nombre,Apellido1=@Apellido1,Apellido2=@Apellido2,Sexo=@Sexo,FechaNacimiento=@FechaNacimiento,Foto=@Foto,NumTelefono=@NumTelefono,Direccion=@Direccion,IDPais=@IDPais,CorreoElectronico=@CorreoElectronico,Cedula=@Cedula Where (ID = @ID)";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@ID", pCliente.ID);
                command.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
                command.Parameters.AddWithValue("@Apellido1", pCliente.Apellido1);
                command.Parameters.AddWithValue("@Apellido2", pCliente.Apellido2);
                command.Parameters.AddWithValue("@Sexo", pCliente.Sexo);
                command.Parameters.AddWithValue("@FechaNacimiento", pCliente.FechaNacimiento);
                command.Parameters.AddWithValue("@Foto", pCliente.Foto);
                command.Parameters.AddWithValue("@NumTelefono", pCliente.NumTelefono);
                command.Parameters.AddWithValue("@Direccion", pCliente.Direccion);
                command.Parameters.AddWithValue("@IDPais", pCliente.Pais.ID);
                command.Parameters.AddWithValue("@CorreoElectronico", pCliente.CorreoElectronico);
                command.Parameters.AddWithValue("@Cedula", pCliente.Cedula);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (row > 0)
                    oCliente = GetClienteById(pCliente.ID);

                return oCliente;
            }
            catch (Exception er)
            {
                log.Error(er.Message.ToString());
                throw;
            }
        }

        /// <summary>
        ///Método utilizado por la capa DAL de Cliente
        /// para eliminar el cliente de la base de datos
        /// </summary>
        /// <param name="pCliente"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar el cliente</returns>
        public async Task <bool> DeleteCliente(Cliente cliente)
        {
            log4net.Config.XmlConfigurator.Configure();
            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();

            string command1 = @"Delete  from  Cliente where ID = @ID";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@ID", cliente.ID);
                command.CommandText = command1;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    row = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
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
