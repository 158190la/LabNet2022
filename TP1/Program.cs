using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Taxi> Taxis = new List<Taxi>();
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("Ingrese Pasajeros Taxi{0}", i);
                int cantidadPasajeros = Console.Read();
                new Taxi(cantidadPasajeros);
            }
            foreach (Taxi taxi in Taxis)
            {
                Console.WriteLine(taxi.cantidadPasajeros);
            }
            Console.ReadKey();

        }
    }
}
