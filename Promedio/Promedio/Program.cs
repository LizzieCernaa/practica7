using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 0;
            double B = 0;
            double C = 0;
           
            Console.WriteLine("Ingresa el primer valor");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo valor");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer valor");
            C = double.Parse(Console.ReadLine());

            double promedio = (A + B + C) / 3;
           // Para redondiar a dos decimales -- promedio = Math.Round(promedio,2);
            Console.WriteLine($"El promedio del {A}  {B}  {C} es {promedio}");


            Console.ReadKey();
        }
    }
}
