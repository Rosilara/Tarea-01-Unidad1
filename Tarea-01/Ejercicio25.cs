using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio25
    {
         public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 25: Rotación de arreglo");
            Console.WriteLine();

            Console.WriteLine("Cantidad de elementos: ");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Elemento " + (i + 1) + ": ");
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("ELIJA QUE QUIERE HACER CON EL ARREGLO: ");
            Console.WriteLine("1. Rotar izquierda");
            Console.WriteLine("2. Rotar derecha");
            Console.WriteLine("3. Invertir");
            Console.WriteLine();
            Console.WriteLine("OPCION: ");
            int op = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("K posiciones: ");
            int k = int.Parse(Console.ReadLine());
            k %= n;

            if (op == 1)
            {
                int[] temp = new int[n];
                for (int i = 0; i < n; i++)
                    temp[i] = v[(i + k) % n];
                v = temp;
            }
            else if (op == 2)
            {
                int[] temp = new int[n];
                for (int i = 0; i < n; i++)
                    temp[(i + k) % n] = v[i];
                v = temp;
            }
            else if (op == 3)
            {
                Array.Reverse(v);
            }

            Console.WriteLine();
            Console.WriteLine("RESULTADO:");
            foreach (int x in v)
                Console.WriteLine(x + " ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}