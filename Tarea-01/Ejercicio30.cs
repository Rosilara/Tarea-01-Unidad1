using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio30
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 30: Inventario simple)");
            Console.WriteLine();

            int[] codigo = { 101, 102, 103, 104, 105 };
            string[] nombre = { "Arroz", "Frijoles", "Azucar", "Cafe", "Aceite" };
            int[] cantidad = { 10, 8, 15, 5, 12 };
            double[] precio = { 25.5, 30.0, 22.0, 80.0, 60.0 };

            int op;
            do
            {
                Console.WriteLine("\n1. Mostrar inventario");
                Console.WriteLine("2. Buscar producto");
                Console.WriteLine("3. Actualizar cantidad");
                Console.WriteLine("4. Valor total inventario");
                Console.WriteLine("0. Salir");
                Console.WriteLine();
                Console.WriteLine("OPCION: ");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {Console.WriteLine("CODIGO-----NOMBRE-----CANTIDAD-----PRECIO");
                    for (int i = 0; i < 5; i++)
                    {
                        
                        Console.WriteLine(codigo[i] + "        " + nombre[i] + "        "
                            + cantidad[i] + "          " + precio[i]);
                    }
                }
                else if (op == 2)
                {
                    Console.WriteLine("Código: ");
                    int c = int.Parse(Console.ReadLine());
                    bool enc = false;

                    for (int i = 0; i < 5; i++)
                    {
                        if (codigo[i] == c)
                        {
                            Console.WriteLine("Producto: " + nombre[i]);
                            Console.WriteLine (" Cant: " + cantidad[i] );
;                           Console.WriteLine  (" Precio: " + precio[i]);
                            enc = true;
                        }
                    }
                    Console.WriteLine();

                    if (!enc) Console.WriteLine("Producto no encontrado");
                    Console.ReadKey();
                }
                else if (op == 3)
                {
                    Console.WriteLine("Código: ");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nueva cantidad: ");
                    int cant = int.Parse(Console.ReadLine());
                    Console.ReadKey();

                    for (int i = 0; i < 5; i++)
                    {
                        if (codigo[i] == c)
                        {
                            cantidad[i] = cant;
                            Console.WriteLine("CANTIDAD ACTuALIZADA");
                            Console.ReadKey();
                        }
                    }
                }
                else if (op == 4)
                {
                    double total = 0;
                    for (int i = 0; i < 5; i++)
                        total += cantidad[i] * precio[i];

                    Console.WriteLine();    
                    Console.WriteLine("Valor total inventario: " + total.ToString("F2"));
                    Console.ReadKey();
                }

            } while (op != 0);
        }
        
    }
}