using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrograIII.Layers.Entities;

namespace ProyectoPrograIII.Interfaces
{
    interface IDALPais
    {
        /// <summary>
        ///Metodo utilizado por la capa DAL de país 
        /// para retornar todos los países almacenados
        /// en la base de datos
        /// </summary>
        /// <returns>Lista de tipo país</returns>
        List<Pais> GetAllPaises();

        /// <summary>
        ///Metodo utilizada por la capa DAL de país
        /// para retornar el país de la base de datos
        /// usando como filtro el ID del país(llave primaria) 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>Objeto (entity) Pais</returns>
        Pais GetPaisByID(string ID);
    }
}
