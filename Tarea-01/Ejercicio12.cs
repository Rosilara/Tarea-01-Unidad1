using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio12
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 12: Año bisiesto y días del mes");
            Console.WriteLine();

            Console.Write("Año: ");
            if (!int.TryParse(Console.ReadLine(), out int anio))
            {
                Console.WriteLine("Entrada inválida.");
                Console.ReadKey();
                return;
            }

            Console.Write("Mes (1-12): ");
            if (!int.TryParse(Console.ReadLine(), out int mes))
            {
                Console.WriteLine("Entrada inválida.");
                Console.ReadKey();
                return;
            }

            bool bisiesto = (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);
            int dias = 0;

            switch (mes)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    dias = 31; break;
                case 4: case 6: case 9: case 11:
                    dias = 30; break;
                case 2:
                    dias = bisiesto ? 29 : 28; break;
                default:
                    Console.WriteLine("MES INVALIDO");
                    Console.ReadKey();
                    return;
            }

            Console.WriteLine("AÑO BISIESTO: " + (bisiesto ? "Sí" : "No"));
            Console.WriteLine("DÍAS DEL MES: " + dias);

            Console.ReadKey();
        }
    }
}
