using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio15
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 15: Tabla de multiplicar extendida");
            Console.WriteLine();


            Console.WriteLine("Ingrese un número: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("TABLA MULTIPLICAR DEL NUMERO " + n);
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + (n * i));
            }
            Console.ReadKey();
        }
    }
}