/*3. Pida un número y determine e indique si dicho número es primo*/

using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite su numero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Determinar si el número es primo
            bool isPrime = true; // Asumir que el número es primo
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    // El número es divisible por i, por lo que no es primo
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine(num + " es un número primo.");
            }
            else
            {
                Console.WriteLine(num + " no es un número primo.");
            }
        }
    }
}
