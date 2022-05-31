using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class div0
    {
        public int Divisor { get; set; }
        public int Dividendo { get; set; }

        public div0(int divisor, int dividendo)
        {
            this.Divisor = divisor;
            this.Dividendo = dividendo;
        }

        public int Dividir()
        {
            return Dividendo / Divisor;
        }

    }
}
