using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01
{
    public class Ejercicio20
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 20: Validación de contraseña");
            Console.WriteLine();

            bool valida = false;

            while (valida == false)
            {
                Console.Write("Ingrese contraseña: ");
                string pass = Console.ReadLine();

                bool mayuscula = false;
                bool minuscula = false;
                bool numero = false;
                bool especial = false;

                if (pass.Length >= 8)
                {
                    for (int i = 0; i < pass.Length; i++)
                    {
                        if (char.IsUpper(pass[i])) 
                        // IsUpper verifica que una letra sea mayuscula 
                        {
                            mayuscula = true;
                        }
                        else if (char.IsLower(pass[i]))
                        //IsLower para ver si hay letra minuscula
                        {
                            minuscula = true;
                        }
                        else if (char.IsDigit(pass[i]))
                        //IsDigit verifica si es un numero
                        {
                            numero = true;
                        }
                        else
                        {
                            especial = true;
                        }
                    }

                    if (mayuscula && minuscula && numero && especial)
                    {
                        Console.WriteLine();
                        Console.WriteLine("CONTRASENIA VALIDA");
                        valida = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("La contraseña no cumple con todos los requisitos");
                    }
                }
                else
                {
                    Console.WriteLine("La contrasenia ebe tener al menos 8 caracteres");
                }

                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
