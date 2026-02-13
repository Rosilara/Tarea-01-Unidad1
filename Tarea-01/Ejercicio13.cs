using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio13
    {
        public static void Ejecutar()
        {
            
            Console.Clear();
            Console.WriteLine("Ejercicio 13: Validador de fecha");
            Console.WriteLine();

            
            Console.WriteLine("Día: ");
            int dia = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine("Mes: ");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Año: ");
            int anio = int.Parse(Console.ReadLine());

            
            bool bisiesto = (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);
            
            int diasMes = 0;

            switch (mes)
            {
                
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    diasMes = 31;
                    break;

               
                case 4: case 6: case 9: case 11:
                    diasMes = 30;
                    break;

               
                case 2:
                    diasMes = bisiesto ? 29 : 28;
                    break;

                
                default:
            
                    Console.WriteLine("Fecha inválida");
                    Console.ReadKey();
                    return; 
            }

            Console.WriteLine();
            if (dia >= 1 && dia <= diasMes)

                Console.WriteLine("FECHA VALIDA");
            else
                Console.WriteLine("FECHA INVALIDA");

            
            Console.ReadKey();
        }
    }
}
