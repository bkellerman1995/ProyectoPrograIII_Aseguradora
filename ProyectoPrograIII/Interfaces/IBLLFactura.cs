using ProyectoPrograIII.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Interfaces
{
    interface IBLLFactura
    {
        /// <summary>
        ///Método utilizado por la capa BLL de factura
        /// para salvar la factura en la base de datos
        /// </summary>
        /// <param name="pFactura"></param>
        /// <param name="oPoliza"></param>
        /// <returns>objeto (BLL) BLLFactura</returns>
        FacturaEncabezado SaveFactura(FacturaEncabezado pFactura, Poliza oPoliza);

        /// <summary>
        /// Método utilizado por la capa BLL de factura
        /// para obtener el siguiente número de factura 
        /// obtenido por la secuencia (CREATE SEQUENCE) de la base de datos 
        /// </summary>
        /// <returns>valor de tipo entero con el número de siguiente factura</returns>
        int GetNextNumeroFactura();

        /// <summary>
        /// Método utilizado por la capa BLL de factura
        /// para obtener el número de factura actual
        /// obtenido por la secuencia (CREATE SEQUENCE) de la base de datos 
        /// </summary>
        /// <returns>valor de tipo entero con el número de factura</returns>
        int GetCurrentNumeroFactura();

        /// <summary>
        /// Método utilizado por la capa BLL de factura
        /// para obtener el objeto factura desde la base de datos
        /// </summary>
        /// <param name="pNumeroFactura"></param>
        /// <returns>objeto (BLL) BLLFactura</returns>
        FacturaEncabezado GetFactura(int pNumeroFactura);

        /// <summary>
        /// Método utilizado por la capa BLL de factura
        /// para obtener la lista de facturas por fecha (parámetro)
        /// desde la base de datos
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns>Lista de facturas filtrada por fecha</returns>
        List<FacturaEncabezado> GetFacturasPorFecha(DateTime fecha);

        /// <summary>
        /// Método utilizado por la capa BLL de factura
        /// para obtener la lista de encabezados de factura
        /// desde la base de datos
        /// </summary>
        /// <returns>Lista de facturas</returns>
        List<FacturaEncabezado> GetAllFactura();

        /// <summary>
        ///Método utilizado por la capa BLL de factura
        /// para eliminar la factura de la base de datos
        /// recibiendo como parámetro el número de factura (llave primaria) 
        /// </summary>
        /// <param name="pFacturaID"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar la factura</returns>
        bool DeleteFactura(int pFacturaID);

        /// <summary>
        ///Método utilizado por la capa BLL de factura
        /// para actualizar la factura en la Base de Datos
        /// </summary>
        /// <param name="pFacturaEncabezado"></param>
        /// <returns>objeto (BLL) BLLFactura</returns>
        FacturaEncabezado UpdateEstadoFactura(FacturaEncabezado pFacturaEncabezado);
    }
}
