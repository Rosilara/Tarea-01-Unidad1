using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_01.Ejercicios
{
    public class Ejercicio01
    {
 public static void Ejecutar()
        {
            Console.Clear();

            
            Console.WriteLine("Ejercicio 01: CALCULADORA IMC");
            Console.WriteLine();
            Console.WriteLine("Peso kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Altura m: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            string categoria = imc < 18.5 ? "Bajo peso" : 
            imc < 25 ? "Normal" :
            imc < 30 ? "Sobrepeso" : "Obesidad";

            Console.WriteLine("IMC=" + imc.ToString("F2") ); 
            Console.WriteLine("Condicion: " + categoria);

            // se usa .ToString pra pasar un numero a texto y F2 para las cifras despues del punto
        }
    }
}