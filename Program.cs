using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //int y;

            Console.WriteLine("Introduzca un numero: ");
            int x = Convert.ToInt32(Console.ReadLine());  //convertir tipo string a entero

            Console.WriteLine("\nIntroduzca otro numero: ");
            int y = Convert.ToInt32(Console.ReadLine());  //convertir tipo string a entero

            int suma = x + y;

            Console.WriteLine("\n");
            Console.WriteLine("\nLa suma de ambos numeros es: " + suma);

            Console.ReadKey();
        }
    }
}
