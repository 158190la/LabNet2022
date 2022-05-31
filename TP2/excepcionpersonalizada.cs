using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{

    internal class Excepcionpersonalizada : Exception
    {
        public Excepcionpersonalizada() : base() { }
        public Excepcionpersonalizada(string message) : base(message) { }
    }
}
