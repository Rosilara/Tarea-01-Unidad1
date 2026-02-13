using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio16
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 16: Números primos en rango");
            Console.WriteLine();

            Console.WriteLine("Inicio: ");
            int inicio = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Fin: ");
            int fin = int.Parse(Console.ReadLine());

            int contador = 0;

            Console.WriteLine();
            Console.WriteLine("Numeros primos dentro del rango");
            
            for (int n = inicio; n <= fin; n++)
            {
                if (n < 2) continue;

                bool primo = true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }
            
                if (primo)
                {
                    Console.WriteLine();
                    Console.WriteLine(n + " ");
                    
                    contador++;
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Cantidad de primos: " + contador);
            Console.ReadKey();
        }
    }
}