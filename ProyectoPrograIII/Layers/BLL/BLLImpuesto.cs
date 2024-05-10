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
    public class BLLImpuesto : IBLLImpuesto
    {
        /// <summary>
        ///Método utilizado por la capa DAL de Impuesto
        /// para eliminar el Impuesto de la base de datos
        /// recibiendo como parámetro el porcentaje de impuesto 
        /// </summary>
        /// <param name="porcentaje"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar el impuesto</returns>
        public bool DeleteImpuesto(int porcentaje)
        {
            IDALImpuesto _DALImpuesto = new DALImpuesto();

            return _DALImpuesto.DeleteImpuesto(porcentaje);
        }

        /// <summary>
        /// Método utilizado por la capa BLL de Impuesto 
        /// para retornar todos los IVAs (impuestos) 
        /// almacenados en la base de datos 
        /// </summary>
        /// <returns>Lista de tipo impuesto (BLL)</returns>
        public List<Impuesto> GEtAllImpuesto()
        {
            IDALImpuesto _DALImpuesto = new DALImpuesto();
            return _DALImpuesto.GEtAllImpuesto();
        }

        /// <summary>
        ///Metodo utilizada por la capa BLL de Impuesto 
        /// para retornar el Impuesto de la base de datos
        /// usando como filtro el porcentaje
        /// </summary>
        /// <param name="pPocentaje"></param>
        /// <returns>objeto (BLL) BLLImpuesto</returns>
        public Impuesto GetImpuestoByID(int pPocentaje)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///Método utilizado por la capa BLL de Impuesto 
        /// para salvar el Impuesto en la Base de Datos
        /// </summary>
        /// <param name="pImpuesto"></param>
        /// <returns>objeto (BLL) BLLImpuesto</returns>
        public Impuesto SaveImpuesto(Impuesto pImpuesto)
        {
            IDALImpuesto _DALImpuesto = new DALImpuesto();
            //Task<Impuesto> oImpuesto = null;

            return _DALImpuesto.SaveImpuesto(pImpuesto);
        }

        /// <summary>
        ///Método utilizado por la capa BLL de Impuesto 
        /// para actualizar el Impuesto en la Base de Datos
        /// </summary>
        /// <param name="pImpuesto"></param>
        /// <returns>objeto (BLL) BLLImpuesto</returns>
        public Impuesto UpdateImpuesto(Impuesto pImpuesto)
        {
            IDALImpuesto _DALImpuesto = new DALImpuesto();
            return _DALImpuesto.UpdateImpuesto(pImpuesto);
        }
    }
}
