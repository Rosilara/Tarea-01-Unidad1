using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio21
    {
         public static void Ejecutar()
        {
             Console.Clear();
            Console.WriteLine("Ejercicio 21: Patrón de asteriscos");
            Console.WriteLine();

            Console.WriteLine("ELIJA LA FIGURA QUE QUIERE FORMAR con asteriscos: ");
            Console.WriteLine("1. Triángulo");
            Console.WriteLine("2. Triángulo invertido");
            Console.WriteLine("3. Rombo");
            Console.WriteLine("4. Cuadrado hueco");
            Console.WriteLine();
            Console.WriteLine("Opción: ");
            int op = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Tamaño: ");
            int n = int.Parse(Console.ReadLine());
            Console.ReadKey();

            switch (op)
            {
                case 1:
                    for (int i = 1; i <= n; i++)
                        Console.WriteLine(new string('*', i));
                    break;

                case 2:
                    for (int i = n; i >= 1; i--)
                        Console.WriteLine(new string('*', i));
                    break;

                case 3:
                    for (int i = 1; i <= n; i++)
                        Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));
                    for (int i = n - 1; i >= 1; i--)
                        Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));
                    break;

                case 4:
                    for (int i = 1; i <= n; i++)
                    {
                        if (i == 1 || i == n)
                            Console.WriteLine(new string('*', n));
                        else
                            Console.WriteLine("*" + new string(' ', n - 2) + "*");
                    }
                    break;
            }

         Console.ReadKey();   
        }
    }
}