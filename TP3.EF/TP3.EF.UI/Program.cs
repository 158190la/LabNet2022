using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.EF.Entities;
using TP3.EF.Logic;

namespace TP3.EF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            RR.Menu();
            try
            {
               opcion = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Opcion Invalida vuelva a Intentar");
            }

            while (opcion != 5)
            {
                switch (opcion)
                {
                    case 1: //add new shipper
                        try
                        {
                            RR.AddShippers();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Alguno de los datos ingresados no corresponde con lo solicitado");
                        }

                        break;
                    case 2: //Update shipper
                        try
                        {
                            RR.UpdateShippers();
                        }
                        catch
                        {
                            Console.WriteLine("Dato Mal ingresado o ID inexistente Intente nuevamente por favor");
                        }
                        break; //Delete shipper
                    case 3:
                        try
                        {
                            RR.DeleteShippers();
                        }
                        catch
                        {
                            Console.WriteLine("El ID ingresado no existe intente con otro por favor");
                        }

                        break;

                    case 4: // Mostrar Tabla

                        ShippersLogic.Show();

                        break;


                }
                RR.Menu2();
                try
                {
                   opcion = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Opcion Invalida vuelva a Intentar");
                }

            }










        }

        




    }
}
