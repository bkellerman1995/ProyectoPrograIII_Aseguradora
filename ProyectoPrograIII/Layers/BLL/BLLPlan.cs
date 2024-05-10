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
    public class BLLPlan : IBLLPlan
    {
        /// <summary>
        ///Método utilizado por la capa BLL de plan 
        /// para eliminar la cobertura del plan en la tabla 
        /// intermedia (1 a muchos) en la base de datos
        /// </summary>
        /// <param name="pCobertura"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar la cobertura del plan</returns>
        public bool DeleteCobertura(Cobertura pCobertura)
        {
            IDALPlan _DALPlan = new DALPlan();

            return _DALPlan.DeleteCobertura(pCobertura);
        }

        /// <summary>
        ///Método utilizado por la capa BLL de plan
        /// para eliminar el plan en la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar el plan</returns>
        public bool DeletePlan(string pIdPlan)
        {
            IDALPlan _DALPlan = new DALPlan();

            return _DALPlan.DeletePlan(pIdPlan);
        }


        /// <summary>
        ///Método utilizado por la capa BLL de plan
        /// para retornar todas las coberturas del plan 
        /// enviado como parámetro desde la base de datos
        /// </summary>
        /// <param name="pPlan"></param>
        /// <returns>Lista de objetos tipo Cobertura (BLL)</returns>
        public List<Cobertura> GetAllCoberturasPlan(Plan pPlan)
        {
            IDALPlan _DALPlan = new DALPlan();
            return _DALPlan.GetAllCoberturasPlan(pPlan);
        }

        /// <summary>
        ///Método utilizado por la capa BLL de plan
        /// para retornar todas los planes de la base de datos
        /// </summary>
        /// <returns>Lista de objetos tipo Plan (BLL)</returns>
        public List<Plan> GetAllPlan()
        {
            IDALPlan _DALPlan = new DALPlan();
            return _DALPlan.GetAllPlan();
        }

        /// <summary>
        ///Método utilizado por la capa BLL de plan
        /// para retornar el plan de la base de datos
        /// usando como filtro el ID (llave primaria)
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>objeto (BLL) BLLPlan</returns>
        public Plan GetPlanbyID(string pIDPlan)
        {
            IDALPlan _DALPlan = new DALPlan();
            return _DALPlan.GetPlanByID(pIDPlan);
        }

        /// <summary>
        ///Método utilizado por la capa BLL de plan
        /// para salvar la cobertura del plan en la tabla intermedia (1 a muchos) 
        /// en la base de datos
        /// <param name="plan"></param>
        /// <param name="pCobertura"></param>
        public void SaveCoberturaPlan(Plan pPlan,Cobertura pCobertura)
        {
            IDALPlan _DALPlan = new DALPlan();
            _DALPlan.SaveCobertura(pPlan, pCobertura);
        }

        /// <summary>
        ///Método utilizado por la capa BLL de plan
        /// para salvar el plan en la base de datos
        /// </summary>
        /// <param name="pPlan"></param>
        /// <returns>objeto (BLL) BLLPlan</returns>
        public Plan SavePlan(Plan pPlan)
        {
            IDALPlan _DALPlan = new DALPlan();
            //Task<Cliente> oCliente = null;

            Plan oPlan = null;

            if (_DALPlan.GetPlanByID(pPlan.ID) == null)
                oPlan = _DALPlan.SavePlan(pPlan);
            else
                oPlan = _DALPlan.UpdatePlan (pPlan);

            return oPlan;
        }

        /// <summary>
        ///Método utilizado por la capa BLL de plan
        /// para actualizar el plan en la base de datos
        /// </summary>
        /// <param name="pPlan"></param>
        /// <returns>objeto (BLL) BLLPlan</returns>
        public Plan UpdatePlan(Plan pPlan)
        {
            IDALPlan _DALPlan = new DALPlan();
            return _DALPlan.UpdatePlan(pPlan);
        }
    }
}
