using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio07
    {
         public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 07: Conversión de unidades de almacenamiento");
            Console.WriteLine();
            Console.WriteLine("Cantidad en bytes: ");
            double bytes = double.Parse(Console.ReadLine());

            Console.WriteLine("KB: " + (bytes / 1024));
            Console.WriteLine("MB: " + (bytes / Math.Pow(1024, 2)));
            Console.WriteLine("GB: " + (bytes / Math.Pow(1024, 3)));
            Console.WriteLine("TB: " + (bytes / Math.Pow(1024, 4)));
            //para elevar un numero a una potencia

            Console.ReadKey();
        }
    }
}