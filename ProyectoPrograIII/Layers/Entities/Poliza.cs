using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Layers.Entities
{
    public class Poliza
    {
        public string ID { get; set; }
        public string Descripcion { get; set; }
        public Cliente Cliente {get;set;}
        public Plan Plan { get; set; }

        public override string ToString() => $"{ID.Trim()} - {Descripcion.Trim()}";
    }
}
