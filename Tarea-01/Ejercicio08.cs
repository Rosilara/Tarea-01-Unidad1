using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio08
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 08: Cálculo de salario semanal");
            Console.WriteLine();
            Console.WriteLine("Horas trabajadas: ");
            double horas = double.Parse(Console.ReadLine());

            Console.WriteLine("Tarifa por hora: ");
            double tarifa = double.Parse(Console.ReadLine());

            double horasNormales = Math.Min(horas, 44);
            double horasExtras = Math.Max(horas - 44, 0);

            double pagoNormal = horasNormales * tarifa;
            double pagoExtra = horasExtras * tarifa * 1.5;
            double total = pagoNormal + pagoExtra;

            Console.WriteLine("Pago normal: L. " + pagoNormal.ToString("F2"));
            Console.WriteLine("Pago extra: L. " + pagoExtra.ToString("F2"));
            Console.WriteLine("Total semanal: L. " + total.ToString("F2"));

            Console.ReadKey();
        }
    }
}