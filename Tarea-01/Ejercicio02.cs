using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Tarea_01.Ejercicios
{
    public class Ejercicio02
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 02: Conversión de temperatura");
            Console.WriteLine();

            Console.WriteLine("Elija la conversión que quiere realizar:");
            Console.WriteLine("1. Celsius -> Fahrenheit");
            Console.WriteLine("2. Fahrenheit -> Celsius");
            Console.WriteLine("3. Celsius -> Kelvin");
            Console.WriteLine("4. Kelvin -> Celsius");
            Console.WriteLine();
            Console.Write("Seleccione opción: ");

            int opcion = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor: ");
            double valor = double.Parse(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = valor * 9 / 5 + 32 ;
                    break;

                case 2:
                    resultado = (valor - 32) * 5 / 9;
                    break;

                case 3:
                    resultado = valor + 273.15;
                    break;

                case 4:
                    resultado = valor - 273.15;
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    Console.ReadKey();
                    //para que no se cierre el programa 
                    return;
            }

            Console.WriteLine();
            Console.WriteLine("Resultado: " + resultado.ToString("F2")); 
            
            Console.ReadKey();
        }
    }
}
