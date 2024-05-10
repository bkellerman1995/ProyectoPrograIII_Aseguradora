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
    class BLLCliente : IBLLCliente
    {
        /// <summary>
        ///Metodo utilizada por la capa BLL de Cliente
        /// para retornar el cliente de la base de datos
        /// usando como filtro el ID del cliente(llave primaria) 
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>objeto (BLL) BLLCliente</returns>
        public Cliente GetClienteById(int pIdCliente)
        {
            IDALCliente _DALCliente = new DALCliente();
            return _DALCliente.GetClienteById(pIdCliente);
        }

        /// <summary>
        /// Método utilizado por la capa BLL de Cliente 
        /// para retornar una lista con todos los clientes
        /// almacenados en la base de datos 
        /// </summary>
        /// <returns>Lista de objetos tipo Cliente</returns>
        public List<Cliente> GetAllCliente()
        {
            IDALCliente _DALCliente = new DALCliente();
            return _DALCliente.GetAllCliente();
        }

        /// <summary>
        ///Método utilizado por la capa BLL de Cliente
        /// para salvar el cliente en la Base de Datos
        /// </summary>
        /// <param name="pCliente"></param>
        /// <returns>objeto (BLL) BLLCliente</returns>
        public Cliente SaveCliente(Cliente pCliente)
        {
            IDALCliente _DALCliente = new DALCliente();
            //Task<Cliente> oCliente = null;

            Cliente oCliente = null;

            if (_DALCliente.GetClienteById(pCliente.ID) == null)
                oCliente = _DALCliente.SaveCliente(pCliente);
            else
                oCliente = _DALCliente.UpdateCliente(pCliente);

            return oCliente;
        }

        /// <summary>
        ///Método utilizado por la capa BLL de Cliente
        /// para eliminar el cliente de la base de datos
        /// </summary>
        /// <param name="pCliente"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar el cliente</returns>
        public Task<bool> DeleteCliente(Cliente pCliente)
        {
            IDALCliente _DALCliente = new DALCliente();
            IBLLFamiliares familiarBLL = new BLLFamiliares();
            if (familiarBLL.GetAllFamiliaresCliente(pCliente).Count > 0)
            {
                foreach (var familiar in familiarBLL.GetAllFamiliaresCliente(pCliente))
                {
                    familiarBLL.DeleteFamiliarCliente(familiar);
                }
            }

            return _DALCliente.DeleteCliente(pCliente);

        }

        /// <summary>
        ///Método utilizado por la capa BLL de Cliente
        ///para actualizar el cliente en la Base de Datos
        /// </summary>
        /// <param name="pCliente"></param>
        /// <returns>objeto (BLL) BLLCliente</returns>
        public Cliente UpdateCliente(Cliente pCliente)
        {
            IDALCliente clienteDAL = new DALCliente();
            return clienteDAL.UpdateCliente(pCliente);
        }
    }
}
