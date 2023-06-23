using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foro01._1erForo
{
    class Cuadrilatero : Calculos
    {
        private double lado1;
        private double lado2;
        public Cuadrilatero(double lado) {
           lado1 = lado;
           lado2 = lado;
        }

        public Cuadrilatero(double lado01, double lado02) {
            lado1 = lado01;
            lado2 = lado02;
        }

        public override double calcularPerimetro()
        {
            return (lado1 + lado2)*2;
        }

        public override double calcularArea()
        {
            return lado1 * lado2;
        }
    }
}
