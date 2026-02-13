using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio24
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 24: Búsqueda y ordenamiento");
            Console.WriteLine();

            int[] v = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Valor " + (i + 1) + ": ");
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("\nNUMERO A  BUSCAR: ");
            int buscar = int.Parse(Console.ReadLine());
            bool encontrado = false;

            for (int i = 0; i < 10; i++)
            {
                if (v[i] == buscar)
                {
                    Console.WriteLine();
                    Console.WriteLine(" - Encontrado en la posición " + i);
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
             Console.WriteLine();
             Console.WriteLine("Numer no encontrado");

            int mayor = int.MinValue;
            int segundo = int.MinValue;

            foreach (int x in v)
            {
                if (x > mayor)
                {
                    segundo = mayor;
                    mayor = x;
                }
                else if (x > segundo && x != mayor)
                {
                    segundo = x;
                }
            }

            Console.WriteLine();
            Console.WriteLine("- Numero segundo mayor: " + segundo);

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9 - i; j++)
                {
                    if (v[j] > v[j + 1])
                    {
                        int aux = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = aux;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("- ARREGLO ORDENADO:");
            foreach (int x in v)
                Console.WriteLine(x + " ");

            Console.WriteLine();
            Console.WriteLine("\n - ELEMENTOS EN POSICIONES PARES:");
            for (int i = 0; i < 10; i += 2)
                Console.WriteLine(v[i] + " ");

            
            Console.ReadKey();
        }
    }
}
