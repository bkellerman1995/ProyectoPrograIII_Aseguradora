using ProyectoPrograIII.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Interfaces
{
    interface IBLLImpuesto
    {
        /// <summary>
        /// Método utilizado por la capa BLL de Impuesto 
        /// para retornar todos los IVAs (impuestos) 
        /// almacenados en la base de datos 
        /// </summary>
        /// <returns>Lista de tipo impuesto (BLL)</returns>
        List<Impuesto> GEtAllImpuesto();

        /// <summary>
        ///Método utilizado por la capa BLL de Impuesto 
        /// para salvar el Impuesto en la Base de Datos
        /// </summary>
        /// <param name="pImpuesto"></param>
        /// <returns>objeto (BLL) BLLImpuesto</returns>
        Impuesto SaveImpuesto (Impuesto pImpuesto);

        /// <summary>
        ///Método utilizado por la capa BLL de Impuesto 
        /// para actualizar el Impuesto en la Base de Datos
        /// </summary>
        /// <param name="pImpuesto"></param>
        /// <returns>objeto (BLL) BLLImpuesto</returns>
        Impuesto UpdateImpuesto (Impuesto pImpuesto);

        /// <summary>
        ///Metodo utilizada por la capa BLL de Impuesto 
        /// para retornar el Impuesto de la base de datos
        /// usando como filtro el porcentaje
        /// </summary>
        /// <param name="pPocentaje"></param>
        /// <returns>objeto (BLL) BLLImpuesto</returns>
        Impuesto GetImpuestoByID(int pPocentaje);

        /// <summary>
        ///Método utilizado por la capa DAL de Impuesto
        /// para eliminar el Impuesto de la base de datos
        /// recibiendo como parámetro el porcentaje de impuesto 
        /// </summary>
        /// <param name="porcentaje"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar el impuesto</returns>
        bool DeleteImpuesto (int porcentaje);

    }
}
