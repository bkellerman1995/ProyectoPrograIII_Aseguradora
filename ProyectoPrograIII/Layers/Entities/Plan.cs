using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII.Layers.Entities
{
    public class Plan
    {
        public string ID { get; set; }
        public string NombrePlan { get; set; }
        public List<Cobertura> listaCoberturas { get; set; }

        public bool Familiar { get; set; }

        public double CostoPlan { get; set; }

        public Plan()
        {
            if (listaCoberturas == null)
                listaCoberturas = new List<Cobertura>();
        }

        public override string ToString() => $"{ID.Trim()} - {NombrePlan.Trim()} - {"Familiar: " + Familiar} " +
            $"- {"Costo: $ " + CostoPlan}";

    }

}
