using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Program
    {


        static void Main(string[] args)
        {

            /*
            int divisor = 0;
            int dividendo = 0;
            try
            {
                Console.WriteLine("Ingrese el divisor");
                divisor = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el dividendo");
                dividendo = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Seguro Ingreso una letra o no ingreso nada");
                
            }
            div0 resultado = new div0(divisor, dividendo);

            try
            {
                Console.WriteLine(resultado.Dividir());
                
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Solo Chuck Norris divide por 0");
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.ToString());
                
            }
            finally 
            {
                Console.WriteLine("operacion finalizada");
            }
            ejercicio 3
            try
            {
                Logic logic = new Logic();
                Console.WriteLine(logic.Division(10,0));
            }
            catch (Exception)
            {

                throw;
            }
            Console.ReadKey();
            */ //ejercicio 4
            try
            {
                Logic logic = new Logic();
                Console.WriteLine(logic.Division(10, 0));
            }
            catch (Excepcionpersonalizada message)
            {

                throw message;
            }
            Console.ReadKey();

        }

    }
}
