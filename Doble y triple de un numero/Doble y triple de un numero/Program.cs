using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doble_y_triple_de_un_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int doble = 2;
            int triple = 3;
            int multi1 = 0;
            int multi2 = 0;

            Console.WriteLine("Ingresa un dumero entero");
            num = int.Parse(Console.ReadLine());

            multi1  = num * doble;
            Console.WriteLine($"El numero es {num} y su doble es {multi1}");

            multi2 = num * triple;
            Console.WriteLine($"El numero es {num} y su triple es {multi2}");




            Console.ReadKey();
        }
    }
}
