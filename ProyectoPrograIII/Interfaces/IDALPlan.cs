using ProyectoPrograIII.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Interfaces
{
    interface IDALPlan
    {
        /// <summary>
        ///Método utilizado por la capa DAL de plan 
        /// para retornar el plan de la base de datos
        /// usando como filtro el ID (llave primaria)
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>objeto (entity) Plan</returns>
        Plan GetPlanByID (string pId);

        /// <summary>
        ///Método utilizado por la capa DAL de plan 
        /// para retornar todas los planes de la base de datos
        /// </summary>
        /// <returns>Lista de objetos tipo Plan</returns>
        List<Plan> GetAllPlan();

        /// <summary>
        ///Método utilizado por la capa DAL de plan 
        /// para retornar todas las coberturas del plan 
        /// enviado como parámetro desde la base de datos
        /// </summary>
        /// <param name="pPlan"></param>
        /// <returns>Lista de objetos tipo Cobertura</returns>
        List<Cobertura> GetAllCoberturasPlan(Plan pPlan);

        /// <summary>
        ///Método utilizado por la capa DAL de plan 
        /// para salvar el plan en la base de datos
        /// </summary>
        /// <param name="pPlan"></param>
        /// <returns>objeto (entity) Plan</returns>
        Plan SavePlan (Plan pPlan);

        /// <summary>
        ///Método utilizado por la capa DAL de plan 
        /// para salvar la cobertura del plan en la tabla intermedia (1 a muchos) 
        /// en la base de datos
        /// <param name="plan"></param>
        /// <param name="pCobertura"></param>
        void SaveCobertura(Plan plan, Cobertura pCobertura);

        /// <summary>
        ///Método utilizado por la capa DAL de plan 
        /// para actualizar el plan en la base de datos
        /// </summary>
        /// <param name="pPlan"></param>
        /// <returns>objeto (entity) Plan</returns>
        Plan UpdatePlan(Plan pPlan);

        /// <summary>
        ///Método utilizado por la capa DAL de plan 
        /// para eliminar el plan en la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar el plan</returns>
        bool DeletePlan(string pId);

        /// <summary>
        ///Método utilizado por la capa DAL de plan 
        /// para eliminar la cobertura del plan en la tabla 
        /// intermedia (1 a muchos) en la base de datos
        /// </summary>
        /// <param name="pCobertura"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar la cobertura del plan</returns>
        bool DeleteCobertura(Cobertura pCobertura);

    }
}
