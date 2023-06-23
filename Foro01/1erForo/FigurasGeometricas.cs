using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foro01._1erForo
{
    public class FigurasGeometricas
    {
        public FigurasGeometricas() {
            Console.WriteLine("Calculadora de Figuras Geometricas");

            bool salir = false;

            while (!salir) {
                Console.WriteLine("Seleccione una figura geometrica:");
                Console.WriteLine("1. Cuadrado");
                Console.WriteLine("2. Rectangulo");
                Console.WriteLine("3. Triangulo");
                Console.WriteLine("4. Circulo");
                Console.WriteLine("5. Salir");   

                Console.Write("Ingrese el numero que corresponde a la figura a calcular: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Cuadrilatero c;
                Triangulo t;
                Circulo o;

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Perímetro y Area de un Cuadrado");
                        Console.WriteLine("Ingrese el lado del Cuadrado: ");
                        double lado = Convert.ToInt32(Console.ReadLine());
                        c = new Cuadrilatero(lado);
                        Console.WriteLine("El cuadrado tiene un perímetro de: " + c.calcularPerimetro() + " cm \ny un área de: " + c.calcularArea() + " cm2\n");
                        break;
                    case 2:
                        Console.WriteLine("Perímetro y Area de un Rectangulo");
                        Console.WriteLine("Ingrese la altura del Rectangulo: ");
                        double lado1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese la base del Rectangulo: ");
                        double lado2 = Convert.ToInt32(Console.ReadLine());
                        c = new Cuadrilatero(lado1, lado2);
                        Console.WriteLine("El rectangulo tiene un perímetro de: " + c.calcularPerimetro() + " cm \ny un área de: " + c.calcularArea() + " cm2\n");
                        break;
                    case 3:
                        Console.WriteLine("Perímetro y Area de un Triangulo");
                        Console.WriteLine("Ingrese la altura del Triangulo: ");
                        double a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese la base del Triangulo: ");
                        double b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese la hipotenusa del Triangulo: ");
                        double h = Convert.ToInt32(Console.ReadLine());
                        t = new Triangulo(a, b, h);
                        Console.WriteLine("El triangulo tiene un perímetro de: " + t.calcularPerimetro() + " cm \ny un área de: " + t.calcularArea() + " cm2\n");
                        break;
                    case 4:
                        Console.WriteLine("Perímetro y Area de un Circulo");
                        Console.WriteLine("Ingrese el radio del circulo: ");
                        double r = Convert.ToInt32(Console.ReadLine());
                        o = new Circulo(r);
                        Console.WriteLine("El circulo tiene un perímetro de: " + o.calcularPerimetro() + " cm \ny un área de: " + o.calcularArea() + " cm2\n");
                        break;
                    case 5:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no valida");
                        break;
                }
            }

        }

    }
}
