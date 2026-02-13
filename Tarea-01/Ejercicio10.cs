using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio10
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 10: Sistema de calificaciones UNAH");
            Console.WriteLine();
            Console.WriteLine("Ingrese nota (0-100): ");
            int nota = int.Parse(Console.ReadLine());

            if (nota < 0 || nota > 100)
            {
                Console.WriteLine("Nota fuera de rango");
                return;
            }

            char letra;
            string descripcion;
            bool aprueba;

            if (nota >= 90)
            {
                letra = 'A';
                descripcion = "Excelente";
                aprueba = true;
            }
            else if (nota >= 80)
            {
                letra = 'B';
                descripcion = "Muy bueno";
                aprueba = true;
            }
            else if (nota >= 70)
            {
                letra = 'C';
                descripcion = "Bueno";
                aprueba = true;
            }
            else if (nota >= 60)
            {
                letra = 'D';
                descripcion = "Suficiente";
                aprueba = true;
            }
            else
            {
                letra = 'F';
                descripcion = "Reprobado";
                aprueba = false;
            }

            Console.WriteLine("Letra: " + letra);
            Console.WriteLine("Descripción: " + descripcion);
            Console.WriteLine("Resultado: " + (aprueba ? "APROBO" : "REPROBO"));

            Console.ReadKey();
        }
    }
}