using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Layers.Entities
{
	public class Pais
	{
		public string Nombre { get; set; }
		public string ID { get; set; }
		public override string ToString() => $"{ID} - {Nombre.Trim()}";
	}
}
