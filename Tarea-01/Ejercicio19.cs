using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio19
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 19: Juego de adivinanza");
            Console.WriteLine();

            Random rnd = new Random();
            int secreto = rnd.Next(1, 101);
            int intentos = 7;
            bool gano = false;

        
            for (int i = 1; i <= intentos; i++)
            {
                Console.WriteLine("INTENTO " + i + ": ");
                int n = int.Parse(Console.ReadLine());

                if (n == secreto)
                {
                    Console.WriteLine("¡Correcto!");
                    gano = true;
                    break;
                }
            
                else if (n < secreto)
                    Console.WriteLine("El numero es MAYOR");
                else
                    Console.WriteLine("El numero es MENOR");
            }

            Console.WriteLine();
            Console.WriteLine("EL NUMERO SECRETO ERA: " + secreto);
            Console.WriteLine("RESULTADO: " + (gano ? "Exelente, ha ganado! :) " : "Ha perdido! No adivino el numero :( )"));
            Console.ReadKey();
        }
    }
}