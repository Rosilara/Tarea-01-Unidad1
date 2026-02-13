using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio04
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 04: Calculadora de préstamo simple");
            Console.WriteLine();

            Console.WriteLine("Monto del préstamo: ");
            double monto = double.Parse(Console.ReadLine());

            Console.WriteLine("Tasa anual (%): ");
            double tasa = double.Parse(Console.ReadLine()) / 100;

            Console.WriteLine("Plazo en meses: ");
            int meses = int.Parse(Console.ReadLine());

            double interes = monto * tasa * (meses / 12.0);
            double total = monto + interes;
            double cuota = total / meses;

            Console.WriteLine("Interés total: L. " + interes.ToString("F2"));
            Console.WriteLine("Cuota mensual: L. " + cuota.ToString("F2"));

            Console.ReadKey();

        }
    }
    
            
}