using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Layers.Entities
{
    public class Tarjeta
    {
        public string IdTarjeta { get; set; }
        public string DescripcionTarjeta { get; set; }
        public override string ToString() => $"{IdTarjeta} {DescripcionTarjeta}";

        public string CVC { get; set; }

        public DateTime FechaExpiracion { get; set; }
    }
}
