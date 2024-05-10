using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Layers.Entities
{
    public class Cobertura
    {
        public string IDCobertura { get; set; }
        public string Nombre { get; set; }
        public double Prima { get;set; }
        public double MontoMaximo { get; set;}

        public int NumEventosAnno { get; set; }
        public override string ToString() => $"{IDCobertura.Trim()} - {Nombre.Trim()} " +
            $"{" - $" + Prima + " - $"+ MontoMaximo}";
    }
}
