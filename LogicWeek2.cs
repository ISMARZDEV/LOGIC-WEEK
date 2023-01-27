/*2. Pida un número y determine si es par o impar*/

using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num;
            Console.Write("Digite un número: ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"El numero {num} es par");
            }
            else
            {
                Console.WriteLine($"El numero {num} es impar");
            }
        }
    }
}
