using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intercambio_de_valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double temporal = 0;

            Console.WriteLine("Ingresa el primer numero");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el seugundo numero");
            num2 = double.Parse(Console.ReadLine());

            temporal = num1;
            num1 = num2;
            num2 = temporal;

            Console.WriteLine($"El primero valor es {num1} cuando el segundo numero es {num2}");


          Console.ReadKey();
        }
    }
}
