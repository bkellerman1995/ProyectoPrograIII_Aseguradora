using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Interfaces
{
    interface IDALIVA
    {
        //List<Cliente> GetClienteByFilter(string pDescripcion);
        Cliente GetClienteById(int pId);
        //List<IEnumerable<Cliente>> GetAllCliente();

        //Task<IEnumerable<Cliente>> GetAllCliente();
        List<Cliente> GetAllCliente();
        //Task<Cliente> SaveCliente(Cliente pCliente);
        Cliente SaveCliente(Cliente pCliente);
        //Task<Cliente> UpdateCliente(Cliente pCliente);
        Cliente UpdateCliente(Cliente pCliente);
        //Task<bool> DeleteCliente(string pId);
        bool DeleteCliente(int pId);
    }
}
