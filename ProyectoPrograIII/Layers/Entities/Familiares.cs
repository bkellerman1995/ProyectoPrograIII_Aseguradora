
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Layers.Entities
{
    public class Familiares
    {
        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Parentesco { get; set; }

        public override string ToString() => $"{Cedula.Trim()} - {Nombre.Trim()} - {"Parentesco: " + Parentesco.ToString()}";
    }
}
