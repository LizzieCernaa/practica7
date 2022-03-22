using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leer_un_número_y_escriba_su_cuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;

            Console.WriteLine("Ingresa un numero");
            numero = double.Parse(Console.ReadLine());

            double resultado = Math.Pow(numero, 2);
            Console.WriteLine($"El numero {numero} levado al cuadrado es {resultado}");   

            Console.ReadKey();
        }
    }
}
