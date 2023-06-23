using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foro01._1erForo
{
    
    class Triangulo : Calculos
    {
        private double b;
        private double a;
        private double h;
        public Triangulo(double bas, double altura, double hip) {
            b = bas;
            a = altura;
            h = hip;
        }

        public override double calcularPerimetro()
        {
            return b + a + h;
        }

        public override double calcularArea()
        {
            return (b*a)/2;
        }
    }
}
