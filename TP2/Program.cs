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
            Div0 resultado = new Div0(divisor, dividendo);

            try
            {
                Console.WriteLine(resultado.Dividir());

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Solo Chuck Norris divide por 0");
            }
            catch (Exception ex)
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
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
                Console.WriteLine(e.GetType().ToString());
            }
            Console.ReadKey();
             ejercicio 4
            */
            int divisor = 0;
            int dividendo = 0;
            
            try
            {
                Console.WriteLine("Ingrese el divisor");
                divisor = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el dividendo");
                dividendo = int.Parse(Console.ReadLine());
                Logic logic = new Logic();
                logic.Division(divisor,dividendo);
                ValidateNewExceptionPersonalizated(divisor,dividendo);
            }
            catch (Excepcionpersonalizada ex)
            {

                Console.WriteLine(ex.ToString() + ex.Message);
                Console.WriteLine(ex.GetType().ToString());

            }

            Console.ReadKey();

        }

        private static void ValidateNewExceptionPersonalizated(int divisor, int dividendo) {
            if (divisor == 0)
            {
                throw new Excepcionpersonalizada();
            }
        }

    }
}
