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
    public class DALPais : IDALPais
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        ///Metodo utilizado por la capa DAL de país 
        /// para retornar todos los países almacenados
        /// en la base de datos
        /// </summary>
        /// <returns>Lista de tipo país</returns>
        public List<Pais> GetAllPaises()
        {
            log4net.Config.XmlConfigurator.Configure();
            try
            {
                List<Pais> list = new List<Pais>();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "usp_SELECT_Paises_All";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        Pais oPais = new Pais();

                        oPais.Nombre = reader["Nombre"].ToString();
                        oPais.ID = reader["ID"].ToString();

                        list.Add(oPais);
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
        ///Metodo utilizada por la capa DAL de país
        /// para retornar el país de la base de datos
        /// usando como filtro el ID del país(llave primaria) 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>Objeto (entity) Pais</returns>
        public Pais GetPaisByID(string ID)
        {
            log4net.Config.XmlConfigurator.Configure();
            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            IDataReader reader = null;
            Pais oPais = null;
            try
            {
                command.CommandText = @"select * from Pais with (rowlock) where ID = @ID";
                command.Parameters.AddWithValue("@ID", ID);
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        oPais = new Pais();
                        oPais.Nombre = reader["Nombre"].ToString();
                        oPais.ID = reader["ID"].ToString();
                    }
                }

                return oPais;
            }
            catch (Exception er)
            {

                log.Error(er.Message.ToString());
                throw;
            }
        }
    }
}
