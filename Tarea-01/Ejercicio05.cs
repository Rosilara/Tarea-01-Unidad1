using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio05
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 05: Tiempo transcurrido");
            Console.WriteLine();

            Console.WriteLine("Hora inicial (hh:mm:ss): ");
            TimeSpan hora1 = TimeSpan.Parse(Console.ReadLine());
            //TimeSpan es para mdir intervalos del tiempo

            Console.WriteLine("Hora final (hh:mm:ss): ");
            TimeSpan hora2 = TimeSpan.Parse(Console.ReadLine());

            if (hora2 < hora1)
            {
                hora2 = hora2.Add(TimeSpan.FromHours(24));
            }

            TimeSpan diferencia = hora2 - hora1;

            Console.WriteLine(
                "Diferencia: " + diferencia.Hours + "h " +
                diferencia.Minutes + "m " +
                diferencia.Seconds + "s"
            );
            Console.ReadKey();
        }
    }
    
}