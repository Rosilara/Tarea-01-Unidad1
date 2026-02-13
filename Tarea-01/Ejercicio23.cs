using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio23
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 23: Estadísticas de calificaciones");
            Console.WriteLine();


            Console.WriteLine("CANTIDAD DE CALIFICACIONES: ");
            int n = int.Parse(Console.ReadLine());

            double[] notas = new double[n];
            double suma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("NOTA " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());
                suma += notas[i];
            }

            double promedio = suma / n;
            double max = notas[0], min = notas[0];
            int aprobados = 0, reprobados = 0;

            foreach (double nota in notas)
            {
                if (nota >= 60) aprobados++;
                else reprobados++;

                if (nota > max) max = nota;
                if (nota < min) min = nota;
            }

            double sumaVar = 0;
            foreach (double nota in notas)
                sumaVar += Math.Pow(nota - promedio, 2);

            double desviacion = Math.Sqrt(sumaVar / n);

            Console.WriteLine();
            Console.WriteLine("Promedio: " + promedio.ToString("F2"));
            Console.WriteLine("Máxima: " + max);
            Console.WriteLine("Mínima: " + min);
            Console.WriteLine("Aprobados: " + aprobados);
            Console.WriteLine("Reprobados: " + reprobados);
            Console.WriteLine("Desviación estándar: " + desviacion.ToString("F2"));
            Console.ReadKey();
        }
    }
}