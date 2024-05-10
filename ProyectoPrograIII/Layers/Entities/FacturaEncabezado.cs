using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Layers.Entities
{
    public class FacturaEncabezado
    {
        public int IdFactura { set; get; }
        public Tarjeta Tarjeta { set; get; }
        
        public string TarjetaNumero { set; get; }
        public DateTime FechaFacturacion { set; get; }
        public Cliente Cliente { set; get; }
        public bool EstadoFactura { set; get; }


        public List<FacturaDetalle> _ListaFacturaDetalle { get; } = new List<FacturaDetalle>();

        /// <summary>
        /// Método que agrega la factura detalle a la lista 
        /// de detalles del encabezado de la factura
        /// </summary>
        /// <param name="pFacturaDetalle"></param>
        public void AddDetalle(FacturaDetalle pFacturaDetalle)
        {
            _ListaFacturaDetalle.Add(pFacturaDetalle);
        }

        /// <summary>
        /// Método que retorna la suma toal (por medio de linq)
        /// del precio en colones  de  todos los detalles de factura enbezado
        /// </summary>
        /// <returns>valor tipo double con la suma total en colones</returns>
        public double GetTotalColones()
        {
            return _ListaFacturaDetalle.Sum(p => p.PrecioColones);
        }

        /// <summary>
        /// Método que retorna la suma toal (por medio de linq)
        /// del precio en dolares de  todos los detalles de factura enbezado
        /// </summary>
        /// <returns>valor tipo double con la suma total en dolares</returns>
        public double GetTotalDolares()
        {
            return _ListaFacturaDetalle.Sum(p => p.PrecioDolares);
        }

        /// <summary>
        /// Método que retorna la suma total (por medio de linq)
        /// del impuesto de todos los detalles de factura enbezado 
        /// </summary>
        /// <returns>valor tipo double con la suma total del impuesto</returns>
        public double GetImpuesto()
        {
            return _ListaFacturaDetalle.Sum(p => p.Impuesto);
        }
    }
}
