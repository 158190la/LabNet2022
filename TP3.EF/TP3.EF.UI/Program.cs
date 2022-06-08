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
            ReadAndWrite.Menu();
            try
            {
               opcion = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Opcion Invalida vuelva a Intentar");
            }

            while (opcion != 6)
            {
                switch (opcion)
                {
                    case 1: 
                        try
                        {
                            ReadAndWrite.AddShippers();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Alguno de los datos ingresados no corresponde con lo solicitado");
                        }
                        break;

                    case 2: 
                        try
                        {
                            ReadAndWrite.UpdateShippers();
                        }
                        catch
                        {
                            Console.WriteLine("Dato mal ingresado o ID inexistente Intente nuevamente por favor");
                        }
                        break; 

                    case 3:
                        try
                        {
                            ReadAndWrite.DeleteShippers();
                        }
                        catch
                        {
                            Console.WriteLine("El ID ingresado no existe intente con otro por favor");
                        }
                        break;

                    case 4:
                        ShippersLogic.Show();
                        break;
                    case 5:
                        CategoriesLogic.Show();
                        break;
                    default:
                        Console.WriteLine("Opcion no disponible, intente ingresar alguna de las mencionadas anteriormente");
                        break;

                }
                ReadAndWrite.Menu2();
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
