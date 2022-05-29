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
            Console.WriteLine("Para comenzar a Ingresar los pasajeros en los taxis presiona una tecla");
            Console.ReadKey();
            int[] pasajerosTaxi = new int[5];
            for (int i = 1; i < 6; i++)
            {
                
                try
                {
                    Console.WriteLine($"Ingrese cantidad de pasajeros en taxi N° {i}");
                    pasajerosTaxi[i - 1] = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("El valor ingresado no es un numero intente nuevamente");
                    pasajerosTaxi[i - 1] = int.Parse(Console.ReadLine());
                }
                
            }
            Console.WriteLine("Hemos finalizado con la carga de pasajeros en la categoria Taxis");
            Console.WriteLine("Para comenzar a Ingresar los pasajeros en los Omnibus presiona Enter");
            Console.ReadKey();
            int[] pasajerosOmnibus = new int[5];
            for (int i = 1; i < 6; i++)
            {
                
                try
                {
                    Console.WriteLine($"Ingrese cantidad de pasajeros en Omnibus N° {i}");
                    pasajerosOmnibus[i - 1] = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("El valor ingresado no es un numero intente nuevamente");
                    pasajerosOmnibus[i - 1] = int.Parse(Console.ReadLine());
                    
                }
            }
            Console.WriteLine("Hemos finalizado con la carga de pasajeros en la categoria Omnibus");
            Console.WriteLine("Si queres ver el resumen de tu carga de datos presiona una tecla");
            Console.ReadKey();
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
                Console.WriteLine("El taxi N°{0} lleva {1} pasajero/s", f,var.Pasajeros);
                
                
            }

            List<Omnibus> pasajerosOmnibuss = new List<Omnibus>
            {
                new Omnibus(pasajerosOmnibus[0]),
                new Omnibus(pasajerosOmnibus[1]),
                new Omnibus(pasajerosOmnibus[2]),
                new Omnibus(pasajerosOmnibus[3]),
                new Omnibus(pasajerosOmnibus[4]),

            };
            Console.WriteLine("------------------------------------------------------------------------------");
            int d = 0;
            foreach (Omnibus var in pasajerosOmnibuss)
            {   
               
                d++;
                Console.WriteLine("El Omnibus N°{0} lleva {1} pasajero/s", d, var.Pasajeros);

            }
            Console.ReadLine();
        }
    }
}
