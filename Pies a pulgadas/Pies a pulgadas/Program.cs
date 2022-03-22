using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pies_a_pulgadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pie = 0;
            double pp = 0;
            double pulga = 12;
            double pc = 0;
            double cm = 2.54;
            double cmt = 0;
            double metro = 0.3048;

            Console.WriteLine("Ingresa el numero de pies");
            pie = int.Parse(Console.ReadLine());

            pp = pie * pulga;
            Console.WriteLine($"La conversion de {pie} pies a pulgadas es :{pp}");

            pc = pp * cm;
            Console.WriteLine($"La conversion de {pp} pies a centimetros es :{pc}");

            cmt = pc * metro;
            Console.WriteLine($"La conversion de {pc} pies a pulgadas es :{cmt}");


            Console.ReadKey();  
        }
    }
}
