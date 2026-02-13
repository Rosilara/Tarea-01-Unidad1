using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio27
    {
         public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 27: Arreglo de temperaturas");
            Console.WriteLine();

            double[] temp = new double[7];
            double suma = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Temperatura día " + (i + 1) + ": ");
                temp[i] = double.Parse(Console.ReadLine());
                suma += temp[i];
            }

            double promedio = suma / 7;
            int sobreProm = 0;
            int diaMax = 0, diaMin = 0;

            for (int i = 0; i < 7; i++)
            {
                if (temp[i] > promedio) sobreProm++;
                if (temp[i] > temp[diaMax]) diaMax = i;
                if (temp[i] < temp[diaMin]) diaMin = i;
            }

            Console.WriteLine();
            Console.WriteLine("PROMEDIO SEMANAL: " + promedio.ToString("F2"));
            Console.WriteLine();
            Console.WriteLine("DIAS MAYORES QUE LE PROMEDIO: " + sobreProm);
            Console.WriteLine();
            Console.WriteLine("DIA MAS CALUROSO: Día " + (diaMax + 1));
            Console.WriteLine();
            Console.WriteLine("DIA MAS FRIO: Día " + (diaMin + 1));
            Console.ReadKey();

            Console.WriteLine("Variación entre días:");
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("Día " + i + " a " + (i + 1) + ": " +
                    (temp[i] - temp[i - 1]).ToString("F2"));
                    Console.ReadKey();
            }
        }
        
    }
}