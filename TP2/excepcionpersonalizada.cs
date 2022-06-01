using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP2
{

    internal class Excepcionpersonalizada : Exception
    {
        public Excepcionpersonalizada() : base(String.Format("hola juan carlo"))
        {

        }

        public Excepcionpersonalizada(string name) { }

        public static void ExcepcionpersonalizadaValidacion(int divisor, int dividendo)
        {
            if (divisor == 0)
            {
                throw new Excepcionpersonalizada();
            }
        }

    }
}
