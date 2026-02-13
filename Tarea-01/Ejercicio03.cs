using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01.Ejercicios
{
    public class Ejercicio03
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 03: Desglose de billetes");
            Console.WriteLine();
            
            Console.WriteLine("Ingrese monto en lempiras: ");
            int monto = int.Parse(Console.ReadLine());

            int[] billetes = { 500, 100, 50, 20, 10, 5, 2, 1 };

            foreach (int b in billetes)
            {
                int cantidad = monto / b;
                if (cantidad > 0)
                {
                    Console.WriteLine("Billetes de " + b + ": " + cantidad);
                    monto %= b;
                }
    }
     
            Console.ReadKey();
}  
    }
}