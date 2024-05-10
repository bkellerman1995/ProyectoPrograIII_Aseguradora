using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrograIII.Interfaces;

namespace ProyectoPrograIII.Layers.Entities
{ 
    public class Usuarios
    {
        public string ID { set; get; }
        public string Nombre {set;get;}
        public string Contrasenna { set; get; }

        public int IdRol { set; get; }
        public bool Estado { set; get; }

        public byte [] Foto { get; set; }

        public override string ToString() => $"{ID.Trim()} - {Nombre.Trim()}";
    }
}
