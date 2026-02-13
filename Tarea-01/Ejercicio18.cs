using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio18
    {
        static long Factorial(int n)
        {
            long f = 1;
            for (int i = 1; i <= n; i++)
                f *= i;
            return f;
        }

        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 18: Factorial y combinaciones");
            Console.WriteLine();

            Console.WriteLine("Ingrese n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese r: ");
            int r = int.Parse(Console.ReadLine());

            if (r > n || n < 0 || r < 0)
            {
                Console.WriteLine("VALORES INVALIDOS");
                Console.ReadKey();
                return;
            }

            long factN = Factorial(n);
            long combinacion = factN / (Factorial(r) * Factorial(n - r));

            
            Console.WriteLine();
            Console.WriteLine("FACTORIAL DE n: " + factN);
            Console.WriteLine("C(n,r): " + combinacion);
            Console.ReadKey();
            //ReadKey para presionar tecla antes de slair
        }

    }
}