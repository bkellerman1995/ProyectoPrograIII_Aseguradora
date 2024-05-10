using ProyectoPrograIII.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Interfaces
{
    interface IDALTarjeta
    {
        /// <summary>
        /// Método utilizado por la capa DAL de tarjeta 
        /// para retornar una lista con todas las tarjetas
        /// almacenadas en la base de datos 
        /// </summary>
        /// <returns>Lista de tipo tarjeta (entity)</returns>
        List<Tarjeta> GetAllTarjeta();

        /// <summary>
        ///Metodo utilizada por la capa DAL de tarjeta
        /// para retornar la tarjeta de la base de datos
        /// usando como filtro el número de tarjeta (llave primaria) 
        /// </summary>
        /// <param name="pIdTarjeta"></param>
        /// <returns>objeto (entity) Tarjeta</returns>
        Tarjeta GetTarjetaById(string pIdTarjeta);

        /// <summary>
        ///Método utilizado por la capa DAL de tarjeta
        /// para salvar a la tarjeta en la Base de Datos
        /// </summary>
        /// <param name="pTarjeta"></param>
        /// <returns>objeto (entity) Tarjeta</returns>
        Tarjeta SaveTarjeta(Tarjeta pTarjeta);

        /// <summary>
        ///Método utilizado por la capa DAL de tarjeta
        /// para eliminar la tarjeta de la base de datos
        /// recibiendo como parámetro el número de tarjeta (llave primaria) 
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar la tarjeta</returns>
        bool DeleteTarjeta(string pId);

        /// <summary>
        ///Método utilizado por la capa DAL de tarjeta
        /// para actualizar la tarjeta en la Base de Datos
        /// </summary>
        /// <param name="pTarjeta"></param>
        /// <returns>objeto (entity) Tarjeta</returns>
        Tarjeta UpdateTarjeta(Tarjeta pTarjeta);
    }
}
