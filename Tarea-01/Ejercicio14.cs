using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio14
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 14: Cajero automático");
            Console.WriteLine();

            double saldo = 5000;

            Console.WriteLine("Ingrese el monto a retirar: L. ");
            int monto = int.Parse(Console.ReadLine());

            if (monto % 20 != 0)
            {
                Console.WriteLine("EL NUMERO DEBE SER MULTIPLO DE 20 MUCHACH@");
                Console.ReadKey();
                return;
            }

            if (monto > saldo)
            {
                Console.WriteLine("SALDO INSUFICIENTE,YA NO TIENE FONDOS ");
                Console.ReadKey();
                return;
            }

            int[] billetes = { 500, 100, 50, 20 };

            foreach (int b in billetes)
            {
                int cantidad = monto / b;
                if (cantidad > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Billetes de " + b + ": " + cantidad);
                    monto = monto % b;
                }
            }
            Console.WriteLine();
            saldo -= monto;
            Console.WriteLine("SU RETIRO HA SIDO EXITOSO!!!");
            Console.ReadKey();
        }
    }
}