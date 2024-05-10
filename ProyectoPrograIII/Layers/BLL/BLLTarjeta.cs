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
    public class BLLTarjeta : IBLLTarjeta

    {
        /// <summary>
        ///Método utilizado por la capa BLL de tarjeta
        /// para eliminar la tarjeta de la base de datos
        /// recibiendo como parámetro el número de tarjeta (llave primaria) 
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar la tarjeta</returns>
        public bool DeleteTarjeta(string pId)
        {
            IDALTarjeta _DALTarjeta = new DALTarjeta();
            return _DALTarjeta.DeleteTarjeta(pId);
        }

        /// <summary>
        /// Método utilizado por la capa BLL de tarjeta 
        /// para retornar una lista con todas las tarjetas
        /// almacenadas en la base de datos 
        /// </summary>
        /// <returns>Lista de tipo tarjeta (BLLTarjeta)</returns>
        public List<Tarjeta> GetAllTarjeta()
        {
            IDALTarjeta _DALTarjeta = new DALTarjeta();
            return _DALTarjeta.GetAllTarjeta();
        }

        /// <summary>
        ///Metodo utilizada por la capa BLL de tarjeta 
        /// para retornar la tarjeta de la base de datos
        /// usando como filtro el número de tarjeta (llave primaria) 
        /// </summary>
        /// <param name="pIdTarjeta"></param>
        /// <returns>objeto (BLL) BLLTarjeta</returns>
        public Tarjeta GetTarjetaById(string pIdTarjeta)
        {
            IDALTarjeta _DALTarjeta = new DALTarjeta();
            return _DALTarjeta.GetTarjetaById(pIdTarjeta);
        }

        /// <summary>
        ///Método utilizado por la capa BLL de tarjeta
        /// para salvar a la tarjeta en la Base de Datos
        /// </summary>
        /// <param name="pTarjeta"></param>
        /// <returns>objeto (BLL) BLLTarjeta</returns>
        public Tarjeta SaveTarjeta(Tarjeta pTarjeta)
        {
            IDALTarjeta _DALTarjeta = new DALTarjeta();
            //Task<Cliente> oCliente = null;

            Tarjeta oTarjeta = null;

            if (_DALTarjeta.GetTarjetaById(pTarjeta.IdTarjeta) == null)
                oTarjeta = _DALTarjeta.SaveTarjeta(pTarjeta);
            else
                oTarjeta = _DALTarjeta.UpdateTarjeta(pTarjeta);

            return oTarjeta;
        }
    }
}
