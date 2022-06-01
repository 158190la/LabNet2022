using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Div0
    {
        public int Divisor { get; set; }
        public int Dividendo { get; set; }
             

        public static int Dividir(int divisor,int dividendo)
        {
            int divisor3 = divisor;
            int dividendo3 = dividendo;
            return dividendo3 / divisor3;
        }

    }
}
