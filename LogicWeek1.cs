/*1. Muestre la secuencia de Fibonacci hasta la cantidad de elementos indicados indicada por el usuario por el teclado.*/

using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 1, c = 1;
            int fin, cont = 1;
            Console.Write("Digitar la cantidad deseada en la serie fibonacci: ");
            fin = Convert.ToInt32(Console.ReadLine());
            for (cont = 1; cont <= fin; cont++)
            {
                Console.WriteLine($"Secuencia {cont}: {a}");
                a = b;
                b = c;
                c = a + b;
            }
        }
    }
}
