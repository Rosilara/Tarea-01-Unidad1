using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio28
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 28: Matriz de notas por parcial");
            Console.WriteLine();

            Console.WriteLine("Cantidad de estudiantes: ");
            int n = int.Parse(Console.ReadLine());

            double[,] notas = new double[n, 3];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("ESTUDIANTE " + (i + 1));
                for (int j = 0; j < 3; j++)
                {
        
                    Console.WriteLine("Parcial " + (j + 1) + ": ");
                    notas[i, j] = double.Parse(Console.ReadLine());
                }
            }

            double mejorProm = 0;
            int mejorEst = 0;

            for (int i = 0; i < n; i++)
            {
                double suma = 0;
                for (int j = 0; j < 3; j++)
                    suma += notas[i, j];

                double prom = suma / 3;
                Console.WriteLine();
                Console.WriteLine("Promedio estudiante " + (i + 1) + ": " + prom.ToString("F2"));

                if (i == 0 || prom > mejorProm)
                {
                    mejorProm = prom;
                    mejorEst = i;
                }
            }

            double menorPromParcial = double.MaxValue;
            int parcialDificil = 0;

            for (int j = 0; j < 3; j++)
            {
                double suma = 0;
                for (int i = 0; i < n; i++)
                    suma += notas[i, j];

                double prom = suma / n;
                Console.WriteLine();
                Console.WriteLine("Promedio parcial " + (j + 1) + ": " + prom.ToString("F2"));

                if (prom < menorPromParcial)
                {
                    menorPromParcial = prom;
                    parcialDificil = j;
                }
            }

            Console.WriteLine();
            Console.WriteLine("MEJOR ESTUDIANTE: " + (mejorEst + 1));
            Console.WriteLine("PARCIAL MAS DIFICIL: " + (parcialDificil + 1));
            Console.ReadKey();
        }
    }
}