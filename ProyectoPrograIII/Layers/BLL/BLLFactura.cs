using ProyectoPrograIII.Interfaces;
using ProyectoPrograIII.Layers.DAL;
using ProyectoPrograIII.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Layers.BLL
{
    public class BLLFactura : IBLLFactura
    {
        /// <summary>
        /// Método utilizado por la capa BLL de factura
        /// para obtener el número de factura actual
        /// obtenido por la secuencia (CREATE SEQUENCE) de la base de datos 
        /// </summary>
        /// <returns>valor de tipo entero con el número de factura</returns>
        public int GetCurrentNumeroFactura()
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.GetCurrentNumeroFactura();
        }

        /// <summary>
        /// Método utilizado por la capa BLL de factura
        /// para obtener el siguiente número de factura 
        /// obtenido por la secuencia (CREATE SEQUENCE) de la base de datos 
        /// </summary>
        /// <returns>valor de tipo entero con el número de siguiente factura</returns>
        public int GetNextNumeroFactura()
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.GetNextNumeroFactura();
        }

        /// <summary>
        ///Método utilizado por la capa BLL de factura
        /// para salvar la factura en la base de datos
        /// </summary>
        /// <param name="pFactura"></param>
        /// <param name="oPoliza"></param>
        /// <returns>objeto (BLL) BLLFactura</returns>
        public FacturaEncabezado SaveFactura(FacturaEncabezado pFactura, Poliza oPoliza)
        {
            IDALFactura _DALFactura = new DALFactura();

            return _DALFactura.SaveFactura(pFactura, oPoliza);  
        }

        /// <summary>
        /// Método utilizado por la capa BLL de factura
        /// para obtener el objeto factura desde la base de datos
        /// </summary>
        /// <param name="pNumeroFactura"></param>
        /// <returns>objeto (BLL) BLLFactura</returns>
        public FacturaEncabezado GetFactura(int pNumeroFactura)
        {
            IDALFactura _DALFactura = new DALFactura();

            return _DALFactura.GetFactura(pNumeroFactura);
        }

        /// <summary>
        /// Método estático utilizado por la capa BLL de factura
        /// para enviar el correo electrónico al cliente 
        /// con el detalle de la factura
        /// </summary>
        /// <param name="rutaPDF"></param>
        public static void EnviarCorreo (string rutaPDF)
        {

            string cuentacorreoElectronico = "bjkt1805@gmail.com";
            string contrasennaGeneradaGamil = "ohcowhhwzqbzfbsm";

            MailMessage mensaje = new MailMessage();
            mensaje.IsBodyHtml = true;
            mensaje.Subject = "Factura por concepto de: Adquisicion de Poliza de seguro y plan";
            mensaje.Body = "Estimado cliente " +
                "\nAdjunto encontrara un archivo en formato .pdf con el detalle de la factura del plan y la poliza que adquirio el dia de hoy.";

            mensaje.From = new MailAddress(cuentacorreoElectronico);
            mensaje.To.Add("utnbjkt1805@gmail.com");
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(cuentacorreoElectronico, contrasennaGeneradaGamil);
            smtp.EnableSsl = true;

            using (Attachment attachment = new Attachment(rutaPDF))
            {
                mensaje.Attachments.Add(attachment);
                smtp.Send(mensaje);
            }


        }

        /// <summary>
        /// Método utilizado por la capa BLL de factura
        /// para obtener la lista de facturas por fecha (parámetro)
        /// desde la base de datos
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns>Lista de facturas filtrada por fecha</returns>
        public List<FacturaEncabezado> GetFacturasPorFecha(DateTime fecha)
        {
            IDALFactura _DALFactura = new DALFactura();

            return _DALFactura.GetFacturasPorFecha(fecha);
        }

        /// <summary>
        /// Método utilizado por la capa BLL de factura
        /// para obtener la lista de encabezados de factura
        /// desde la base de datos
        /// </summary>
        /// <returns>Lista de facturas</returns>
        public List<FacturaEncabezado> GetAllFactura()
        {
            IDALFactura _DALFactura = new DALFactura();

            return _DALFactura.GetAllFactura();
        }

        /// <summary>
        ///Método utilizado por la capa BLL de factura
        /// para eliminar la factura de la base de datos
        /// recibiendo como parámetro el número de factura (llave primaria) 
        /// </summary>
        /// <param name="pFacturaID"></param>
        /// <returns>valor booleano (true/false) basado en
        /// el resultado de eliminar la factura</returns>
        public bool DeleteFactura(int pFacturaID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///Método utilizado por la capa BLL de factura
        /// para actualizar la factura en la Base de Datos
        /// </summary>
        /// <param name="pFacturaEncabezado"></param>
        /// <returns>objeto (BLL) BLLFactura</returns>
        public FacturaEncabezado UpdateEstadoFactura(FacturaEncabezado pFacturaEncabezado)
        {
            IDALFactura _DALFactura = new DALFactura();

            return _DALFactura.UpdateEstadoFactura(pFacturaEncabezado);
        }
    }
}
