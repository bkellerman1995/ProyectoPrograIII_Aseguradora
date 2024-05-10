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
    public class BLLCobertura : IBLLCobertura
    {
        /// <summary>
        ///Método utilizado por la capa BLL de cobertura
        /// para eliminar la cobertura de la base de datos
        /// recibiendo como parámetro el ID de cobertura (llave primaria) 
        /// </summary>
        /// <param name="pID"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar la cobertura</returns>
        public bool DeleteCobertura(string pId)
        {
            IDALCobertura _DALCobertura = new DALCobertura();

            return _DALCobertura.DeleteCobertura(pId);
        }

        /// <summary>
        /// Método utilizado por la capa BLL de cobertura 
        /// para retornar una lista con todas las coberturas
        /// almacenadas en la base de datos 
        /// </summary>
        /// <returns>Lista de tipo coberturas</returns>
        public List<Cobertura> GetAllCobertura()
        {
            IDALCobertura _DALCobertura = new DALCobertura();

            return _DALCobertura.GetAllCobertura();
        }

        /// <summary>
        ///Metodo utilizada por la capa BLL de cobertura
        /// para retornar la cobertura de la base de datos
        /// usando como filtro el ID de cobertura(llave primaria) 
        /// </summary>
        /// <param name="pID"></param>
        /// <returns>objeto (BLL) BLLCobertura</returns>
        public Cobertura GetCoberturabyID(string pId)
        {
            IDALCobertura _DALCobertura = new DALCobertura();

            return _DALCobertura.GetCoberturabyID(pId);
        }

        /// <summary>
        ///Método utilizado por la capa BLL de cobertura
        /// para salvar a la cobertura en la Base de Datos
        /// </summary>
        /// <param name="pCobertura"></param>
        /// <returns>objeto (BLL) BLLCobertura</returns>
        public Cobertura SaveCobertura(Cobertura pCobertura)
        {
            IDALCobertura _DALCobertura = new DALCobertura();
            //Task<Cobertura> oCobertura = null;

            Cobertura oCobertura = null;

            if (_DALCobertura.GetCoberturabyID(pCobertura.IDCobertura) == null)
                oCobertura = _DALCobertura.SaveCobertura(pCobertura);
            else
                oCobertura = _DALCobertura.UpdateCobertura(pCobertura);

            return oCobertura;
        }

        /// <summary>
        ///Método utilizado por la capa BLL de cobertura
        /// para actualizar la cobertura en la Base de Datos
        /// </summary>
        /// <param name="pCobertura"></param>
        /// <returns>objeto (BLL) BLLCobertura</returns>
        public Cobertura UpdateCobertura(Cobertura pCobertura)
        {
            IDALCobertura _DALCobertura = new DALCobertura();
            return _DALCobertura.UpdateCobertura(pCobertura);
        }
    }
}
