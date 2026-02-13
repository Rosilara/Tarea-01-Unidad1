using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio09
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 09: Clasificación de triángulos");
            Console.WriteLine();

            Console.WriteLine("Lado 1: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Lado 2: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Lado 3: ");
            double c = double.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("No forman un triángulo válido");
                return;
            }

            if (a == b && b == c)
                Console.WriteLine("Tipo por lados: Equilátero");
            else if (a == b || a == c || b == c)
                Console.WriteLine("Tipo por lados: Isósceles");
            else
                Console.WriteLine("Tipo por lados: Escaleno");

            double a2 = a * a, b2 = b * b, c2 = c * c;

            if (a2 + b2 == c2 || a2 + c2 == b2 || b2 + c2 == a2)
                Console.WriteLine("Tipo por ángulos: Rectángulo");
            else if (a2 + b2 > c2 && a2 + c2 > b2 && b2 + c2 > a2)
                Console.WriteLine("Tipo por ángulos: Acutángulo");
            else
                Console.WriteLine("Tipo por ángulos: Obtusángulo");

            Console.ReadKey();
        }
        
    }
}