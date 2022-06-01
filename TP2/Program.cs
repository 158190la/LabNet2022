using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TP2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Practica Excepciones");
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Ejercicio 3");
            Console.WriteLine("Ejercicio 4");
            Console.WriteLine("Salir");
            Console.WriteLine("Ingrese su opcion");
            int opcion = int.Parse(Console.ReadLine());
            while (opcion != 5)
            {
                switch (opcion)
                {

                    case 1:
                        int divisor1 = 0;
                        int dividendo1 = 0;
                        
                            Console.WriteLine("Ingrese el divisor");
                            divisor1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el dividendo");
                            dividendo1 = int.Parse(Console.ReadLine());
                        
                        Div0 resultado1 = new Div0(divisor1, dividendo1);

                        try
                        {
                            Console.WriteLine(resultado1.Dividir());
                        }
                       
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                        finally
                        {
                            Console.WriteLine("operacion finalizada");
                        }

                        break;
                    case 2:

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
                        break;

                    case 3: //ejercicio 3
                        {
                            try
                            {
                                Logic logic = new Logic();
                                Console.WriteLine(logic.Division(10, 0));
                            }
                            catch (Exception e)
                            {

                                Console.WriteLine(e.ToString());
                                Console.WriteLine(e.GetType().ToString());
                            }
                            
                        }
                        break;
                    // ejercicio 4
                    case 4:
                        {
                            

                            try
                            {
                                Console.WriteLine("Ingrese el divisor");
                                divisor = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el dividendo");
                                dividendo = int.Parse(Console.ReadLine());
                                Logic logic = new Logic();
                                logic.Division(divisor, dividendo);
                                Excepcionpersonalizada.ValidateNewExceptionPersonalizated(divisor,dividendo);
                            }
                            catch (Excepcionpersonalizada ex)
                            {
                                MessageBox.Show(ex.ToString());
                                                      
                            }
                        }
                        break;
                }
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Practica Excepciones");
                Console.WriteLine("Ejercicio 1");
                Console.WriteLine("Ejercicio 2");
                Console.WriteLine("Ejercicio 3");
                Console.WriteLine("Ejercicio 4");
                Console.WriteLine("Salir");
                Console.WriteLine("Ingrese su opcion");
                Console.WriteLine("------------------------------------");
                opcion = int.Parse(Console.ReadLine());

            }

        
        }

    }
}
