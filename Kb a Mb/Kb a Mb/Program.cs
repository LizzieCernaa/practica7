using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kb_a_Mb
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string numero = string.Empty;
            double kb = 1024;
            double resultado = 0;

            Console.WriteLine("Ingresa una cantidad en Kb");
            numero = Console.ReadLine();

            resultado = double.Parse(numero) / kb;    

            Console.WriteLine($"{numero}Kb son {resultado} Mb");

            Console.ReadKey();
        }
    }
}
