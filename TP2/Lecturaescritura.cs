using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Lecturaescritura
    {
        public static Tuple<int, int> IngresoDivisor()
        {
            int divisor1 = 0;
            int dividendo1 = 0;
            Console.WriteLine("Ingrese el dividendo");
            dividendo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el divisor");
            divisor1 = int.Parse(Console.ReadLine());
            return Tuple.Create(divisor1, dividendo1);
        }

        public static void Menu()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Practica - Ingrese su opcion y presione enter para continuar");
            Console.WriteLine("1-Ejercicio 1");
            Console.WriteLine("2-Ejercicio 2");
            Console.WriteLine("3-Ejercicio 3");
            Console.WriteLine("4-Ejercicio 4");
            Console.WriteLine("5-Salir");
            Console.WriteLine("Ingrese su opcion");
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
