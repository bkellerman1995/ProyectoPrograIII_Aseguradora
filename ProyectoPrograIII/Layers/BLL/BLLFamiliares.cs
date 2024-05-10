using ProyectoPrograIII.Interfaces;
using ProyectoPrograIII.Layers.DAL;
using ProyectoPrograIII.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Layers.BLL
{
    public class BLLFamiliares : IBLLFamiliares
    {
        /// <summary>
        ///Método utilizado por la capa BLL de Familiares
        /// para eliminar el familiar de un cliente en la Base de Datos
        /// </summary>
        /// <param name="pFamiliar"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar el familiar</returns>
        public bool DeleteFamiliarCliente(Familiares pFamiliar)
        {
            IDALFamiliares _DALFamiliares = new DALFamiliares();

            return _DALFamiliares.DeleteFamiliarCliente(pFamiliar);
        }

        /// <summary>
        ///Metodo utilizada por la capa BLL de Familiares
        /// para retornar el familiar de un cliente
        /// usando como filtro el ID (identificación) del familiar  (llave primaria) 
        /// </summary>
        /// <param name="pIDFamiliar"></param>
        /// <returns>objeto (BLL) BLLFamiliares<</returns>
        public List<Familiares> GetAllFamiliares()
        {
            IDALFamiliares _DALFamiliares = new DALFamiliares();

            return _DALFamiliares.GetAllFamiliares();
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
            IDALFamiliares _DALFamiliares = new DALFamiliares();

            return _DALFamiliares.GetAllFamiliaresCliente(pCliente);
        }

        /// <summary>
        ///Metodo utilizada por la capa BLL de Familiares
        /// para retornar el familiar de un cliente
        /// usando como filtro el ID (identificación) del familiar  (llave primaria) 
        /// </summary>
        /// <param name="pIDFamiliar"></param>
        /// <returns>objeto (BLL) BLLFamiliares<</returns>
        public Familiares GetFamiliarByID(string pIDFamiliar)
        {
            IDALFamiliares _DALFamiliares = new DALFamiliares();

            return _DALFamiliares.GetFamiliarByID(pIDFamiliar);
        }

        /// <summary>
        ///Método utilizado por la capa BLL de Familiares
        /// para salvar al familiar en la Base de Datos
        /// </summary>
        /// <param name="pFamiliar"></param>
        /// <returns>objeto (BLL) BLLFamiliares</returns>
        public Familiares SaveFamiliar(Familiares pFamiliar)
        {
            IDALFamiliares _DALFamiliares = new DALFamiliares();

            return _DALFamiliares.SaveFamiliar(pFamiliar);
        }

        /// <summary>
        ///Método utilizado por la capa BLL de Familiares
        /// para salvar al familiar de un cliente en 
        /// tabla intermedia (muchos a muchos) en la Base de Datos
        /// </summary>
        /// <param name="pCliente"></param>
        /// <param name="pFamiliar"></param>
        public void SaveFamiliarCliente(Cliente pCliente, Familiares pFamiliar)
        {
            IDALFamiliares _DALFamiliares = new DALFamiliares();

            _DALFamiliares.SaveFamiliarCliente(pCliente, pFamiliar);
        }
    }
}
