﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrograIII.Layers.Entities;

namespace ProyectoPrograIII.Interfaces
{
    interface IBLLCliente
    {
        /// <summary>
        ///Metodo utilizada por la capa BLL de Cliente
        /// para retornar el cliente de la base de datos
        /// usando como filtro el ID del cliente(llave primaria) 
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>objeto (BLL) BLLCliente</returns>
        Cliente GetClienteById(int pIdCliente);

        /// <summary>
        /// Método utilizado por la capa BLL de Cliente 
        /// para retornar una lista con todos los clientes
        /// almacenados en la base de datos 
        /// </summary>
        /// <returns>Lista de objetos tipo Cliente</returns>
        List<Cliente> GetAllCliente();

        /// <summary>
        ///Método utilizado por la capa BLL de Cliente
        /// para salvar el cliente en la Base de Datos
        /// </summary>
        /// <param name="pCliente"></param>
        /// <returns>objeto (BLL) BLLCliente</returns>
        Cliente SaveCliente(Cliente pCliente);

        /// <summary>
        ///Método utilizado por la capa BLL de Cliente
        ///para actualizar el cliente en la Base de Datos
        /// </summary>
        /// <param name="pCliente"></param>
        /// <returns>objeto (BLL) BLLCliente</returns>
        Cliente UpdateCliente (Cliente pUsuario);

        /// <summary>
        ///Método utilizado por la capa BLL de Cliente
        /// para eliminar el cliente de la base de datos
        /// </summary>
        /// <param name="pCliente"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar el cliente</returns>
        Task<bool> DeleteCliente(Cliente pCliente);
    }
}
