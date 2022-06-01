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
    }
}
