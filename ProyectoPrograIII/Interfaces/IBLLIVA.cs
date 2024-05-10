using ProyectoPrograIII.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Interfaces
{
    interface IBLLIVA
    {
        Impuesto GetIVAByID (int pIdCliente);
        //Task<IEnumerable<Cliente>> GetAllCliente();
        List<Impuesto> GetAllImpuesto();

        List<Cliente> GetClienteByFilter(string pDescripcion);

        //Task<Cliente> SaveCliente(Cliente pCliente);
        Cliente SaveCliente(Cliente pCliente);
        //Task<bool> DeleteCliente(string pId);
        Cliente UpdateCliente(Cliente pUsuario);
        bool DeleteCliente(int pId);
    }
}
