using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrograIII.Interfaces;
using ProyectoPrograIII.Layers.Entities;

namespace ProyectoPrograIII.Layers.BLL
{
    public class BLLPoliza : IBLLPoliza
    {
        /// <summary>
        ///Método utilizado por la capa BLL de póliza 
        /// para eliminar la póliza en la base de datos
        /// recibiendo como parámetro el ID (llave primaria)
        /// </summary>
        /// <param name="pPoliza"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar la póliza</returns>
        public bool DeletePoliza(string pId)
        {
            IDALPoliza _DALPoliza = new DALPoliza();

            return _DALPoliza.DeletePoliza(pId);
        }

        /// <summary>
        ///Método utilizado por la capa BLL de póliza 
        /// para retornar todas las pólizas de la base de datos
        /// </summary>
        /// <returns>Lista de objetos tipo BLLPoliza</returns>
        public List<Poliza> GetAllPoliza()
        {
            IDALPoliza _DALPoliza = new DALPoliza();

            return _DALPoliza.GetAllPoliza();
        }

        /// <summary>
        ///Método utilizado por la capa BLL de póliza 
        /// para retornar la póliza  de la base de datos
        /// usando como filtro el ID (llave primaria)
        /// </summary>
        /// <param name="pID"></param>
        /// <returns>objeto (BLL) BLLPoliza</returns>
        public Poliza GetPolizaByID(string pIdPoliza)
        {
            IDALPoliza _DALPoliza = new DALPoliza();
            return _DALPoliza.GetPolizaByID(pIdPoliza);
        }

        /// <summary>
        ///Método utilizado por la capa BLL de póliza 
        /// para salvar la póliza en la base de datos
        /// </summary>
        /// <param name="pPoliza"></param>
        /// <returns>objeto (BLL) BLLPoliza</returns>
        public Poliza SavePoliza(Poliza pPoliza)
        {
            IDALPoliza _DALPoliza = new DALPoliza();
            //Task<Poliza> oPoliza = null;

            Poliza oPoliza = null;

            if (_DALPoliza.GetPolizaByID(pPoliza.ID) == null)
                oPoliza = _DALPoliza.SavePoliza(pPoliza);
            else
                oPoliza = _DALPoliza.UpdatePoliza(pPoliza);

            return oPoliza;
        }

        /// <summary>
        ///Método utilizado por la capa BLL de póliza 
        /// para actualizar la póliza en la base de datos
        /// </summary>
        /// <param name="pPoliza"></param>
        /// <returns>objeto (BLL) BLLPoliza</returns>
        public Poliza UpdatePoliza(Poliza pPoliza)
        {
            IDALPoliza _DALPoliza = new DALPoliza();
            return _DALPoliza.UpdatePoliza(pPoliza);
        }
    }
}
