using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrograIII.Layers.Entities;

namespace ProyectoPrograIII.Interfaces
{
    interface IDALCobertura
    {
        /// <summary>
        ///Metodo utilizada por la capa DAL de cobertura
        /// para retornar la cobertura de la base de datos
        /// usando como filtro el ID de cobertura(llave primaria) 
        /// </summary>
        /// <param name="pID"></param>
        /// <returns>objeto (entity) Cobertura</returns>
        Cobertura GetCoberturabyID(string pID);

        /// <summary>
        /// Método utilizado por la capa DAL de cobertura 
        /// para retornar una lista con todas las coberturas
        /// almacenadas en la base de datos 
        /// </summary>
        /// <returns>Lista de tipo coberturas</returns>
        List<Cobertura> GetAllCobertura();

        /// <summary>
        ///Método utilizado por la capa DAL de cobertura
        /// para salvar a la cobertura en la Base de Datos
        /// </summary>
        /// <param name="pCobertura"></param>
        /// <returns>objeto (entity) Cobertura</returns>
        Cobertura SaveCobertura(Cobertura pCobertura);

        /// <summary>
        ///Método utilizado por la capa DAL de cobertura
        /// para actualizar la cobertura en la Base de Datos
        /// </summary>
        /// <param name="pCobertura"></param>
        /// <returns>objeto (entity) Cobertura</returns>
        Cobertura UpdateCobertura(Cobertura pCobertura);

        /// <summary>
        ///Método utilizado por la capa DAL de cobertura
        /// para eliminar la cobertura de la base de datos
        /// recibiendo como parámetro el ID de cobertura (llave primaria) 
        /// </summary>
        /// <param name="pID"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar la cobertura</returns>
        bool DeleteCobertura(string pID);
    }
}
