using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio11
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 11: Calculadora de descuentos");
            Console.WriteLine();


            Console.WriteLine("MONTO DE COMPRA: L. ");
            
            double monto = double.Parse(Console.ReadLine());

            double descuento = 0;

            if (monto >= 2500)
                descuento = 0.15;
            else if (monto >= 1000)
                descuento = 0.10;
            else if (monto >= 500)
                descuento = 0.05;

            double montoDescuento = monto * descuento;
            double total = monto - montoDescuento;

            Console.WriteLine("PRECIO ORIGINAL: L. " + monto.ToString("F2"));
            Console.WriteLine("DESCUENTI: L. " + montoDescuento.ToString("F2"));
            Console.WriteLine("PRECIO FINAL: L. " + total.ToString("F2"));

            Console.ReadKey();
        }
    }
}