/*5. Pida un monto y determine la cantidad mínima de monedas de circulación nacional (RD$ 1– RD$ 2,000) a devolver (Simulador de cajero).*/

using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Otra;

            do
            {
                Console.Clear();
                double Monto = 0; int CM2000 = 0, CM1000 = 0, CM500 = 0, CM200 = 0, CM100 = 0, CM50 = 0, CM25 = 0, CM10 = 0, CM5 = 0, CM1 = 0;

                Console.Write("Ingrese el monto: ");

                try
                {
                    Monto = Convert.ToDouble(Console.ReadLine());
                }

                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nIngrese un monto, nada de letras o separar el monto con comas");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                while (2000 <= Monto) { CM2000 += 1; Monto -= 2000; }

                while (1000 <= Monto) { CM1000 += 1; Monto -= 1000; }

                while (500 <= Monto) { CM500 += 1; Monto -= 500; }

                while (200 <= Monto) { CM200 += 1; Monto -= 200; }

                while (100 <= Monto) { CM100 += 1; Monto -= 100; }

                while (50 <= Monto) { CM50 += 1; Monto -= 50; }

                while (25 <= Monto) { CM25 += 1; Monto -= 25; }

                while (10 <= Monto) { CM10 += 1; Monto -= 10; }

                while (5 <= Monto) { CM5 += 1; Monto -= 5; }

                while (1 <= Monto) { CM1 += 1; Monto -= 1; }

                if (CM2000 > 0) { Console.WriteLine("\n(" + CM2000 + ") $2000"); }

                if (CM1000 > 0) { Console.WriteLine("\n(" + CM1000 + ") $1000"); }

                if (CM500 > 0) { Console.WriteLine("\n(" + CM500 + ") $500"); }

                if (CM200 > 0) { Console.WriteLine("\n(" + CM200 + ") $200"); }

                if (CM100 > 0) { Console.WriteLine("\n(" + CM100 + ") $100"); }

                if (CM50 > 0) { Console.WriteLine("\n(" + CM50 + ") $50"); }

                if (CM25 > 0) { Console.WriteLine("\n(" + CM25 + ") $25"); }

                if (CM10 > 0) { Console.WriteLine("\n(" + CM10 + ") $10"); }

                if (CM5 > 0) { Console.WriteLine("\n(" + CM5 + ") $5"); }

                if (CM1 > 0) { Console.WriteLine("\n(" + CM1 + ") $1"); }

                Console.Write("\n¿Desea ingresar otro monto? ");
                Otra = Console.ReadLine();

            } while (Otra != "No" && Otra != "no");
        }
    }
}
