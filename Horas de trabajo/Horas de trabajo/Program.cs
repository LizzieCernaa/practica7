using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horas_de_trabajo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h =0;
            int v = 0;
            int S=0;    
            string  nombre;
            Console.WriteLine("Ingresa el nombre del trabajador");
            nombre= Console.ReadLine();
            Console.WriteLine("Ingrese las horas trabajadas");
            h= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor por hora");
            v= int.Parse(Console.ReadLine());
            S = h * v; 

            Console.WriteLine($"El salario del trabajador {S}");
            
            
            Console.ReadKey();
        }
    }
}
