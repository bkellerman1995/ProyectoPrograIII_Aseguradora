using ProyectoPrograIII.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Interfaces
{
    interface IBLLTarjeta
    {
        /// <summary>
        /// Método utilizado por la capa BLL de tarjeta 
        /// para retornar una lista con todas las tarjetas
        /// almacenadas en la base de datos 
        /// </summary>
        /// <returns>Lista de tipo tarjeta (BLLTarjeta)</returns>
        List<Tarjeta> GetAllTarjeta();

        /// <summary>
        ///Metodo utilizada por la capa BLL de tarjeta 
        /// para retornar la tarjeta de la base de datos
        /// usando como filtro el número de tarjeta (llave primaria) 
        /// </summary>
        /// <param name="pIdTarjeta"></param>
        /// <returns>objeto (BLL) BLLTarjeta</returns>
        Tarjeta GetTarjetaById(string pIdTarjeta);

        /// <summary>
        ///Método utilizado por la capa BLL de tarjeta
        /// para salvar a la tarjeta en la Base de Datos
        /// </summary>
        /// <param name="pTarjeta"></param>
        /// <returns>objeto (BLL) BLLTarjeta</returns>
        Tarjeta SaveTarjeta(Tarjeta pTarjeta);

        /// <summary>
        ///Método utilizado por la capa BLL de tarjeta
        /// para eliminar la tarjeta de la base de datos
        /// recibiendo como parámetro el número de tarjeta (llave primaria) 
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar la tarjeta</returns>
        bool DeleteTarjeta(string pId);
    }
}
