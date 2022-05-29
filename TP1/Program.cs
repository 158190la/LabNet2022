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
            int[] pasajerosTaxi = new int[5];
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"Ingrese cantidad de pasajeros en taxi N° {i}");
                pasajerosTaxi[i-1] = int.Parse(Console.ReadLine());
                             
            }
            int[] pasajerosOmnibus = new int[5];
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"Ingrese cantidad de pasajeros en Omnibus N° {i}");
                pasajerosOmnibus[i - 1] = int.Parse(Console.ReadLine());

            }

            List<Taxi> pasajerosTaxis = new List<Taxi>
            {
                new Taxi(pasajerosTaxi[0]),
                new Taxi(pasajerosTaxi[1]),
                new Taxi(pasajerosTaxi[2]),
                new Taxi(pasajerosTaxi[3]),
                new Taxi(pasajerosTaxi[4]),

            };
            int f = 0;
            foreach (Taxi var in pasajerosTaxis)
            {
                
                f++;
                Console.WriteLine("El taxi N°{0} lleva {1} pasajeros", f,var.Pasajeros);
                
                
            }

            List<Omnibus> pasajerosOmnibuss = new List<Omnibus>
            {
                new Omnibus(pasajerosOmnibus[0]),
                new Omnibus(pasajerosOmnibus[1]),
                new Omnibus(pasajerosOmnibus[2]),
                new Omnibus(pasajerosOmnibus[3]),
                new Omnibus(pasajerosOmnibus[4]),

            };
            int d = 0;
            foreach (Omnibus var in pasajerosOmnibuss)
            {   
               
                d++;
                Console.WriteLine("El Omnibus N°{0} lleva {1} pasajeros", d, var.Pasajeros);

            }
            Console.ReadLine();
        }
    }
}
