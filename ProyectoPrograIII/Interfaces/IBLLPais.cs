using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrograIII.Layers.Entities;

namespace ProyectoPrograIII.Interfaces
{
    interface IBLLPais
    {

        /// <summary>
        ///Metodo utilizada por la capa BLL de país 
        /// para retornar todos los países almacenados
        /// en la base de datos
        /// </summary>
        /// <returns>Lista de tipo país (BLL)</returns>
        List<Pais> GetAllPaises();

        /// <summary>
        ///Metodo utilizada por la capa BLL de país 
        /// para retornar el país de la base de datos
        /// usando como filtro el ID del país(llave primaria) 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>Objeto (BLL) tipo BLLPais</returns>
        Pais GetPaisByID(string ID);
    }
}
