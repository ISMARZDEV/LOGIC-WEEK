/*4. Pida el Sueldo Bruto muestre las deducciones y el sueldo neto*/

using System;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sueldoBruto, AFP, SFS, sueldoNeto, deducciones;

            Console.Write("Digitar Sueldo Bruto: ");
            sueldoBruto = Convert.ToDouble(Console.ReadLine());

            SFS = sueldoBruto * 0.0304;
            AFP = sueldoBruto * 0.0287;
            deducciones = AFP + SFS;
            sueldoNeto = sueldoBruto - deducciones;

            Console.WriteLine($"Deducciones: ${deducciones}");
            Console.WriteLine($"Sueldo neto: ${sueldoNeto}");
        }
    }
}
