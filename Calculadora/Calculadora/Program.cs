using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1= 0;
            int num2= 0;
            int suma = 0;
            int res = 0;
            int multi = 0;
            int div = 0;

            Console.WriteLine("Ingresa el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            suma = num1 + num2;
            Console.WriteLine($"La suma de {num1} y {num2} es : {suma}");

            res= num1 -  num2;
            Console.WriteLine($"La resta de {num1} y {num2} es : {res}");

            multi = num1 *  num2;
            Console.WriteLine($"La multiplicacion de {num1} y {num2} es : {multi}");

            div = num1 / num2;
            Console.WriteLine($"La division de {num1} y {num2} es : {div}");

            Console.ReadKey();
        }
    }
}

