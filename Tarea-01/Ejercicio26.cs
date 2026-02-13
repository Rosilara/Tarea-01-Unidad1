using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio26
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 26: Frecuencia de elementos");
            Console.WriteLine();

            int[] numeros = new int[20];
            int[] frecuencia = new int[11];
            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                numeros[i] = rand.Next(1, 11);
                frecuencia[numeros[i]]++;
            }

            for (int i = 1; i <= 10; i++)
                Console.WriteLine("Número " + i + ": " + frecuencia[i] + " veces");

            int max = 1, min = 1;
            for (int i = 2; i <= 10; i++)
            {
                if (frecuencia[i] > frecuencia[max]) max = i;
                if (frecuencia[i] < frecuencia[min]) min = i;
            }

            Console.WriteLine();
            Console.WriteLine("Más frecuente: " + max);
            Console.WriteLine("Menos frecuente: " + min);
            Console.ReadKey();
        }
    }
}