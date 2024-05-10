using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectoPrograIII.Interfaces;
using ProyectoPrograIII.Layers.BLL;

namespace ProyectoPrograIII.Layers.Entities
{
    public class FacturaDetalle
    {
        public int IdFactura { set; get; }
        public string IDPoliza  { set; get; }
        public double PrecioColones { set; get; }
        public double PrecioDolares { set; get; }

        public int Impuesto { get; set; }

        /// <summary>
        /// Metodo que conecta la aplicacion al servicio web del BCCR
        /// para retornar el tipo de cambio del dolar actualizado a la fecha de hoy (venta)
        /// </summary>
        /// <returns>Tipo de cambio venta del dolar</returns>
        public static double RetornarTipoCambio()
        {
            double TipoCambio = 0;
            DateTime fecha = DateTime.Today;
            string fechahoy = fecha.ToString("dd/MM/yyyy");
            cr.fi.bccr.gee.wsindicadoreseconomicos cliente = new cr.fi.bccr.gee.wsindicadoreseconomicos();
            DataSet tipoCambio = cliente.ObtenerIndicadoresEconomicos("318", fechahoy, fechahoy, "Brian Kellerman", "N", "bjkt1805@gmail.com", "0RMAJR312K");
            TipoCambio = double.Parse((tipoCambio.Tables[0].Rows[0].ItemArray[2].ToString()));
            return TipoCambio;
        }

        /// <summary>
        /// Metodo que recibe un parametro de tipo Poliza, 
        /// recorre la lista de coberturas que el plan tiene asignadas
        /// y las va sumando en el total a pagar en colones. 
        /// </summary>
        /// <param name="pPoliza"></param>
        /// <returns>Total a pagar en colones (valor double)</returns>
        public double calcularTotalColones(Poliza pPoliza)
        {
            double total = 0;
            IBLLPlan planBLL = new BLLPlan();

            foreach (var cobertura in planBLL.GetAllCoberturasPlan(pPoliza.Plan))
            {
                total += ((cobertura.Prima));
            }

            total += pPoliza.Plan.CostoPlan;
            PrecioColones = RetornarTipoCambio() * (total + (total * (Convert.ToDouble(Impuesto)/ 100)));
            return PrecioColones;
        }

        /// <summary>
        /// Metodo que recibe un parametro de tipo Poliza, 
        /// recorre la lista de coberturas que el plan tiene asignadas
        /// y las va sumando en el total a pagar en dolares. 
        /// </summary>
        /// <param name="pPoliza"></param>
        /// <returns>Total a pagar en dolares (valor double)</returns>
        public double calcularTotalDolares(Poliza pPoliza)
        {
            double total = 0;
            IBLLPlan planBLL = new BLLPlan();

            foreach (var cobertura in planBLL.GetAllCoberturasPlan(pPoliza.Plan))
            {
                total += ((cobertura.Prima));
            }

            total += pPoliza.Plan.CostoPlan;
            PrecioDolares = total + (total * (Convert.ToDouble(Impuesto)/ 100));

            return PrecioDolares;
        }
    }
}
