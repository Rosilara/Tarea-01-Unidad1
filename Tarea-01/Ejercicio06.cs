using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio06
    {
public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 06: Área y perímetro");
            Console.WriteLine();

            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Triángulo");
            Console.WriteLine("3. Rectángulo");
            Console.WriteLine("4. Trapecio");
            Console.Write("Seleccione figura: ");
            int op = int.Parse(Console.ReadLine());

            double area = 0, per = 0;

            switch (op)
            {
                case 1:
                    Console.WriteLine("Radio: ");
                    double r = double.Parse(Console.ReadLine());
                    if (r > 0)
                    {
                        area = Math.PI * r * r;
                        per = 2 * Math.PI * r;
                    }
                    break;

                case 2:
                    Console.WriteLine("Base: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura: ");
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine("Lado 1: ");
                    double l1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Lado 2: ");
                    double l2 = double.Parse(Console.ReadLine());
                    if (b > 0 && h > 0 && l1 > 0 && l2 > 0)
                    {
                        area = (b * h) / 2;
                        per = b + l1 + l2;
                    }
                    break;

                case 3:
                    Console.WriteLine("Base: ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura: ");
                    h = double.Parse(Console.ReadLine());
                    if (b > 0 && h > 0)
                    {
                        area = b * h;
                        per = 2 * (b + h);
                    }
                    break;

                case 4:
                    Console.WriteLine("Base mayor: ");
                    double B = double.Parse(Console.ReadLine());
                    Console.WriteLine("Base menor: ");
                    double bm = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura: ");
                    h = double.Parse(Console.ReadLine());
                    Console.WriteLine("Lado 1: ");
                    l1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Lado 2: ");
                    l2 = double.Parse(Console.ReadLine());
                    if (B > 0 && bm > 0 && h > 0 && l1 > 0 && l2 > 0)
                    {
                        area = ((B + bm) * h) / 2;
                        per = B + bm + l1 + l2;
                    }
                    break;
            }

            Console.WriteLine("Área: " + area.ToString("F2"));
            Console.WriteLine("Perímetro: " + per.ToString("F2"));

            Console.ReadKey();
        }
    }
}