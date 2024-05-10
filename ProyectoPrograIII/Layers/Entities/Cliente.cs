using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Layers.Entities
{
    public class Cliente
    {
		public int ID {get;set;}
		public string Nombre {get;set;}
		public string Apellido1 {get;set;}
		public string Apellido2 {get;set;}
		public int Sexo {get;set;}
		public DateTime FechaNacimiento {get;set;}
		public byte [] Foto {get;set;}
		public string NumTelefono {get;set;}
		public string Direccion {get;set;}
		public Pais Pais { get; set;}
		public string CorreoElectronico {get;set;}
		public byte [] Cedula {get;set;}

		public List<Familiares> listaFamiliares { get; set; }

		public override string ToString() => $"{ID} - {Nombre.Trim()} - {FechaNacimiento.ToString("dd/MM/yyyy")}";

		public Cliente()
        {
			if (listaFamiliares == null)
				listaFamiliares = new List<Familiares>();
        }
    }
}
