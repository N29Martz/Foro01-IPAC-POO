using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foro01._1erForo
{
     class Circulo : Calculos
    {
        public double r;
        public Circulo(double radio) { 
            r= radio;
        }

        public override double calcularPerimetro()
        {
            return 2 * Math.PI * r;
        }

        public override double calcularArea()
        {
            return Math.PI * r * r;
        }
    }
}
