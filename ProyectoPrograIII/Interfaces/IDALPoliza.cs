using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrograIII.Layers.Entities;

namespace ProyectoPrograIII.Interfaces
{
    interface IDALPoliza
    {
        /// <summary>
        ///Método utilizado por la capa DAL de póliza 
        /// para retornar la póliza  de la base de datos
        /// usando como filtro el ID (llave primaria)
        /// </summary>
        /// <param name="pID"></param>
        /// <returns>objeto (entity) Póliza</returns>
        Poliza GetPolizaByID (string pID);

        /// <summary>
        ///Método utilizado por la capa DAL de póliza 
        /// para retornar todas las pólizas de la base de datos
        /// </summary>
        /// <returns>Lista de objetos tipo Póliza</returns>
        List<Poliza> GetAllPoliza ();

        /// <summary>
        ///Método utilizado por la capa DAL de póliza 
        /// para salvar la póliza en la base de datos
        /// </summary>
        /// <param name="pPoliza"></param>
        /// <returns>objeto (entity) Póliza</returns>
        Poliza SavePoliza(Poliza pPoliza);

        /// <summary>
        ///Método utilizado por la capa DAL de póliza 
        /// para actualizar la póliza en la base de datos
        /// </summary>
        /// <param name="pPoliza"></param>
        /// <returns>objeto (entity) Póliza</returns>
        Poliza UpdatePoliza(Poliza pPoliza);

        /// <summary>
        ///Método utilizado por la capa DAL de póliza 
        /// para eliminar la póliza en la base de datos
        /// recibiendo como parámetro el ID (llave primaria)
        /// </summary>
        /// <param name="pPoliza"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar la póliza</returns>
        bool DeletePoliza(string pID);
    }
}
