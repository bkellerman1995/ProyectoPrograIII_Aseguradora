using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrograIII.Interfaces;
using ProyectoPrograIII.Layers.Entities;
using ProyectoPrograIII.Layers.DAL;

namespace ProyectoPrograIII.Layers.BLL
{
    public class BLLPais : IBLLPais
    {
        /// <summary>
        ///Metodo utilizada por la capa BLL de país 
        /// para retornar todos los países almacenados
        /// en la base de datos
        /// </summary>
        /// <returns>Lista de tipo país (BLL)</returns>
        public List<Pais> GetAllPaises()
        {
            IDALPais dalPais = new DALPais();
            return dalPais.GetAllPaises();
        }

        /// <summary>
        ///Metodo utilizada por la capa BLL de país 
        /// para retornar el país de la base de datos
        /// usando como filtro el ID del país(llave primaria) 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>Objeto (BLL) tipo BLLPais</returns>
        public Pais GetPaisByID(string pIDPais)
        {
            IDALPais dalPais = new DALPais();
            return dalPais.GetPaisByID(pIDPais);
        }
    }
}
