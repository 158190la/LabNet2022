using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
   
    internal class Excepcionpersonalizada : Exception
    {
        public Excepcionpersonalizada() { }
        
        public Excepcionpersonalizada(string name) : base(String.Format("hola juan carlo {0}", name)) { }
    }
}
