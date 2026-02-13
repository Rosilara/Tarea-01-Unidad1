using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System;

namespace Tarea_01
{
    public class Ejercicio22
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Calculadora con menú");
            Console.WriteLine();

            double resultado = 0;
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("\nResultado actual: " + resultado);
                Console.WriteLine();
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raíz cuadrada");
                Console.WriteLine("7. Porcentaje");
                Console.WriteLine("0. Salir");
                Console.WriteLine();
                Console.Write("OPCION: ");

                opcion = int.Parse(Console.ReadLine());

                if (opcion == 0)
                    break;

                if (opcion == 6)
                {
                    if (resultado >= 0)
                        resultado = Math.Sqrt(resultado);
                    else
                        Console.WriteLine("No se puede calcular raíz de número negativo.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("INGRESE NUMERO: ");
                    double numero = double.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            resultado += numero;
                            break;
                        case 2:
                            resultado -= numero;
                            break;
                        case 3:
                            resultado *= numero;
                            break;
                        case 4:
                            if (numero != 0)
                                resultado /= numero;
                            else
                                Console.WriteLine("No se puede dividir entre 0.");
                            break;
                        case 5:
                            resultado = Math.Pow(resultado, numero);
                            break;
                        case 7:
                            resultado = resultado * numero / 100;
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }

            } while (true);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
