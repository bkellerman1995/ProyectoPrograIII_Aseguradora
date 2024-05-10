using ProyectoPrograIII.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Interfaces
{
    interface IDALFamiliares
    {
        /// <summary>
        ///Método utilizado por la capa DAL de Familiares
        /// para salvar al familiar de un cliente en 
        /// tabla intermedia (muchos a muchos) en la Base de Datos
        /// </summary>
        /// <param name="pCliente"></param>
        /// <param name="pFamiliar"></param>
        void SaveFamiliarCliente(Cliente pCliente, Familiares pFamiliar);

        /// <summary>
        ///Metodo utilizada por la capa DAL de Familiares
        /// para retornar el familiar de un cliente
        /// usando como filtro el ID (identificación) del familiar (llave primaria) 
        /// </summary>
        /// <param name="pIDFamiliar"></param>
        /// <returns>objeto (entity) Familiares<</returns>
        Familiares GetFamiliarByID(string pIDFamiliar);

        /// <summary>
        ///Método utilizado por la capa DAL de Familiares
        /// para eliminar el familiar de un cliente en la Base de Datos
        /// </summary>
        /// <param name="pFamiliar"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar el familiar</returns>
        bool DeleteFamiliarCliente(Familiares pFamiliar);

        /// <summary>
        /// Método utilizado por la capa DAL de Familiares 
        /// para retornar todos los familiares
        /// almacenados en la base de datos 
        /// </summary>
        /// <returns>Lista de tipo Familiares (entity)</returns>
        List<Familiares> GetAllFamiliares();

        /// <summary>
        ///Método utilizado por la capa DAL de tarjeta
        /// para salvar al familiar en la Base de Datos
        /// </summary>
        /// <param name="pFamiliar"></param>
        /// <returns>objeto (entity) Familiares</returns>
        Familiares SaveFamiliar(Familiares pFamiliar);

        /// <summary>
        /// Método utilizado por la capa DAL de Familiares 
        /// para retornar todos los familiares de UN CLIENTE
        /// almacenados en la base de datos 
        /// </summary>
        /// <param name="pCliente"></param>
        /// <returns>Lista de tipo Familiares (entity)</returns>
        List<Familiares> GetAllFamiliaresCliente(Cliente pCliente);
    }
}
