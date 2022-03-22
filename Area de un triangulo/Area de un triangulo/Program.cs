using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_un_triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baSe = 0;
            double alTura = 0;

            Console.WriteLine("Ingresa Altura");
            alTura = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa Base");
            baSe = int.Parse(Console.ReadLine());

            double resultado = (baSe * alTura) / 2;
            Console.WriteLine($"El area del triangudo es {resultado}");


            Console.ReadKey();
        }
    }
}
