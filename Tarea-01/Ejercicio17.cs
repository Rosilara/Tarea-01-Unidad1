using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio17
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 17: Serie Fibonacci");
            Console.WriteLine();

            Console.WriteLine("Cantidad de términos: ");
            int n = int.Parse(Console.ReadLine());

            long a = 0, b = 1, suma = 0;

            Console.WriteLine();
            Console.WriteLine("SERIE FIBONACCI:");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(a + " ");
                suma += a;
                long temp = a + b;
                a = b;
                b = temp;
            }

            Console.WriteLine();
            Console.WriteLine("SUMA TOTAL: " + suma);
            Console.WriteLine("PROMEDIO: " + (suma / (double)n));
            Console.ReadKey();
        }
        
    }
}